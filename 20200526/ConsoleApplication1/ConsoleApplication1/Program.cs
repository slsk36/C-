using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Myclass2
    {
        public void test()
        {
            //Program.Main 클래스 밖에서 접근 불가
            Program.tester(); //밖이라도 tester에 접근가능 public 선언이므로
        }
    }
    class Program
    {
        class Myclass
        {
            public void test()
            {
                Program.Main(new string[] { "" });
            } //클래스 내부로는 접근 가능
        }

        public static void tester()
        {
            Program.Main(new string[] { "" });
        }// 접근가능

        static void Main(string[] args)
        {

        }
    }
}
