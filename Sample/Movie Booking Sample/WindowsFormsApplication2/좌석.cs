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
    public partial class 좌석 : Form
    {
        예매 reserv;
        int seatprice;
        int sum;
        
        private FormBorderStyle initialStyle;
      
        public 좌석()
        {
            initialStyle = this.FormBorderStyle;
            
            InitializeComponent();
            button29.Click += new EventHandler(button29_Click);
            this.Controls.Add(button29);
           
        }
        public 좌석(예매 r)
        {
            InitializeComponent();
            this.reserv = r;
        }
        void button29_DoubleClick(object sender, EventArgs e)
        {
            this.FormBorderStyle = initialStyle;
            this.BackColor = SystemColors.Control;
        }
        private void 좌석_Load(object sender, EventArgs e)
        {
            MessageBox.Show("좌석 선택은 최대 6개 입니다.");
            textBox1.Text = Convert.ToString(seatprice);
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button29_Click(object sender, EventArgs e) //성인 1명
        {
            button29.BackColor = Color.LightPink;
            if (button30.BackColor == Color.LightPink || button31.BackColor == Color.LightPink || button32.BackColor == Color.LightPink
                || button33.BackColor == Color.LightPink || button34.BackColor == Color.LightPink)
            {
                button30.BackColor = SystemColors.ButtonFace;
                button31.BackColor = SystemColors.ButtonFace;
                button32.BackColor = SystemColors.ButtonFace;
                button33.BackColor = SystemColors.ButtonFace;
                button34.BackColor = SystemColors.ButtonFace;
            }
            label15.Text = Convert.ToString(10000); //성인 수
            seatprice =Convert.ToInt32(label15.Text);
            sum += 10000;
        }

        private void button30_Click(object sender, EventArgs e) //성인2명
        {
            button30.BackColor = Color.LightPink;
            if (button29.BackColor == Color.LightPink || button31.BackColor == Color.LightPink || button32.BackColor == Color.LightPink
                || button33.BackColor == Color.LightPink || button34.BackColor == Color.LightPink)
            {
                button29.BackColor = SystemColors.ButtonFace;
                button31.BackColor = SystemColors.ButtonFace;
                button32.BackColor = SystemColors.ButtonFace;
                button33.BackColor = SystemColors.ButtonFace;
                button34.BackColor = SystemColors.ButtonFace;
            }
            label15.Text = Convert.ToString(20000);
            seatprice = Convert.ToInt32(label15.Text);
            sum += 20000;
        }
        
        private void button31_Click(object sender, EventArgs e) //성인 3명
        {
            button31.BackColor = Color.LightPink;
            if (button30.BackColor == Color.LightPink || button29.BackColor == Color.LightPink || button32.BackColor == Color.LightPink
                || button33.BackColor == Color.LightPink || button34.BackColor == Color.LightPink)
            {
                button30.BackColor = SystemColors.ButtonFace;
                button29.BackColor = SystemColors.ButtonFace;
                button32.BackColor = SystemColors.ButtonFace;
                button33.BackColor = SystemColors.ButtonFace;
                button34.BackColor = SystemColors.ButtonFace;
            }
            label15.Text = Convert.ToString(30000);
            seatprice = Convert.ToInt32(label15.Text);
            sum += 30000;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackColor = Color.LightPink;
            if (button30.BackColor == Color.LightPink || button31.BackColor == Color.LightPink || button29.BackColor == Color.LightPink
                || button33.BackColor == Color.LightPink || button34.BackColor == Color.LightPink)
            {
                button30.BackColor = SystemColors.ButtonFace;
                button31.BackColor = SystemColors.ButtonFace;
                button29.BackColor = SystemColors.ButtonFace;
                button33.BackColor = SystemColors.ButtonFace;
                button34.BackColor = SystemColors.ButtonFace;
            }
            label15.Text = Convert.ToString(40000);
            seatprice = Convert.ToInt32(label15.Text);
            sum += 40000;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.LightPink;
            if (button30.BackColor == Color.LightPink || button31.BackColor == Color.LightPink || button32.BackColor == Color.LightPink
                || button29.BackColor == Color.LightPink || button34.BackColor == Color.LightPink)
            {
                button30.BackColor = SystemColors.ButtonFace;
                button31.BackColor = SystemColors.ButtonFace;
                button32.BackColor = SystemColors.ButtonFace;
                button29.BackColor = SystemColors.ButtonFace;
                button34.BackColor = SystemColors.ButtonFace; 
            }
            label15.Text = Convert.ToString(50000);
            seatprice = Convert.ToInt32(label15.Text);
            sum += 50000;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.BackColor = Color.LightPink;
            if (button30.BackColor == Color.LightPink || button31.BackColor == Color.LightPink || button32.BackColor == Color.LightPink
                || button33.BackColor == Color.LightPink || button29.BackColor == Color.LightPink)
            {
                button30.BackColor = SystemColors.ButtonFace;
                button31.BackColor = SystemColors.ButtonFace;
                button32.BackColor = SystemColors.ButtonFace;
                button33.BackColor = SystemColors.ButtonFace;
                button29.BackColor = SystemColors.ButtonFace;
            }
            label15.Text = Convert.ToString(60000); //성인 6명
            seatprice = Convert.ToInt32(label15.Text);
            sum += 60000;
            
            
            
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.BackColor = Color.LightPink;
            if (button35.BackColor == Color.LightPink || button36.BackColor == Color.LightPink || button37.BackColor == Color.LightPink
                || button38.BackColor == Color.LightPink || button39.BackColor == Color.LightPink)
            {
                button35.BackColor = SystemColors.ButtonFace;
                button36.BackColor = SystemColors.ButtonFace;
                button37.BackColor = SystemColors.ButtonFace;
                button38.BackColor = SystemColors.ButtonFace;
                button39.BackColor = SystemColors.ButtonFace;
            }
            label16.Text = Convert.ToString(7000);  //청소년
            seatprice = Convert.ToInt32(label16.Text);
            sum += 7000;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.LightPink;
            if (button35.BackColor == Color.LightPink || button36.BackColor == Color.LightPink || button37.BackColor == Color.LightPink
                || button38.BackColor == Color.LightPink || button40.BackColor == Color.LightPink)
            {
                button35.BackColor = SystemColors.ButtonFace;
                button36.BackColor = SystemColors.ButtonFace;
                button37.BackColor = SystemColors.ButtonFace;
                button38.BackColor = SystemColors.ButtonFace;
                button40.BackColor = SystemColors.ButtonFace;
            }
            label16.Text = Convert.ToString(14000);
            seatprice = Convert.ToInt32(label16.Text);
            sum += 14000;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.BackColor = Color.LightPink;
            if (button35.BackColor == Color.LightPink || button36.BackColor == Color.LightPink || button37.BackColor == Color.LightPink
                || button40.BackColor == Color.LightPink || button39.BackColor == Color.LightPink)
            {
                button35.BackColor = SystemColors.ButtonFace;
                button36.BackColor = SystemColors.ButtonFace;
                button37.BackColor = SystemColors.ButtonFace;
                button40.BackColor = SystemColors.ButtonFace;
                button39.BackColor = SystemColors.ButtonFace;
            }
            label16.Text = Convert.ToString(21000);
            seatprice = Convert.ToInt32(label16.Text);
            sum += 21000;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.LightPink;
            if (button35.BackColor == Color.LightPink || button36.BackColor == Color.LightPink || button40.BackColor == Color.LightPink
                || button38.BackColor == Color.LightPink || button39.BackColor == Color.LightPink)
            {
                button35.BackColor = SystemColors.ButtonFace;
                button36.BackColor = SystemColors.ButtonFace;
                button40.BackColor = SystemColors.ButtonFace;
                button38.BackColor = SystemColors.ButtonFace;
                button39.BackColor = SystemColors.ButtonFace;
            }
            label16.Text = Convert.ToString(28000);
            seatprice = Convert.ToInt32(label16.Text);
            sum += 28000;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.LightPink;
            if (button35.BackColor == Color.LightPink || button40.BackColor == Color.LightPink || button37.BackColor == Color.LightPink
                || button38.BackColor == Color.LightPink || button39.BackColor == Color.LightPink)
            {
                button35.BackColor = SystemColors.ButtonFace;
                button40.BackColor = SystemColors.ButtonFace;
                button37.BackColor = SystemColors.ButtonFace;
                button38.BackColor = SystemColors.ButtonFace;
                button39.BackColor = SystemColors.ButtonFace;
            }
            label16.Text = Convert.ToString(35000);
            seatprice = Convert.ToInt32(label16.Text);
            sum += 35000;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.BackColor = Color.LightPink;
            if (button40.BackColor == Color.LightPink || button36.BackColor == Color.LightPink || button37.BackColor == Color.LightPink
                || button38.BackColor == Color.LightPink || button39.BackColor == Color.LightPink)
            {
                button40.BackColor = SystemColors.ButtonFace;
                button36.BackColor = SystemColors.ButtonFace;
                button37.BackColor = SystemColors.ButtonFace;
                button38.BackColor = SystemColors.ButtonFace;
                button39.BackColor = SystemColors.ButtonFace;
            }
            label16.Text = Convert.ToString(42000);
            seatprice = Convert.ToInt32(label16.Text);
            sum += 42000;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.BackColor = Color.LightPink;
            if (button41.BackColor == Color.LightPink || button42.BackColor == Color.LightPink || button43.BackColor == Color.LightPink
                || button44.BackColor == Color.LightPink || button45.BackColor == Color.LightPink)
            {
                button41.BackColor = SystemColors.ButtonFace;
                button42.BackColor = SystemColors.ButtonFace;
                button43.BackColor = SystemColors.ButtonFace;
                button44.BackColor = SystemColors.ButtonFace;
                button45.BackColor = SystemColors.ButtonFace;
            }
            label17.Text = Convert.ToString(5000);
            seatprice = Convert.ToInt32(label17.Text);
            sum += 5000;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.LightPink;
            if (button41.BackColor == Color.LightPink || button42.BackColor == Color.LightPink || button43.BackColor == Color.LightPink
                || button44.BackColor == Color.LightPink || button46.BackColor == Color.LightPink)
            {
                button41.BackColor = SystemColors.ButtonFace;
                button42.BackColor = SystemColors.ButtonFace;
                button43.BackColor = SystemColors.ButtonFace;
                button44.BackColor = SystemColors.ButtonFace;
                button46.BackColor = SystemColors.ButtonFace;
            }
            label17.Text = Convert.ToString(10000);
            seatprice = Convert.ToInt32(label17.Text);
            sum += 10000;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.BackColor = Color.LightPink;
            if (button41.BackColor == Color.LightPink || button42.BackColor == Color.LightPink || button43.BackColor == Color.LightPink
                || button46.BackColor == Color.LightPink || button45.BackColor == Color.LightPink)
            {
                button41.BackColor = SystemColors.ButtonFace;
                button42.BackColor = SystemColors.ButtonFace;
                button43.BackColor = SystemColors.ButtonFace;
                button46.BackColor = SystemColors.ButtonFace;
                button45.BackColor = SystemColors.ButtonFace;
            }
            label17.Text = Convert.ToString(15000);
            seatprice = Convert.ToInt32(label17.Text);
            sum += 15000;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.BackColor = Color.LightPink;
            if (button41.BackColor == Color.LightPink || button42.BackColor == Color.LightPink || button46.BackColor == Color.LightPink
                || button44.BackColor == Color.LightPink || button45.BackColor == Color.LightPink)
            {
                button41.BackColor = SystemColors.ButtonFace;
                button42.BackColor = SystemColors.ButtonFace;
                button46.BackColor = SystemColors.ButtonFace;
                button44.BackColor = SystemColors.ButtonFace;
                button45.BackColor = SystemColors.ButtonFace;
            }
            label17.Text = Convert.ToString(20000);
            seatprice = Convert.ToInt32(label17.Text);
            sum += 20000;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.LightPink;
            if (button41.BackColor == Color.LightPink || button46.BackColor == Color.LightPink || button43.BackColor == Color.LightPink
                || button44.BackColor == Color.LightPink || button45.BackColor == Color.LightPink)
            {
                button41.BackColor = SystemColors.ButtonFace;
                button46.BackColor = SystemColors.ButtonFace;
                button43.BackColor = SystemColors.ButtonFace;
                button44.BackColor = SystemColors.ButtonFace;
                button45.BackColor = SystemColors.ButtonFace;
            }
            label17.Text = Convert.ToString(25000);
            seatprice = Convert.ToInt32(label17.Text);
            sum += 25000;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.BackColor = Color.LightPink;
            if (button46.BackColor == Color.LightPink || button42.BackColor == Color.LightPink || button43.BackColor == Color.LightPink
                || button44.BackColor == Color.LightPink || button45.BackColor == Color.LightPink)
            {
                button46.BackColor = SystemColors.ButtonFace;
                button42.BackColor = SystemColors.ButtonFace;
                button43.BackColor = SystemColors.ButtonFace;
                button44.BackColor = SystemColors.ButtonFace;
                button45.BackColor = SystemColors.ButtonFace;
            }
            label17.Text = Convert.ToString(30000);
            seatprice = Convert.ToInt32(label17.Text);
            sum += 30000;
        }
        
        
        private void button47_Click(object sender, EventArgs e)
        {
            
            결재 calc = new 결재();
            calc.textBox1.Text = textBox1.Text;
            calc.label13.Text = label20.Text;
            calc.label5.Text = label18.Text;
            calc.label6.Text = label11.Text;
        
            calc.Show();
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text += "A1\n";
            button1.BackColor = Color.LightBlue;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text += "A2\n";
            button2.BackColor = Color.LightBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text += "A3\n";
            button3.BackColor = Color.LightBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Text += "A4\n";
            button4.BackColor = Color.LightBlue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label11.Text += "A5\n";
            button5.BackColor = Color.LightBlue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label11.Text += "A6\n";
            button6.BackColor = Color.LightBlue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label11.Text += "A7\n";
            button7.BackColor = Color.LightBlue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label11.Text += "B1\n";
            button14.BackColor = Color.LightBlue;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label11.Text += "B2\n";
            button13.BackColor = Color.LightBlue;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label11.Text += "B3\n";
            button12.BackColor = Color.LightBlue;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label11.Text += "B4\n";
            button11.BackColor = Color.LightBlue;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label11.Text += "B5\n";
            button10.BackColor = Color.LightBlue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label11.Text += "B6\n";
            button9.BackColor = Color.LightBlue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label11.Text += "B7\n";
            button8.BackColor = Color.LightBlue;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label11.Text += "C1\n";
            button21.BackColor = Color.LightBlue;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label11.Text += "C2\n";
            button20.BackColor = Color.LightBlue;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label11.Text += "C3\n";
            button19.BackColor = Color.LightBlue;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label11.Text += "C4\n";
            button18.BackColor = Color.LightBlue;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label11.Text += "C5\n";
            button17.BackColor = Color.LightBlue;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label11.Text += "C6\n";
            button16.BackColor = Color.LightBlue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label11.Text += "C7\n";
            button15.BackColor = Color.LightBlue;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label11.Text += "D1\n";
            button28.BackColor = Color.LightBlue;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label11.Text += "D2\n";
            button27.BackColor = Color.LightBlue;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label11.Text += "D3\n";
            button26.BackColor = Color.LightBlue;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label11.Text += "D4\n";
            button25.BackColor = Color.LightBlue;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label11.Text += "D5\n";
            button24.BackColor = Color.LightBlue;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label11.Text += "D6\n";
            button23.BackColor = Color.LightBlue;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label11.Text += "D7\n";
            button22.BackColor = Color.LightBlue;
        }

        private void button48_Click(object sender, EventArgs e) //모두취소
        {
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;
            button7.BackColor = SystemColors.Control;
            button8.BackColor = SystemColors.Control;
            button9.BackColor = SystemColors.Control;
            button10.BackColor = SystemColors.Control;
            button11.BackColor = SystemColors.Control;
            button12.BackColor = SystemColors.Control;
            button13.BackColor = SystemColors.Control;
            button14.BackColor = SystemColors.Control;
            button15.BackColor = SystemColors.Control;
            button16.BackColor = SystemColors.Control;
            button17.BackColor = SystemColors.Control;
            button18.BackColor = SystemColors.Control;
            button19.BackColor = SystemColors.Control;
            button20.BackColor = SystemColors.Control;
            button21.BackColor = SystemColors.Control;
            button22.BackColor = SystemColors.Control;
            button23.BackColor = SystemColors.Control;
            button24.BackColor = SystemColors.Control;
            button25.BackColor = SystemColors.Control;
            button26.BackColor = SystemColors.Control;
            button27.BackColor = SystemColors.Control;
            button28.BackColor = SystemColors.Control;
            button29.BackColor = SystemColors.Control;
            button30.BackColor = SystemColors.Control;
            button31.BackColor = SystemColors.Control;
            button32.BackColor = SystemColors.Control;
            button33.BackColor = SystemColors.Control;
            button34.BackColor = SystemColors.Control;
            button35.BackColor = SystemColors.Control;
            button36.BackColor = SystemColors.Control;
            button37.BackColor = SystemColors.Control;
            button38.BackColor = SystemColors.Control;
            button39.BackColor = SystemColors.Control;
            button40.BackColor = SystemColors.Control;
            button41.BackColor = SystemColors.Control;
            button42.BackColor = SystemColors.Control;
            button43.BackColor = SystemColors.Control;
            button44.BackColor = SystemColors.Control;
            button45.BackColor = SystemColors.Control;
            button46.BackColor = SystemColors.Control;
            
            label11.Text = "";
            textBox1.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            sum = 0;
        }

        private void button49_Click(object sender, EventArgs e) //계산
        {
            textBox1.Text = Convert.ToString(sum);
        }
    }
}
