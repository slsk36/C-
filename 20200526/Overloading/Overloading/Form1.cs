using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading
{
    class Myclass
    {
        public void test()
        {
            
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(Test(1000,11).ToString());
        }

        private static void print()
        {

        }

        //뭘 집어넣어도 리턴은 0

        //public double Test(int input)
        //{
        //    return input;
        //}     

        // 매개변수가 같으면 오류

        public int Test(int input)
        {
            return 0; 
        }

        public int Test(int input, int input2)
        {
            return 0;
        }
        //매개변수가 다를경우 오류나지 않음
        public int Test(double input)
        {
            return 0;
        }
    }
}
