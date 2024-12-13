namespace FeaturesCSharp.Versao8
{
    /*
     * Resumo:
        A principal vantagem dessas melhorias é tornar o código mais expressivo e conciso, 
            permitindo fazer correspondências de padrões em tipos complexos de forma mais direta e legível.
        Permitem que você utilize padrões de maneira mais poderosa com switch, is, e outras estruturas.
        Padrões podem ser usados para:
            Testar tipos (com is e switch).
            Combinar condições (com when).
            Desestruturar tipos (como tuplas ou classes).

            Benefícios:
                * Código Mais Simples e Conciso
                * Melhora na Legibilidade
                * Desestruturação de Tipos Complexos
     */
    public static class PatternMatchingAvancado
    {
        public record Pessoa(string Nome, int Idade);                
    }
}
