using System.Reflection.PortableExecutable;

namespace NovosRecursos.Versao8
{
    public class PatternMatchingAvancado
    {
        public class Pessoa
        {
            public int Idade { get; set; }
            public string? Sexo { get; set; }
        }

        public string PatternMatchingExpression(object obj) => obj switch
        {
            int i when i > 0 => "Inteiro positivo", //Testa primeiro se obj é do tipo int e, em seguida, avalia a condição i > 0.
            int i when i == 0 => "Zero",
            int i => "Negativo",
            string s => $"A string: {s}",
            _ => "Unknown" // Interpreta _ como uma correspondência padrão (similar ao default do switch tradicional
        };


        public void PatternsCombinados(Object obj)
        {
            /*A expressão obj is int i and >= 0 and <= 100 é desmembrada em verificações sequenciais:
                Verifica se obj é do tipo int.
                Se for, atribui obj à variável i.
                Em seguida, verifica se i está no intervalo de 0 a 100.
             */
            if (obj is int i and >= 0 and <= 100)
            {
                Console.WriteLine($"Número dentro do intervalo: {i}");
            }
        }
    }
}
