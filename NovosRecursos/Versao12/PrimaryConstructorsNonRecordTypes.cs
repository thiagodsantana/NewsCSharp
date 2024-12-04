namespace FeaturesCSharp.Versao12
{
    internal class PrimaryConstructorsNonRecordTypes
    {
        /*
      * Resumo:
          Benefícios: 
             * Código Mais Limpo
             * Melhora a Legibilidade: Fica claro desde a definição do tipo quais valores são necessários para sua inicialização.
             * Consistência: Alinha-se ao padrão já existente com Record Type
          Limitações
             * Sem Inicialização Pós-Criação: Membros devem ser inicializados diretamente no construtor ou no corpo da classe.
             * Dependência de Versões Recentes: Requer C# 12 e .NET 8 ou superior.
      */

        public class Pedido(int numeroPedido, DateTime dataPedido)
        {
            public int NumeroPedido { get; } = numeroPedido;
            public DateTime DataPedido { get; } = dataPedido;
        }

        /*
         * Código Gerado pelo compilador
                 public class Pedido
                 {
                    public int NumeroPedido { get; }
                    public DateTime DataPedido { get; }

                    public Pedido(int numeroPedido, DateTime dataPedido)
                    {
                        NumeroPedido = numeroPedido;
                        DataPedido = dataPedido;
                    }
                 }
         */
    }
}
