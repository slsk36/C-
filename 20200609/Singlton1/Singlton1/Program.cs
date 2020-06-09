using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton1
{
    class SingleTest
    {
        //싱글톤: 이미 생성되어진 객체를 재사용
        private static SingleTest inst;
        private int data;
        private static Random rd;

        public SingleTest(Random r)
        {
            rd = r;
            //Random r = new Random();
            data = r.Next(1,100);
        }
        public static SingleTest getInstance()
        {
            if(inst == null)
            {
                inst = new SingleTest(rd);
            }
            return inst;
        }


        public int getData()
        {
            return data;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Random r = new Random();

            //일반적인 객체 생성
            SingleTest test1 = new SingleTest(r);
            Console.WriteLine(test1.getData());
            Console.WriteLine(new SingleTest(r).getData());
            Console.WriteLine(new SingleTest(r).getData());

            //싱글톤
            Console.WriteLine(SingleTest.getInstance().getData());
            Console.WriteLine(SingleTest.getInstance().getData());
            Console.WriteLine(SingleTest.getInstance().getData());

        }
    }
}
