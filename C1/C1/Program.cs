using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1번 문제: cm inch 변환
            Console.Write("inch를 입력하세요\n");
            int i = int.Parse(Console.ReadLine());
            double d = i * 2.54;
            Console.WriteLine(+d + "cm");
            
            //2번 문제: kg pound 변환
            Console.Write("kg을 입력하세요\n");
            double k = double.Parse(Console.ReadLine());
            double p = k * 2.20462262;
            Console.WriteLine(+p + "pound");

            //3번 문제:원의 반지름 입력받아 원 둘레, 넓이 구하기
            Console.Write("반지름 입력\n");
            double r = double.Parse(Console.ReadLine());
            double a = r * r * 3.14;
            double b = r * 2 * 3.14;
            Console.WriteLine("원넓이" + a); 
            Console.WriteLine("원둘레" + b);
        }
    }
}
