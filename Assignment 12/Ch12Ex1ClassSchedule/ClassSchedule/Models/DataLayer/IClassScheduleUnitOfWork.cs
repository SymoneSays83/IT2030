using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassSchedule.Models
{
    interface IClassScheduleUnitOfWork
    {
        public Repository<Class> Classes { get; }
        public Repository<Teacher> Teachers { get; }
        public Repository<Day> Days { get; }

        public void Save();
    }
}
