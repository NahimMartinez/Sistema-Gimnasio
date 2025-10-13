using Business.Exceptions;
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Business
{
    public class InventoryService
    {
        private readonly InventoryRepository repository;

        public InventoryService()
        {
            repository = new InventoryRepository();
        }

        public void CreateInventory(Inventory inventario)
        {
            // 1. Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(inventario.Nombre))
            {
                throw new ArgumentException("El nombre del artículo no puede estar vacío.");
            }
            // 2. Validar que la cantidad no sea negativa
            if (inventario.Cantidad < 0)
            {
                throw new ArgumentException("La cantidad no puede ser un número negativo.");
            }
            // 3. Validar que se haya seleccionado una categoría
            if (inventario.IdInventarioCategoria <= 0)
            {
                throw new ArgumentException("Debe seleccionar una categoría para el artículo.");
            }

            try
            {
                // Por defecto, un nuevo artículo siempre estará activo (Estado = true)
                inventario.Estado = true;
                repository.InsertInventory(inventario);
            }
            catch (SqlException ex)
            {
                // Capturamos el error de SQL por si el nombre ya existe (Unique Constraint)
                if (ex.Number == 2627)
                {
                    throw new DuplicateFieldException("Error al crear el artículo", "Nombre");
                }
                throw;
            }
        }

        public List<dynamic> GetAllInventoriesForView()
        {
            return repository.GetAllInventoriesForView();
        }

        public Inventory GetInventoryById(int id)
        {
            return repository.GetById(id);
        }

        // Guarda los cambios de un artículo
        public void UpdateInventory(Inventory inventario)
        {
            // Reutilizamos las mismas validaciones que al crear
            if (string.IsNullOrWhiteSpace(inventario.Nombre))
            {
                throw new ArgumentException("El nombre del artículo no puede estar vacío.");
            }
            if (inventario.Cantidad < 0)
            {
                throw new ArgumentException("La cantidad no puede ser un número negativo.");
            }
            if (inventario.IdInventarioCategoria <= 0)
            {
                throw new ArgumentException("Debe seleccionar una categoría para el artículo.");
            }

            try
            {
                repository.Update(inventario);
            }
            catch (SqlException ex)
            {
                // Manejamos el error de nombre duplicado
                if (ex.Number == 2627)
                {
                    throw new DuplicateFieldException("Ya existe otro artículo con ese nombre.", "Nombre");
                }
                throw;
            }
        }

        public void ChangeInventoryStatus(int id)
        {
            repository.ChangeStatus(id);
        }
    }
}