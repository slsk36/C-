using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retangle_getset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            int w = int.Parse(textBox1.Text); //텍스트 박스에 너비를 입력받는다
            int h = int.Parse(textBox2.Text); //텍스트 박스에 높이를 입력받는다
            //Box box = new Box(w,h);
            //box.width = w;
            //box.height = h;

            Box box = new Box();
            //box.SetWidth(w);
            //box.SetHeight(h);
            box.mWidth = w;
            box.mHeight = h;

            label4.Text = box.Area().ToString();  //레이블 4에 box.area 의 리턴값이 입력된다

        }
    }
}
