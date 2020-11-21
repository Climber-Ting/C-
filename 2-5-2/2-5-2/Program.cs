using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个整数n：");
            int n = Convert.ToInt32(Console.ReadLine());
            float y = 0 ;
            int f=1;
            for(int i=1;i<=n;i++)
            {
                f*= i;
                y = y + f;
            }
            Console.Write("n的值为{0}\n1到n的阶乘求和为y={1,10:f8}",n,y);
            Console.ReadLine();
        }
    }
}
