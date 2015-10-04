using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormBuddyWeb;
using FormBuddyWeb.Controllers;
using Moq;
using FormBuddyWeb.Interfaces;
using FormBuddyWeb.Tests.BusinessLogic_Repository;

namespace FormBuddyWeb.Tests.Controllers
{
    [TestClass]
    public class UT_HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            Mock<BLR_MiscAgent> miscMock = new Mock<BLR_MiscAgent>();
            Mock<IUserRepository> userMock = new Mock<IUserRepository>();
            HomeController controller = new HomeController(userMock.Object, miscMock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewName, "Index.cshtml");
        }

        [TestMethod]
        public void Index_ValidateFailed()
        {
        }

        [TestMethod]
        public void Index_ValidateSuccess()
        {
            //Arrange
            var registerModel = new RegisterModel
            {
                Email = "validEmailAddress@domain.com",
                Password = "password"
            };

            //Assign
            var result = _controller.Register(registerModel) as RedirectToRouteResult;

            //Assert
            result.RouteValues["Action"].ShouldBeEqual("Index");
        }
    }
}
