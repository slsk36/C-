using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1
{
    //학생 클래스를 만들고 아래 데이터에 맞게 3개의 변수 만들기
    public partial class Form1 : Form
    {
        class Student
        {
            public string mName;
            public int mGender; //남0 여1
            public string mMajor;

            public Student() { }

            public Student(string name, int gender, string major)
            {
                mName = name;
                mGender = gender;
                mMajor = major;
            }

            public static implicit operator Student(string v)
            {
                throw new NotImplementedException();
            }
        }

        public Form1()
        {
            InitializeComponent();

            Student st1 = new Student();
            st1.mName = "이동준";
            st1.mGender = 0;
            st1.mMajor = "c#";

            Student st2 = new Student()
            {
                mName = "박명회", mGender = 0, mMajor = "java"
            };

            Student st3 = new Student("김은주", 1, "oracle");

            Student[] students = new Student[3];

            students[0] = st1;

            students[1] = st2;
            students[1] = new Student() { mName = "박명회", mGender = 0, mMajor = "java" };

            students[2] = st3;
            students[2] = new Student("김은주", 1, "oracle");


            string gender = st1.mGender == 0 ? "남" : "여";
            label_st1.Text = $"이름: {st1.mName}, 성별:{st1.mGender}, 주과목: {st1.mMajor}";

            gender = st2.mGender == 0 ? "남" : "여";
            label_st2.Text = $"이름: {st2.mName}, 성별:{st2.mGender}, 주과목: {st2.mMajor}";

            gender = st3.mGender == 0 ? "남" : "여";
            label_st3.Text = $"이름: {st3.mName}, 성별:{st3.mGender}, 주과목: {st3.mMajor}";

            for(int i=0; i< students.Length; i++)
            {
                Label label = new Label();
                string genderInfo = students[i].mGender == 0 ? "남" : "여";
                label.Text = $"이름: {students[i].mName}, 성별:{students[i].mGender}, 주과목: {students[i].mMajor}";
                Controls.Add(label);
                label.AutoSize = true;
                label.Location = new Point(15, 130 + 30 * i);
            }

        }



    }
}
