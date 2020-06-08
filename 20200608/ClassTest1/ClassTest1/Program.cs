using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest1
{
    //학생 클래스 정의
    class Student
    {
        //public    : 외부에서 접근가능
        //private   : 클래스 내부에서만 접근
        //protected : 상속받은 클래스에서 접근
        //속성, 특징(변수)
        private string name;
        private int age;
        public static string ID = "1111";

        public string Name
        {
            get { return name; }
            set { name = value; }
        } //private 변수에 접근하기 위해 정의

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //기본 생성자 역할: 정보 초기화
        public Student()
        {
            Console.WriteLine("기본 생성자 호출");
            name = "전우치";
            age = 200;
        }

        //생성자 오버로딩(중복정의)
        public Student(string name, int age)
        {
            //this : 객체(인스턴스)가 생성되어진 위치 정보
            this.name = name;
            this.age = age;
        }

        public void showStdInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //strudent클래스 객체(인스턴스) 생성
            Student std = new Student();
            //캡슐화 : 변수 접근시 getter setter이용
            //std.name = "홍길동";
            std.Name = "홍길동";

            Student std2 = new Student();
            //std2.age = 10;
            std2.Age = 40;

            Student std3 = new Student();
            Console.WriteLine("이름: " +std3.Name);
            Console.WriteLine("나이: " +std3.Age);

            Student std4 = new Student("박길동", 30);
            Console.WriteLine("ID: " + Student.ID);

            Console.WriteLine("----------");

            Car car = new Car();
            car.ShowInfoCar();

            Car car2 = new Car("현대", "흰색", 40000000, "그랜저");
            car2.Color = "파랑";
            car.ShowInfoCar();
        }
    }
}
