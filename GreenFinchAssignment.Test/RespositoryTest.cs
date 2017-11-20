using System;
using GreenFinchAssignment.Web.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenFinchAssignment.Web.Models;
using System.Collections.Generic;
using Moq;

namespace GreenFinchAssignment.Test
{
    [TestClass]
    public class RespositoryTest
    {
        Mock<ISubscriberRepository> subscriberRepository;
        List<SubscribingUserViewModel> mockSubscribers;
        ISubscriberRepository subscriberService;
        [TestInitialize]
        public void Initialize()
        {
            subscriberRepository = new Mock<ISubscriberRepository>();
            subscriberRepository = new Mock<ISubscriberRepository>();
            mockSubscribers = new List<SubscribingUserViewModel>() {
                new SubscribingUserViewModel() { Id = 1, SubscribingReason = "Test 1", SubscribingSourceId=1, Email="iam.shabir@yahoo.com" },
                new SubscribingUserViewModel() { Id = 2, SubscribingReason = "Test 2", SubscribingSourceId=2, Email="iam.shabir89@yahoo.com" },
                new SubscribingUserViewModel() { Id = 3, SubscribingReason = "Test 3", SubscribingSourceId=2, Email="shj@ciklum.com" },
                new SubscribingUserViewModel() { Id = 4, SubscribingReason = "", SubscribingSourceId=1, Email="shjabc@ciklum.com" },
            };
        }

        [TestMethod]
        public void CheckEmailExists()
        {

            subscriberRepository.Setup(x => x.All).Returns(mockSubscribers);

            var user = subscriberService.CheckIfEmailExists("iam.shabir@yahoo.com");

            //Assert
            Assert.AreEqual(false, user);

        }
    }
}
