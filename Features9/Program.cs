using FeaturesCSharp.Versao9;

#region Features C# 9

#region InitOnly

Console.WriteLine("InitOnly - C# 9");

InitOnly.Produto produto = new()
{
    Codigo = "1009",
    Nome = "Café"
};

produto.Nome = "Chá";  // Ok, pois 'Nome' tem 'set'
//produto.Codigo = "B456";  // Erro de compilação, pois 'Codigo' tem 'init'            

#endregion

Console.WriteLine();

#region Record
Console.WriteLine("Record - C# 9");
Console.WriteLine();
var pessoa = new Records.PessoaRecord("Thiago Darlei", 36);

//Comparação estrutural
var pessoa1 = new Records.PessoaRecord("Thiago Darlei", 36);
var pessoa2 = new Records.PessoaRecord("Thiago Darlei", 36);
var pessoa3 = new Records.PessoaRecord("Thiago Darlei", 30);

Console.WriteLine("Comparação Records:");
Console.WriteLine($"{pessoa1} -> {pessoa2} | Resultado: {pessoa1 == pessoa2}");
Console.WriteLine($"{pessoa1} -> {pessoa3} | Resultado {pessoa1 == pessoa3}");


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

Console.WriteLine();
Console.WriteLine("Clonagem com o operador with:");
Console.WriteLine($"Record base: {pessoa4}");
Console.WriteLine($"Record clonado com alteração: {pessoa5}");


//Desconstrução
var pessoa6 = new Records.PessoaRecord("José", 20);
var (nome, idade) = pessoa6;

Console.WriteLine();
Console.WriteLine("Resultado do Desconstrutor:");
Console.WriteLine($"{nome} - {idade}"); // José, 20

#endregion

Console.WriteLine();

#region With Expression

#endregion

Console.ReadLine();

#endregion
