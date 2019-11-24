using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Váhy
{
    class Vaha
    {
        private int _basis, _count, x;
        int[] vahy = new int[31];
        public Vaha(int basis, int count)
        {
            _basis = basis;
            _count = count;
            x = _count - 1;
            for (int i = 0; i < _count; i++, x--)
            {
                vahy[i] = Convert.ToInt32(Math.Pow(_basis, x));
            }
            Console.Write("Základ soustavy: " + _basis + " Váhy: ");
            for (int i = 0; i < _count; i++)
            {
                Console.Write(vahy[i] + "; ");
            }

        }
        //public static get()
        //{
        //    return 
        //}

        //public void weight()
        //{
        //    for (int i = 0; i < _count; i++)
        //    {
        //        Console.Write(vahy[i] + ", ");
        //    }
        //}


    }
}
