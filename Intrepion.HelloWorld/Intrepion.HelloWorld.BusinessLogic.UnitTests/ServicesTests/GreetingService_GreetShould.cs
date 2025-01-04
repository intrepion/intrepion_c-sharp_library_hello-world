using Intrepion.HelloWorld.BusinessLogic.Services;

namespace Intrepion.HelloWorld.BusinessLogic.UnitTests.ServicesTests;

[TestFixture]
public class GreetingService_GreetShould
{
    [TestCase("Oliver")]
    [TestCase("     Oliver       ")]
    [TestCase(" \n Oliver \n ")]
    [TestCase(" \r   Oliver \r  ")]
    [TestCase("\t\t\tOliver\t\t\t")]
    public void Greet_InputNameOliver_ReturnHelloOliver(string oliver)
    {
        // Arrange
        var expected = "Hello, Oliver!";

        // Act
        var actual = GreetingService.Greet(oliver);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("James")]
    [TestCase("     James       ")]
    [TestCase(" \n James \n ")]
    [TestCase(" \r   James \r  ")]
    [TestCase("\t\t\tJames\t\t\t")]
    public void Greet_InputNameJames_ReturnHelloJames(string james)
    {
        // Arrange
        var expected = "Hello, James!";

        // Act
        var actual = GreetingService.Greet(james);

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
