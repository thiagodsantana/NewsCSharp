namespace FeaturesCSharp.Versao9
{
    /*
     * Resumo:  Utilizado para permitir que as propriedades de uma classe ou struct sejam definidas apenas durante a inicialização
        do objeto, mas não possam ser alteradas depois que o objeto é criado. (Imutabilidade)     
            * Benefícios:
                *   Imutabilidade: Maneira simples e segura de criar objetos imutáveis, pois as propriedades podem ser atribuídas apenas uma vez durante a criação do objeto.   
                *   Segurança de Dados: Garante que o estado do objeto não será modificado acidentalmente após a criação, melhorando a integridade dos dados.
                *   Facilidade de Uso: Permite a criação de objetos de forma concisa e expressiva, sem a necessidade de criar um construtor complexo.
    */
    public class InitOnly
    {
        public class Produto
        {
            public string Nome { get; set; }  // Pode ser alterado a qualquer momento
            //.set instance void Produto::set_Codigo(int32) { set }
            public string Codigo { get; init; }  // Só pode ser atribuído na inicialização
            //.set instance void Produto::set_Codigo(int32) { init }

        }

        /*
         .class public auto ansi beforefieldinit Produto
            extends [System.Private.CoreLib]System.Object
        {
            .field public string Nome
            .field public string Codigo

            // Construtor
            .method public hidebysig specialname rtspecialname instance void .ctor() cil
            {
                // código do construtor
                ldarg.0
                call instance void [System.Private.CoreLib]System.Object::.ctor()
                ret
            }

            // Propriedade Nome - 'set'
            .method public hidebysig instance void set_Nome(string value) cil
            {
                .maxstack 8
                ldarg.0
                ldarg.1
                stfld string Produto::Nome
                ret
            }

            // Propriedade Codigo - 'init'
            .method public hidebysig instance void set_Codigo(string value) cil
            {
                .maxstack 8
                ldarg.0
                ldarg.1
                stfld string Produto::Codigo
                ret
            }
        }

         */


        public void Validar()
        {
            var produto = new Produto 
            { 
                Nome = "Café", 
                Codigo = "A123" 
            };

            produto.Nome = "Chá";  // Ok, pois 'Nome' tem 'set'
            //produto.Codigo = "B456";  // Erro de compilação, pois 'Codigo' tem 'init'            
        }
    }
}
