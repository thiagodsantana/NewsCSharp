namespace NovosRecursos.Versao11
{
    internal class GenericAttributes
    {
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

    }
}
