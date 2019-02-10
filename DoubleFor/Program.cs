using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleFor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your first digit");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your second digit");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("-{0}", i);

            }
            Console.ReadKey();
        }
    }
}
