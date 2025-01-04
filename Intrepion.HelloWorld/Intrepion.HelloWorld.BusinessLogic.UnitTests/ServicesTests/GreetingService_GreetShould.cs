using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

[TestFixture]
public class GreetingService_GreetShould
{
    [Test]
    public void Greet_InputNameOliver_ReturnHelloOliver()
    {
        // Arrange
        var expected = "Hello, Oliver!";

        // Act
        var actual = GreetingService.Greet("Oliver");

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Greet_InputNameJames_ReturnHelloJames()
    {
        // Arrange
        var expected = "Hello, James!";

        // Act
        var actual = GreetingService.Greet("James");

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("")]
    [TestCase(" ")]
    [TestCase("\n")]
    [TestCase("\r")]
    [TestCase("\t")]
    public void Greet_InputNameNone_ReturnHelloWorld(string name)
    {
        // Arrange
        var expected = "Hello, world!";

        // Act
        var actual = GreetingService.Greet(name);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
