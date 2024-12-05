using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesCSharp.Versao13
{
    /*
     * Resumo: Este recurso é útil para manipulações em coleções sem precisar calcular manualmente os índices finais.
            * Benefícios:
                * Melhor Legibilidade: Permite inicializar ou modificar elementos em coleções de forma direta e intuitiva.
                * Flexibilidade: Possibilidade de inicializar coleções ou modificar elementos diretamente em um ponto específico do código.
                * Redução de Erros: Evita erros comuns ao calcular índices manualmente, como acessar índices fora dos limites ou usar o comprimento incorreto.

     */
    internal class IniciadoresIndex
    {        
        public void Validar()
        {
            // Exemplo simples de inicialização usando índices implícitos
            var numeros = new int[5];

            // Usando índice implícito para modificar valores
            numeros[^1] = 10; // Último - ^1 corresponde ao último elemento (array.Length - 1).
            numeros[^2] = 20; // Penúltimo -  ^2 corresponde ao penúltimo elemento (array.Length - 2).

            // Resultado: numeros = [0, 0, 0, 20, 10]

            // Código interpretado pelo compilador
            //var numeros = new int[5] { 1, 2, 3, 4, 5 };
            //numeros[numeros.Length - 1] = 10; // Último elemento
            //numeros[numeros.Length - 2] = 20; // Penúltimo elemento


        }
    }
}
