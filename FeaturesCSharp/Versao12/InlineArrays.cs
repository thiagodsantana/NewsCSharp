using System.Runtime.CompilerServices;

namespace FeaturesCSharp.Versao12
{
    internal class InlineArrays
    {
        /*
         * Resumo:  É um aprimoramento voltado para melhorar o desempenho e a eficiência ao trabalhar com arrays em estruturas de baixo nível. 
         *          Ele se concentra em permitir a alocação de arrays "embutidos" diretamente dentro de estruturas, 
         *          evitando a alocação separada na heap e promovendo uma organização mais compacta na memória.
            * Benefícios:
                *  Concorrência e Legibilidade: A sintaxe simplificada permite uma inicialização rápida e direta de arrays em qualquer lugar.
                *  Inferência de Tipo: O compilador infere automaticamente o tipo do array, o que economiza digitação e torna o código mais limpo.
                *  Melhor Integração com Expressões e Métodos: Ao criar arrays diretamente dentro de expressões ou chamadas de métodos, o código se torna mais conciso e flexível.
                * 
         */


        [InlineArray(3)] // é usado para definir um array "in-line" dentro de uma estrutura. (Apenas struct)
        /*
         * Comportamento:
                O array fica diretamente contido dentro da estrutura.   
                Evita alocações separadas na heap.
                Pode ser acessado usando indexadores ([]) como arrays normais.
         */

        public struct InlineArrayNumbers
        {
            private int _dummy; // O compilador usa isso para embutir os elementos
        }


        public void Validar()
        {
            InlineArrayNumbers numbers = default;

            // Acessando os elementos
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]); // Saída: 10, 20, 30
            }
        }

    }
}
