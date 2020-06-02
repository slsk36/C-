using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 1차원 배열(number)
            //int[] arrInt = { 10,20,30,40,50 };
            //for(int i = 0; i < arrInt.Length; i++)
            //{
            //    Console.WriteLine(arrInt[i] + " ");
            //    string str = string.Format("배열[{0}] : {1}",
            //        i, arrInt[i]);
            //    Console.WriteLine(str);
            //}
            //Console.WriteLine();

            ////2. 1차원 배열(string)
            //char[] arrCh = new char[5] { '이', '박', '김', '홍', '최' };
            //Console.WriteLine(arrCh);
            //Console.WriteLine();

            ////3. 빈공간 1차원 배열
            //string[] arrStr = new string[5];
            //Random rand = new Random();
            //string[] name = { "홍길동", "김길동", "최길동", "박길동", "이길동" };
            //for(int i = 0; i < arrStr.Length; i++)
            //{
            //    //0~4까지의 랜덤한 숫자를 뽑는다.
            //    int r = rand.Next(0, 5);
            //    //비어있는 배열에다가 집어넣는다.
            //    arrStr[i] = name[r];

            //    Console.WriteLine(arrStr[i]);
            //}
            //Console.WriteLine();

            ////4. 2차원 배열 초기화
            //int[,] arr2Int =
            //{
            //    {1,2,3}, {4,5,6 }
            //};

            //for(int i=0; i<2; i++) //고정(기준)
            //{
            //    for(int j=0; j < 3; j++) //변동값
            //    {
            //        Console.Write(arr2Int[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            ////5. 빈 공간 2차원 배열
            //string[][] arrStr2 = new string[2][];
            //arrStr2[0] = new string[] { "홍길동", "이길동", "박길동" };
            //arrStr2[1] = new string[] { "최길동" };

            //for(int i=0; i < arrStr2.Length; i++)
            //{
            //    for(int j=0; j<arrStr2[i].Length; j++)
            //    {
            //        Console.WriteLine(arrStr2[i][j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            //----------------------------------
            //로또 프로그램 v1.0
            //1. 1~45 랜덤한 숫자 6개 획득
            //2. 중복 체크(배열사용)
             

            
            Random rand = new Random();
            int[] lotto = new int[6];

            for(int i=0; i<lotto.Length; i++)
            {
                int r = rand.Next(1, 46);
                Console.WriteLine(r);
                for(int j=0; j<lotto.Length; j++)
                {
                    if (i == 0)
                    {
                        lotto[i] = r;
                        Console.WriteLine(r);
                    }
                    else
                    {
                        int temp = lotto[i];
                        lotto[i] = lotto[j];
                        lotto[j] = temp;
                        Console.WriteLine(temp);
                    }
                }

                
            }
            
            

            

           





        }
    }
}
