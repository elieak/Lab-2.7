using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int usrInput = 0;
            char dollar = '$';
            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out usrInput);

            for (int i = 0; i < usrInput; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(dollar);
                }
                Console.WriteLine("");
            }
        }
    }
}
