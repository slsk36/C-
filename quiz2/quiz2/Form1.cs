using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz2
    //Random 함수를 사용하여 숫자맞추기 게임만들기
{
    public partial class Form1 : Form
    {
        private int answerNumber;
        
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("hello world");
            ////case 1
            //Random random = new Random();
            //answerNumber = random.Next(1, 11);

            //case 2
            answerNumber = new Random().Next(1, 11);
            label1.Text = answerNumber.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox_inp.Text);
            if(input > answerNumber)
            {
                MessageBox.Show("입력하신 숫자가 정답보다 큽니다");
            }
            else if(input < answerNumber)
            {
                MessageBox.Show("입력하신 숫자가 정답보다 작습니다");

            }
            else
            {
                MessageBox.Show("정답!");
                answerNumber = new Random().Next(1, 11);
                label1.Text = answerNumber.ToString();
            }
        }
        //Parse 잘못된 string 받으면 프로그램이 종료됨
        //TryParse 잘못된 string 받으면 값을 0으로 바꿔주고 그 함수 자체는 false를 리턴합니다



    }
}
