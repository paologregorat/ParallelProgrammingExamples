using ParallelProgramming.Abstract;
using ParallelProgramming.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.Client
{
    public class Client
    {
        public void Main()
        {
            ClientMethod(new ConcreteFactoryCaso1(),1);
            ClientMethod(new ConcreteFactoryCaso1(),2);
            ClientMethod(new ConcreteFactoryCaso2(), 1);
            ClientMethod(new ConcreteFactoryCaso2(), 2);
            ClientMethod(new ConcreteFactoryCaso3(), 1);
            ClientMethod(new ConcreteFactoryCaso3(), 2);

        }
        public void ClientMethod(IAbstractFactory factory, int id)
        {
            switch (id)
            {
                case 1:
                    {
                        var res = factory.CreaCategoria1();
                        res.EseguiComandoCategoria1();
                        break;
                    }

                case 2:
                    {
                        var res = factory.CreaCategoria2();
                        res.EseguiComandoCategoria2();
                        break;
                    }
                default:
                    Console.WriteLine("Default case");
                    break;
            }
           
        }
    }
}
