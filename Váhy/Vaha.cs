using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Váhy
{
    class Vaha
    {
        private int _basis, _count;
        public Vaha(int basis, int count)
        {
            _basis = basis;
            _count = count;
            for (int i = 0; i < _count; i++)
            {
                Console.Write(Math.Pow(_basis, i) + ", ");
            }
        }

        
    }
}
