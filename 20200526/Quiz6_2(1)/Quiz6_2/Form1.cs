using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private int limitTime;
        int answer = 0;
        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer = 0;
            label1.Text = "game start";
            answer = new Random().Next(1, 26);
            label3.Text = answer.ToString();
            Console.WriteLine("answer: " + answer);
            int count = 1; //순차적으로 텍스트를 써주는 변수
            for(int i=0; i<5; i++) //5*5버튼 생성
            {
                for(int j=0; j<5; j++)
                {
                    Button button = new Button();
                    Point point = new Point();
                    point.X = 13 + 100 * j;
                    point.Y = 13 + 13 + (23 + 3) * i;
                    button.Location = point;
                    button.Click += Button_Click; //tap누르기
                    button.Text = count.ToString();
                    count++;
                    Controls.Add(button);


                }
            }//버튼 만들기

            timer1.Enabled = true; //타이머 상태 바꿈
            if(int.TryParse(Limit_time.Text,out limitTime))
            {
                timer = -1;
            }//예외처리

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == answer.ToString())
            {
                label1.Text = "보물";
                timer = 0;
                label2.Text = timer.ToString();
                timer1.Stop();
            }
            else
            {
                label1.Text = "꽝";
            }
            //throw new NotImplementedException();
        }

        private int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer > limitTime || timer == -1) {
                label1.Text = "Game over";
                timer = 0;
                MessageBox.Show("Game over");

                timer1.Stop();
            }
        }
    }
}
