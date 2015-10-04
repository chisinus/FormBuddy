using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FormBuddyWeb.Interfaces;
using System.Web.Mvc;
using FormBuddyWeb.Controllers;

namespace FormBuddyWeb.Tests.BusinessLogic
{
    /// <summary>
    /// Summary description for UT_MiscAgent
    /// </summary>
    [TestClass]
    public class UT_MiscAgent
    {
        [TestMethod]
        public void GetSecurityQuestions()
        {
            //Mock<IMiscRepository> miscMock = new Mock<IMiscRepository>();
            //miscMock.Setup(m => m.SecurityQuestions).Returns(new List<SelectListItem>
            //{
            //    new SelectListItem { Text="What was your childhood nickname?", Value="1" },
            //    new SelectListItem { Text="What school did you attend for sixth grade?", Value="2" },
            //    new SelectListItem { Text="What was your dream job as a child?", Value="3" },
            //    new SelectListItem { Text="What year did you graduate from High School?", Value="4" },
            //    new SelectListItem { Text="What was the color of your first car?", Value="5" }
            //});

            //Mock<IUserRepository> useMock = new Mock<IUserRepository>();
            //miscMock.Setup(m => m.)

            //HomeController controller = new HomeController(miscMock.Object);
        }
    }
}
