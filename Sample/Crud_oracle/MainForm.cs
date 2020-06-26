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
    public partial class MainForm : MaterialForm
    {
        DbManger db = new DbManger();
        DbManger inst = DbManger.getInstance();
        
        public MainForm()
        {
            InitializeComponent();
            //DbManger.getInstance().dbConnect();
            db.dbConnect();
            
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue400, Primary.Blue500,
            Primary.Blue500, Accent.LightBlue200,
            TextShade.WHITE
            );
        }

        private void createTable_Click(object sender, EventArgs e)
        {
            db.createTable();
        }

        private void onDropTable(object sender, EventArgs e)
        {
            db.dropTable();
        }

        private void onExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onHelp(object sender, EventArgs e)
        {
            MessageBox.Show("오라클DB 관리 프로그램 v1.4\n"+
                "2020.6.22 by hack4ork\nDB를 연동하여 데이터를 관리합니다.",
                "프로그램 정보",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void onInsert(object sender, EventArgs e)
        {
            InsertForm insert = new InsertForm();
            insert.ShowDialog();

            //Console.Write("이름 입력: ");
            //string name = Console.ReadLine();
            //db.insertDB(name, 100, "조선 팔도 방방곡곡");
        }

        private void onShowDB(object sender, EventArgs e)
        {
            Viewform view = new Viewform();
            view.ShowDialog();
        }
    }
}
