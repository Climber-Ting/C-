using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[30];
            a[0] = 1;
            a[1] = 1;
            int count = 2;
            Console.Write(a[0] + " ");
            Console.Write(a[1] + " ");
            for (int i = 2; i <= 29; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
                Console.Write(a[i] + " ");
                count++;
                if (count % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
    
