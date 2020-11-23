using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.SetInfo();
            stu1.Display();
            Console.ReadKey();
        }
    }
    class Student
    {
        string Name;
        double English;
        double Chinese;
        double Math;
        public void SetInfo()
        {
            Console.WriteLine("请输入学生姓名：");
            Name = Console.ReadLine();
            Console.WriteLine("请输入英语成绩：");
            English = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入语文成绩：");
            Chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入数学成绩：");
            Math = Convert.ToDouble(Console.ReadLine());
        }
        public double GetSum()
        {
            return (Math + English + Chinese);
        }
        public double GetAve()
        {
            return (Math + English + Chinese) / 3;
        }
        public void Display()
        {
            Console.WriteLine("你输入的学生信息：");
            Console.WriteLine("姓名：" + Name);
            Console.WriteLine("英语：" + English);
            Console.WriteLine("语文：" + Chinese);
            Console.WriteLine("数学：" + Math);
            Console.WriteLine("总分：" + GetSum());
            Console.WriteLine("平均数：" + GetAve());
        }
    }
}
