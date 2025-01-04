using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

[TestFixture]
public class GreetingService_GreetShould
{
    [TestCase("Alice")]
    [TestCase("     Alice       ")]
    [TestCase(" \n Alice \n ")]
    [TestCase(" \r   Alice \r  ")]
    [TestCase("\t\t\tAlice\t\t\t")]
    public void Greet_InputNameAlice_ReturnHelloAlice(string alice)
    {
        // Arrange
        var expected = "Hello, Alice!";

        // Act
        var actual = GreetingService.Greet(alice);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("Bob")]
    [TestCase("     Bob       ")]
    [TestCase(" \n Bob \n ")]
    [TestCase(" \r   Bob \r  ")]
    [TestCase("\t\t\tBob\t\t\t")]
    public void Greet_InputNameBob_ReturnHelloBob(string bob)
    {
        // Arrange
        var expected = "Hello, Bob!";

        // Act
        var actual = GreetingService.Greet(bob);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("\n")]
    [TestCase("\r")]
    [TestCase("\t")]
    public void Greet_InputNameNone_ReturnHelloWorld(string? name)
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var actual = GreetingService.Greet(name);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("mary jane", "Hello, mary jane!")]
    [TestCase("O'Connor", "Hello, O'Connor!")]
    [TestCase("María", "Hello, María!")]
    [TestCase("    多田野数人    ", "Hello, 多田野数人!")]
    [TestCase("Smith-Jones", "Hello, Smith-Jones!")]
    [TestCase("  First   Last  ", "Hello, First   Last!")]
    [TestCase("😀", "Hello, 😀!")]
    public void Greet_InputSpecialNames_ReturnCorrectGreeting(string input, string expected)
    {
        // Act
        var actual = GreetingService.Greet(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
