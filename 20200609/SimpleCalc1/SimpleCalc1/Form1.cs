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
        private string res;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "+":
                case "-":
                case "×":
                case "÷":
                    res += ((Button)sender).Text;
                    textBox1.Text = res;
                    //Console.WriteLine("0누름"); 디버깅을 위한 코드
                    break;
                case "CE":
                    textBox1.Clear();
                    res = string.Empty;
                    break;
                case "=":
                    char[] op = { '+', '-', '×', '÷' };
                    string[] opStr = res.Split(op);
                    foreach(var item in opStr)
                    {
                        Console.WriteLine(item);
                        int result = Int32.Parse(item);
                        Console.WriteLine(result);

                    }
                    

                    char[] val = { '0','1','2','3','4','5','6','7','8','9' };
                    string[] valStr = res.Split(val);
                    foreach(var item1 in valStr)
                    {
                        //Console.WriteLine(item1);
                        


                    }
                    



                    break;
                
            }
        }
    }
}
