using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

public class GreetingService_GreetShould
{
    [Theory]
    [InlineData("Alice")]
    [InlineData("     Alice       ")]
    [InlineData(" \n Alice \n ")]
    [InlineData(" \r   Alice \r  ")]
    [InlineData("\t\t\tAlice\t\t\t")]
    public void Greet_InputNameAlice_ReturnHelloAlice(string alice)
    {
        // Arrange
        var expected = "Hello, Alice!";

        // Act
        var actual = GreetingService.Greet(alice);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Bob")]
    [InlineData("     Bob       ")]
    [InlineData(" \n Bob \n ")]
    [InlineData(" \r   Bob \r  ")]
    [InlineData("\t\t\tBob\t\t\t")]
    public void Greet_InputNameBob_ReturnHelloBob(string bob)
    {
        // Arrange
        var expected = "Hello, Bob!";

        // Act
        var actual = GreetingService.Greet(bob);

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
