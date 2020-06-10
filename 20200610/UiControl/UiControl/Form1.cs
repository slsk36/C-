using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiControl
{
    public partial class Form1 : Form
    {
        Random random = new Random(30);
        private int n;

        public Form1()
        {
            n = 300;
            InitializeComponent();

            listView1.Columns.Add("Name");
            listView1.Columns.Add("Depth");
            
        }

        private void font_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        void changeFont()
        {
            if(cm_font.SelectedIndex < 0)
            {
                return;
            }

            FontStyle style = FontStyle.Regular;
            //체크박스가 체크되었는지
            if (bold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (itelic.Checked)
            {
                style |= FontStyle.Italic;
            }

            sample_text.Font = new Font((string)cm_font.SelectedItem, 16, style);
            
        }
        //윈도우 창이 처음 보여질때
        private void Form1_Load(object sender, EventArgs e)
        {
            //폰트정보 초기화
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
            {
                cm_font.Items.Add(font.Name);
            }
        }


        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        private void itelic_CheckedChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDownload.Value = tbDummy.Value;
        }

        private void btn_Modal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "모달";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();
        }

        private void btn_Modaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form () ;
            frm.Text = "모달리스";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Blue;
            frm.Show();
        }

        private void btn_Msg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sample_text.Text, "메시지박스창", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void tn_root_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(random.Next().ToString());
            treeToList();
        }

        private void btn_child_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "트리뷰", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            treeView1.SelectedNode.Nodes.Add(random.Next().ToString());
            treeView1.SelectedNode.Expand();
            treeToList();
        }

        void treeToList()
        {
            listView1.Items.Clear();
            foreach(TreeNode node in treeView1.Nodes)
            {
                treeToList(node);
            }
        }

        void treeToList(TreeNode node)
        {
            listView1.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }));
            foreach(TreeNode n in node.Nodes)
            {
                treeToList(n);
            }
        }
    }
}
