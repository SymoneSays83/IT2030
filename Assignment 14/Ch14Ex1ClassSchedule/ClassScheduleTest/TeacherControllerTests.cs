using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using ClassSchedule.Controllers;

namespace ClassScheduleTest
{
    public class TeacherControllerTests
    {
        [Fact]
        public void IndexActionMethod_ReturnsAView()
        {
            var rep = new Mock<IRepository<Teacher>>();
            var controller = new TeacherController(rep.Object);

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
