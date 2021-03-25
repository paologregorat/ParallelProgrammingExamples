using ParallelProgramming.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.Concrete
{
    public class ConcreteCategoriaCaso2_1 : ICategoria2
    {
        public void EseguiComandoCategoria2()
        {
            Console.WriteLine("*** Start Main ***");

            var task = Task.Run(() => Operation1());
            Console.WriteLine("this is executed first");
            task.Wait();

            Console.WriteLine("*** End Main ***");
        }

        private static void Operation1()
        {
            Console.WriteLine("Operation 1 executed");
        }

        private static void Operation2()
        {
            Console.WriteLine("Operation 2 executed");
        }
    }
}
