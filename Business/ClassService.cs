using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Business
{
    public class ClassService
    {
        private readonly ClassRepository classRepo = new ClassRepository();

        public List<dynamic> GetAllClassesForView()
        {
            try
            {
                return classRepo.GetAllClassesForView();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la vista de clases.", ex);
            }
        }

        public void CreateClass(Class newClass)
        {
            // Validaciones de negocio
            if (newClass.HoraDesde >= newClass.HoraHasta)
            {
                throw new Exception("La hora de inicio no puede ser mayor o igual a la hora de fin.");
            }
            if (newClass.Dias == null || !newClass.Dias.Any())
            {
                throw new Exception("Debe seleccionar al menos un día para la clase.");
            }

            using (var connection = new SqlConnection(Data.Connection.chain))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Llama al repositorio, pasándole la conexión y la transacción
                        classRepo.InsertClass(newClass, connection, transaction);

                        // Si todo va bien, confirma la transacción
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Si algo falla, revierte todos los cambios
                        transaction.Rollback();
                        throw; // Vuelve a lanzar la excepción para que la UI la reciba
                    }
                }
            }
        }

        public void ChangeClassStatus(int classId){
            try { 
                classRepo.ChangeStatus(classId);
            }
            catch (Exception ex) {
                throw new Exception("Error al cambiar el estado de la clase.", ex);
            }
        }

        public Class GetClassById(int idClase)
        {
            return classRepo.GetById(idClase);
        }

        public void UpdateClass(Class clase)
        {
            // Reutilizo las validaciones de CreateClass
            if (clase.HoraDesde >= clase.HoraHasta)
            {
                throw new Exception("La hora de inicio no puede ser mayor o igual a la hora de fin.");
            }
            if (clase.Dias == null || !clase.Dias.Any())
            {
                throw new Exception("Debe seleccionar al menos un día para la clase.");
            }

            using (var connection = new SqlConnection(Data.Connection.chain))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        classRepo.Update(clase, connection, transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al actualizar la clase.", ex);
                    }
                }
            }
        }

        public int GetTotalActiveClasses() {
            return classRepo.GetTotalActiveClass();
        }
    }
}