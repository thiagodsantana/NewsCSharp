namespace FeaturesCSharp.Versao11
{
    /*
     * Resumo: Foi introduzido como parte das melhorias em classes e structs para garantir que certas propriedades ou campos 
              sejam obrigatoriamente inicializados durante a criação de instâncias. 
              Isso aumenta a segurança e a clareza do código, especialmente em cenários onde a inicialização correta dos dados é essencial.

        * Benefícios:
            *   Construção de objetos complexos
            *   Classes com muitas propriedades que precisam de valores para serem usadas corretamente.
        * Limitações ou desvantagens:
            *   Potencial confusão em herança: Dificuldade para rastrear quais membros obrigatórios precisam ser inicializados em hierarquias complexas de herança.
            *   Uso excessivo: Se muitos membros forem marcados como required, pode complicar o uso da classe.
     */
    public class RequiredMembers
    {
        public class Animal
        {
            public required string Especie { get; init; }
        }

        public class Cachorro : Animal
        {
            public required string Raca { get; init; }

        }

        public void Validar()
        {
            // Correto:
            var cachorro = new Cachorro
            {
                Especie = "Canina",
                Raca = "Labrador"
            };

            // Incorreto:
            var cachorroInvalido = new Cachorro
            {
                Especie = "Canina"
                // Falta "Raca"
            };
        }

        /*
         * Como o compilador interpreta:
            * O compilador gera metadados adicionais para as propriedades marcadas como required. 
                *   Especificamente:
                        Atributo especial [RequiredMember] é adicionado às propriedades definidas como required.
                        Esses metadados informam ao compilador que essas propriedades devem ser inicializadas antes que o objeto seja considerado válido.
            
                     [RequiredMember] não pode ser usado diretamente em código C# da mesma forma que você usaria [Required]. 
                        Ele é gerado automaticamente pelo compilador para refletir a semântica de required nos metadados do tipo.

            [RequiredMember] 
            public string Raca { get; init; }

        .custom instance void System.Runtime.CompilerServices.RequiredMemberAttribute::.ctor() = (
                01 00 00 00
            )
            .property instance string Raca
            {
                .get instance string Raca::get_Raca()
                .set instance void Raca::set_Raca(string)
            }

         */
    }
}
