namespace FeaturesCSharp.Versao11
{
    public class RequiredMembers
    {
        public class Pedido
        {
            //[RequiredMemberAtribute]: Esse atributo sinaliza que a inicialização desses membros é obrigatória.

            //Compilador interpreta required como:
            //[RequiredMemberAttribute]
            public required int Numero { get; init; }

            //Compilador interpreta required como:
            //[RequiredMemberAttribute]
            public required string Cliente { get; init; }


            //Se a classe possuir um construtor, o compilador adiciona o atributo SetsRequiredMembers a ele.
            //Esse atributo indica que o construtor inicializa todos os membros obrigatórios, dispensando verificações adicionais.
            //[SetsRequiredMembers]
            public Pedido()
            {
                Numero = 0;
                Cliente = string.Empty;
            }
        }

        public void Validar()
        {
            var pedidoValido = new Pedido
            {
                Cliente = "Thiago Darlei",
                Numero = 1988
            };

            /*
             * Obrigatorio inicializar a propriedade Cliente
             */
            //var pedidoInvalido = new Pedido
            //{
            //    Numero = 1999
            //};
        }
    }
}
