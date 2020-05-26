using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//한 게임회사의 총 회원수와 리스트 구하기
namespace characterEx
{
    class GameCharacter
    {
        public string mId;
        public static int mCountOfMember=0;

        public GameCharacter() {
            mCountOfMember++;
        }
       
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GameCharacter leedongjoon = new GameCharacter() { mId = "ldj" };
            GameCharacter leedongjoo = new GameCharacter() { mId = "lhj" };

            List<string> idList = new List<string>();

            idList.Add(leedongjoon.mId);
            idList.Add(leedongjoo.mId);

            for(int i=0; i<idList.Count; i++)
            {
                Label label = new Label();
                label.Text = idList[i];
                label.Location = new Point(13, 13 + (23 + 3) * i);
                Controls.Add(label);
            }

            MessageBox.Show($"게임 회원수는 총 {GameCharacter.mCountOfMember} 명입니다");


        }

    }
}
