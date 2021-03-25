using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.Abstract
{
    public interface IAbstractFactory
    {
        public ICategoria1 CreaCategoria1();
        public ICategoria2 CreaCategoria2();
    }
}
