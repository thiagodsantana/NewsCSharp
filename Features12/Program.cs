using FeaturesCSharp.Versao12;
using static FeaturesCSharp.Versao12.InlineArrays;

#region Features C# 12

////#region Primary Constructors Non Record Types

////Console.WriteLine("Primary Constructors Non Record Types - C# 12");
////PrimaryConstructorsNonRecordTypes.Validar();
////#endregion

Console.WriteLine();

////#region Collection Expressions
////Console.WriteLine("Collection Expressions - C# 12");
////CollectionExpressions.Validar();
////#endregion

Console.WriteLine();

#region InlineArrays
Console.WriteLine("Inline Arrays - C# 12");

// Criando um array inline de structs (Pessoa)
var pessoas = [new Pessoa("João", 30), new Pessoa("Maria", 25), new Pessoa("José", 35)];
InlineArrayNumbers numbers = default;

// Acessando os elementos
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;

;
InlineArrayNumbers strings = default;
strings[0] = "Teste";

//Compilador informa que está fora do indíce
//numbers[3] = 40;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(numbers[i]); // Saída: 10, 20, 30
}

#endregion

Console.ReadLine();

#endregion