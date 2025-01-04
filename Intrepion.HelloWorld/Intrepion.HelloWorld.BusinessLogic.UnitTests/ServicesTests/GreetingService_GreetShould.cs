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
}
