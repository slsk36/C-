using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz6_3
{
    //다음과 같은 메서드를 만들어 보시오
    //인스턴스 메소드




    class Class1 //class명은 대문자로
    {
        public int Power(int input) 
        {
            return input * input;
        } //제곱함수

        public int Power(int input, int count)
        {
            int output = 1;
            for(int i=0; i<count; i++)
            {
                output *= input;
            }
            return output;
        }

        public int Sum(int end)
        {
            return Sum(0, end);
        } //0부터 end사이에 모든 정수를 더하는 메서드

        public int Sum(int start, int end)
        {
            int output = 0;
            for(int i=start; i <= end; i++)
            {
                output += i;
            }
            return output;
        }//start부터 end사이의 모든 정수를 더하는 메서드
    }
}
