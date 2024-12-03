using System.Linq.Expressions;

namespace NovosRecursos.Versao8
{
    public class IndicesFaixas
    {
        public IndicesFaixas()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            /* ================================================================
                                 Uso do recurso Index
             ================================================================*/

            int ultimo = array[^1];  // => Retorna o último elemento da coleção

            // Conversão da Expressão:
            var index = new Index(1, fromEnd: true);
            ultimo = array[index]; // último elemento

            // Interpretação do compilador
            ultimo = array[array.Length - 1]; // Como o compilador interpreta


            /* ================================================================
                                    Uso do recurso Range
              ================================================================*/

            var subArray = array[1..3];  // => Retorna o intervalo de valores da coleção

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
