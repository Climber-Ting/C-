using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个浮点数x和一个整数n： ");
            double x = Convert.ToDouble(Console.Read());
            int n = Convert.ToInt16(Console.Read());
            Console.WriteLine(hermite(n, x));
            Console.ReadLine();
            Console.Read();
        }
        public static double hermite(double n,double x )
        {
            if(n==0)
            {
                return 1;
            }
            if(n==1)
            {
                return 2 * x;
            }
            return 2 * x * hermite(n - 1, x) - 2 * (n - 1) * hermite(n - 2, x);           
        }
    }
}
/*Console.Write("请输入一个浮点数x和一个整数n： ");
            double x = Convert.ToDouble(Console.Read());
            int n = Convert.ToInt16(Console.Read());
            double sum;
            if(n==0)
            {
                sum = 1;
            }
            else if(n==1)
            {
                sum = 2 * x;
            }
            else if(n>1)
            {
                for(int i=1;i<=n;i++)
                {
                    
                }
            }*/
        