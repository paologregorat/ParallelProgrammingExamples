using ParallelProgramming.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.Concrete
{
    public class ConcreteCategoriaCaso2_2 : ICategoria2
    {
        public void EseguiComandoCategoria2()
        {
            Console.WriteLine("*** Start Main ***");

            // Represents async code
            Run();

            Console.WriteLine("*** End Main ***");
        }

        private static async void Run()
        {
            var stopwatch = Stopwatch.StartNew();
            // Creating new Task Completion Source
            var tcs = new TaskCompletionSource<bool>();
            Console.WriteLine($"Start: {stopwatch.ElapsedMilliseconds}ms");

            // Wrapping Task Completion Source in a Task
            var fnf = Task.Delay(2000)
                .ContinueWith(task => tcs.SetResult(true));
            Console.WriteLine($"Waiting: {stopwatch.ElapsedMilliseconds}ms");

            // Awaiting Task Completion Source
            await tcs.Task;
            Console.WriteLine($"Done: {stopwatch.ElapsedMilliseconds}ms");
            stopwatch.Stop();
        }
    }
}