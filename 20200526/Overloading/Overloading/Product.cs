using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Product
    {
        public static int mCounter = 0;
        public int mId;
        public string mName;
        public int mPrice;
        public const int test = 1; //클래스로 상수 선언 test값 고정시킴

        public Product(string name, int price)
        {
            mCounter++;
            mId = mCounter;
            mName = name;
            mPrice = price;
        } //변수 선언되는 순간 값 바로 할당
    }
}
