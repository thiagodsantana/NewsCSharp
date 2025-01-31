namespace FeaturesCSharp.Versao13
{
    /*
     * Resumo:  Simplifica o código e melhora o desempenho ao permitir que coleções sejam passadas diretamente para métodos que utilizam params. 
       É uma evolução que facilita o trabalho com coleções em cenários modernos de desenvolvimento.
            * Benefícios: 
                *   Flexibilidade: Métodos com params agora suportam diretamente  listas, coleções e spans.
                *   Desempenho: Ao suportar tipos como Span e ReadOnlySpan, o consumo de memória é reduzido.
                *   Melhor Integração com LINQ: Permite passar coleções resultantes de consultas LINQ sem conversões adicionais.
     */
    public static class ParamsCollections
    {
        public static void ContarNumeros(params int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine($"Compilador interpreta e encapsula => Type: {numeros.GetType().Name}");
            Console.WriteLine($"Quantidade de números {numeros.Count()}");
        }

        public static void ContadorNumeros(params Span<int> numeros)
        {
            Console.WriteLine();
            //Console.WriteLine($"Compilador verifica compatibilidade de Type: {numeros.GetType().Name} (implementa interface IEnumerable<int>)");
            Console.WriteLine("Executa o método sem realizar conversões adicionais");
            //Console.WriteLine($"Quantidade de números {numeros.Count()}");            
        }        
    }
}
