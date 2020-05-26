using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click +=//여기까지 입력하고 탭을 누르면 코드상 새로운 이벤트 자동 생성
                Button1_Click; 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "sadf"; //버튼을 누르면 버튼이 sadf로 바뀜
            textBox1.Text += "+";
            label1.Text += "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(e.CloseReason.ToString()); //창을 닫으면 userclosing 메세지 표시
        }


        private int elapsedTime = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = elapsedTime + "초 경과";
            //label1.Text = elapsedTime + "초 경과"; 
            //타이머 속성에서 interval은 1000(1초) enable true로 바꿔야 작동함
        }
    }
}
