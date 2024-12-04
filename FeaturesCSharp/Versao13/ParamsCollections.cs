namespace FeaturesCSharp.Versao13
{
    internal class ParamsCollections
    {
        public ParamsCollections()
        {
            void Adicionar(params int[] numeros)
            {
                /* ... */
            }

            Adicionar(1, 2, 3); // Aloca um array para agrupar os parâmetros.

            Adicionar(stackalloc[] { 1, 2, 3 }); // Usa `Span<int>` sem alocar no heap.



        }
    }
}
