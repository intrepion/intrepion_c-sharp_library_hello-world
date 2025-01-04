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
    public void BeHelloAlice_GivenAlice(string alice)
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
    public void BeHelloBob_GivenBob(string bob)
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
    public void BeHelloWorld_GivenNothing(string? nothing)
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var actual = GreetingService.Greet(nothing);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("mary jane", "Hello, mary jane!")]
    [InlineData("O'Connor", "Hello, O'Connor!")]
    [InlineData("María", "Hello, María!")]
    [InlineData("    多田野数人    ", "Hello, 多田野数人!")]
    [InlineData("Smith-Jones", "Hello, Smith-Jones!")]
    [InlineData("  First   Last  ", "Hello, First   Last!")]
    [InlineData("😀", "Hello, 😀!")]
    public void BeHelloSpecial_GivenSpecial(string special, string expected)
    {
        // Act
        var actual = GreetingService.Greet(special);

        // Assert
        Assert.Equal(expected, actual);
    }
}
