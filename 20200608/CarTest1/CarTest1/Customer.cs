using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest1
{
    class Customer
    {
        private string name;
        private string tel;
        private string address;
        private CarClass1 car; //carclass 객체정보 생성       

        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        //public CarClass1 Car { get; set; }

        public void showInfoCus()
        {
            Console.WriteLine(name);
            Console.WriteLine(tel);
            Console.WriteLine(address);
            car.showInfoCar();

        }

        public Customer(string name, string tel, string address, CarClass1 car) {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.car = car; //carclass1에서 만들어놓은 변수를 쓴다
        }//매개변수를 사용하는 생성자

    }
}
