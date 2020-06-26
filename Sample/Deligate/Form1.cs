using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormData622
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onCallSubForm(object sender, EventArgs e)
        {
            SubForm sub = new SubForm("홍길동");
            sub.onSubFormSendEvent += onGetMsgEvent;
            sub.ShowDialog();
        }

        public void onGetMsgEvent(string str)
        {
            if (str == "")
            {
                label2.Text = "전달받은 데이터가 없습니다.";
            }
            else
            {
                label2.Text = str;
            }
        }
    }
}
