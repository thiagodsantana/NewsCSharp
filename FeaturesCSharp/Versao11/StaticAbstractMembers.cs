namespace FeaturesCSharp.Versao11
{
    /*
     * Resumo: Esse recurso permite que interfaces definam métodos ou propriedades abstratas que são estáticos 
                e precisam ser implementados por tipos que implementam a interface.
              Com esse recurso temos mais controle sobre como as classes implementadoras interagem com os membros estáticos, 
                tornando o código mais modular, reutilizável e fácil de manter.

            * Benefícios:
                 * Contratos Mais Expressivos
                 * Facilidade em Criar Tipos Genéricos
                 * Maior Flexibilidade e Reusabilidade de Código
     */
    internal class StaticAbstractMembers
    {
        public interface IRepository
        {
            // Método estático abstrato para criação de instâncias
            static abstract IRepository Criar();

            // Propriedade estática abstrata para nome da coleção
            static abstract string NomeColecao { get; }
        }

        public class UsuarioRepository : IRepository
        {
            // Implementação do método estático para criar instâncias
            public static IRepository Criar() => new UsuarioRepository();

            // Implementação da propriedade estática para nome da coleção
            public static string NomeColecao => "Usuarios";
        }

        public class ProdutoRepository : IRepository
        {
            // Implementação do método estático para criar instâncias
            public static IRepository Criar() => new ProdutoRepository();

            // Implementação da propriedade estática para nome da coleção
            public static string NomeColecao => "Produtos";
        }

        class Program
        {
            static void Main()
            {
                // Criando instâncias usando o método estático da interface
                IRepository usuarioRepo = UsuarioRepository.Criar();
                IRepository produtoRepo = ProdutoRepository.Criar();

                // Acessando propriedades estáticas
                Console.WriteLine(UsuarioRepository.NomeColecao);  // Saída: Usuarios
                Console.WriteLine(ProdutoRepository.NomeColecao);  // Saída: Produtos
            }
        }

        /*
         * Como o compilador interpreta
            * Análise da Interface
            * Análise das Classes que herdam 
            * Verificação de Chamada de Membros Estáticos
            * Geração do Código IL (Intermediate Language)
                * O método Criar() será tratado como um método estático que pode ser chamado diretamente pela classes
                e a propriedade NomeColecao será uma propriedade estática acessada diretamente pela classe.
         */
    }
}
