using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest1
{
    /// <summary>
    /// 차량 관리 프로그램 v1.0
    ///1. Car 클래스 생성
    ///2. 속성 - 모델명, 색상, 연식, 제조회사 (private)
    ///3. Car 클래스 getter, setter 추가
    ///4. 모든 속성 정보 출력 메소드 추가
    ///5. 고객클래스 생성
    ///6. 고객 클래스 속성- private
    ///  car 클래스 객체, 이름, 전화번호, 주소
    ///  customer 생성자 오버로딩 적용(매개변수 사용)
    ///7. 고객 클래스 get set 추가
    ///8. 고객 클래스 모든 속성 정보 출력 메소드 추가
    ///9. main()에서 배열 초기화작업
    ///  name = {"홍길동","김길동","이길동","최길동","박길동"}
    ///  tel = {"010-1111-1234", "010-1222-1234","010-1133-1234","010-1144-1234","010-1155-1234"}
    ///  address={"서울","대구","대전","부산","광주"}
    ///  model = {"SM6","sonata","santafe","K7","morning"}
    ///  color = {"블랙","그레이","흰색","빨강","파랑"}
    ///  year = {2017,2018,2019,2020,2021}
    ///  company={"르노삼성","현대","기아","쉐보레","쌍용"}
    ///12.고객 정보를 10명 생성
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "이길동", "최길동", "박길동" };
            string[] tel = { "010-1111-1234", "010-1222-1234", "010-1133-1234", "010-1144-1234", "010-1155-1234" };
            string[] address = { "서울", "대구", "대전", "부산", "광주" };
            string[] model = { "SM6", "sonata", "santafe", "K7", "morning" };
            string[] color = { "블랙", "그레이", "흰색", "빨강", "파랑" };
            int[] year = { 2017, 2018, 2019, 2020, 2021 };
            string[] company = { "르노삼성", "현대", "기아", "쉐보레", "쌍용" };

            Random rand = new Random();
            int r = rand.Next(0, 5);

            //int n = new int[10];
            Customer[] cs = new Customer[10];
            //CarClass1[] car = new CarClass1[10];
            

            for(int i=0; i<10; i++)
            {
                cs[i] = new Customer(name[rand.Next(0,5)], tel[rand.Next(0,5)], address[rand.Next(0,5)], 
                    new CarClass1(model[rand.Next(0,5)], color[rand.Next(0, 5)], year[rand.Next(0, 5)], company[rand.Next(0, 5)]) );
                cs[i].showInfoCus();
                //car[i] = new CarClass1(model[rand.Next(0, 5)], color[rand.Next(0, 5)], year[rand.Next(0, 5)], company[rand.Next(0, 5)]);
                //car[i].showInfoCar();
                Console.WriteLine("=================");
            }
        }
    }
}
