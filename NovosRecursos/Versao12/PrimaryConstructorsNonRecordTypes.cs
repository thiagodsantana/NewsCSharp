namespace NovosRecursos.Versao12
{
    public class Pessoa(string nome, int idade)
    {
        public string Nome { get; } = nome;
        public int Idade { get; } = idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }

    ////var pessoa = new Pessoa("Maria", 30);
    ////pessoa.ExibirInfo();  // Saída: Nome: Maria, Idade: 30
 
}
