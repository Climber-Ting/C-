﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hb, Lb, x;
            x = 0x1af034;
            Hb = (x >> 16) & 0xffff;
            Lb = x & 0x00ff;
            Console.Write("Hb is {0}\t", Hb);
            Console.WriteLine("Lb is {0}", Lb);
            Console.Read();
        }
    }
}
