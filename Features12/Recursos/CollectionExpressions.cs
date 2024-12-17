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

            // Concatenação de Listas
            List<int> lista1 = [1, 2];
            List<int> lista2 = [3, 4];
            List<int> listaFinal = [.. lista1, .. lista2]; // [1, 2, 3, 4]

            /*
             * Interpretação do compilador
                ( .. ) é usado para desempacotar os elementos da coleção dentro da nova lista.
                List<int> lista1 = new List<int> { 1, 2 };
                List<int> lista2 = new List<int> { 3, 4 };
                List<int> listaFinal = new List<int>();

                listaFinal.AddRange(lista1); // Desempacota lista1
                listaFinal.AddRange(lista2); // Desempacota lista2

             */

            List<int> lista = [1, 2, 3, 4, 5];
            List<int> novaLista = [.. lista[0..^2], 99]; // [1, 2, 3, 99]
            /*
             * Interpretação do compilador
                ( .. ) é usado para desempacotar os elementos da coleção dentro da nova lista.
                List<int> subLista = lista.GetRange(0, lista.Count - 2); // Sublista [1, 2, 3]
                List<int> novaLista = new List<int>();

                novaLista.AddRange(subLista); // Adiciona [1, 2, 3] na nova lista.
                novaLista.Add(99);            // Adiciona 99 no final da nova lista.

             */                     
        }
    }
}
