using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class 예매확인 : Form
    {
        public 예매확인()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader st = new System.IO.StreamReader(@"store.txt");
            if (textBox1.Text == st.ReadLine())
            {
                MessageBox.Show("예매정보 : " + st.ReadLine());
            }
            else
            {
                MessageBox.Show("예매정보가 없습니다.");
            }
        }
    }
}
