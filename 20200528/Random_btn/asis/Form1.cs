using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asis

{
    
    //버튼 1~5개까지 랜덤으로 생성하기 is와 as를 이용
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls) //form1에 있는 모든 컨트롤들을 하나하나 살펴본다.
            {
                //if(item.GetType() == typeof(Button)) //아이템의 타입이 버튼이고
                //{
                //    if(((Button)item).Text.Contains("번째"))
                //    {
                //        ((Button)item).Visible = false;

                //    }
                //}

                //if(item is Button)
                //    {
                //        if (((Button)item).Text.Contains("번째"))
                //        {
                //            ((Button)item).Visible = false;
                //        }
                //    }

                //if(item is Button)
                //{
                //    if((item as Button).Text.Contains("번째"))
                //    {
                //        (item as Button).Visible = false;
                //    }
                //}

                var button = item as Button;
                if (button != null && button.Text.Contains("번째"))
                {
                    button.Visible = false;
                }
            }


            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Location = new Point(13, 50 + (23 + 3) * i);
                button.Text = $"{i + 1}번째 생성";
                button.Width = 200;

                Random rand = new Random();
                bool visible = rand.Next(0, 2) == 0 ? false : true;

                Thread.Sleep(10);

                button.Visible = visible;
                Controls.Add(button);
            }
        }

    
        
        }
    }


