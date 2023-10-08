using System.Drawing;

namespace ds.test.impl;

internal class DivisionPlugin : PluginOperations
{
    public override string PluginName => "Div";
    public override string Version => ".NET 7";
    public override Image Image => null;
    public override string Description => "a / b";
    public override int Run(int input1, int input2)
    {
        if (input2 == 0)
        {
            throw new Exception("Ошибка при делении! На ноль делить запрещено!");
        }
        if (input1 % input2 != 0)
        {
            throw new Exception("Ошибка при делении! При делении не должно быть дробного значения!");
        }
        return input1 / input2;
    }
}