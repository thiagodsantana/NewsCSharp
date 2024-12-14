#region Features C# 11

#region List Patterns
using FeaturesCSharp.Versao11;
using static FeaturesCSharp.Versao11.StaticAbstractMembers;

Console.WriteLine("List Patterns - C# 11");
var numeros = new int[3] { 1, 2, 3 };
ListPatterns.Validar(numeros);

#endregion

Console.WriteLine();

#region Required Member

Console.WriteLine("Required Member - C# 11");
var cachorro = new RequiredMembers.Cachorro
{
    Nome = "Rex",
    Especie = "Canina",
    Raca = "Labrador"
};


//Propriedades Nome e Raca devem ser inicializada no construtor
//var cachorroRequired = new RequiredMembers.Cachorro
//                       {
//                           Especie = "Canina"
//                       };
Console.WriteLine($"Espécie: {cachorro.Especie} | Raça: {cachorro.Raca}");

#endregion

Console.WriteLine();

#region Static Abastract Member
Console.WriteLine("Static Abastract Member - C# 11");
// Criando instâncias usando o método estático da interface
IRepository usuarioRepo = UsuarioRepository.Criar();
IRepository produtoRepo = ProdutoRepository.Criar();

// Acessando propriedades estáticas
Console.WriteLine($"Repositório Criado: {UsuarioRepository.NomeColecao}");  // Saída: Usuarios
Console.WriteLine($"Repositório Criado: {ProdutoRepository.NomeColecao}");  // Saída: Produtos
#endregion

Console.ReadLine();
#endregion