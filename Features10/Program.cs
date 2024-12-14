#region Features C# 10

#region Constant Interpolated Strings
Console.WriteLine("Constant Interpolated Strings - C# 10");
ConstantInterpolatedStrings.Validar();

ConstantInterpolatedStrings.ValidarSwitchConstante();

/*
 * Definição de valores em atributos
*/
const string Author = "Thiago Darlei";
const string Version = "1.0";

[System.Obsolete($"Definindo valores em atributos by {Author} in version {Version}.")]
void OldMethod()
{
    List<int> list = [];
    _ = list.Sum();
}

OldMethod();

#endregion

Console.WriteLine();

#region GlobalUsing
// Mostrar arquivo e explicar
#endregion

Console.WriteLine();

#region FileScopedNamespace
// Mostrar arquivo e explicar
#endregion

Console.ReadLine();
#endregion
