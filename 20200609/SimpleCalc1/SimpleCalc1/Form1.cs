using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc1
{
    public partial class Form1 : Form
    {
        private string op;    //연산자
        private int num = 0;  //숫자
        

        public Form1()
        {
            InitializeComponent();
        }




        public void btn_Click(object sender, EventArgs e)
        {
            /*
            switch (((Button)sender).Text)
            {
                case "+":
                case "-":
                case "×":
                case "÷":
                case "=":
                    textBox1.Text = num.ToString();
                    break;
                    res += ((Button)sender).Text;
                    textBox1.Text = res;

                    char[] op = { '+', '-', '×', '÷' };
                    string[] opStr = res.Split(op);
                    
                    foreach (var item in opStr)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine(res);
                    

                    char[] val = { '0','1','2','3','4','5','6','7','8','9' };
                    string[] valStr = res.Split(val);
                    
                    foreach (var item1 in valStr)
                    {

                    }
                    
                    int result = 0;
                        if(valStr[i] != "")
                        {
                            int num = int.Parse(textBox1.Text);
                            switch (valStr[i])
                            {
                                case "+":
                                    result += num;
                                    break;
                                case "-":
                                    result -= num;
                                    break;
                                case "×":
                                    result *= num;
                                    break;
                                case "÷":
                                    result /= num;
                                    break;
                            }
                        textBox1.Text = result.ToString();
                    }
                    
                    
                    break;
                    

                case "CE":
                    textBox1.Clear();
                    res = string.Empty;
                    break;

            }
            */
        }

        private void num_Click(object sender, EventArgs e) //0~9까지 클릭했을때 이벤트
        {
            Button btn = (Button)sender; //버튼의 숫자를 받아옴
            textBox1.Text += btn.Text;   //출력창에 버튼의 text를 추가
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //버튼의 숫자를 받아옴
            textBox1.Text += btn.Text;   //출력창에 버튼의 text를 추가
            textBox1.Text = (num + int.Parse(textBox1.Text)).ToString();
            num = int.Parse(textBox1.Text);
        }

        
    }
}
