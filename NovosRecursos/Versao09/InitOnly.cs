using System;

namespace NovosRecursos.Versao9
{
    public class InitOnly
    {
        public class Pedido
        {
            public int NumeroPedido { get; init; }
            //.set instance void Pedido::set_NumeroPedido(int32) { initonly }
            public DateTime DataPedido { get; init; }
            //.set instance void Pedido::set_DataPedido(valuetype[System.Private.CoreLib] System.DateTime) { initonly }
        }


        public InitOnly()
        {
            var pedido = new Pedido
            {
                NumeroPedido = 99999,
                DataPedido = DateTime.Now
            };

            // Tentativa de alterar depois de inicializar causa erro
            pedido.NumeroPedido = 1111; // Erro de compilação            

        }
    }
}
