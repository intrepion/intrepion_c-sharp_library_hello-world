using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

[TestClass]
public class GreetingService_GreetShould
{
    [TestMethod]
    public void Greet_NameAlice_ReturnHelloAlice()
    {
        // Arrange
        var expected = "Hello, Alice!";

        // Act
        var actual = GreetingService.Greet("Alice");

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Greet_NameBob_ReturnHelloBob()
    {
        // Arrange
        var expected = "Hello, Bob!";

        // Act
        var actual = GreetingService.Greet("Bob");

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
    public void Greet_NameNone_ReturnHelloWorld(string? name)
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var actual = GreetingService.Greet(name);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
