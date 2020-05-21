using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 가위:0, 바위:1, 보:2
        /// 가위바위보 게임 만들기
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mychoice = 0;
            int computerChoice = new Random().Next(0, 3);

            label2.Text = "가위";
            switch(computerChoice)
            {
                case 0:
                    label4.Text = "가위";
                    label6.Text = "비김";
                    break;
                case 1:
                    label4.Text = "바위";
                    label6.Text = "이김";
                    break;
                case 2:
                    label4.Text = "보";
                    label6.Text = "패배";
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mychoice = 1;
            int computerChoice = new Random().Next(0, 3);

            label2.Text = button2.Text;
            switch (computerChoice)
            {
                case 0:
                    label4.Text = "가위";
                    label6.Text = "패배";
                    break;
                case 1:
                    label4.Text = "바위";
                    label6.Text = "비김";
                    break;
                case 2:
                    label4.Text = "보";
                    label6.Text = "이김";
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mychoice = 2;
            int computerChoice = new Random().Next(0, 3);

            label2.Text = button3.Text;
            switch (computerChoice)
            {
                case 0:
                    label4.Text = "가위";
                    label6.Text = "패배";
                    break;
                case 1:
                    label4.Text = "바위";
                    label6.Text = "이김";
                    break;
                case 2:
                    label4.Text = "보";
                    label6.Text = "비김";
                    break;
                default:
                    break;
            }

        }
    }
}
