using ParallelProgramming.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming.Concrete
{
    public class ConcreteCategoriaCaso1_2 : ICategoria1
    {
        public void EseguiComandoCategoria1()
        {
            Console.WriteLine("*** Start Main ***");

            // Creates 3 different tasks
            Task[] tasks = new Task[3]
            {
                Task.Factory.StartNew(() => Method1()),
                Task.Factory.StartNew(() => Method2()),
                Task.Factory.StartNew(() => Method3()),
            };

            // Blocks main thread
            Task.WaitAll(tasks);

            // Continue on this thread...

            Console.WriteLine("*** End Main ***");
        }

        private static void Method1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Method1");
        }

        private static void Method2()
        {
            Console.WriteLine("Method2");
        }

        private static void Method3()
        {
            Console.WriteLine("Method3");
        }
    }
}