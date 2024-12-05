namespace FeaturesCSharp.Versao8
{
    /*
     * Resumo: Ajudar a evitar erros de referência nula (NullReferenceException) e melhorar a segurança e a confiabilidade do código.
            * Benefícios:
                *   Prevenção de Erros de Execução: O compilador pode ajudar a evitar falhas comuns como NullReferenceException.
                *   Maior clareza: Se torna mais claro e fácil de entender, já que as intenções do desenvolvedor ficam mais visíveis.
                *   Facilidade de Manutenção: Tipos mais rigoroso, a manutenção do código se torna mais segura, 
                       uma vez que o compilador ajuda a identificar problemas antes mesmo de o código ser executado.
     */
    public class TiposReferenciaAnulaveis
    {
        public void Validar()
        {
            /*
             * Como o compilador interpreta
                    * Ativação dos Tipos de Referência Anuláveis
                        - csproj <Nullable>enable</Nullable>
                        - #nullable enable (dúvida)
                    * Verificação de Nulos em Tempo de Compilação
                    * Uso de ? para Indicar Tipos Anuláveis
                    * Operadores de Nullability
                        -  operador ?. e o operador ??, que podem ser usados para verificar ou substituir valores nulos de forma mais segura.
                    * Desabilitando a Verificação de Tipos Nulos: Usar o operador ! para garantir que o compilador ignore a possibilidade de nulo em uma expressão.
             */


            /*
            ********************
            Uso do recurso Tipos de referência não anuláveis
            ********************
            */

            // Não anuláveis
            string nonNullableString = "Hello, World!";
            nonNullableString = null; // ERRO: Não pode ser nulo

            Console.WriteLine(nonNullableString); // Sem avisos do compilador

            /*
            ********************
            Uso do recurso Tipos de referência anuláveis
            ********************
            */
            
            string? nullableString = "Hello, Nullable!";
            nullableString = null; // OK: Pode ser nulo

            if (nullableString != null)
            {
                // O compilador sabe que nullableString não é nulo aqui
                Console.WriteLine(nullableString.Length);
            }

            // Usando o operador de anulação suprimida (!) - assumindo que não será nulo
            Console.WriteLine(nullableString!.Length); // AVISO suprimido, mas pode causar NullReferenceException se nullableString for nulo
        }
    }
}
