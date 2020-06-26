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
    public partial class 예매 : Form
    {

        좌석 seat;

        protected string b1, b2, b3, b4, b5;
        Button btn = new Button();
       
        public 예매()
        {
            InitializeComponent();
           
        }
        public 예매(좌석 s)
        {
            InitializeComponent();
            seat = s;
        }

        private void 예매_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            SetupDataGridView();
        }

        public void SetupDataGridView()

        {

            this.Controls.Add(dataGridView1);



            // DataGridView의 컬럼 갯수를 3개로 설정합니다.

            dataGridView1.ColumnCount = 3;



            // DataGridView에 컬럼을 추가합니다.

            dataGridView1.Columns[0].Name = "등급";

            dataGridView1.Columns[1].Name = "영화";

            dataGridView1.Columns[2].Name = "장르";



        }

        public void PopulateDataGridView()

        {

            // DataGridView에 삽입할 데이터를 설정합니다.

            string[] row0 = { "15세이용가","미이라","액션/모험/판타지" };

            string[] row1 = { "청소년관람불가","악녀","액션/한국" };

            string[] row2 = { "12세이용가","원더우먼","액션/SF/어드밴처" };

            string[] row3 = { "12세이용가", "노무현입니다", "다큐멘터리" };

            string[] row4 = { "12세이용가", "캐리비안의해적 : 죽은자는 말이없다", "액션/모험/코미디" };

            string[] row5 = { "15세이용가", "대립군", "드라마" };



            // DataGridView에 한 줄씩 삽입합니다.

            dataGridView1.Rows.Add(row0);

            dataGridView1.Rows.Add(row1);

            dataGridView1.Rows.Add(row2);

            dataGridView1.Rows.Add(row3);

            dataGridView1.Rows.Add(row4);

            dataGridView1.Rows.Add(row5);


            // DataGridView에 들어갈 컬럼의 순서를 지정합니다.

            dataGridView1.Columns[0].DisplayIndex = 0;

            dataGridView1.Columns[1].DisplayIndex = 1;

            dataGridView1.Columns[2].DisplayIndex = 2;

            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink||button3.BackColor==Color.LightPink || button4.BackColor == Color.LightPink
                || button5.BackColor == Color.LightPink)
            {
                button2.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
            }
            button1.BackColor = Color.LightPink;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
           || button5.BackColor == Color.LightPink)
            {
                button1.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
            }
            button2.BackColor = Color.LightPink;
            
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            treeView1.LineColor = Color.LightPink;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button1.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
           || button5.BackColor == Color.LightPink)
            {
                button1.BackColor = SystemColors.ButtonFace;
                button2.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
            }
            button3.BackColor = Color.LightPink;
     

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button1.BackColor == Color.LightPink
           || button5.BackColor == Color.LightPink)
            {
                button1.BackColor = SystemColors.ButtonFace;
                button2.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
            }
            button4.BackColor = Color.LightPink;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
           || button1.BackColor == Color.LightPink)
            {
                button1.BackColor = SystemColors.ButtonFace;
                button2.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
            }
            button5.BackColor = Color.LightPink;
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            좌석 seat = new 좌석();
            if (button1.BackColor == Color.LightPink)
            {
                seat.label20.Text = button1.Text;
            }
            else if (button2.BackColor == Color.LightPink)
            {
                seat.label20.Text = button2.Text;
            }
            else if (button3.BackColor == Color.LightPink)
            {
                seat.label20.Text = button3.Text;
            }
            else if (button4.BackColor == Color.LightPink)
            {
                seat.label20.Text = button4.Text;
            }
            else if (button5.BackColor == Color.LightPink)
            { 
            seat.label20.Text = button5.Text;
            }
            seat.label18.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
            seat.label19.Text = treeView1.SelectedNode.Text;
            seat.label21.Text = dateTimePicker1.Text;
            seat.ShowDialog();
            
        }
    }
}
