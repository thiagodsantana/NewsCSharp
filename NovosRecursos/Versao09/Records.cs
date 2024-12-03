namespace NovosRecursos.Versao9
{
    internal class Records
    {
        public record Pessoa(string Nome, int Idade);

        /*
         * Resumo: 
         * Gera uma classe imutável com construtor;
         * Propriedades de somente leitura (init);
         * Métodos de igualdade por valor (Equals e GetHashCode);
         * Suporte a clonagem com o operador with e ToString() personalizado.
        */

        //public class Pessoa
        //{
        //    public string Nome { get; init; }
        //    public int Idade { get; init; }

        //    public Pessoa(string nome, int idade)
        //    {
        //        Nome = nome;
        //        Idade = idade;
        //    }

        //    public bool Equals(Pessoa pessoa) =>
        //        pessoa is not null && Nome == pessoa.Name && Idade == pessoa.Age;

        //    public override int GetHashCode() =>
        //        HashCode.Combine(Nome, Idade);

        //    public override string ToString() =>
        //        $"Pessoa {{ Nome = {Nome}, Idade = {Idade} }}";
        //}


        public Records()
        {
            // Imutabilidade
            var pessoa = new Pessoa("João", 30);
            //pessoa.Nome = "Maria"; // Erro: 'Nome' é uma propriedade de somente leitura.

            //Comparação estrutural
            var pessoa1 = new Pessoa ("João", 30);
            var pessoa2 = new Pessoa ("João", 30);

            Console.WriteLine(pessoa1 == pessoa2); // True

            //Clonagem com o operador with
            var pessoa3 = new Pessoa ("João", 30);
            var pessoa4 = pessoa1 with { Nome = "Maria" };

            Console.WriteLine(pessoa4); // Pessoa { Nome = Maria, Idade = 30 }


            //Desconstrução
            var pessoa5 = new Pessoa("José", 20);
            var (nome, idade) = pessoa5;

            Console.WriteLine($"{nome}, {idade}"); // José, 20

        }
    }
}
