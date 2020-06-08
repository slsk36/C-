using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest1
{
    class student
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //5. main()에서 다음의 학생정보 배열 초기화
            string[] name = { "홍길동", "김길동", "최길동", "박길동", "이길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] sex = { '남', '여' };
            string[] address = { "산골1", "산골2", "산골3", "산골4", "산골5" };

            
            Random rand = new Random();
            int r = rand.Next(0, 5);

            //6. 10명의 학생 정보 생성(객체 10개 생성)
            int[] n = new int[10];
            Student[] st = new Student[10]; //빈 객체

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine((i + 1)+"번 학생 ");
                st[i] = new Student(name[rand.Next(0,5)], age[rand.Next(0,5)], sex[rand.Next(0, 2)], address[rand.Next(0, 5)]);
                st[i].showInfoStu();
                //
                //Console.WriteLine(st[i]);
            }
            st[9] = new Student("전우치", 24, '남', "강원도");
            st[9].showInfoStu();
            //7. 10번째 학생 정보를 변경

        }
    }
}
