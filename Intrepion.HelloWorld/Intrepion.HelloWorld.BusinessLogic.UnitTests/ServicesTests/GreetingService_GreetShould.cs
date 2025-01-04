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
    public void BeHelloAlice_GivenAlice(string alice)
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
    public void BeHelloBob_GivenBob(string bob)
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
    public void BeHelloWorld_GivenNothing(string? nothing)
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var actual = GreetingService.Greet(nothing);

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
    public void BeHelloSpecial_GivenSpecial(string special, string expected)
    {
        // Act
        var actual = GreetingService.Greet(special);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
