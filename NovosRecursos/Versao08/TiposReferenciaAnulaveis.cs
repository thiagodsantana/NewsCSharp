namespace NovosRecursos.Versao8
{
    #nullable enable // Habilitando tipos de referência anuláveis
    public class TiposReferenciaAnulaveis
    {
        public TiposReferenciaAnulaveis()
        {
            /* ================================================================
               Uso do recurso Tipos de referência não anuláveis e anuláveis
            ================================================================*/

            // Não anuláveis
            string nonNullableString = "Hello, World!";
            nonNullableString = null; // ERRO: Não pode ser nulo

            Console.WriteLine(nonNullableString); // Sem avisos do compilador

            // Tipos de referência anuláveis
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
