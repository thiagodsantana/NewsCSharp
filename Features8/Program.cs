using Features8.Classes;

#region Features C# 8

#region Index e Range
Console.WriteLine("Indíces e Faixas - C# 8");

Console.WriteLine();
Console.WriteLine("Recurso Index");
int[] array = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine("int[] array = { 1, 2, 3, 4, 5, 6 }");
int ultimo = array[^1];
int penultimo = array[^2];
Console.WriteLine($"Último Registro usando index: {ultimo}");
Console.WriteLine($"Penúltimo Registro usando index: {penultimo}");


//Conversão da Expressão:
var index = new Index(1, fromEnd: true);
ultimo = array[index]; // último elemento
//Interpretação do compilador
ultimo = array[array.Length - 1]; // Como o compilador interpreta

Console.WriteLine();
Console.WriteLine("Recurso Range");

//Retorna o intervalo de valores da coleção
var subArray = array[1..3];

// Conversão da Expressão:
var range = new Range(new Index(1, fromEnd: false), new Index(3, fromEnd: false));
subArray = array[range];


// Interpretação do compilador
int[] slice = new int[3]; // O tamanho da fatia é 3 (de 1 a 3 inclusivo)
Array.Copy(array, 1, slice, 0, 3); // Copia do índice 1 ao 3

Console.WriteLine("int[] array = { 1, 2, 3, 4, 5, 6 }");

Console.WriteLine($"Subarray gerado com Range");

for (int y = 0; y < subArray.Length; y++)
{
    Console.WriteLine(subArray[y]);
}

#endregion

Console.WriteLine();

#region Tipos Anuláveis

Console.WriteLine("Tipos Anuláveis - C# 8");

Console.WriteLine();
Console.WriteLine("Recurso Tipos de referência não anuláveis");
TiposReferenciaAnulaveis.nonNullableString = null; // ERRO: Não pode ser nulo
Console.WriteLine($"Valor TiposReferenciaAnulaveis.nonNullableString -> {TiposReferenciaAnulaveis.nonNullableString}"); // Sem avisos do compilador

Console.WriteLine();
Console.WriteLine("Recurso Tipos de referência anuláveis");
TiposReferenciaAnulaveis.nullableString = null; // OK: Pode ser nulo

if (TiposReferenciaAnulaveis.nullableString != null)
{
    // O compilador sabe que nullableString não é nulo aqui
    Console.WriteLine(TiposReferenciaAnulaveis.nullableString.Length);
}

// Usando o operador de anulação suprimida (!) - assumindo que não será nulo
// AVISO suprimido, mas pode causar NullReferenceException se nullableString for nulo
Console.WriteLine("TiposReferenciaAnulaveis.nullableString!.Length -> NullReferenceException");
//Console.WriteLine(TiposReferenciaAnulaveis.nullableString!.Length); 


#endregion

Console.WriteLine();

#region Pattern Matching

Console.WriteLine("Pattern Matching - C# 8");
Console.WriteLine();
var obj = "Teste sem pattern matching";

if (obj is string)
{
    string str1 = (string)obj;
    Console.WriteLine($"Objeto foi identificado como string: {str1}");
}

Console.WriteLine();
var obj2 = "Pattern Matching - Operador is com atribuição";
if (obj2 is string str2)
{
    Console.WriteLine($"Objeto foi identificado como string: {str2}");
}

Console.WriteLine();
Object valor = 10;
if (valor is int i and >= 0 and <= 100)
{
    /*
        Compilador desmembra:
            * Verifica se obj é do tipo int
            * Se for, atribui obj à variável i.
            * Em seguida, verifica se i está no intervalo de 0 a 100 
     */
    Console.WriteLine("Pattern Matching - Operador 'is' e 'and'");
    Console.WriteLine($"Número dentro do intervalo: {i}");
}

Console.WriteLine();

PatternMatching.Pessoa pessoa = new("João", 30);
if (pessoa is PatternMatching.Pessoa { Idade: > 18 } pessoaMaiorIdade)
{
    Console.WriteLine("Pattern Matching - Operador 'is' + Condicional de propriedades do objeto");
    Console.WriteLine(pessoa);
    Console.WriteLine($"{pessoaMaiorIdade.Nome} é maior de idade.");
}

Console.WriteLine();
Console.WriteLine("Pattern Matching - Combinação switch com Operador 'when'");
switch (pessoa)
{
    case PatternMatching.Pessoa p when (p.Idade >= 18):
        Console.WriteLine($"{p.Nome} é maior de idade.");
        break;
    case PatternMatching.Pessoa p when (p.Idade < 18):
        Console.WriteLine($"{p.Nome} é menor de idade.");
        break;
    default:
        break;
}


// Código gerado pelo compilador:            
//if (pessoa is PatternMatching.Pessoa p)
//{
//    if (p.Idade >= 18)
//    {
//        // Primeiro case
//    }
//    else if (p.Idade < 18)
//    {
//        // Segundo case
//    }
//    else
//    {
//        // Default
//    }
//}


#endregion

#endregion

Console.ReadLine();
