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
    public class MembershipService
    {
        private readonly MembershipRepository membershipRepository = new MembershipRepository();
        private readonly PaymentRepository PaymentRepository = new PaymentRepository();
        private readonly ClassRepository classRepository = new ClassRepository();

        public List<MembershipType> GetMembershipType()
        {
            return membershipRepository.GetMembershipType();
        }
        public bool InactiveMembershipService(int socioId)
        {
            return membershipRepository.InactiveMembership(socioId);
        }
        public (int membresiaId, int pagoId) Register(
        int socioId,
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


                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        // 1. Membresía
                        var membership = new Membership
                        {
                            IdSocio = socioId,
                            IdUsuario = usuarioId,
                            IdTipo = tipoMembresiaId,
                            FechaInicio = fechaInicio,
                            FechaFin = fechaInicio.AddDays(duracionDias),
                            Estado = true,
                            Clases = clasesIds.Select(id => new Class { IdClase = id }).ToList()
                        };

                        int membresiaId = membershipRepository.Insert(membership, cn, tx); // usa OUTPUT INSERTED.id_membresia

                        foreach (var id in clasesIds)
                        {
                            int affected = classRepository.UpdateCapacity(id, false, cn, tx);
                            if (affected == 0)
                                throw new InvalidOperationException($"La clase {id} no tiene cupo disponible.");
                        }
                        // 2. Pago y detalle
                        var payment = new Payment
                        {
                            IdSocio = socioId,
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

                        int pagoId = PaymentRepository.Insert(payment, cn, tx);

                        tx.Commit();
                        return (membresiaId, pagoId);
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        public void synchronizeMembership()
        { 
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        
                        List<int> classId = membershipRepository.DesactiveMembership(cn, tx);

                        
                        if (!classId.Any())
                        {
                            tx.Commit();
                            return;
                        }

                        
                        foreach (var idClase in classId)
                        {
                            
                            classRepository.UpdateCapacity(idClase, true, cn, tx);
                        }

                        
                        tx.Commit();
                    }
                    catch
                    {
                        
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
