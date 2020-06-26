using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Form1 : Form
    {
        //SQL connection 에 대한 명령어를 변수 설정
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteLog(string contents) //로그파일을 만들어서 수정내역 추적
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            LogWriter.PrintLog(logContents);
                
        }

        private void selectQuery()  //데이터 수정 후에 새로고침 하는 변수만들기
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(Infomation.Strconn);
            sqlcon.Open();  //접속

            SqlDataAdapter adpt = new SqlDataAdapter("select * from MemberTable", sqlcon);
            adpt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0]; //datasource를 뷰에 집어넣는다
            sqlcon.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //MessageBox.Show($"선택한 값: {dataGridView1[e.ColumnIndex, e.RowIndex].Value}");
                //string.format으로 사용도 가능
                

                txt_id.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                txt_name.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txt_age.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txt_etc.Text = dataGridView1[4, e.RowIndex].Value.ToString();       //textbox에 그리드뷰 클릭하면 내용이 표시되도록
            }
            catch (Exception ect)
            {
                MessageBox.Show(ect.Message);
                MessageBox.Show(ect.StackTrace); //오류추적

            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Select 버튼 클릭");
            //WriteLog("Select 버튼 클릭");
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(Infomation.Strconn);
            sqlcon.Open();  //접속

            SqlDataAdapter adpt = new SqlDataAdapter("select * from MemberTable where name", sqlcon);
            adpt.Fill(ds,"MemberTable");

            label1.Text = ds.Tables[0].Rows[0][0].ToString();

            //DataTable dt = new DataTable();

            //dataGridView1.DataSource = ds.Tables[0]; //datasource를 뷰에 집어넣는다
            //label1.Text = ds.Tables

            sqlcon.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Insert 완료");
            //WriteLog("Insert 완료");

            SqlConnection conn = new SqlConnection(Infomation.Strconn);
            conn.Open(); //열면 반드시 닫아주기
            SqlCommand cmd = new SqlCommand("insert into MemberTable" +
                "(ID,Name,age,rgdate,etc)" + "values" + "(@ID,@name,@age,getdate(),@etc)", conn);

            cmd.Parameters.AddWithValue("@ID", txt_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@age", txt_age.Text);
            cmd.Parameters.AddWithValue("@etc", txt_etc.Text);      //파라미터에 어떤 값이 들어갈지 적어주기

            cmd.ExecuteNonQuery();
            

            conn.Close();
            selectQuery();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("update 완료");
            WriteLog("update 완료");

            SqlConnection conn = new SqlConnection(Infomation.Strconn);

            conn.Open();

            SqlCommand cmd = new SqlCommand("update MemberTable set name=@name,age=@age,etc=@etc where ID=@ID", conn);
            cmd.Parameters.AddWithValue("@ID", txt_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@age", txt_age.Text);
            cmd.Parameters.AddWithValue("@etc", txt_etc.Text);
            cmd.ExecuteNonQuery();


            conn.Close();
            selectQuery(); //무조건 클로즈하고 나서 넣기

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("delete 완료");
            WriteLog("delete 완료");
            SqlConnection conn = new SqlConnection(Infomation.Strconn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from MemberTable where ID = @ididid", conn);
            cmd.Parameters.AddWithValue("@ididid", txt_id.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            selectQuery();
        }
    }
}
