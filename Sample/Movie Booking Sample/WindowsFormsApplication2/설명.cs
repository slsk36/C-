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
    public partial class 설명 : Form
    {
        string pst;
        메인 main;
        
        public 설명()
        {
            InitializeComponent();
        }
        public 설명(string name, 메인 in_form)
        {
            InitializeComponent();
            pst = name;
            main = in_form;
        }
        private void 설명_Load(object sender, EventArgs e)
        {
            if (pst.Equals("pictureBox1"))
            {
                pictureBox1.Image = Properties.Resources.미이라;
                label1.Text = main.label1.Text;
                label2.Text = "The Mummy";
                label3.Text = main.label2.Text;
                label4.Text = "감독 : 알렉스 커츠만/ 배우 : 톡 크루즈, 소피아 부텔라, 애나벨 윌리스";
                label5.Text = "장르 : 액션, 모험, 판타지";
                label6.Text = main.label3.Text;
                label7.Text = "등급 : [국내] 15세 관람가 [해외] PG-13";
                label8.Text = "신들과 괴물들의 세상,\n절대적 존재가 깨어난다 !";
                label9.Text = "사막 한 가운데, 고대 이집트 미이라의 무덤을 발견한 닉(톰 크루즈)은 미이라의 관을 수송하던 중 의문의 비행기 \n\n추락사고로 사망한다. 그러나 죽음에서 다시 깨어난 닉!\n\n그는 자신이 발견한 미이라 무덤이 강력한 힘을 갈구한 잘못된 욕망으로 인해\n\n 산 채로 봉인 당해야 했던 아마네트 공주의 것이며, 자신이 부활하게 된 비밀이 이로부터 시작됨을 감지한다.\n\n한편, 수천 년 만에 잠에서 깨어난 아마네트는 분노와 파괴의 강력한 힘으로 전 세상을 자신의 것으로 만들려 하고, \n\n지킬 박사(러셀 크로우)는 닉에게 의미심장한 이야기를 전하게 되는데... 건드려선 안 될 \n\n강력한 존재와 이에 맞선 무한의 힘 마침내 세상을 구할 숙명적인 전쟁이 시작된다!";
            }
            else if(pst.Equals("pictureBox2"))
            {
                pictureBox1.Image = Properties.Resources.악녀;
                label1.Text = main.label4.Text;
                label2.Text = "The Villainess";
                label3.Text = main.label5.Text;
                label4.Text = "감독 : 정병길 / 배우 : 김옥빈, 신하균, 성준";
                label5.Text = "장르 : 액션 | 한국";
                label6.Text = main.label6.Text;
                label7.Text = "등급 : [국내]청소년 관람불가";
                label8.Text = "어린시절부터 킬러로 길러진 숙희.\n 그녀는 국가 비밀조직에 스카우트되어 새로운 삶을 살 기회를 얻는다.";
                label9.Text = "“10년만 일해주면 넌 자유야.\n하지만 가짜처럼 보이는 순간, 그땐 우리가 널 제거한다”\n\n살기 위해 죽여야만 하는 킬러 숙희 앞에\n진실을 숨긴 의문의 두 남자가 등장하고,\n\n자신을 둘러싼 엄청난 비밀에 마주하게 되면서 운명에 맞서기 시작하는데...\n\n\n“보여줄게, 내가 어떻게 만들어졌는지”";
               
            }
            else if (pst.Equals("pictureBox3"))
            {
                pictureBox1.Image = Properties.Resources.원우;
                label1.Text = main.label7.Text;
                label2.Text = "Wonder Women";
                label3.Text = main.label8.Text;
                label4.Text = "감독 : 패티 젠킨스 / 배우 : 갤 가돗, 로빈 라이트, 크리스 파인 ";
                label5.Text = "장르 : 액션, SF, 어드벤처, 환타지 ";
                label6.Text = main.label9.Text;
                label7.Text = "등급 : [국내] 12세이상 관람가 [해외] PG-13";
                label8.Text = "히어로의 새로운 기준 “내가 원더 우먼이다!”";
                label9.Text =
                "아마존 데미스키라 왕국의 공주 ‘다이애나 프린스’(갤 가돗)는 전사로서 훈련을 받던 중 최강 전사로서의 운명을 직감한다.\n\n" +
                "때마침 섬에 불시착한 조종사 ‘트레버 대위’(크리스 파인)를 통해 인간 세상의 존재와 그 곳에서 전쟁이 일어나고 있음을 알게 된다.\n\n" +
                "신들이 주신 능력으로 세상을 구하는 것이 자신의 사명임을 깨달은 다이애나는 \n\n" +
                "낙원과 같은 섬을 뛰쳐나와 1차 세계 대전의 지옥 같은 전장 한가운데로 뛰어드는데…\n\n";
            }
            else if (pst.Equals("pictureBox4"))
            {
                pictureBox1.Image = Properties.Resources.노무현입니다;
                label1.Text = main.label10.Text;
                label2.Text = "OUR PRESIDENT";
                label3.Text = main.label11.Text;
                label4.Text = "감독 : 이창재 / 출연 : 노무현 ";
                label5.Text = "장르 : 다큐멘터리 ";
                label6.Text = main.label12.Text;
                label7.Text = "등급 : [국내] 12세이상 관람가";
                label8.Text = 
                    "지지율 2%의 꼴찌 후보에서 대선후보 1위, 국민의 대통령이 되기까지\n"+
                    "뒤흔들었던 노무현, 그 기적의 역전 드라마\n";
                label9.Text =
                "국회의원, 시장 선거 등 출마하는 선거마다 번번이 낙선했던 만년 꼴찌 후보 노무현이\n" +
                 "\n2002년 대선 당시 대한민국 정당 최초로 도입된 새천년민주당 국민참여경선에 당당히 출사표를 던진다.\n" +
                "\n제주를 시작으로 전국 16개 도시에서 치러진 대국민 이벤트.\n" +
                   "\n쟁쟁한 후보들과 엎치락뒤치락하며 제주 경선 3위, 울산 1위, 그리고 광주까지 석권한\n" +
                "\n지지율 2 % 의 꼴찌 후보 노무현이 전국을 뒤흔들기 시작한다.";
            }
            else if (pst.Equals("pictureBox5"))
            {
                pictureBox1.Image = Properties.Resources.캐리비안;
                label1.Text = main.label13.Text;
                label2.Text = "Pirates of the Caribbean: Dead Men Tell No Tales";
                label3.Text = main.label14.Text;
                label4.Text = "감독 : 요아킴 뢰닝, 에스펜 잔드베르크 / 배우 : 조니 뎁, 하비에르 바르뎀, 제프리 러쉬";
                label5.Text = "장르 : 액션, 모험, 코미디, 판타지 ";
                label6.Text = main.label15.Text;
                label7.Text = "등급 : [국내] 12세이상 관람가 [해외] PG-13";
                label8.Text =
                    "죽음마저 집어삼킨 복수가 시작된다!\n";
                label9.Text =
               " 전설적인 해적 캡틴 ‘잭 스패로우’(조니 뎁)의 눈 앞에 죽음마저 집어삼킨 바다의 학살자\n\n" +
               "‘살라자르’(하비에르 바르뎀)가 복수를 위해 찾아온다. 둘 사이에 숨겨진 엄청난 비밀··· \n\n" +
               " 잭은 자신과 동료들의 죽음에 맞서 살아남기 위해 사투를 시작하는데··· \n\n\n\n" +
               "지금, 모든 것을 압도할 거대한 전투가 펼쳐진다!";
            }
            else if (pst.Equals("pictureBox6"))
            {
                pictureBox1.Image = Properties.Resources.대립;
                label1.Text = main.label16.Text;
                label2.Text = "WARRIORS OF THE DAWN";
                label3.Text = main.label17.Text;
                label4.Text = "감독 : 정윤철 / 배우 : 이정재, 여진구, 김무열";
                label5.Text = "장르 : 드라마 ";
                label6.Text = main.label18.Text;
                label7.Text = "등급 : [국내] 15세이상 관람가";
                label8.Text =
                    "\n";
                label9.Text =
              "1592년 임진왜란이 발발하자,\n"+
               "선조는 어린 ‘광해’(여진구)에게 조정을 나눈 ‘분조’를 맡기고 의주로 피란한다.\n\n"+
                "임금 대신 의병을 모아 전쟁에 맞서기 위해 머나 먼 강계로 떠난 광해와 분조 일행은\n"+
                "남의 군역을 대신하며 먹고 사는 대립군들을 호위병으로 끌고간다.\n\n"+
                 "대립군의 수장 ‘토우’(이정재)와 동료들은 광해를 무사히 데려다주고 공을 세워\n"+
                "비루한 팔자를 고치기 위해 위험을 무릅쓴다.\n\n"+
                "하지만 정체불명의 자객 습격과 왕세자를 잡으려는 일본군의 추격에\n"+
                "희생이 커지면서 서로 간에 갈등은 점점 깊어만 가는데…\n\n";
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pst.Equals("pictureBox1"))
            {
                this.linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://movie.naver.com/movie/bi/mi/mediaView.nhn?code=120160&mid=34341#tab");
            }
            else if (pst.Equals("pictureBox2"))
            {
                this.linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://movie.naver.com/movie/bi/mi/mediaView.nhn?code=155256&mid=34933#tab");
            }
            else if (pst.Equals("pictureBox3"))
            {
                this.linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://movie.naver.com/movie/bi/mi/mediaView.nhn?code=125473&mid=34112#tab");
            }
            else if (pst.Equals("pictureBox4"))
            {
                this.linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://movie.naver.com/movie/bi/mi/mediaView.nhn?code=162173&mid=34708#tab");
            }
            else if (pst.Equals("pictureBox5"))
            {
                this.linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://movie.naver.com/movie/bi/mi/mediaView.nhn?code=82473&mid=34197#tab");
            }
            else if (pst.Equals("pictureBox6"))
            {
                this.linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://movie.naver.com/movie/bi/mi/mediaView.nhn?code=149221&mid=34582#tab");
            }
        
        }
    }
}
