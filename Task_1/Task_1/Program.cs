using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 1000;
            int c;

            Console.Write("Create a new price: ");
            c = int.Parse(Console.ReadLine());

            if (c < a)
            {
                Console.WriteLine("Your price is lesser than the minimum price. You should to contact with trader!");
            }
            if (c > b)
            {
                Console.WriteLine("Your price is bigger than the maximum price. You should to contact with trader!");
            }
            else if (a >= c && b <= c)
            {
                Console.WriteLine("The new price was created");
            }


            Console.ReadLine();
        }
    }
}
