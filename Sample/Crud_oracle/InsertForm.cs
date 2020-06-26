using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace oraWinform622
{
    public partial class InsertForm : MaterialForm
    {
        public InsertForm()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue400, Primary.Blue500,
            Primary.Blue400, Accent.LightBlue200,
            TextShade.WHITE
            );

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string name = nameTextField.Text;
            string age = ageTextField2.Text;
            string addr = addrTextField3.Text;

            //공백인지 아닌지 체크
            if(name == "" || age =="" || addr == "")
            {
                MessageBox.Show("입력하세요", "입력오류",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                DbManger.getInstance().insertDB(name, Convert.ToInt32(age), addr);
                Close();
            }

        }

        
    }
}
