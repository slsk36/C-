using System;
using System.Windows.Forms;

namespace tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //case 1
            new TestClass().Print();
            //case 2(recommanded)
            TestClass t = new TestClass();
            t.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int square = int.Parse(textBox1.Text);
            TestClass test = new TestClass();
            int result = test.Power(square);
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mul1 = int.Parse(textbox_mul1.Text);
            int mul2 = int.Parse(textbox_mul2.Text);
            TestClass test = new TestClass();
            int result = test.Multi(mul1, mul2);
            label2.Text = result.ToString();
        }
    }
}
