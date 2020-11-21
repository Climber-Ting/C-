using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一组数：（每个数字一行，以0结束输入）");
            ArrayList a = new ArrayList();//定义动态数组
            int fuNumber = 0, zhengNumber = 0,sum=0;
            int i;
            do
            {
                String s = Console.ReadLine();
                i = Convert.ToInt32(s);
                if (i > 0)
                {
                    zhengNumber++;
                    sum += i;
                }
                if (i < 0)
                {
                    fuNumber++;
                    sum += i;
                }
               a.Add(i);//给动态数组赋值
            } while (i != 0);
            Console.WriteLine("正数个数：{0}  负数个数：{1}  平均值：{2}", zhengNumber, fuNumber, sum/a.Count);
            Console.Read();
        }
    }
}
       