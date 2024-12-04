namespace FeaturesCSharp.Versao11
{
    internal class ListPatterns
    {
        /*
         Resumo:
            * Otimização de Acessos: usa acesso direto a propriedades e indexadores, evitando iterações desnecessárias.
            * Eficiência no Rest Pattern (..): Elementos intermediários são ignorados sempre que possível, minimizando operações desnecessárias.
            * Mensagem de Erro em Tempo de Compilação: Se o tipo numeros não suportar as operações necessárias (como Length ou indexação), o compilador gera erros.
         */

        void TestarPadrao(int[] numeros)
        {
            if (numeros is [_, _, 3])
            {
                //1 - Comprimento do array é pelo menos 3.
                //2 - Terceiro elemento(numeros[2]) é 3.
                //3 - Primeiros dois elementos(_) são ignorados.
                Console.WriteLine("O array termina com 3.");
            }
            else if (numeros is [1, .., 3])
            {
                //1 - Começa com 1 (numeros[0])
                //2 - Termina com 3(numeros[n - 1])
                //3 - Ignora os elementos intermediários
                Console.WriteLine("O array começa com 1 e termina com 3.");
            }
            else
            {
                Console.WriteLine("Nenhum padrão correspondeu.");
            }
        }
    }
}
