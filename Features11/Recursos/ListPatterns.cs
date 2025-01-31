namespace FeaturesCSharp.Versao11
{
    public static class ListPatterns
    {
        /*
         Resumo: Funcionalidade que melhora a correspondência de padrões (pattern matching) em listas e arrays. 
                 Eles permitem verificar o conteúdo de coleções de maneira mais expressiva, simplificando o código ao lidar 
                 com estruturas de dados sequenciais.

            * Benefícios:
                * Otimização de Acessos: usa acesso direto a propriedades e indexadores, evitando iterações desnecessárias.
                * Eficiência no Rest Pattern (..): Elementos intermediários são ignorados sempre que possível, minimizando operações desnecessárias.
                * Mensagem de Erro em Tempo de Compilação: Se o tipo numeros não suportar as operações necessárias (como Length ou indexação), o compilador gera erros.
         */

        public static void Validar(int[] numeros)
        {
            // Exibindo o conteúdo do array
            Console.WriteLine($"Array: {string.Join(", ", numeros)}");

            // Com List Patterns
            if (numeros is [1, .., 3])
                Console.WriteLine("O array começa com 1 e termina com 3.");

            //Sem List Patterns
            if (numeros.Length >= 2 && numeros[0] == 1 && numeros[numeros.Length - 1] == 3)
                Console.WriteLine("O array começa com 1 e termina com 3.");

            // Com List Patterns [] = Verifica se está vazio e não nulo
            if (numeros is [])
                Console.WriteLine("O array está vazio.");

            //Sem List Patterns
            if (numeros.Length == 0)
                Console.WriteLine("O array está vazio.");

            //Com List Patterns
            if (numeros is [var primeiro, var segundo])
                Console.WriteLine($"O array tem exatamente 2 elementos: {primeiro} e {segundo}.");

            //Sem List Patterns
            if (numeros.Length == 2)
            {
                int primeiroElemento = numeros[0];
                int segundoElemento = numeros[1];
                Console.WriteLine($"O array tem exatamente 2 elementos: {primeiroElemento} e {segundoElemento}.");
            }

            //Com List Patterns
            if (numeros is [_, _, 3])
                Console.WriteLine("O array tem exatamente 3 elementos e o último é 3.");

            //Sem List Patterns
            if (numeros.Length == 3 && numeros[numeros.Length - 1] == 3)
                Console.WriteLine("O array tem exatamente 3 elementos e o último é 3.");

            //Com List Patterns
            if (numeros is [1, 2, 3])
                Console.WriteLine("O array contém exatamente [1, 2, 3].");

            //Sem List Patterns
            if (numeros.Length == 3 && numeros[0] == 1 && numeros[1] == 2 && numeros[2] == 3)
                Console.WriteLine("O array contém exatamente [1, 2, 3].");                        
        }
    }
}
