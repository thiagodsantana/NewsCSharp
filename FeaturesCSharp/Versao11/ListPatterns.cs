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
            Console.WriteLine(numeros.ToString());
            if (numeros is [1, .., 3])
            {
                /*
                 * Significado da expressão:
                    - O array deve começar com o valor 1.
                    - O array deve terminar com o valor 3.
                    - O número de elementos entre o primeiro e o último (representado por ..) pode variar
                      e esses elementos são ignorados.

                * O que o compilador faz:
                    - Verifica se o primeiro elemento é igual a 1 (numeros[0] == 1).
                    - Verifica se o último elemento é igual a 3 (numeros[numeros.Length - 1] == 3).
                    - Permite qualquer número de elementos entre o primeiro e o último.

                    Verificações de comprimento = Array.Length ou propriedades similares para validar o tamanho do array.
                    Verificações de índice: O acesso aos elementos do array, como numeros[2] ou numeros[0], é traduzido em instruções de carregamento e comparação.

                Papelo do .. :
                    O .. é expandido para lidar com o intervalo de elementos intermediários sem acessá-los explicitamente.
                    Por exemplo, o segundo padrão ([1, .., 3]) pode ser traduzido conceitualmente para algo como:
                    
                    if (numeros.Length >= 2 && numeros[0] == 1 && numeros[numeros.Length - 1] == 3)
                    {
                        // Correspondência bem-sucedida
                    }

                 */
                Console.WriteLine("O array começa com 1 e termina com 3.");
            }
            else
            if (numeros is [_, _, 3])
            {
                /*
                 * Significado da expressão:
                    - O comprimento do array deve ser exatamente 3 elementos.
                    - O terceiro elemento (índice 2) deve ser igual a 3.
                    - Os dois primeiros elementos (numeros[0] e numeros[1]) podem ser qualquer valor (_ indica que são ignorados).

                * O que o compilador faz:
                    - Verifica se o tamanho do array é 3 (numeros.Length == 3).
                    - Verifica se numeros[2] == 3.

                Papel do _ :
                    _ É um padrão curinga (wildcard). 
                        Ele corresponde a qualquer valor e indica ao compilador que o valor não é relevante e será descartado.

                if (numeros.Length == 3 && numeros[2] == 3)
                {
                    // O padrão foi correspondido
                }

                 */
                Console.WriteLine("O array termina com 3.");
            }                       
            else
            {
                Console.WriteLine("Nenhum padrão correspondeu.");
            }
        }
    }
}
