using AutoFixture;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TeamCityTutorial.Controllers;

namespace TeamCityTutorial.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        private Fixture _fixture;
        private Mock<ILogger<HomeController>> _loggerMock;
        private HomeController _homeController;

        [TestInitialize]
        public void TestInitialize()
        {
            _fixture = new Fixture();
            _loggerMock = new Mock<ILogger<HomeController>>();
            _homeController = new HomeController(_loggerMock.Object);
        }

        [TestMethod]
        public void IndexTest()
        {
            //arrange

            //act
            var actual = _homeController.Index();

            //assert
            actual.Should().NotBeNull();
        }

        [TestMethod]
        public void PrivacyTest()
        {
            //arrange

            //act
            var actual = _homeController.Privacy();

            //assert
            actual.Should().NotBeNull();
        }
    }
}
