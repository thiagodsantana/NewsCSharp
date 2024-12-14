using FeaturesCSharp.Versao12;

#region Features C# 12

#region Primary Constructors Non Record Types
using static FeaturesCSharp.Versao12.InlineArrays;

Console.WriteLine("Primary Constructors Non Record Types - C# 12");
PrimaryConstructorsNonRecordTypes.Validar();
#endregion

Console.WriteLine();

#region Collection Expressions
Console.WriteLine("Collection Expressions - C# 12");
CollectionExpressions.Validar();
#endregion

Console.WriteLine();

#region InlineArrays
Console.WriteLine("Inline Arrays - C# 12");
InlineArrayNumbers numbers = default;

// Acessando os elementos
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(numbers[i]); // Saída: 10, 20, 30
}

#endregion

Console.ReadLine();

#endregion