using FeaturesCSharp.Versao9;
using static FeaturesCSharp.Versao9.InitOnly;

#region Features C# 9

#region InitOnly

Console.WriteLine("InitOnly - C# 9");

var config = new Config
{
    ConnectionString = "Server=myServer;Database=myDB;",
    MaxConnections = 10
};

//config.ConnectionString = "Server=myServer;Database=newDB;";  // Erro de compilação, pois 'ConnectionString' está definida como 'init'

#endregion

Console.WriteLine();

#region Record
Console.WriteLine("Record - C# 9");
Console.WriteLine();

//Comparação estrutural
var pessoa1 = new Records.PessoaRecord("Thiago Darlei", 36, [1,2]);
var pessoa2 = new Records.PessoaRecord("Thiago Darlei", 36, [1,2]);
var pessoa3 = new Records.PessoaRecord("Thiago Darlei", 30);

Console.WriteLine("Comparação Records:");
Console.WriteLine($"{pessoa1} -> {pessoa2} | Resultado: {pessoa1 == pessoa2}"); // True
// Se o record possuir reference type a comparação por valores pode não funcionar pois n tem implementado o metódo GetHash e Equal
Console.WriteLine($"{pessoa1} -> {pessoa3} | Resultado {pessoa1 == pessoa3}"); // False


Records.PessoaClass pessoaClass1 = new()
{
    Nome = "Thiago Darlei",
    Idade = 36,
};

Records.PessoaClass pessoaClass2 = new()
{
    Nome = "Thiago Darlei",
    Idade = 36,
};

Records.PessoaClass pessoaClass3 = new()
{
    Nome = "João",
    Idade = 30,
};

Console.WriteLine();
Console.WriteLine("Comparação Classes:");
Console.WriteLine($"{pessoaClass1.Nome} {pessoaClass1.Idade} -> {pessoaClass2.Nome} {pessoaClass2.Idade} | Resultado: {pessoaClass1 == pessoaClass2}");
Console.WriteLine($"{pessoaClass1.Nome} {pessoaClass1.Idade} -> {pessoa3.Nome} {pessoa3.Idade} | Resultado: {pessoa1 == pessoa3}");


//Clonagem com o operador with
var pessoa4 = new Records.PessoaRecord("João", 30);
var pessoa5 = pessoa4 with { Nome = "Maria" };
//var pessoa5 = new Records.PessoaRecord("Maria", pessoa4.Idade);


Console.WriteLine();
Console.WriteLine("Clonagem com o operador with:");
Console.WriteLine($"Record base: {pessoa4}");
Console.WriteLine($"Record clonado com alteração: {pessoa5}");


//Desconstrução
var pessoa6 = new Records.PessoaRecord("José", 20);
//var (nome, idade) = pessoa6;

Console.WriteLine();
Console.WriteLine("Resultado do Desconstrutor:");
//Console.WriteLine($"{nome} - {idade}"); // José, 20

#endregion

Console.WriteLine();

#region With Expression

#endregion

Console.ReadLine();

#endregion
