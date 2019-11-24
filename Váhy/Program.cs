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
                string power;
                string count;
                Console.WriteLine("Zadej základ soustavy: ");
                power = Console.ReadLine();
                if (Char.IsNumber(char.Parse(power)))
                {
                    
                    int x = Int32.Parse(power);
                    Console.WriteLine("Zadej počet vah: ");
                    count = Console.ReadLine();
                    if (Char.IsNumber(char.Parse(count)))
                    {
                        int y = Int32.Parse(count);
                        Vaha v1 = new Vaha(x, y);
                    }
                    else
                        Console.WriteLine("Zadaná hodnota není číslo");
                }
                else
                    Console.WriteLine("Zadaná hodnota není číslo");

                Console.WriteLine("\nChceš vypsat další váhy? [A]");
                ans = Console.ReadKey();
            } while (ans.Key == ConsoleKey.A || ans.Key == ConsoleKey.Enter);


            Console.ReadKey();
        }
    }
}
