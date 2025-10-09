using Data;
using Entities;
using System.Collections.Generic;

namespace Business
{
    public class ActivityService
    {
        private readonly ActivityRepository repo = new ActivityRepository();

        public List<Activity> GetAllActividades()
        {
            return repo.GetAll();
        }
    }
}