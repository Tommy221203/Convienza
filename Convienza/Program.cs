using System;

namespace Convienza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanti soldi devi spendere?");
            double a = int.Parse(Console.ReadLine());
            if(a<=500)
            {
                Console.WriteLine("conviene fare la spesa nel primo negozio");
            }
            else
            {
                Console.WriteLine("conviene fare la spesa nel secondo negozio");
            }
            Console.ReadLine();
        }
    }
}
