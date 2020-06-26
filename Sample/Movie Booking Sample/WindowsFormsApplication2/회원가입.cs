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

    
    public partial class 회원가입 : Form
    {

        public 회원가입()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            user use = new user();
            use.setName(textBox1.Text);
            use.setID(textBox2.Text);
            use.setPASS(textBox3.Text);
            use.setTEL(textBox4.Text);
            System.IO.StreamWriter info = new System.IO.StreamWriter(@"info.txt",append:true);
            info.WriteLine(textBox1.Text);
            info.WriteLine(textBox2.Text);
            info.WriteLine(textBox3.Text);
            info.WriteLine(textBox4.Text);
            info.Close();
            info.Dispose();

            MessageBox.Show("가입을 축하합니다 !");
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
