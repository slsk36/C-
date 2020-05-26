using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//클래스 메소드 사용하여 곱과 제곱 프로그램 실행하기
namespace tester
{
    class testClass2
    {
        public static int Power(int x)
        {
            return x * x;
        }
        public static int Multi(int x,int y)
        {
            return x * y;
        }
        public static void Print()
        {
            MessageBox.Show("메세지출력22");
        }
    }
}
