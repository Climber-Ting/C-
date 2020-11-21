using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个十进制整数：");
            int n=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n,16));
            Console.Read();

        }
    }
}
