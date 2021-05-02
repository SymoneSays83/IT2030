using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;

namespace ClassSchedule.Components
{
    public class DayFilter : ViewComponent
    {
        private IRepository<Day> days { get; set; }
        public DayFilter(IRepository<Day> rep) => days = rep;

        public IViewComponentResult Invoke()
        {
            var daysData = days.List(new QueryOptions<Day>
            {
                OrderBy = d => d.DayId
            });
            return View(daysData);
        }
    }
}
