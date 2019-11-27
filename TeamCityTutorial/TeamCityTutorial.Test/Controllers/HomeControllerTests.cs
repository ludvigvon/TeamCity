using AutoFixture;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using TeamCityTutorial.Controllers;
using Xunit;

namespace TeamCityTutorial.Test
{
    public class HomeControllerTests
    {
        private readonly Fixture _fixture;
        private readonly Mock<ILogger<HomeController>> _loggerMock;
        private readonly HomeController _homeController;

        public HomeControllerTests()
        {
            _fixture = new Fixture();
            _loggerMock = new Mock<ILogger<HomeController>>();
            _homeController = new HomeController(_loggerMock.Object);
        }

        [Fact]
        public void IndexTest()
        {
            //arrange

            //act
            var actual = _homeController.Index();

            //assert
            actual.Should().NotBeNull();
        }

        [Fact]
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
