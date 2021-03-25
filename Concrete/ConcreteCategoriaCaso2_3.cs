using ParallelProgramming.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.Concrete
{
    public class ConcreteCategoriaCaso2_3 : ICategoria2
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
            Console.WriteLine("*** Start Main ***");

            // Creating a task with inner attached tasks
            var task1 = Task.Factory.StartNew(() => {
                var child1 = Task.Factory.StartNew(() => {
                    var child2 = Task.Factory.StartNew(() => {
                        // This exception is nested inside three AggregateExceptions
                        throw new CustomException("Attached child2 faulted");
                    }, TaskCreationOptions.AttachedToParent);

                    // This exception is nested inside two AggregateExceptions.
                    throw new CustomException("Attached child 1 faulted");
                }, TaskCreationOptions.AttachedToParent);
            });

            try
            {
                task1.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.Flatten().InnerExceptions)
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