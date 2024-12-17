using System.Runtime.CompilerServices;

namespace FeaturesCSharp.Versao12
{
    public static class InlineArrays
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

        [System.Runtime.CompilerServices.InlineArray(3)]
        //[InlineArray(3)] // é usado para definir um array "in-line" dentro de uma estrutura. (Apenas struct)
        public struct InlineArrayNumbers
        {
            private int _dummy; // (_dummy) representa o início do array e serve de base para os elementos subsequentes.
        }

        /*
         * Comportamento:
                O array fica diretamente contido dentro da estrutura.   
                Evita alocações separadas na heap.
                Pode ser acessado usando indexadores ([]) como arrays normais.
         */
    }
}
