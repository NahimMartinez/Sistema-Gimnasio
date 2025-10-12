using Business.Exceptions;
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient; 

namespace Business
{
    public class InventoryCategoryService
    {
        private readonly InventoryCategoryRepository repository;

        public InventoryCategoryService()
        {
            // El servicio crea su propia instancia del repositorio
            repository = new InventoryCategoryRepository();
        }

        public List<InventoryCategory> GetAllCategories()
        {
            return repository.GetAllCategories();
        }

        public void CreateCategory(InventoryCategory category)
        {
            // 1. Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(category.Nombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");
            }

            // 2. Llamar al repositorio para insertar en la BD
            try
            {
                repository.InsertCategory(category);
            }
            catch (SqlException ex)
            {
                // El error 2627 es para violaciones de Unique Constraint (nombre duplicado)
                if (ex.Number == 2627)
                {
                    // Lanza una excepción personalizada y más amigable
                    throw new DuplicateFieldException("Error al crear categoría", "Nombre");
                }
                // Si es otro error de SQL, lo relanzamos
                throw;
            }
        }
    }
}