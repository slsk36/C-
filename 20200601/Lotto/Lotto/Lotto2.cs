using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto2
    {
        static void Main(string[] args)
        {


            Random rand = new Random();
            int[] lotto = new int[6];

            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = (int)rand.Next(1, 46);
                //Console.Write(lotto + " ");

                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                    {
                        i--;                //i값 1개를 잃어버려서 다시 복원
                        break;

                    }

                }

            }

            for(int k=0; k<lotto.Length; k++)
            {
                Console.WriteLine(lotto[k]);
            }

        }
    }
}
