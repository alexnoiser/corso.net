using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capiamo_da_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scrivi i due numeri che vuoi sommare");
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            int p = int.Parse(input);
            int p2 = int.Parse(input2);
            object result;
            //Console.WriteLine(Sum(p, p2, out result));
            Sum(p, p2, out result);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        

        private static void Sum(int p, int p2, out object result)
        {

            result = p + p2;
        }
    }

}
