namespace FeaturesCSharp.Versao12
{
    internal class InterpolatedStringImprovements
    {
        int a = 18;
        int b = 20;

        public InterpolatedStringImprovements()
        {
            var mensagem = $"A soma de {a} e {b} é {a + b}";
            Console.WriteLine(mensagem);
        }
    }
}
