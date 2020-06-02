using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest1
{
    class Person
    {
        //객체의 특징 -> 속성(변수)
        private string name;
        private int age;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void swapNum(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public void swapNumRef(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }   // 포인트 대체 동작 ref

        public void add(int num1, int num2, out int sum)
        {
            sum = num1 + num2;
        }

        public int add(int num1, int num2 = 0, int num3 = 0)
        {
            return num1 + num2 + num3;
        } //Default 매개변수
    }

    class ClassTest2
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            int num1 = 100;
            int num2 = 200;
            //값에 의한 매개변수 전달(Call by Value)
            p.swapNum(num1, num2);
            Console.WriteLine(num1 + " " + num2);

            //참조에 의한 매개변수 전달(Call by Reference)
            p.swapNumRef(ref num1, ref num2);
            Console.WriteLine(num1 + " " + num2);

            //출력 전용 매개변수 out
            int res = 0;
            p.add(100, 200, out res);
            Console.WriteLine("res: " + res);
        }
    }
}
