using ParallelProgramming.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.Concrete
{
    public class ConcreteFactoryCaso3 : IAbstractFactory
    {
        public ICategoria1 CreaCategoria1()
        {
            return new ConcreteCategoriaCaso1_3();
        }

        public ICategoria2 CreaCategoria2()
        {
            return new ConcreteCategoriaCaso2_3();
        }
    }
}
