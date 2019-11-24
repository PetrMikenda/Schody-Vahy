using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Váhy
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Vaha v1 = new Vaha(2, 10);
            //v1.weight();
            ConsoleKeyInfo ans;
            do
            {
                Console.WriteLine("Chceš vypsat další váhy? [A]");
                ans = Console.ReadKey();
            } while (ans.Key == ConsoleKey.A || ans.Key == ConsoleKey.Enter);


            Console.ReadKey();
        }
    }
}
