using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

public class GreetingService_GreetingShould
{
    [Test]
    public async Task Greet_NameAlice_ReturnHelloAlice()
    {
        // Arrange
        var expected = "Hello, Alice!";

        // Act
        var actual = GreetingService.Greet("Alice");

        // Assert
        await Assert.That(actual).IsEqualTo(expected);
    }
}
