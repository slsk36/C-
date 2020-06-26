using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class 로그인 : Form
    {
       
        public 로그인()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            user use = new user();
            use.setID("admin");
            use.setPASS("admin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            회원가입 f2 = new 회원가입();
            메인 f3 = new 메인();
            관리자 f4 = new 관리자();
            로그인 f1 = new 로그인();

            System.IO.StreamReader info = new System.IO.StreamReader(@"info.txt");
            

            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "admin")
                {
                    MessageBox.Show("관리자 모드입니다.");
                    
                    f4.Show();
                }
                else
                {
                    MessageBox.Show("비밀번호가 다릅니다.");
                }
            }
            else if(textBox1.Text == info.ReadLine())
            {
               
                if (textBox2.Text == info.ReadLine())
                {
                    MessageBox.Show("환영합니다.");
                    
                    f3.Show();
                    
                }
                else
                    MessageBox.Show("비밀번호가 다릅니다.");
            }
            else if(textBox1.Text == "비회원"&& textBox2.Text == "1")
            {
                MessageBox.Show("비회원 모드 입니다.");
                
                f3.Show();
                
            }
            else
            {
                MessageBox.Show("등록된 정보가 없습니다.");
            }
            info.Close();
            info.Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            회원가입 f2 = new 회원가입();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            예매확인 enter = new 예매확인();
            enter.Show();
        }
    }
}
