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

        public List<Partner> GetAllPartnerView()
        {
            return partners.GetAllPartner();
        }
    }
}
