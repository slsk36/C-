using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
    public partial class BasicCalc : Form
    {
        int num1;

        public BasicCalc()
        {
            InitializeComponent();
        }

        private void onExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onHelp(object sender, EventArgs e)
        {
            MessageBox.Show("간단한 계산을 수행하는 앱!",
                "간단 계산기",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(input1.Text);
            int n2 = Convert.ToInt32(input2.Text);
            int re = n1 + n2;
            result.Text = re.ToString();
        }


        private void btn_minus_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int result = n1 - n2;
            answer2.Text = result.ToString();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox3.Text);
            int n2 = Convert.ToInt32(textBox4.Text);
            int result = n1 * n2;
            answer3.Text = result.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox5.Text);
            int n2 = Convert.ToInt32(textBox6.Text);
            int result = n1 / n2;
            answer4.Text = result.ToString();
        }

       
    }
}
