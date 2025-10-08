using Data;
using System.Collections.Generic;
using System;

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
    }
}