namespace NovosRecursos.Versao9
{
    internal class WithExpressions
    {
        public record Pessoa(string Nome, int Idade);

        /*
         * Resumo: 
         
         * Gera um método especial chamado Clone, que cria uma cópia superficial do objeto. 
         * A cópia é então modificada com as propriedades especificadas na expressão with.
            *  O tipo deve ser um record ou outro tipo que tenha suporte explícito ao método Clone e propriedades setáveis.
         
         * Como funciona:
            * O compilador chama o método Clone para criar uma cópia superficial de person1.
            * Em seguida, ele altera a propriedade Age da cópia, criando person2.
        */

        public WithExpressions()
        {
            var pessoa1 = new Pessoa("João", 25);

            // Criar uma cópia de 'pessoa1' com a idade alterada
            var pessoa2 = pessoa1 with { Idade = 30 };

            Console.WriteLine(pessoa1);  // Saída: Pessoa { Nome = João, Idade = 25 }
            Console.WriteLine(pessoa2);  // Saída: Pessoa { Nome = João, Idade = 30 }


        }
    }
}
