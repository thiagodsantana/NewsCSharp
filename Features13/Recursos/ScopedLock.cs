using System.Diagnostics;
using System.Net.Http.Headers;

namespace FeaturesCSharp.Versao13
{
    /*
     * Resumo: É um recurso que visa simplificar e tornar mais segura a utilização de locks para proteger seções críticas de código 
        em ambientes multi-threaded. Oferece uma sintaxe mais concisa e um tratamento mais elegante de exceções, comparado ao mecanismo 
            tradicional de lock utilizando object como argumento..
        * Benefícios:
            * Segurança: Garante que o lock seja sempre liberado, mesmo em caso de exceções, evitando deadlocks e inconsistências de dados.
            * Concisão: A sintaxe using simplifica a aquisição e liberação do lock, tornando o código mais limpo e legível.
            * Expressividade: A intenção de proteger uma seção crítica fica mais clara, melhorando a compreensão do código.
     */
    public static class ScopedLock
    {
        static Stopwatch stopwatch = new Stopwatch();
        public static int Valor => contador;
        private static int contador = 0;
        private static readonly Lock bloqueio = new();
        private static readonly System.Object ObjectLock = new();

        static void SimularOperacaoLockObjGenerico(int taskId)
        {
            stopwatch.Start();
            lock (ObjectLock) // O compilador emitiria instruções IL para usar System.Threading.Monitor.Enter e Monitor.Exit.
            {
                Console.WriteLine($"Task {taskId} entrou no lock genérico.");
                Task.Delay(500).Wait(); // A thread fica parada ocupando recursos e nenhuma outra tarefa pode avançar
                contador++;
                Console.WriteLine($"Task {taskId} incrementou o contador para {contador} usando lock genérico.");
            }
        }

        static void SimularOperacaoNewLock(int taskId)
        {
            if (bloqueio.TryEnter()) // Verifica se o lock está disponível sem bloquear a Thread 
            {
                try
                {
                    Console.WriteLine($"Task {taskId} entrou no new lock .");
                    Thread.Sleep(500);
                    IncrementarContador();
                    Console.WriteLine($"Task {taskId} incrementou o contador para {contador} usando new lock.");
                }
                finally
                {
                    bloqueio.Exit(); //Garante que o lock seja liberado, independentemente de qualquer exceção que possa ocorrer dentro do bloco try
                    Console.WriteLine($"Task {taskId} liberou o new lock.");
                }
            }
            else
            {
                Console.WriteLine($"Task {taskId} executando outras ações.");
                // Pode Executar operações paralelas sem esperar por recursos
            }
        }

        private static void IncrementarContador()
        {
            contador++;
        }

        public static async void ValidarLockGenerico()
        {
            stopwatch.Start();
            var tasksLockObjGenerico = new Task[5];
            for (int i = 0; i < 5; i++)
            {
                var taskId = i;
                tasksLockObjGenerico[i] = Task.Run(() => SimularOperacaoLockObjGenerico(taskId));
            }
            await Task.WhenAll(tasksLockObjGenerico);
            stopwatch.Stop();
            Console.Write($"Tempo passado Lock Genérico: {stopwatch.Elapsed}");
            stopwatch.Restart();
        }

        public static async void ValidarNewLock()
        {
            stopwatch.Start();
            var taskNewLock = new Task[5];
            for (int i = 0; i < 5; i++)
            {
                var taskId = i;
                taskNewLock[i] = Task.Run(() => SimularOperacaoNewLock(taskId));
            }
            await Task.WhenAll(taskNewLock);
            stopwatch.Stop();
            Console.Write($"Tempo passado New Lock: {stopwatch.Elapsed}");
            stopwatch.Restart();
        }
    }
}
