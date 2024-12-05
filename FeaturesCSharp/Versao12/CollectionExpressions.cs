namespace FeaturesCSharp.Versao12
{
    internal class CollectionExpressions
    {
        /*
         * Resumo: Recurso criado com o intuito de simplificar a criação e inicialização de coleções como listas, 
                   dicionários, e conjuntos de maneira mais concisa e legível.
            * Benefícios:
                * Legibilidade: Código mais limpo
                * Redução de Boilerplate: Menos necessidade de código adicional para inicialização de coleções.
                * Unificação de Sintaxe: Facilita a transição entre diferentes tipos de coleções
            * Limitações:
                    *   Compatibilidade: O tipo deve implementar ICollection<T> ou IReadOnlyCollection<T>
                    *   Limitações de Sintaxe: Ainda em preview
         */
        public void Validar()
        {
            /*
             * C# 10 e versões anteriores
             */

            // List
            List<int> listaCsharp10 = new() { 10, 20, 30 };

            //Dictionary
            Dictionary<string, int> dicionarioCsharp10 = new()
            {
                { "um", 1 },
                { "dois", 2 }
            };


            /*
             * C# 11
             */
            List<int> listaCsharp11 = [10, 20, 30];
            // Intepretação do compilador
            List<int> lista = new List<int> { 10, 20, 30 };


            //var dicionario = { "um": 1, "dois": 2};

        }
    }
}
