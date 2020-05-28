using System.Windows.Forms;

namespace quiz6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1 cal = new Class1();
            //인스턴스 메소드 방식
            MessageBox.Show(cal.Power(5).ToString());
            MessageBox.Show(cal.Power(5,3).ToString());
            MessageBox.Show(cal.Sum(10).ToString());
            MessageBox.Show(cal.Sum(5,10).ToString());

            //클래스 메소드 방식
            MessageBox.Show(Class2.Power(5).ToString());
            MessageBox.Show(Class2.Power(5,3).ToString());
            MessageBox.Show(Class2.Sum(10).ToString());
            MessageBox.Show(Class2.Sum(5,10).ToString());


        }
    }
}
