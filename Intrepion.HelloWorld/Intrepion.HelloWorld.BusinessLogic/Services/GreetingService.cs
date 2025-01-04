namespace Intrepion.HelloWorld.BusinessLogic.Services;

public static class GreetingService
{
    public static string Greet(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "Hello, world!";
        }

        name = name.Trim();

        return $"Hello, {name}!";
    }
}
