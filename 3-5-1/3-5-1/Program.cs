using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("计算加法请输入  1，计算减法请输入 2。");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine("请输入第一个复数的实部：");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第一个复数的虚部：");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个复数的实部：");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个复数的虚部：");
                int d = int.Parse(Console.ReadLine());
                newlei m = new newlei();
                m.jisuanjiafa(a, c);
                newlei m1 = new newlei();
                m1.jisuanjiafa(b, d);
                Console.WriteLine("计算的复数结果是y={0}+{1}i", m.x, m1.x);
            }
            else if (i == 2)
            {
                Console.WriteLine("请输入第一个复数的实部：");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第一个复数的虚部：");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个复数的实部：");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个复数的虚部：");
                int d = int.Parse(Console.ReadLine());
                newlei m2 = new newlei();
                m2.jisuanjianfa(a, c);
                newlei m3 = new newlei();
                m3.jisuanjianfa(b, d);
                Console.WriteLine("计算的复数结果是y={0}+{1}i", m2.x, m3.x);
            }
            Console.ReadLine();
        }
    }
    class newlei
    {
        public int x;
        public int jisuanjiafa(int a, int b)
        {
            x = a + b;
            return x;
        }
        public int jisuanjianfa(int a, int b)
        {
            x = a - b;
            return x;
        }
    }
}
       