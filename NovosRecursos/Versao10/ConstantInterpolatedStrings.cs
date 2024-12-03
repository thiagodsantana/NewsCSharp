namespace NovosRecursos.Versao10
{
    internal class ConstantInterpolatedStrings
    {
        /*
         * Resumo: 
         
         * Permitem que strings interpoladas sejam declaradas como const, desde que todos os componentes sejam constantes.
         * O compilador resolve a interpolação em tempo de compilação.
         * São úteis em:
            * Inicialização de constantes;
            * Atributos e switch case, simplificando cenários que antes exigiam concatenação manual.      
            
        * Como o compilador intepreta:
            * Verifica se todos os elementos dentro da string interpolada são constantes;
            * Valor final é calculado e armazenado como um literal diretamente no código compilado.
            * O valor calculado é tratado como uma constante literal na saída do IL (Intermediate Language). 
            * Não há chamadas de método ou lógica de interpolação em tempo de execução.                        
        */

        public ConstantInterpolatedStrings()
        {
            /*
             * Inicialização de constantes
             */
            const string nome = "João";
            const string sobrenome = "Silva";
            const string nomeCompleto = $"{nome} {sobrenome}";

            Console.WriteLine(nomeCompleto);  // Saída: João Silva

            /*
             * Definição de valores em atributos
             */
            const string Author = "Alice";
            const string Version = "1.0";

            [System.Obsolete($"This method is deprecated by {Author} in version {Version}.")]
            void OldMethod()
            { 
                List<int> list = new();
                list.Sum();
            }
            
            /*
             * Uso de switch case
             */

            const string Saudacao = "Olá";
            const string Despedida = "Adeus";
            const string Nome = "Thiago";
            string entrada = "Olá, Thiago";

            switch (entrada)
            {
                case $"{Saudacao}, {Nome}":
                    Console.WriteLine("Recebida uma saudação!");
                    break;

                case $"{Despedida}, {Nome}":
                    Console.WriteLine("Recebida uma despedida!");
                    break;

                default:
                    Console.WriteLine("Mensagem não reconhecida.");
                    break;
            }

        }
    }
}
