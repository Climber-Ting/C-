using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int m;
            for (m = 1; m < 1000; m++)
            {
                int t1 = m % 10;
                int t2 = m / 10 % 10;
                int t3 = m / 100;
                int t = Convert.ToInt32(Math.Pow(t1, 3) + Math.Pow(t2, 3) + Math.Pow(t3, 3));
                if (m == t)
                {

                    Console.Write(m+" ");
                }
            }
            Console.ReadLine();
        }
    }
}

       
