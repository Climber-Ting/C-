using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个字符串：");
            String s = Console.ReadLine();
            Boolean b = true;
            for (int i = 0,j=s.Length-1; i < s.Length / 2; i++,j--)
            {
                char m = s[i],n=s[j];
                if (m!=n)
                {
                    b = false;
                }
            }
            if(b)
            {
                Console.WriteLine("是");
            }
            else
            {
                Console.WriteLine("否");
            }
            Console.Read();
        }
       
    }
}
        