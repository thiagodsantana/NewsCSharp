using FeaturesCSharp.Versao13;

#region Features C# 13

#region ScopedLock

Console.WriteLine("Scoped Lock - C# 13");
ScopedLock.ValidarLockGenerico();
ScopedLock.ValidarNewLock();
#endregion

Console.WriteLine();

#region Params Collection
Console.WriteLine("Params Collection - C# 13");
ParamsCollections.ContarNumeros(1, 2, 3);

List<int> lista = [1, 2, 3, 4];
var enumerable = Enumerable.Range(5, 5);
var hashSet = (new HashSet<int> { 5, 6, 7, 8, 9, 10 });
int[] array = [1, 2, 3, 4, 5, 6, 7];


ParamsCollections.ContadorNumeros(lista);
ParamsCollections.ContadorNumeros(enumerable);
ParamsCollections.ContadorNumeros(hashSet);
ParamsCollections.ContarNumeros(array);

#endregion

Console.ReadLine();
#endregion
