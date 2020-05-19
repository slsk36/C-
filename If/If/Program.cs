using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("숫자 입력: ");
            //int input = int.Parse(Console.ReadLine());
            //if(input % 2 == 0 )
            //{
            //    Console.WriteLine("짝수");
            //}
            //if(input %2 == 1)
            //{
            //    Console.WriteLine("홀수");
            //}

            //for tap+tap : 자동완성
            string[] arr = { "사과", "배", "바나나", "딸기" };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
