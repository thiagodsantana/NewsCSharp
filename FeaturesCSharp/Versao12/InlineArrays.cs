namespace FeaturesCSharp.Versao12
{
    internal class InlineArrays
    {
        /*
         * Resumo:  Uma nova maneira de criar e inicializar arrays diretamente em C#. 
                    Esta funcionalidade permite a declaração e inicialização de um array de maneira mais compacta, 
                        usando uma sintaxe simples de colchetes ([]), sem precisar de uma declaração explícita de tamanho do array.
            * Benefícios:
                *  Concorrência e Legibilidade: A sintaxe simplificada permite uma inicialização rápida e direta de arrays em qualquer lugar.
                *  Inferência de Tipo: O compilador infere automaticamente o tipo do array, o que economiza digitação e torna o código mais limpo.
                *  Melhor Integração com Expressões e Métodos: Ao criar arrays diretamente dentro de expressões ou chamadas de métodos, o código se torna mais conciso e flexível.
                * 
         */
        public InlineArrays()
        {
            // Definindo um array de forma simplificada (sem precisar de 'new')
            var numeros = [1, 2, 3, 4];
            var palavras = ["um", "dois", "três"];

            // Como o compilador interpreta:
            var numeros2 = new int[] { 1, 2, 3, 4 };
            var palavras2 = new string[] { "um", "dois", "três"};

            // Segurança nos tipos:
            var misturado = [1, "texto", 3.5];  // Erro de compilação


            Console.WriteLine(string.Join(", ", numeros));  // Saída: 1, 2, 3, 4

        }
    }
}
