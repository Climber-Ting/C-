using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个四位整数n:");
            int[]a=new int[5];
            for(int i=1;i<=4;i++)
            {
                a[i]=Console.Read();
            }
            for(int j=4;j>0;j--)
            {
                Console.Write((char)a[j]);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
