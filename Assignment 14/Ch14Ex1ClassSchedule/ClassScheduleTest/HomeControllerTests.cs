using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using ClassSchedule.Controllers;
using Microsoft.AspNetCore.Http;

namespace ClassScheduleTest
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
            var unit = new Mock<IClassScheduleUnitOfWork>();
            var classes = new Mock<IRepository<Class>>();
            var days = new Mock<IRepository<Day>>();

            unit.Setup(r => r.Classes).Returns(classes.Object);
            unit.Setup(r => r.Days).Returns(days.Object);

            var http = new Mock<IHttpContextAccessor>();

            var controller = new HomeController(unit.Object, http.Object);

            var result = controller.Index(0);

            Assert.IsType<ViewResult>(result);
        }
    }
}
