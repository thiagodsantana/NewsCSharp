namespace NovosRecursos.Versao11
{
    internal class ListPatterns
    {
        public ListPatterns()
        {
            int[] numeros = { 1, 2, 3 };
            if (numeros is [1, 2, 3])
                Console.WriteLine("Padrão corresponde");

        }
    }
}
