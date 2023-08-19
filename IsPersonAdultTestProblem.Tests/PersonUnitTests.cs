using Moq;

namespace IsPersonAdultTestProblem.Tests
{
    public class PersonUnitTests
    {
        [Fact]
        public void CreatePerson_IsNotAdult()
        {
            // Arrange
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();
            dateTimeProviderMock.Setup(provider => provider.GetCurrentDate()).Returns(new DateTime(2017, 1, 1));

            var personFactory = new PersonFactory(dateTimeProviderMock.Object);

            // Act
            var person = personFactory.CreatePerson("John", "Doe", new DateTime(2000, 1, 1));

            // Assert
            Assert.False(person.IsAdult);
        }

        [Fact]
        public void CreatePerson_IsAdult()
        {
            // Arrange
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();
            dateTimeProviderMock.Setup(provider => provider.GetCurrentDate()).Returns(new DateTime(2019, 1, 1));

            var personFactory = new PersonFactory(dateTimeProviderMock.Object);

            // Act
            var person = personFactory.CreatePerson("John", "Doe", new DateTime(2000, 1, 1));

            // Assert
            Assert.True(person.IsAdult);
        }
    }
}