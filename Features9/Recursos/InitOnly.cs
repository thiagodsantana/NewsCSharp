namespace FeaturesCSharp.Versao9
{
    /*
     * Resumo:  Utilizado para permitir que as propriedades de uma classe ou struct sejam definidas apenas durante a inicialização
        do objeto, mas não possam ser alteradas depois que o objeto é criado. (Imutabilidade)     
            * Benefícios:
                *   Imutabilidade: Maneira simples e segura de criar objetos imutáveis, pois as propriedades podem ser atribuídas apenas uma vez durante a criação do objeto.   
                *   Segurança de Dados: Garante que o estado do objeto não será modificado acidentalmente após a criação, melhorando a integridade dos dados.
                *   Facilidade de Uso: Permite a criação de objetos de forma concisa e expressiva, sem a necessidade de criar um construtor complexo.
    */
    public static class InitOnly
    {
        public class Config
        {
            public string ConnectionString { get; init; }
            public int MaxConnections { get; init; }            
        }

        /* Código interpretado pelo compilador
         *  O compilador trata as propriedades init de forma especial:
                - Cria campos de suporte para armazenar os valores.
                - Implementa um set accessor restrito que só funciona na inicialização do objeto.
                - Impede modificações após a inicialização, promovendo imutabilidade.
                - Faz verificações de tipo e nulidade em tempo de compilação, melhorando a segurança do código.

         * 
         public class Config
        {
            private string _connectionString;
            private int _maxConnections;

            public string ConnectionString
            {
                get => _connectionString;
                init => _connectionString = value;
            }

            public int MaxConnections
            {
                get => _maxConnections;
                init => _maxConnections = value;
            }
        }
         */
    }
}
