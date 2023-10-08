using ds.test.impl;

internal interface PluginFactory
{
    int PluginsCount => 4;

    string[] GetPluginNames => new[] { "Add", "Div", "Multi", "Sub" };

    IPlugin GetPlugin(string pluginName)
    {
        switch (pluginName)
        {
            case "Add":
                return new AdditionPlugin();
            case "Div":
                return new DivisionPlugin();
            case "Multi":
                return new MultiplicationPlugin();
            case "Sub":
                return new SubtractionPlugin();
            default: throw new Exception("Операция не найдена!");
        }
    }
}