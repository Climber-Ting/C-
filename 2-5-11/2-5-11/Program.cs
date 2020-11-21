using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4] { { 1, 1, 1, 1 },{ 1,1,1,1},{1,1,1,1 },{1,1,1,1 } };
            int num = a[0, 0] + a[0, 3] + a[1, 1] + a[1, 2] + a[2, 1] + a[2, 2] + a[3, 0] + a[3, 3];
            Console.WriteLine(num);
            Console.Read();
        }
    }
}
