using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest1
{
    //1. 인스턴스 속성(외부에서 접근 차단)
    //- 이름,나이,성별,주소
    //2. 매개변수 사용하는 생성자 추가
    //3. getter, setter
    //4. 모든 속성 정보 출력하는 인스턴스 메소드 추가
    //5. main()에서 다음의 학생정보 배열 초기화
    //- 랜덤하게 생성하여 생성자 매개변수로 전달
    // string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
    // int[] age = { 20,25,30,35,40}
    // string[] sex = {'남','여'}
    // string[] address={"산골1", "산골2","산골3","산골4","산골5"}
    // ###############################################
    //6. 10명의 학생 정보 생성(객체 10개 생성)
    //7. 10번째 학생 정보를 변경
    // "전우치", 240, '남', "강원도"

    class Student
    {
        //1. 인스턴스 속성(외부에서 접근 차단)
        private string name;
        private int age;
        private char sex;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }//3. getter, setter

        public void showInfoStu() {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(sex);
            Console.WriteLine(address);
            Console.WriteLine("==============");
        }//4. 모든 속성 정보 출력하는 인스턴스 메소드 추가


        public Student(string name, int age, char sex, string address) {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.address = address;
        } 
        //2. 매개변수 사용하는 생성자 추가

    }
}
