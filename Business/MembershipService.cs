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

        public List<MembershipType> GetMembershipType()
        {
            return membershipRepository.GetMembershipType();
        }

        public (int membresiaId, int pagoId) Register(
        int socioId,
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
                            IdTipo = tipoMembresiaId,
                            FechaInicio = fechaInicio,
                            FechaFin = fechaInicio.AddDays(duracionDias),
                            Estado = true,
                            Clases = clasesIds.Select(id => new Class { IdClase = id }).ToList()
                        };

                        int membresiaId = membershipRepository.Insert(membership, cn, tx); // usa OUTPUT INSERTED.id_membresia

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
    }
}
