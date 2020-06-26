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
    public partial class 메인 : Form
    {
       
        public 메인()
        {
            InitializeComponent();
        }
       

        public void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            설명 intro = new 설명(p1.Name, this);
            intro.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            설명 intro = new 설명(p1.Name, this);
            intro.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            설명 intro = new 설명(p1.Name, this);
            intro.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            설명 intro = new 설명(p1.Name, this);
            intro.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            설명 intro = new 설명(p1.Name, this);
            intro.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            설명 intro = new 설명(p1.Name, this);
            intro.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            설명 intro = new 설명(p1.Name, this);
            intro.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            설명 intro = new 설명(p1.Name, this);
            intro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            예매 reservation = new 예매();
            reservation.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            예매 reservation = new 예매();
            reservation.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            예매 reservation = new 예매();
            reservation.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            예매 reservation = new 예매();
            reservation.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            예매 reservation = new 예매();
            reservation.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            예매 reservation = new 예매();
            reservation.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            로그인 f1 = new 로그인();
            f1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            매점 snack = new 매점();
            snack.Show();
        }
    }
}
