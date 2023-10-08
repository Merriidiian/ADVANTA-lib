using ds.test.impl;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Plugins.GetPluginsCount());
        foreach (var name in Plugins.GetPluginsName())
        {
            Console.WriteLine(name);
        }
        Console.WriteLine(Plugins.GetPlugin("Add").Run(1, 1));
        Console.WriteLine(Plugins.GetPlugin("Div").Run(1, 1));
        Console.WriteLine(Plugins.GetPlugin("Multi").Run(1, 1));
        Console.WriteLine(Plugins.GetPlugin("Sub").Run(1, 1));
        try
        {
            Console.WriteLine(Plugins.GetPlugin("Test").Run(1, 1));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}