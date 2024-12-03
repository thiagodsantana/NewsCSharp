namespace NovosRecursos.Versao11
{
    internal class RequiredMembers
    {
        public class Pessoa
        {
            public required string Nome { get; set; }
        }

        public RequiredMembers()
        {
            var pessoa = new Pessoa { Nome = "João" };
            Console.WriteLine(pessoa);
        }
    }
}
