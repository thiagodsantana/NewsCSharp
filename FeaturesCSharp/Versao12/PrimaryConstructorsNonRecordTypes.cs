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

        public record PedidoRecord(int NumeroPedido, DateTime DataPedido);
        public class PedidoClassAnemica(int NumeroPedido, DateTime DataPedido);

        public class PedidoClass(int numeroPedido, DateTime dataPedido)
        {
            // Definição propriedades de acesso são necessárias diferente do uso
            // de records e structs que as propiedades ja ficam acessíceis
            public int NumeroPedido { get; } = numeroPedido;
            public DateTime DataPedido { get; } = dataPedido;

            public PedidoClass() : this(numeroPedido: 0, dataPedido: DateTime.Now)
            {

            }

            public override string ToString()
            {
                return $"{NumeroPedido} - {DataPedido}";
            }
        }

        public void Validar()
        {
            var pedidoClassAnemica = new PedidoClassAnemica(100, DateTime.Now);
            //pedidoClassAnemica.DataPedido -> Não acessível

            var pedidoClass = new PedidoClass(10, DateTime.Now);
            Console.WriteLine($"Data do pedido {pedidoClass.DataPedido}");
            var pedido = new PedidoClass();

            var pedidoRecord = new PedidoRecord(10, DateTime.Now);
            Console.WriteLine(pedidoRecord.DataPedido.ToString());
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
