using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oraWinform622
{
    public partial class Viewform : Form
    {
        public Viewform()
        {
            InitializeComponent();
            //initListView();
        }

        public void initListView()
        {
            string[] data = { "1", "홍길동", "200", "대구 북구 사수동" };
            listView1.Items.Add(new ListViewItem(data));
            for(int i=0; i<50; i++)
            {
                listView1.Items.Add(new ListViewItem(
                new string[]
                {
                    (i+2).ToString(), "홍길동",(100+i).ToString(),"대구 북구 산격동"
                }));
            }

            //listview의 마지막행 자동 선택
            int index = listView1.Items.Count - 1;
            listView1.Items[index].Selected = true;
            listView1.Items[index].Focused = true;
            listView1.Focus();
            listView1.EnsureVisible(index);

            //선택된 마지막행 컬럼값 변경
            listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text = "전우치";
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = (200).ToString(); ;
            listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text = "조선";

            
        }

        private void onViewLoad(object sender, EventArgs e)
        {
            initListView();
            initGridview();
        }

        private void onGetItem(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            //선택한 행의 값을 가져오기
            ListViewItem item = listView1.SelectedItems[0];
            MessageBox.Show("번호 " + item.SubItems[0].Text+ "이름 " 
                + item.SubItems[1].Text+ "나이 " + item.SubItems[2].Text
                + "주소 " + item.SubItems[3].Text);
        }

        public void initGridview()
        {
            string[] data = { "1", "홍길동", "200", "대구 북구 사수동" };
            dataGridView1.Rows.Add(data);
            for (int i = 0; i < 50; i++)
            {
                dataGridView1.Rows.Add(new string[]
                {(i+2).ToString(), "홍길동",(100+i).ToString(),"대구 북구 산격동"});
            }

            //마지막행 자동 선택
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0];

            //셀값 변경
            dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value = "강동원";
            dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[2].Value = 38;
            dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value = "서울 강남";

            //선택한 행의 값 가져오기
            for (int i = 0; i < 4; i++)
            {
                MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[i].Value.ToString());
            }
        }
    }
}
