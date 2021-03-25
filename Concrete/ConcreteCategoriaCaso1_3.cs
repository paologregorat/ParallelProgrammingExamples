using ParallelProgramming.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.Concrete
{
    public class ConcreteCategoriaCaso1_3 : ICategoria1
    {
        public  async void EseguiComandoCategoria1()
        {
            Console.WriteLine("*** Start Main ***");

            // Creating a task
            var task1 = Task.Run(() => throw new CustomException("This exception is expected!"));

            while (!task1.IsCompleted) { }

            if (task1.Status == TaskStatus.Faulted)
            {
                foreach (var e in task1.Exception.InnerExceptions)
                {
                    // Handling the custom exception
                    if (e is CustomException)
                    {
                        Console.WriteLine(e.Message);
                    }
                    else
                    {
                        // rethrow any other exception
                        throw e;
                    }
                }
            }

            Console.WriteLine("*** End Main ***");
        }

        public class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }

            public CustomException() : base()
            {
            }

            public CustomException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    }
}
