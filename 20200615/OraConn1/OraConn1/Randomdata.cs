using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraConn1
{
    class RandomData
    {
        static string[] first = { "a", "b", "c", "d", "e" };
        static string[] mid = { "f", "g", "h", "i", "j" };
        static string[] last = { "o", "n", "m", "l", "k" };
        static int[] age = { 10, 20, 30, 40, 50 };
        static string[] addr = { "미국", "프랑스", "베트남", "북한", "캐나다" };

        static Random r = new Random();

        public static string getName()
        {
            string fullName = last[r.Next(0, 5)] + mid[r.Next(0, 5)] + first[r.Next(0, 5)];
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
