using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest1
{
    //회원가입자 정보
    class User
    {
        public string name;
        public string password;
        public string address;
        public string telNum;
        public DateTime regDate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.name = "홍길동";
            user.address = "조선";
            Console.WriteLine("이름: " + user.name);

            new User().name = "전우치";
        }
    }
}
