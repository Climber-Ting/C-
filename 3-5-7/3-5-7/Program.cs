using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_7
{
   public class CStrOne
    {
        protected string m_str1 = string.Empty;
        public CStrOne(string str1)
        {
            this.m_str1 = str1;
        }
        public void ShowStringOne()
        {
            Console.WriteLine(m_str1);
        }
    }
    public class CStrTwo : CStrOne
    {
        private string m_str2 = string.Empty;
        public CStrTwo(string str, string str2) : base(str)
        {
            this.m_str2 = str2;
        }
        public void ShowStringTwo()
        {
            Console.WriteLine("{0}{1}", m_str1, m_str2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CStrOne cs1 = new CStrOne("我爱你");
            cs1.ShowStringOne();
            CStrTwo cs2 = new CStrTwo("中国", "——亲爱的母亲");
            cs2.ShowStringTwo();
            Console.ReadKey();
        }
    }
}

