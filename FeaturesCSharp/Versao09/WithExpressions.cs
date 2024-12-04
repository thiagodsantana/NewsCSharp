namespace FeaturesCSharp.Versao9
{
    /*
         * Resumo: Oferecem uma maneira conveniente de criar uma nova instância de um objeto baseado em uma instância existente, 
               mas com algumas propriedades modificadas.
                * Benefícios:      
                    * Imutabilidade: Mantém a imutabilidade dos objetos, criando novos objetos com base nos valores existentes.
                    * Código mais limpo: Simplifica a criação de objetos modificados sem a necessidade de chamar um construtor manualmente com valores repetidos.
                    * Facilidade de uso com records: Como os records já possuem imutabilidade e comparação baseada em valor, as with expressions funcionam perfeitamente para modificar objetos de maneira segura e eficaz.:    
        */
    internal class WithExpressions
    {
        public record Pessoa(string Nome, int Idade);        

        public void Validar()
        {
            var pessoa = new Pessoa("João", 25);

            // Criar uma cópia de 'pessoa1' com a idade alterada
            var pessoaCopy = pessoa with { Idade = 30 };

            Console.WriteLine(pessoa);  // Saída: Pessoa { Nome = João, Idade = 25 }
            Console.WriteLine(pessoaCopy);  // Saída: Pessoa { Nome = João, Idade = 30 }

            /*
             * Como o compilador interpreta
                    * Gera um método especial chamado Clone, que cria uma cópia superficial do objeto. 
                    * A cópia é então modificada com as propriedades especificadas na expressão with.
                    *  O tipo deve ser um record ou outro tipo que tenha suporte explícito ao método Clone e propriedades setáveis.
         
            * Como funciona:
                    * O compilador chama o método Clone para criar uma cópia superficial de person1.
                    * Em seguida, ele altera a propriedade Age da cópia, criando person2.
                    
            
            Código Intermediate Language
             // Criação de pessoa1
            .newobj instance void Persona::.ctor(string, int32)  // Chama o construtor de Persona para pessoa1

            // Criando pessoa2 usando 'with'
            ldarg.0                               // Load pessoa1
            ldstr "João"                           // Load string "João"
            ldc.i4 25                              // Load int32 25
            newobj instance void Persona::.ctor(string, int32)  // Cria pessoa1

            // Modificando apenas o campo 'Idade' ao criar uma nova instância
            ldarg.0                               // Load pessoa1
            ldc.i4 30                              // Load int32 30
            newobj instance void Persona::.ctor(string, int32)  // Cria uma nova instância com Idade = 30

                   
             */
        }
    }
}
