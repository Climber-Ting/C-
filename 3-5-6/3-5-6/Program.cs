using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            CPoint p1 = new CPoint(3, 3);
            CPoint p2 = new CPoint(6, 6);
            CPoint p3 = new CPoint(4, 6);
            CPoint p4 = new CPoint(4, 9);
            Cline L = new Cline();
            int line1 = (int)L.GetLine(p1, p2);
            int line2 = (int)L.GetLine(p3, p4);

            CRect a = new CRect();
            int area = a.GetArea(line1, line2);
            int zhouchang = a.GetZhouchang(line1, line2);
            Console.WriteLine("p1和p2,p3和p4组成的线段L1和L2分别是{0}和{1}\n", line1, line2);
            Console.WriteLine("用L1和L2组成的矩形的面积和周长分别是{0}和{1}\n", area, zhouchang);
            Console.ReadKey();
        }
    }
    public class CPoint
    {
        public CPoint()
        {
        }
        public int x, y;
        public CPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("初始化的点为({0},{1})\n", x, y);
        }
    }
    public class Cline : CPoint
    {
        public Cline()
        {
        }
        public double GetLine(CPoint p1, CPoint p2)
        {
            double heng = Math.Pow(p1.x - p2.x, 2);
            double zong = Math.Pow(p1.y - p2.y, 2);
            double result = Math.Sqrt(heng + zong);
            return result;
        }
    }
    public class CRect : Cline
    {
        public int GetZhouchang(int h, int w)
        {
            int c = (h + w) * 2;
            return c;
        }
        public int GetArea(int h, int w)
        {
            int s = h * w;
            return s;
        }
    }
}
       