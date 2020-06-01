using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleTest1
{
    //동전 교환 프로그램 만들기
    class Program
    {
        static void Main(string[] args)
        {
            int Coin500 = 0;
            int Coin100 = 0;
            int Coin50 = 0;
            int Coin10 = 0;
            int PaperMoney;
            int Coin;

            Console.Write("교환할 금액을 입력하세요");
            PaperMoney = int.Parse(Console.ReadLine());
            Console.WriteLine(PaperMoney);


            //solution 1 : 동전 갯수를 직접입력 받아서 반환하기
            //Console.Write("얼마짜리 동전이 필요하세요?");
            //Coin = int.Parse(Console.ReadLine());

            //switch (Coin)
            //{
            //    case 500:
            //        Coin500 = PaperMoney / 500;
            //        Console.WriteLine(Coin500 + "개 받으세요");
            //        break;
            //    case 100:
            //        Coin100 = PaperMoney / 100;
            //        Console.WriteLine(Coin100 + "개 받으세요");
            //        break;
            //    case 50:
            //        Coin50 = PaperMoney / 50;
            //        Console.WriteLine(Coin50 + "개 받으세요");
            //        break;
            //    case 10:
            //        Coin10 = PaperMoney / 10;
            //        Console.WriteLine(Coin10 + "개 받으세요");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 값입니다.");
            //        break;                   
            //}
            //Console.ReadKey();

            //solution 2 : 여러가지 동전으로 반환하기

            Coin500 = PaperMoney / 500;

            PaperMoney = PaperMoney % 500;
            Coin100 = PaperMoney / 100;

            PaperMoney = PaperMoney % 100;
            Coin50 = PaperMoney / 50;

            PaperMoney = PaperMoney % 50;
            Coin10 = PaperMoney / 10;

            Coin = PaperMoney % 10;
            

            Console.WriteLine("500원: "+Coin500);
            Console.WriteLine("100원: " + Coin100);
            Console.WriteLine("50원: " + Coin50);
            Console.WriteLine("10원: " + Coin10);
            Console.WriteLine("나머지: " + Coin);





        }
    }
}
