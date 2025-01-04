using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

[TestClass]
public class GreetingService_GreetShould
{
    [TestMethod]
    [DataRow("Alice")]
    [DataRow("     Alice       ")]
    [DataRow(" \n Alice \n ")]
    [DataRow(" \r   Alice \r  ")]
    [DataRow("\t\t\tAlice\t\t\t")]
    public void BeHelloAlice_GivenAlice(string alice)
    {
        // Arrange
        var expected = "Hello, Alice!";

        // Act
        var actual = GreetingService.Greet(alice);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow("Bob")]
    [DataRow("     Bob       ")]
    [DataRow(" \n Bob \n ")]
    [DataRow(" \r   Bob \r  ")]
    [DataRow("\t\t\tBob\t\t\t")]
    public void BeHelloBob_GivenBob(string bob)
    {
        // Arrange
        var expected = "Hello, Bob!";

        // Act
        var actual = GreetingService.Greet(bob);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow(null)]
    [DataRow("")]
    [DataRow(" ")]
    [DataRow("\n")]
    [DataRow("\r")]
    [DataRow("\t")]
    public void BeHelloWorld_GivenNothing(string? nothing)
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var actual = GreetingService.Greet(nothing);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow("mary jane", "Hello, mary jane!")]
    [DataRow("O'Connor", "Hello, O'Connor!")]
    [DataRow("María", "Hello, María!")]
    [DataRow("    多田野数人    ", "Hello, 多田野数人!")]
    [DataRow("Smith-Jones", "Hello, Smith-Jones!")]
    [DataRow("  First   Last  ", "Hello, First   Last!")]
    [DataRow("😀", "Hello, 😀!")]
    public void BeHelloSpecial_GivenSpecial(string special, string expected)
    {
        // Act
        var actual = GreetingService.Greet(special);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
