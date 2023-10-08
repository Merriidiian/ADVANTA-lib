# Библотека "lib.dll"
## Используется для выполнения математических операций
## Версия .NET 7.0
## Зависимости: System.Drawing.Common
### Описание работы
#### 1. Статический класс Plagins:
Статический класс с 3 методами:

1. int GetPluginsCount() - возвращает кол-во доступных операций (на данный момент 4).
2. string[] GetPluginsName() - возвращает массива имён доступных операций (на данный момент: "Add - сложение, "Div" - деление, "Multi" - умножение, "Sub" - вычитание)
3. IPlugin GetPlugin(string pluginName) - возвращает операцию IPlugun по её имени.

#### 2. Интерфейс IPlagin:
Интерфейс наследующий контракт на 4 переменные (string PluginName, string Version, Image Image, string Description) и метод int Run (int input1, int input2)

1. string PluginName - имя операции
2. string Version - версия
3. Image Image - изображение
4. string Description - расшифровка операции
5. int Run (int input1, int input2) - операция с двумя переменными

#### В библиотеке есть 4 вида операции: сложение, вычитание, умножение и деление.

#### Тесты и примеры реализации находятся в проекте TestLib.
