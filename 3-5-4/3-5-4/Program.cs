using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CPoint c = new CPoint();
            Console.Write("默认参数值为：");
            c.display();
            c.setpoint(80, 150);
            Console.Write("修改后的参数值为：");
            c.display();
            Console.ReadKey(true);
        }
    }
    class CPoint
    {
        private int x;
        private int y;

        public CPoint(int x1, int y2)
        {
            x = x1;
            y = y2;
        }
        public CPoint()
        {
            x = 60;
            y = 75;
        }
        public void display()
        {
            Console.WriteLine("x = {0}   y = {1}", x, y);
        }
        public void setpoint(int x1, int y1)
        {
            x = x1;
            y = y1;
        }
    }
}
       
