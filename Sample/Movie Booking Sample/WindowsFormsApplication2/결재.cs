using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class 결재 : Form
    {
        예매 resv = new 예매();
        double fee5;
        double fee10;
        double fee20;
        double a;
        double result;
        double result1;
        double result2;

        좌석 seat;

        public 결재()
        {
            InitializeComponent();
        }
        public 결재(좌석 s)
        {
            InitializeComponent();
            this.seat = s;
        }


        private void 결재_Load(object sender, EventArgs e)
        {
            
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fee5 = 0.05;
            a = Convert.ToInt32(textBox1.Text);
            result = a * fee5;
            textBox2.Text = Convert.ToString(result);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fee10 = 0.1;
            a = Convert.ToInt32(textBox1.Text);
            result = a * fee10;
            textBox2.Text = Convert.ToString(result);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fee20 = 0.2;
            a = Convert.ToInt32(textBox1.Text);
            result = a * fee20;
            textBox2.Text = Convert.ToString(result);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToInt32(textBox1.Text);
            result2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(result1 - result2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sine = new System.IO.StreamWriter(@"sine.txt", append: true);
            sine.WriteLine(textBox3.Text);
            sine.Close();
            sine.Dispose();
            MessageBox.Show("결제완료\n 금액 : "+textBox3.Text+"\n 영화 : "+label5.Text+ "\n 시간 : "+label13.Text + "\n좌석 : \n"+label6.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter st = new System.IO.StreamWriter(@"store.txt", append: true);
            st.Write(textBox8.Text);
            st.WriteLine();
            st.Write(label5.Text);
            st.WriteLine();
            st.Write(label6.Text);
            st.Write(label13.Text);
            st.WriteLine();
            st.Close();
            st.Close();
            MessageBox.Show("예매 정보가 저장 되었습니다.");
        }
    }
}
