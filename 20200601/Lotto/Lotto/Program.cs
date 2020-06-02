using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] lotto = new int[6];
            Console.WriteLine("초기값");
            for (int i=0; i<6; i++)
            {
AGAIN:
                int r = rand.Next(1, 46);
                
                Console.WriteLine(r); //디버깅을 위한 코드

                if (i == 0)
                {
                    lotto[i] = r;
                    
                }
                else
                {
                    for(int j=0; j<i; j++)
                    {
                        if(lotto[j] == r) //로또번호의 중복이 발생된다면 goto 점프문이 필요함
                        {
                            goto AGAIN;
                        }
                    }                     //for문(중복체크)가 끝남
                    lotto[i] = r;         //중복된 요소가 없으니 배열에 r값을 넣는다.
                }
            }

            Console.WriteLine("로또번호는");
            foreach(int n in lotto)
            {
                Console.WriteLine(n);
            }
        }
    }
}
