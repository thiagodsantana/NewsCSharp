using Features8.Classes;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

#region Features C# 8

#region Index e Range

void ImprimirIndex(string texto, int[] list, Index index) 
    => Console.WriteLine(string.Format("{0} : {1}", texto, string.Join(", ", list[index])));
void ImprimirRange(string texto, int[] list, Range range) 
    => Console.WriteLine(string.Format("{0} : {1}", texto, string.Join(", ", list[range])));


Console.WriteLine("Index e Ranges - C# 8");

Console.WriteLine();
Console.WriteLine("Recurso Index");
int[] array = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine("int[] array = { 1, 2, 3, 4, 5, 6 }");

int ultimo = array[^1];
ultimo = array[new Index(1, fromEnd: true)];
ImprimirIndex("Último Registro ( array[^1] )", array, ultimo);
Console.WriteLine("Interpretação compilador: array[array.Length - 1]");


int penultimo = array[^2];
ultimo = array[new Index(2, fromEnd: true)];
ImprimirIndex("Penúltimo registro ( array[^2] )", array, penultimo);
Console.WriteLine("Interpretação compilador: array[array.Length - 2]");


Console.WriteLine();
Console.WriteLine("Recurso Range");


Console.WriteLine();
ImprimirRange("Retorna todos os elementos usando expressão .. ", array, range: ..);
ImprimirRange("Retorna todos os elementos usando Range.All ", array, Range.All);
//// Conversão da Expressão:
//array.ToList<int>().Slice(0, array.Length);

Console.WriteLine();
ImprimirRange("Retorna os últimos 3 elementos usando expressão ..3 ", array, range: ..3);
ImprimirRange("Retorna os últimos 3 elementos usando Range.EndAt(3) ", array, Range.EndAt(3));
//// Conversão da Expressão:
//array.ToList<int>().Slice(0, 4);

Console.WriteLine();
ImprimirRange("Retorna o intervalo entre os elementos 3 e 5 usando a expressão 1..3 ", array, range: 1..3);
ImprimirRange("Retorna o intervalo entre os elementos 1 e 3 usando new Range(1,3) ", array, new Range(1, 3));
//// Conversão da Expressão:
//var range = new Range(new Index(1, fromEnd: false), new Index(3, fromEnd: false));
//subArray = array[range];

#endregion

Console.WriteLine();

#region Pattern Matching

Console.WriteLine("Pattern Matching - C# 8");
Console.WriteLine();

Console.WriteLine("Switch Expressions:");
string VerificarDia(DayOfWeek day) => day switch
{
    DayOfWeek.Saturday or DayOfWeek.Sunday => "Fim de semana",
    DayOfWeek.Monday => "Início da semana",
    _ => "Dia da semana" // Padrão
};

/*
 * Interpretação do compilador
    string VerificarDia(DayOfWeek day)
    {
        if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
        {
            return "Fim de semana";
        }
        else if (day == DayOfWeek.Monday)
        {
            return "Início da semana";
        }
        else
        {
            return "Dia da semana";
        }
    }
 */

Console.WriteLine(VerificarDia(DayOfWeek.Saturday));

Console.WriteLine();

Console.WriteLine("Property Patterns");

PatternMatching.Pessoa pessoa = new("João", 30);
if (pessoa is PatternMatching.Pessoa { Idade: > 18 } pessoaMaiorIdade)
{
    Console.WriteLine(pessoa);
    Console.WriteLine($"{pessoaMaiorIdade.Nome} é maior de idade.");
}

/*
 * Interpretação do compilador
    PatternMatching.Pessoa pessoaMaiorIdade;
    if (pessoa != null &&
        pessoa is PatternMatching.Pessoa &&
        pessoa.Idade > 18)
    {
        pessoaMaiorIdade = pessoa;
        Console.WriteLine(pessoa);
        Console.WriteLine($"{pessoaMaiorIdade.Nome} é maior de idade.");
    }
 */


Console.WriteLine();
Console.WriteLine("Tuple Patterns");

