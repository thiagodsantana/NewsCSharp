namespace FeaturesCSharp.Versao10
{
    public static class ConstantInterpolatedStrings
    {
        public const string VersaoAntiga = "1.0";
        public const string VersaoNova = "2.0";
        public const string Upgrade = $"{VersaoAntiga} => {VersaoNova}";

        /*
         * Resumo: Permitem que strings interpoladas sejam declaradas como const, desde que todos os componentes sejam constantes.
            * Benefícios:
                *   O compilador resolve a interpolação em tempo de compilação.
                *   Facilidade na inicialização de constantes;
                *   Atributos e switch case, simplificando cenários que antes exigiam concatenação manual.                                                  
        */

        public static void Validar()
        {
            /*
             * Inicialização de constantes
             */
            Console.WriteLine();
            Console.WriteLine("Uso de Constant Interpolated Strings na inicialização");
            const string nome = "João";
            const string sobrenome = "Silva";
            const string nomeCompleto = $"{nome} {sobrenome}";

            Console.WriteLine($"Nome completo formado por constantes: {nomeCompleto}");  // Saída: João Silva            
            MetodoAntigo();
        }

        [Obsolete($"Método obsoleto. Efetuar o upgrade {Upgrade}")]
        static void MetodoAntigo()
        {
            Console.WriteLine("Este método está obsoleto.");
        }

        public static void ValidarSwitchConstante()
        {
            Console.WriteLine();
            Console.WriteLine("Uso de Constant Interpolated Strings com switch");
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

            /*
             * Como o compilador intepreta:
                - Verifica se todos os elementos dentro da string interpolada são constantes;
                - Valor final é calculado e armazenado como um literal diretamente no código compilado.
                - O valor calculado é tratado como uma constante literal na saída do IL(Intermediate Language).
                - Não há chamadas de método ou lógica de interpolação em tempo de execução.
             */
        }
    }
}
