namespace FeaturesCSharp.Versao12
{
    public static class CollectionExpressions
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
        public static void Validar()
        {
            // Arrays (sem precisar de 'new')
            Console.WriteLine();
            int[] numeros = [1, 2, 3, 4];
            Console.WriteLine("Array - Collection Expression");
            Console.WriteLine($"Variável declarada: int[] numeros = [1, 2, 3, 4];");
            Console.WriteLine($"Interpretação do compilador var numeros2 = new int[] {{ 1, 2, 3, 4 }};");
            Console.WriteLine("Iterando pelo array que foi declarado utilizando Collection Expression");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            // Como o compilador interpreta:
            var numeros2 = new int[] { 1, 2, 3, 4 };

            // List
            Console.WriteLine();
            List<int> listaCsharp11 = [10, 20, 30];
            Console.WriteLine("List - Collection Expression");
            Console.WriteLine($"Variável declarada: List<int> listaCsharp11 = [10, 20, 30];");
            Console.WriteLine($"Interpretação do compilador List<int> lista = new List<int> {{ 10, 20, 30 }};");
            Console.WriteLine("Iterando pela list que foi declarado utilizando Collection Expression");
            
            foreach (int i in listaCsharp11)
            {
                Console.WriteLine(i);
            }
        }
    }
}