Console.WriteLine(ClassificarPonto(2, 0));
string ClassificarPonto(int x, int y) => (x, y) switch
{
    (0, 0) => "Origem",
    (_, 0) => "Eixo X",
    (0, _) => "Eixo Y",
    _ => "Outro ponto"
};

/*
 * Interpretação do compilador
    string ClassificarPonto(int x, int y)
    {
        if (x == 0 && y == 0)
        {
            return "Origem";
        }
        else if (y == 0)
        {
            return "Eixo X";
        }
        else if (x == 0)
        {
            return "Eixo Y";
        }
        else
        {
            return "Outro ponto";
        }
    }
 */

Console.WriteLine();
Console.WriteLine("Operadores de Pattern Matching");
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

/*
 * Interpretação do compilador
    if (pessoa is PatternMatching.Pessoa p && p.Idade >= 18)
    {
        Console.WriteLine($"{p.Nome} é maior de idade.");
    }
    else if (pessoa is PatternMatching.Pessoa p && p.Idade < 18)
    {
        Console.WriteLine($"{p.Nome} é menor de idade.");
    }
    else
    {
        // Caso default: não faz nada.
    }

 */

#endregion


Console.WriteLine();

#region Tipos Anuláveis

Console.WriteLine("Tipos Anuláveis - C# 8");

Console.WriteLine();
Console.WriteLine("Ativando Recurso:");
Console.WriteLine(".csproj => <Nullable>enable</Nullable>");
Console.WriteLine("Início arquivo de código => #nullable enable");

Console.WriteLine("");

Console.WriteLine("Tipo não anulável (padrão):");
TiposReferenciaAnulaveis.VariavelNaoAnulavel = null; // Não pode ser nulo
Console.WriteLine($"Valor TiposReferenciaAnulaveis.NaoAnulavel -> {TiposReferenciaAnulaveis.VariavelNaoAnulavel}"); // Sem avisos do compilador

Console.WriteLine();
Console.WriteLine("Tipo anulável:");
TiposReferenciaAnulaveis.VariavelAnulavel = null; // Pode ser nulo


Console.WriteLine();
Console.WriteLine("Análise de Fluxo de Nulidade");
if (TiposReferenciaAnulaveis.VariavelAnulavel != null)
{
    // O compilador sabe que VariavelAnulavel não é nulo aqui
    Console.WriteLine($"Tamanho TiposReferenciaAnulaveis.VariavelAnulavel: {TiposReferenciaAnulaveis.VariavelAnulavel.Length}");    
}

// Usando o operador de anulação suprimida (!) - assumindo que não será nulo
// AVISO suprimido, mas pode causar NullReferenceException se nullableString for nulo
Console.WriteLine("TiposReferenciaAnulaveis.VariavelAnulavel!.Length -> NullReferenceException");
//Console.WriteLine(TiposReferenciaAnulaveis.VariavelAnulavel!.Length); 

string? nome = null; // Valor inicial é nulo.
ValidarNomeNotNull(nome); // O método garante que 'nome' não será mais nulo.
Console.WriteLine(nome); // Saída: "Nome Padrão"

nome = "Thiago";
ValidarNomeMaybeNull(nome);

/*
 * O atributo [NotNull] informa ao compilador e ferramentas de análise que, após o método, nome não será mais nulo.
 */
static void ValidarNomeNotNull([NotNull] string? nome)
{
    if (string.IsNullOrEmpty(nome))
    {
        nome = "Nome Padrão"; // Após a validação, nome não será nulo.
    }
}

/*
 * O atributo [MaybeNull] informa ao compilador e ferramentas de análise que, após o método, nome não será mais nulo.
 */
static void ValidarNomeMaybeNull([MaybeNull] string? nome)
{
    if (string.IsNullOrEmpty(nome))
    {
        nome = null; // Pode deixar o nome como nulo.
    }
    else
    {
        nome = nome.Trim(); // Garante que espaços extras são removidos.
    }
}


#endregion

#endregion

Console.ReadLine();
