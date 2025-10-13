using Business.Exceptions; 
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Business
{
    public class ActivityService
    {
        private readonly ActivityRepository repository;

        public ActivityService()
        {
            repository = new ActivityRepository();
        }

        public List<Activity> GetActivities()
        {
            return repository.GetAll();
        }

        // --- MÉTODO NUEVO PARA CREAR LA ACTIVIDAD ---
        public void CreateActivity(Activity activity)
        {
            // 1. Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(activity.Nombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");
            }

            // 2. Llamar al repositorio para insertar en la BD
            try
            {
                repository.Insert(activity);
            }
            catch (SqlException ex)
            {
                // El error 2627 es para violaciones de Unique Constraint (nombre duplicado)
                if (ex.Number == 2627)
                {
                    throw new DuplicateFieldException("Error al crear la categoría", "Nombre");
                }
                throw;
            }
        }
    }
}