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
        private readonly SupplierRepository supplierRepo = new SupplierRepository();
        public int SupplierCreate(Supplier pSupplier)
        {

            try
            {
                return supplierRepo.InsertSupplier(pSupplier); // devuelve id_proveedor
            }
            catch (Data.Exceptions.DuplicateKeyException ex)
            {
                // Reenvía a la capa de negocio conservando la causa
                throw new Business.Exceptions.DuplicateFieldException(ex.Field.ToString(), ex.Message);
            }
        }

        public void SupplierUpdate(Supplier pSupplier)
        {
            try
            {
                supplierRepo.UpdateSupplier(pSupplier);
            }
            catch (Data.Exceptions.DuplicateKeyException ex)
            {
                // Reenvía a la capa de negocio conservando la causa
                throw new Exception("Error al actualizar el proveedor", ex);
            }
        }
        public List<Supplier> GetAllSuppliers()
        {
            return supplierRepo.GetAllSuppliers();
        }

        public List<Supplier> GetAllService()
        {
            return supplierRepo.GetAll();
        }
    }
}
