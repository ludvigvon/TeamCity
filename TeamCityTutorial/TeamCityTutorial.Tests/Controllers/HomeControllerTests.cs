using AutoFixture;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TeamCityTutorial.Controllers;

namespace TeamCityTutorial.Tests
{
    public class HomeControllerTests
    {
        private Fixture _fixture;
        private Mock<ILogger<HomeController>> _loggerMock;
        private HomeController _homeController;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
            _loggerMock = new Mock<ILogger<HomeController>>();
            _homeController = new HomeController(_loggerMock.Object);
        }

        [Test]
        public void IndexTest()
        {
            //arrange

            //act
            var actual = _homeController.Index();

            //assert
            actual.Should().NotBeNull();
        }

        [Test]
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