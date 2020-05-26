using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwapFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            swapFuntion(ref a, ref b);
            textBox1_1.Text = a.ToString();
            textBox2_1.Text = b.ToString();

        }

        private void swapFuntion(ref int a, ref int b) //callbyvalue referencebyvalue
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
