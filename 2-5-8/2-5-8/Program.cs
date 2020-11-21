using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 4, 3, 5, 7, 9, 4, 2, 7, 11, 5, 1, 4, };
            int max = a[0],index=0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    index = i;
                }
                    
            }
            Console.WriteLine("{0}  {1}", max, index);
            Console.Read();
        }
       
    }
}
       