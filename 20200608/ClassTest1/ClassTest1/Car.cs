using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest1
{
    //1. 속성: 대리점 명은 상수 클래스 변수
    //2. 속성: 제조사,색상,가격,모델 인스턴스 변수로 생성
    //3. 캡슐화 사용(외부 접근 차단)
    //4. 기본 생성자 생성 - 변수 초기화
    //제조사명: 기아, 색상: 블랙, 모델: K7
    //가격: 4000만원, 대리점명: 동대구영업소
    //5. 생성자 오버로딩 적용(모든 인스턴스 변수 갯수만큼 매개변수 사용)
    //6. 모든 속성 정보를 출력하는 인스턴스 메소드 추가.

    class Car
    {
        private string factory; //2
        private string color;
        private int price;
        private string model;

        private static string agency = "동대구영업소"; //1



        public Car()
        {
            factory = "기아";
            color = "블랙";
            model = "K7";
            price = 40000000;
            //agency = "동대구영업소";
        }

        public Car(string factory, string color, int price, string model)
        {
            this.factory = factory;
            this.color = color;
            this.model = model;
            this.price = price;
            //this.agency = "동대구영업소";
        }
        public void ShowInfoCar()
        {
            Console.WriteLine(factory);
            Console.WriteLine(color);
            Console.WriteLine(model);
            Console.WriteLine(price);
            Console.WriteLine(Car.agency);
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    
}
