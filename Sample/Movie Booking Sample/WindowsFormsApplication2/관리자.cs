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
    public partial class 관리자 : Form
    {
        int a, b, res;

        public 관리자()
        {
            InitializeComponent();
        }
        private void 관리자_Load(object sender, EventArgs e)
        {
            
            System.IO.StreamReader see = new System.IO.StreamReader(@"sell.txt");
            System.IO.StreamReader sine = new System.IO.StreamReader(@"sine.txt");
            System.IO.StreamReader st = new System.IO.StreamReader(@"store.txt");
            textBox2.Text = see.ReadLine();
            textBox3.Text = sine.ReadLine();
            label6.Text = st.ReadToEnd();

            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox2.Text);

            res = a + b;

            textBox1.Text = Convert.ToString(res);
           // listBox1.Text = st.ReadLine();
        }
    }
}
