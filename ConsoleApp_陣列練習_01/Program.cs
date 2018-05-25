using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_陣列練習_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tAry = new int[] { 10, 20, 30, 40, 50 };
            for(int k =0; k <= tAry.Length -1; k++)
            {
                Console.WriteLine($"tArty {k}, {tAry[k]}");
            }
            Console.ReadLine();
        }
    }
}
