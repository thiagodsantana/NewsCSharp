namespace FeaturesCSharp.Versao9
{
    public static class Records
    {
        public record PessoaRecord(string Nome, int Idade, int[]? valores = null);

        public class PessoaClass
        {
            public string? Nome { get; set; }
            public int Idade { get; set; }
        }

        

        /*
         * Resumo: São um tipo especial de classe que facilita a criação de objetos com sintaxte simplificada que por sua vez trabalham com comparação pelos valores, 
              e tem como benefícios a segurança dos dados por serem imutáveis. 

                * Benefícios:
                   * Sintaxe simplificada: Um record é mais compacta que a de uma classe, reduzindo a verbosidade do código.
                   * Imutabilidade: Os membros de um record são somente leitura, o que significa que, uma vez criados, não podem ser alterados.
                   * Desestruturação: suportam a desestruturação de maneira fácil, o que permite a extração de valores diretamente de suas propriedades.
                   * Comparação de igualdade: Classes comparam objetos pela referência (identidade), enquanto os records comparam objetos pelos valores de suas propriedades.                    
        */

        // Como o compilador interpreta
        //public class Pessoa
        //{
        //    public string Nome { get; init; }
        //    public int Idade { get; init; }

        //    public Pessoa(string nome, int idade)
        //    {
        //        Nome = nome;
        //        Idade = idade;
        //    }

        //    public bool Equals(Pessoa pessoa) =>
        //        pessoa is not null && Nome == pessoa.Name && Idade == pessoa.Age;

        //    public override int GetHashCode() =>
        //        HashCode.Combine(Nome, Idade);

        //    public override string ToString() =>
        //        $"Pessoa {{ Nome = {Nome}, Idade = {Idade} }}";
        //}        
    }
}
