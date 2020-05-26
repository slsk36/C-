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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(Test(1000,11).ToString());

            MessageBox.Show(Math.PI.ToString()); //상수로 지정된 원주율 변하지 않음
           


            Product product1 = new Product("감자", 1000);
            Product product2 = new Product("무우", 100);
            int j = 1 + Product.test;
            //상수는 변경불가 product.test 값 변경불가
            MessageBox.Show(j.ToString());

            string showtext = $"{product1.mId} : {product1.mName}"
                + Environment.NewLine + $"{product2.mId} : {product2.mName}"
                + Environment.NewLine + $"{Product.mCounter}개 생성되었습니다.";

            Label label = new Label();
            label.AutoSize = true;
            label.Text = showtext;
            Controls.Add(label);


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
