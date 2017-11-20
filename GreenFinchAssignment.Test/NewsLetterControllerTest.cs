using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenFinchAssignment.Web.Controllers;
using GreenFinchAssignment.Web.Repository;
using Moq;
using GreenFinchAssignment.DataStructure;
using Microsoft.AspNetCore.Mvc;

namespace GreenFinchAssignment.Test
{
    [TestClass]
    public class NewsLetterControllerTest
    {
        NewsLetterController ControllerToTest;
        private Mock<ISubscriberRepository> SubscriberRepository;


        [TestInitialize]
        public void Setup()
        {
            SubscriberRepository = new Mock<ISubscriberRepository>();

            ControllerToTest = new NewsLetterController(SubscriberRepository.Object);
        }

        [TestMethod]
        public void TestControllerRenderCreateView()
        {
            var controllerView = ControllerToTest.Create() as ViewResult;
            Assert.AreEqual("", controllerView.ViewName);
        }
    }
}
