using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraWinform622
{
    class RandData
    {
        static string[] first = { "동", "아", "경", "수", "호" };
        static string[] mid = { "길", "세", "나", "민", "연" };
        static string[] last = { "김", "이", "박", "최", "홍"};
        static int[] age = { 10, 20, 30, 40, 50 };
        static string[] addr = {"대구 동구 신암1동",
            "대구 동구 신암5동", "대구 동구 신암2동",
            "대구 동구 신암3동", "대구 동구 신암4동"
        };

        static Random r = new Random();

        public static string getName()
        {
            string fullName = last[r.Next(0, 5)] +
                mid[r.Next(0, 5)] + first[r.Next(0, 5)];
            return fullName;
        }

        public static int getAge()
        {
            return age[r.Next(0, 5)];
        }

        public static string getAddr()
        {
            return addr[r.Next(0, 5)];
        }
    }
}
