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
        public Form1()
        {
            InitializeComponent();
            
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

        
    }
}
