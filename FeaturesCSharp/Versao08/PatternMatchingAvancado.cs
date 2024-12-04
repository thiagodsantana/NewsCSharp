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
    public class PatternMatchingAvancado
    {
        public record Pessoa(string Nome, int Idade);        

        public void Validar()
        {
            //Sem pattern matching
            var obj = "teste";

            if (obj is string)
            {
                string str1 = (string)obj;
                Console.WriteLine(str1);
            }

            //Com pattern matching
            if (obj is string str2)
            {
                Console.WriteLine(str2);
            }

            Object valor = 10;
            if (valor is int i and >= 0 and <= 100)
            {
                /*
                    Compilador desmembra:
                        * Verifica se obj é do tipo int
                        * Se for, atribui obj à variável i.
                        * Em seguida, verifica se i está no intervalo de 0 a 100 
                 */
                Console.WriteLine($"Número dentro do intervalo: {i}");
            }


            Pessoa pessoa = new Pessoa("João", 30);
            if (pessoa is Pessoa { Idade: > 18 } pessoaMaiorIdade)
            {
                Console.WriteLine($"{pessoaMaiorIdade.Nome} é maior de idade.");
            }

            // Código gerado pelo compilador:
            if (pessoa is Pessoa pessoaMaiorIdade && pessoaMaiorIdade.Idade > 18)
            {
                Console.WriteLine($"{pessoaMaiorIdade.Nome} é maior de idade.");
            }

        }
    }
}
