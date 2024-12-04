namespace FeaturesCSharp.Versao8
{
    /*
     * Resumo:
     *  Índices (Index) e faixas (Range) foram introduzidos para facilitar o acesso a subconjuntos de dados em coleções, 
        como arrays, listas e strings, de forma mais expressiva e legível.

            Benefícios:
                * Legibilidade: Código mais expressivo e intuitivo.
                * Menos Erros: Substitui cálculos manuais para acessar elementos.
                * Desempenho: Compatível com Span<T> e Memory<T>, permitindo acesso eficiente sem alocações.
     */

    public class IndicesFaixas
    {
        public void Validar()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            /*
             ********************
             Uso do recurso Index
             ********************
             */

            //Retorna o último elemento da coleção
            int ultimo = array[^1];  

            //Conversão da Expressão:
            var index = new Index(1, fromEnd: true);
            ultimo = array[index]; // último elemento

            //Interpretação do compilador
            ultimo = array[array.Length - 1]; // Como o compilador interpreta


            /*
             ********************
             Uso do recurso Range
             ********************
             */

            //Retorna o intervalo de valores da coleção
            var subArray = array[1..3]; 

            // Conversão da Expressão:
            var range = new Range(new Index(1, fromEnd: false), new Index(3, fromEnd: false));
            subArray = array[range];


            // Interpretação do compilador
            int[] slice = new int[3]; // O tamanho da fatia é 3 (de 1 a 3 inclusivo)
            Array.Copy(array, 1, slice, 0, 3); // Copia do índice 1 ao 3

            Console.WriteLine(ultimo);
            Console.WriteLine(subArray);
        }
    }
}
