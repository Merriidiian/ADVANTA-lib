namespace ds.test.impl;

public static class Plugins
{
    private static readonly List<IPlugin> _plugins;
    private static PluginFactory _pluginFactory;

    static Plugins()
    {
        _plugins = new List<IPlugin>()
        {
            new AdditionPlugin(),
            new DivisionPlugin(),
            new MultiplicationPlugin(),
            new SubtractionPlugin()
        };
    }

    public static int GetPluginsCount()
    {
        return new PluginFactoryRealization().PluginsCount;
    }

    public static string[] GetPluginsName()
    {
        return new PluginFactoryRealization().GetPluginNames;
    }

    public static IPlugin GetPlugin(string pluginName)
    {
        return new PluginFactoryRealization().GetPlugin(pluginName);
    }

/*
 * Дополнительный класс для реализации задания
 * Static Class не может наследовать интерфейсы!
 */
    internal class PluginFactoryRealization : PluginFactory
    {
        public readonly int PluginsCount = _plugins.Count;
        public readonly string[] GetPluginNames = _plugins.Select(n => n.PluginName).ToArray();


        public IPlugin GetPlugin(string pluginName)
        {
            return pluginName switch
            {
                "Add" => new AdditionPlugin(),
                "Div" => new DivisionPlugin(),
                "Multi" => new MultiplicationPlugin(),
                "Sub" => new SubtractionPlugin(),
                _ => throw new Exception("Операция не найдена!")
            };
        }
    }
}