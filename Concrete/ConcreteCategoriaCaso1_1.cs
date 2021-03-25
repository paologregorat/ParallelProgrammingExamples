using ParallelProgramming.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.Concrete
{
    public class ConcreteCategoriaCaso1_1 : ICategoria1
    {
        public  async void EseguiComandoCategoria1()
        {
            Console.WriteLine("*** Start Operation ***");

            var task1 = Delay(5000);
            var task2 = Delay(2500);

            int[] result = await Task.WhenAll(task1, task2);

            Console.WriteLine($"total time: {result.Sum()}");

            Console.WriteLine("*** End Operation ***");
        }

        private static async Task<int> Delay(int ms)
        {
            Console.WriteLine($"Start delay for {ms}");

            await Task.Delay(ms);

            Console.WriteLine($"End delay for {ms}");
            return ms;
        }
    }
}
