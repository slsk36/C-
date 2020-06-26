using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class 매점 : Form
    {
        int price = 0;
        int sum = 0;

        public 매점()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price = 4500;
            label3.Text += "고소팝콘(M)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price = 5000;
            label3.Text += "달콤팝콘(M)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price = 5000;
            label3.Text += "고소팝콘(L)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price = 6000;
            label3.Text += "어니언팝콘(L)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price = 6000;
            label3.Text += "치즈팝콘(L)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price = 4500;
            label3.Text += "칠리치즈나초";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price = 3500;
            label3.Text += "오징어(완)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price = 2500;
            label3.Text += "콜라(L)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price = 2500;
            label3.Text += "사이다(L)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price = 2500;
            label3.Text += "환타포도(L)";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price = 8000;
            label3.Text += "팝콘 콤보";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price = 11000;
            label3.Text += "즉석구이콤보";
            sum += price;
            textBox2.Text = Convert.ToString(price);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = Convert.ToString(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = Convert.ToString(sum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sell = new System.IO.StreamWriter(@"sell.txt", append: true);
            sell.WriteLine(textBox1.Text);
            sell.Close();
            sell.Dispose();
            MessageBox.Show("총 금액 : "+ textBox1.Text+"원 입니다.");
        }
    }
}
