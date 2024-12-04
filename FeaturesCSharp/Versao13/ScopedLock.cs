namespace FeaturesCSharp.Versao13
{
    /*
     * Resumo:
        * Benefícios:
            *   Menos Erros: O bloqueio é liberado automaticamente ao sair do escopo.
            *   Código Mais Limpo: Elimina a necessidade de gerenciar manualmente lock ou Monitor.Enter/Exit.
            *   Eficiência: Melhor integrado aos padrões de uso moderno no C#.
     */
    internal class ScopedLock
    {
        class ContadorSeguro
        {
            private int contador = 0;
            private readonly Lock bloqueio = new();

            public void Incrementar()
            {
                using (bloqueio.Acquire())
                {
                    contador++;
                }
            }

            public int Valor => contador;
        }

        // Código gerado pelo comiplador:

        ////LockHandle lockHandle = null;
        ////try
        ////{
        ////    lockHandle = myLock.Acquire();
        ////    // Código protegido por bloqueio
        ////}
        ////finally
        ////{
        ////    if (lockHandle != null)
        ////        lockHandle.Dispose();
        ////}


    }
}
