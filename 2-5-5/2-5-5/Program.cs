using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 1.0;
            for(int i=1;i<=1000;i++)
            {
                double m=2*i-1;
                double t=2*i+1;
                double a = 2 * i;
                b =b* (a / m) * (a / t);
                if(i==1000)
                {
                    Console.Write(b*2);
                }
            }
            Console.Read();
            

        }
    }
}
