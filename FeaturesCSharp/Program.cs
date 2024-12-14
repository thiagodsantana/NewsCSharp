
#region Features C# 9

#region InitOnly
//Console.WriteLine("InitOnly - C# 9");
InitOnly.Produto produto = new()
{
    Codigo = "1009",
    Nome = "Café"
};

produto.Nome = "Chá";  // Ok, pois 'Nome' tem 'set'
                       //produto.Codigo = "B456";  // Erro de compilação, pois 'Codigo' tem 'init'            

#endregion

#region Record
//Console.WriteLine("Record - C# 9");
//Console.WriteLine();
//var pessoa = new Records.PessoaRecord("Thiago Darlei", 36);

////Comparação estrutural
//var pessoa1 = new Records.PessoaRecord("Thiago Darlei", 36);
//var pessoa2 = new Records.PessoaRecord("Thiago Darlei", 36);
//var pessoa3 = new Records.PessoaRecord("Thiago Darlei", 30);

//Console.WriteLine("Comparação Records:");
//Console.WriteLine($"{pessoa1} -> {pessoa2} | Resultado: {pessoa1 == pessoa2}");
//Console.WriteLine($"{pessoa1} -> {pessoa3} | Resultado {pessoa1 == pessoa3}");


//Records.PessoaClass pessoaClass1 = new()
//{
//    Nome = "Thiago Darlei",
//    Idade = 36,
//};

//Records.PessoaClass pessoaClass2 = new()
//{
//    Nome = "Thiago Darlei",
//    Idade = 36,
//};

//Records.PessoaClass pessoaClass3 = new()
//{
//    Nome = "João",
//    Idade = 30,
//};

//Console.WriteLine();
//Console.WriteLine("Comparação Classes:");
//Console.WriteLine($"{pessoaClass1.Nome} {pessoaClass1.Idade} -> {pessoaClass2.Nome} {pessoaClass2.Idade} | Resultado: {pessoaClass1 == pessoaClass2}");
//Console.WriteLine($"{pessoaClass1.Nome} {pessoaClass1.Idade} -> {pessoa3.Nome} {pessoa3.Idade} | Resultado: {pessoa1 == pessoa3}");


////Clonagem com o operador with
//var pessoa4 = new Records.PessoaRecord("João", 30);
//var pessoa5 = pessoa4 with { Nome = "Maria" };

//Console.WriteLine();
//Console.WriteLine("Clonagem com o operador with:");
//Console.WriteLine($"Record base: {pessoa4}");
//Console.WriteLine($"Record clonado com alteração: {pessoa5}");


////Desconstrução
//var pessoa6 = new Records.PessoaRecord("José", 20);
//var (nome, idade) = pessoa6;

//Console.WriteLine();
//Console.WriteLine("Resultado do Desconstrutor:");
//Console.WriteLine($"{nome} - {idade}"); // José, 20

#endregion

#region With Expression

#endregion

#endregion

#region Features C# 10

#region Constant Interpolated Strings
//Console.WriteLine("Constant Interpolated Strings - C# 10");
//ConstantInterpolatedStrings.Validar();

//ConstantInterpolatedStrings.ValidarSwitchConstante();

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

#region GlobalUsing
// Mostrar arquivo e explicar
#endregion

#region FileScopedNamespace
// Mostrar arquivo e explicar
#endregion

#endregion

#region Features C# 11

#region List Patterns
//Console.WriteLine("List Patterns - C# 11");
//var numeros = new int[3] { 1, 2, 3 };
//ListPatterns.Validar(numeros);

#endregion

#region Required Member

//Console.WriteLine("Required Member - C# 11");
//var cachorro = new RequiredMembers.Cachorro
//{
//    Nome = "Rex",
//    Especie = "Canina",
//    Raca = "Labrador"
//};


// Propriedades Nome e Raca devem ser inicializada no construtor
//var cachorroRequired = new RequiredMembers.Cachorro
//{
//    Especie = "Canina"
//};
//Console.WriteLine($"Espécie: {cachorro.Especie} | Raça: {cachorro.Raca}");

#endregion

#region Static Abastract Member
//Console.WriteLine("Static Abastract Member - C# 11");
//// Criando instâncias usando o método estático da interface
//IRepository usuarioRepo = UsuarioRepository.Criar();
//IRepository produtoRepo = ProdutoRepository.Criar();

//// Acessando propriedades estáticas
//Console.WriteLine($"Repositório Criado: {UsuarioRepository.NomeColecao}");  // Saída: Usuarios
//Console.WriteLine($"Repositório Criado: {ProdutoRepository.NomeColecao}");  // Saída: Produtos
#endregion

#endregion

#region Features C# 12

#region Primary Constructors Non Record Types
//Console.WriteLine("Primary Constructors Non Record Types - C# 12");
//PrimaryConstructorsNonRecordTypes.Validar();
#endregion

#region Collection Expressions
//Console.WriteLine("Collection Expressions - C# 12");
//CollectionExpressions.Validar();
#endregion

#region InlineArrays
//Console.WriteLine("Inline Arrays - C# 12");
//InlineArrayNumbers numbers = default;

//// Acessando os elementos
//numbers[0] = 10;
//numbers[1] = 20;
//numbers[2] = 30;

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(numbers[i]); // Saída: 10, 20, 30
//}

#endregion

#endregion

#region Features C# 13
#region ScopedLock
//Console.WriteLine("Scoped Lock - C# 13");
//ScopedLock.ValidarLockGenerico();
//ScopedLock.ValidarNewLock();
#endregion

#region Params Collection
//Console.WriteLine("Params Collection - C# 13");
//ParamsCollections.ContarNumeros(1, 2, 3);

//List<int> lista = [1, 2, 3, 4];
//var enumerable = Enumerable.Range(5, 5);
//var hashSet = (new HashSet<int> { 5, 6, 7, 8, 9, 10 });
//int[] array = [1, 2, 3, 4, 5, 6, 7];


//ParamsCollections.ContadorNumeros(lista);
//ParamsCollections.ContadorNumeros(enumerable);
//ParamsCollections.ContadorNumeros(hashSet);
//ParamsCollections.ContarNumeros(array);

#endregion

#endregion


Console.ReadLine();