using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data.SqlClient;
using Entities;

namespace Business
{
    public class SupplierService
    {
        private readonly SupplierRepository supplierRepo;
        public int SupplierCreate(Supplier pSupplier)
        {

            try
            {
                return supplierRepo.InsertSupplier(pSupplier); // devuelve id_proveedor
            }
            catch (Data.Exceptions.DuplicateKeyException dex)
            {
                // Reenvía a la capa de negocio conservando la causa
                throw new Business.Exceptions.DuplicateFieldException(dex.Field.ToString(), dex.Message);
            }
        }
    }
}
