using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FeaturesCSharp.Versao13
{
    /*
     * Resumo: Oferece melhorias para sincronização de threads, usando o novo tipo System.Threading.Lock. 
                Ele é projetado para substituir o tradicional uso de System.Threading.Monitor no contexto do bloqueio de objetos, 
                    fornecendo uma abordagem mais robusta e eficiente.
        * Benefícios:
            *   Segurança no Acesso Compartilhado: Garante que o bloqueio seja aplicado corretamente, reduzindo a chance de erros relacionados ao uso de objetos inadequados para bloqueio.
            *   Melhoria de Performance: A nova API é mais eficiente em termos de desempenho e evita possíveis problemas de contenção de threads.
            *   Mensagens de Diagnóstico do Compilador: O compilador emite avisos se Lock for utilizado incorretamente.
     */
    internal class ScopedLock
    {
        public int Valor => contador;
        private int contador = 0;
        private readonly Lock bloqueio = new();

        public void Validar()
        {
            //System.Threading.Lock
            //Otimizado para gerenciamento de sincronização.
            //O compilador reconhece o tipo Lock e utiliza APIs específicas para melhorar a eficiência,
            //prevenindo erros de conversão ou uso inadequado de blocos de sincronização.
            lock (bloqueio) // bloqueia a execução para garantir que apenas uma thread possa acessar o bloco de código associado por vez.
            {
                contador++;
            }
        }

        public void Validar2()
        {
            System.Object objt = new();
            lock (objt) // O compilador emitiria instruções IL para usar System.Threading.Monitor.Enter e Monitor.Exit.
            {
                contador++;
            }
        }

        /*
         * Código gerado pelo compilador
         .method public hidebysig specialname instance int32 get_Valor() cil managed
        {
            ldarg.0
            ldfld int32 <Namespace.ClassName>::contador
            ret
        }

        .method public hidebysig instance void Incrementar() cil managed
        {
            ldarg.0
            ldfld class [mscorlib]System.Threading.Lock <Namespace.ClassName>::bloqueio
            callvirt instance void [mscorlib]System.Threading.Lock::Enter()
            .try
            {
                ldarg.0
                dup
                ldfld int32 <Namespace.ClassName>::contador
                ldc.i4.1
                add
                stfld int32 <Namespace.ClassName>::contador
                leave.s End
            }
            finally
            {
                ldarg.0
                ldfld class [mscorlib]System.Threading.Lock <Namespace.ClassName>::bloqueio
                callvirt instance void [mscorlib]System.Threading.Lock::Exit()
            }
        End:
            ret
        }

         */
    }
}
