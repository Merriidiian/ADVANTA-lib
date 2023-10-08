using System.Drawing;

namespace ds.test.impl;

internal class AdditionPlugin  : PluginOperations
{
    public override string PluginName => "Add";
    public override string Version => ".NET 7";
    public override Image Image => null;
    public override string Description => "a + b";
    public override int Run(int input1, int input2)
    {
        return input1 + input2;
    }
}