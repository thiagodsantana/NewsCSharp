namespace FeaturesCSharp.Versao12
{
    internal class CollectionExpressions
    {
        /*
         * Resumo:
            * Benefícios:
                * Legibilidade: 
                    *   Código mais limpo
                * Redução de Boilerplate:
                    *   Menos necessidade de código adicional para inicialização de coleções.
                * Unificação de Sintaxe: 
                    *   Facilita a transição entre diferentes tipos de coleções
            * Limitações:
                    *   Compatibilidade: O tipo deve implementar ICollection<T> ou IReadOnlyCollection<T>
                    *   Limitações de Sintaxe: Ainda em preview
         */
        public CollectionExpressions()
        {
            // Criação de listas
            var listaCE = [10, 20, 30];
            Console.WriteLine(string.Join(", ", listaCE)); // Saída: 10, 20, 30

            // Intepretação do compilador
            var lista = new List<int> { 10, 20, 30 };


            // Criação de dicionários
            var dicionarioCE = ["um" => 1, "dois" => 2];
            Console.WriteLine(dicionarioCE["um"]); // Saída: 1

            // Interpretação do compilador
            var dicionario = new Dictionary<string, int>
            {
                { "um", 1 },
                { "dois", 2 }
            };
        }
    }
}
