using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz6_1

//1. 숫자 맞추기 게임에 타이머를 추가하여 타이머 안에 숫자를 못 맞출 경우 Label로 Time Over라고 나타나게 하시오
{
    public partial class Form1 : Form
    {
        private int answerNum;
        public Form1()
        {
            InitializeComponent();
            answerNum = new Random().Next(1, 100);
            label_answer.Text = answerNum.ToString();

        }

        
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            if(input != answerNum)
            {
                MessageBox.Show("오답");
                answerNum = new Random().Next(1, 100);
                label_answer.Text = answerNum.ToString();
            }
            else
            {
                MessageBox.Show("정답");
                

                timer1.Stop();
            }
        }

        private int timer = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer--;
                label_time.Text = timer +" 초";
            }
            else
            {
                label_time.Text = "Time Over";
                this.Hide();
                Form2 gameover = new Form2();
                gameover.Show();
                timer1.Stop(); //코드 누락시 무한팝업
            }
        }
    }
}
