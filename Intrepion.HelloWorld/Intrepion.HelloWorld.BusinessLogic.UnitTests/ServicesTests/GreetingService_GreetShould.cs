using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

[TestFixture]
public class GreetingService_GreetShould
{
    [Test]
    public void Greet_InputNameOliver_ReturnHelloOliver()
    {
        // Arrange
        var expected = "Hello, Oliver!";

        // Act
        var actual = GreetingService.Greet("Oliver");

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}