using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

public class GreetingService_GreetShould
{
    [Fact]
    public void Greet_InputNameAlice_ReturnHelloAlice()
    {
        // Arrange
        var expected = "Hello, Alice!";

        // Act
        var actual = GreetingService.Greet("Alice");

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Greet_InputNameBob_ReturnHelloBob()
    {
        // Arrange
        var expected = "Hello, Bob!";

        // Act
        var actual = GreetingService.Greet("Bob");

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("\n")]
    [InlineData("\r")]
    [InlineData("\t")]
    public void Greet_InputNameNone_ReturnHelloWorld(string? input)
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var actual = GreetingService.Greet(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
