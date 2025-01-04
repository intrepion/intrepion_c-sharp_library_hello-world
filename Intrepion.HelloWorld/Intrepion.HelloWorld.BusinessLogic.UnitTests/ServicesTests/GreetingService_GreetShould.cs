using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

public class GreetingService_GreetingShould
{
    [Test]
    [Arguments("Alice")]
    [Arguments("     Alice       ")]
    [Arguments(" \n Alice \n ")]
    [Arguments(" \r   Alice \r  ")]
    [Arguments("\t\t\tAlice\t\t\t")]
    public async Task Greet_NameAlice_ReturnHelloAlice(string alice)
    {
        // Arrange
        var expected = "Hello, Alice!";

        // Act
        var actual = GreetingService.Greet(alice);

        // Assert
        await Assert.That(actual).IsEqualTo(expected);
    }

    [Test]
    [Arguments("Bob")]
    [Arguments("     Bob       ")]
    [Arguments(" \n Bob \n ")]
    [Arguments(" \r   Bob \r  ")]
    [Arguments("\t\t\tBob\t\t\t")]    public async Task Greet_NameBob_ReturnHelloBob(string bob)
    {
        // Arrange
        var expected = "Hello, Bob!";

        // Act
        var actual = GreetingService.Greet(bob);

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

    [Test]
    [Arguments("mary jane", "Hello, mary jane!")]
    [Arguments("O'Connor", "Hello, O'Connor!")]
    [Arguments("María", "Hello, María!")]
    [Arguments("    多田野数人    ", "Hello, 多田野数人!")]
    [Arguments("Smith-Jones", "Hello, Smith-Jones!")]
    [Arguments("  First   Last  ", "Hello, First   Last!")]
    [Arguments("😀", "Hello, 😀!")]
    public async Task Greet_NameSpecial_ReturnSpecial(string name, string expected)
    {
        // Act
        var actual = GreetingService.Greet(name);

        // Assert
        await Assert.That(actual).IsEqualTo(expected);
    }
}
