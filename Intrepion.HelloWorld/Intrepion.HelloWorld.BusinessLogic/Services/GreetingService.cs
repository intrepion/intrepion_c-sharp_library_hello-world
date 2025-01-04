namespace Intrepion.HelloWorld.BusinessLogic.Services;

static public class GreetingService
{
    static public string Greet(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "Hello, world!";
        }

        name = name.Trim();

        return $"Hello, {name}!";
    }
}
