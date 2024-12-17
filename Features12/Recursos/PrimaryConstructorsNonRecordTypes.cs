namespace FeaturesCSharp.Versao12
{
    public static class PrimaryConstructorsNonRecordTypes
    {
        /*
      * Resumo: Recurso que oferece uma sintaxe mais concisa e expressiva para inicializar objetos. 
            Em vez de definir um método construtor tradicional, você declara um construtor primário diretamente na assinatura da classe, 
            especificando os parâmetros e as propriedades que serão inicializadas.​
          Benefícios: 
             * Código Mais Limpo
             * Melhora a Legibilidade: Fica claro desde a definição do tipo quais valores são necessários para sua inicialização.
             * Consistência: Alinha-se ao padrão já existente com Record Type
          Limitações
             * Sem Inicialização Pós-Criação: Membros devem ser inicializados diretamente no construtor ou no corpo da classe.
             * Dependência de Versões Recentes: Requer C# 12 e .NET 8 ou superior.
      */

        public record PedidoRecord(int NumeroPedido, DateTime DataPedido);
        public class PedidoPrimaryConstructor(int NumeroPedido, DateTime DataPedido);

        public class PedidoPrimaryConstructorComPropertysAcesso(int numeroPedido, DateTime dataPedido)
        {
            // Definição propriedades de acesso são necessárias diferente do uso
            // de records e structs que as propiedades ja ficam acessíceis
            public int NumeroPedido { get; } = numeroPedido;
            public DateTime DataPedido { get; } = dataPedido;

            public PedidoPrimaryConstructorComPropertysAcesso() : this(numeroPedido: 0, dataPedido: DateTime.Now)
            {

            }

            public override string ToString()
            {
                return $"Número Pedido: {NumeroPedido} - Data: {DataPedido}";
            }
        }

        public static void Validar()
        {
            Console.WriteLine();
            var pedidoPrimaryConstrutor = new PedidoPrimaryConstructor(100, DateTime.Now);
            Console.WriteLine("Gerando Pedido com PrimaryConstructor => Propriedades não acessíveis");
            Console.WriteLine(pedidoPrimaryConstrutor);
            //pedidoClassAnemica.DataPedido -> Não acessível

            Console.WriteLine();
            var PedidoPrimaryConstructorComPropertysAcesso = new PedidoPrimaryConstructorComPropertysAcesso(10, DateTime.Now);
            Console.WriteLine($"Gerando Pedido com PrimaryConstructor => Foi implementada propridades de acesso");
            Console.WriteLine(PedidoPrimaryConstructorComPropertysAcesso.ToString());

            Console.WriteLine();
            var pedidoRecord = new PedidoRecord(10, DateTime.Now);
            Console.WriteLine("Gerando Pedido com Record => Todas as propriedades acessíveis");
            Console.WriteLine(pedidoRecord.ToString());
        }
    }
}
