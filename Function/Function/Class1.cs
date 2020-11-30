using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Class1
    {
        public static int NumberOfDigits(string TheString)        {             int Count = 0;            for (int i = 0; i < TheString.Length; i++)            {                if (Char.IsDigit(TheString[i]))                {                    Count++;                }            }            return Count;        }    }}


