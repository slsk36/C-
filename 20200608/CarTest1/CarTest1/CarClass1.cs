using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest1
{
    class CarClass1
    {
        private string model;
        private string color;
        private int year;
        private string company;

        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Company { get; set; }

        public void showInfoCar()
        {
            Console.WriteLine(model);
            Console.WriteLine(color);
            Console.WriteLine(year);
            Console.WriteLine(company);
        }

        public CarClass1 (string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

    }
}

