using HandlebarsDotNet;

namespace ClassLibrary1;

public class ConsolePrinter
{
    public static void Print(PrintParameters parameters)
    {
        var template = Handlebars.Compile("{{Value}}");
        Console.WriteLine(template(parameters));
    }
}

public record PrintParameters(string Value);