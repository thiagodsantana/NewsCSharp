namespace NovosRecursos.Versao11
{
    internal class GenericAttributes
    {
        /*
            * Interpretação pelo compilador: O compilador trata Generic Attributes como instâncias genéricas de classes que herdam de Attribute, 
            *   gerando código IL e metadados que armazenam o tipo genérico e os argumentos.

            * Metadados: Os parâmetros genéricos são armazenados e podem ser acessados por reflexão em tempo de execução.

            * Impacto no Código: O recurso melhora a expressividade e flexibilidade do C#, mantendo o comportamento consistente com outros atributos.
         */

        // Definição de um atributo genérico
        public class ValidarTipoAttribute<T> : Attribute
        {
            public bool Validar(T valor)
            {
                return valor != null;
            }
        }

        // Aplicando o atributo a uma classe
        [ValidarTipo<string>]
        public class Pessoa
        {
            public required string Nome { get; set; }
        }

        // Aplicando o atributo a uma classe
        [ValidarTipo<int>]
        public class Casa
        {
            public required int Numero { get; set; }
        }

    }
}
