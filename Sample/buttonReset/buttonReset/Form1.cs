using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonReset
{
    public partial class Form1 : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        public Form1()
        {
            InitializeComponent();
        }

        public int seatprice;
        public int sum;

        private void setForeBackImageBtn()
        {
            button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            button1.BackgroundImage = Image.FromFile($@"{folder}\1st_24px.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            button2.BackgroundImage = Image.FromFile($@"{folder}\circled_2_c_24px.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setForeBackImageBtn();
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            button3.BackgroundImage = Image.FromFile($@"{folder}\circled_3_c_24px.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
