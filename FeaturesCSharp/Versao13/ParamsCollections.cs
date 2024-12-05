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
    internal class ParamsCollections
    {
        public void Adicionar(params IEnumerable<int> numeros)
        {
            foreach (var numero in numeros)
                Console.WriteLine(numero);
        }

        public void Validar()
        {
            var lista = new List<int> { 1, 2, 3, 3, 4, 5 };
            var array = new[] { 1, 2, 3, 3, 4, 5};
            Adicionar(lista); // Verifica a compatibilidade do tipo (implementa interface IEnumerable<int>) e chama o método sem realizar conversões adicionais.
            Adicionar(array); // Verifica a compatibilidade do tipo e chama o método sem realizar conversões adicionais.
            Adicionar(1,2,3,4,5); // Interpreta isso como uma matriz implícita (int[]) e a encapsula como um array que implementa IEnumerable<int>.
        }
    }
}
