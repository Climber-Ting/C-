using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.InPutAllScore();
            Student.Students.Sort();
            Student.ListAllInfo();
            Console.ReadLine();
        }
    }
    public enum ClassName
    {
        CPP, Eng, Math
    }
    public class Score
    {
        public ClassName ItemName { get; set; } 
        public Decimal ScoreNum { get; set; }
    }
    public class Student : IComparable
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Dictionary<ClassName, Score> Score = new Dictionary<ClassName, Score>();
        public Decimal AvgSocre
        {
            get
            {
                var a = (from s in this.Score.Values
                         select s.ScoreNum).Average();
                return a;
            }
        }
        public void SetScore(ClassName c, decimal dcScore)
        {
            this.Score[c] = new Score() { ItemName = c, ScoreNum = dcScore };
        }
        public decimal GetScore(ClassName c)
        {
            Score s = this.Score[c];
            return s == null ? 0m : s.ScoreNum;
        }
        public static List<Student> Students = new List<Student>();
        public static void InPutAllScore()
        {
            int i = 0;
            while (true)
            {
                i++;
                Console.WriteLine("请输入第{0}个学生的信息, 学号输入end表示结束", i);
                Console.Write("学号:");
                string sID = Console.ReadLine();
                if (sID == "end")
                    break;
                Student s = new Student();
                s.ID = sID;
                Console.Write("姓名:");
                string sName = Console.ReadLine();
                s.Name = sName;
                Console.Write("C++成绩:");
                string sScore = Console.ReadLine();
                s.SetScore(ClassName.CPP, decimal.Parse(sScore));
                s.Name = sName;
                Console.Write("英语成绩:");
                sScore = Console.ReadLine();
                s.SetScore(ClassName.Eng, decimal.Parse(sScore));
                s.Name = sName;
                Console.Write("数学成绩:");
                sScore = Console.ReadLine();
                s.SetScore(ClassName.Math, decimal.Parse(sScore));
                s.Name = sName;
                Console.WriteLine("此学生的平均分数为:{0}", s.AvgSocre);
                Students.Add(s);
            }
        }
        #region IComparable 成员, 用于排序
        int IComparable.CompareTo(object obj)
        {
            Student s = obj as Student;
            return -(int)(this.AvgSocre - s.AvgSocre);
        }
        #endregion
        public static void ListAllInfo()
        {
            Console.WriteLine("");
            for (int i = 0; i < Students.Count; i++)
            {
                Student s = Students[i];
                Console.WriteLine(
                "第{0}名：{1, -10} {2, -10} C++: {3,5:#.0} 英语: {4,5:#.0} 数学: {5,5:#.0} 平均分: {6,5:#.0}",
                i + 1, s.ID, s.Name, s.GetScore(ClassName.CPP),
                s.GetScore(ClassName.Eng), s.GetScore(ClassName.Math), s.AvgSocre);
            }
        }
    }
}
       