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

    [Test]
    public async Task Greet_NameBob_ReturnHelloBob()
    {
        // Arrange
        var expected = "Hello, Bob!";

        // Act
        var actual = GreetingService.Greet("Bob");

        // Assert
        await Assert.That(actual).IsEqualTo(expected);
    }

    [Test]
    [Arguments(null)]
    [Arguments("")]
    [Arguments(" ")]
    [Arguments("\n")]
    [Arguments("\r")]
    [Arguments("\t")]
    public async Task Greet_NameNone_ReturnHelloWorld(string? name)
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var actual = GreetingService.Greet(name);

        // Assert
        await Assert.That(actual).IsEqualTo(expected);
    }
}
