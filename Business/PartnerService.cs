using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PartnerService
    {
        private readonly PersonRepository persons = new PersonRepository();
        private readonly PartnerRepository partners = new PartnerRepository();

        private readonly PaymentRepository paymentRepository = new PaymentRepository();
        private readonly MembershipRepository membershipRepository = new MembershipRepository();
        private readonly ClassRepository classRepository = new ClassRepository();   

        public int PartnerCreate(Person pPerson, Partner pPartner)
        {
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {

                        var idPersona = persons.Insert(pPerson, cn, tr);
                        partners.InsertPartner(idPersona, pPartner, cn, tr);

                        tr.Commit();
                        return idPersona;
                    }
                    catch (Data.Exceptions.DuplicateKeyException dex)
                    {
                        tr.Rollback();
                        throw new Business.Exceptions.DuplicateFieldException(dex.Field.ToString(), dex.Message);
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("No se pudo crear el socio", ex);
                    }
                }
            }
        }

        public void UpdatePartner(Partner pPartner)
        {
            try
            {
                partners.UpdatePartner(pPartner);
                persons.Update(pPartner);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el socio", ex);
            }
        }

        public List<PartnerDataGrid> GetAllPartnerView()
        {
            return partners.GetPartnerView();
        }

        public int GetTotalActivePartnersService()
        {
            return partners.GetTotalActivePartners();
        }
        public List<dynamic> GetRecentPartnersService()
        {
            return partners.GetRecentPartners();
        }

        public List<dynamic> GetPartnerCountByMembershipTypeService()
        {
            return partners.GetPartnerCountByMembershipType();
        }

        public (int personaId, int socioId, int membresiaId, int pagoId) RegisterFull(
        Person persona,
        Partner socio,
        int usuarioId,
        int tipoMembresiaId,
        int tipoPagoId,
        IEnumerable<int> clasesIds,
        DateTime fechaInicio,
        int duracionDias,
        decimal total)
        {
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        // 1. Crear persona y socio
                        int idPersona = persons.Insert(persona, cn, tr);
                        int idSocio = partners.InsertPartner(idPersona, socio, cn, tr);

                        // 2. Crear membresía
                        var membership = new Membership
                        {
                            IdSocio = idSocio,
                            IdUsuario = usuarioId,
                            IdTipo = tipoMembresiaId,
                            FechaInicio = fechaInicio,
                            FechaFin = fechaInicio.AddDays(duracionDias),
                            Estado = true,
                            Clases = clasesIds.Select(id => new Class { IdClase = id }).ToList()
                        };
                        int membresiaId = membershipRepository.Insert(membership, cn, tr);

                        // 3. Actualizar cupo de clases
                        foreach (var id in clasesIds)
                        {
                            int affected = classRepository.UpdateCapacity(id, false, cn, tr);
                            if (affected == 0)
                                throw new InvalidOperationException($"La clase {id} no tiene cupo disponible.");
                        }

                        // 4. Crear pago y detalle
                        var payment = new Payment
                        {
                            IdSocio = idSocio,
                            IdTipoPago = tipoPagoId,
                            Fecha = DateTime.Now,
                            Total = total,
                            Estado = true,
                            Detalles = clasesIds.Select(id => new DetailedPayment
                            {
                                IdMembresia = membresiaId,
                                IdClase = id
                            }).ToList()
                        };
                        int pagoId = paymentRepository.Insert(payment, cn, tr);

                        tr.Commit();
                        return (idPersona, idSocio, membresiaId, pagoId);
                    }
                    catch (Data.Exceptions.DuplicateKeyException dex)
                    {
                        tr.Rollback();
                        throw new Business.Exceptions.DuplicateFieldException(dex.Field.ToString(), dex.Message);
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("No se pudo completar el registro total del socio", ex);
                    }
                }
            }
        }
    }
}
