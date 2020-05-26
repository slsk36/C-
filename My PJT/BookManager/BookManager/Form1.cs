﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
            Text = "도서관 관리";

            //라벨설정
            label5.Text = DataManager.Books.Count.ToString();
            label6.Text = DataManager.Users.Count.ToString();
            label7.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            label8.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
            }).Count().ToString();

            //데이터 그리드 설정
            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
            dataGridView2.CurrentCellChanged += DataGridView2_CurrentCellChanged;

            //버튼 이벤트 설정
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void DataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            try {
                //그리드의 셀이 선택되면 텍스트 박스에 글자 지정
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.Isbn;
                textBox2.Text = book.Name;
            }
            catch(Exception exception) {
                
            }
        }

        private void dataGridView2_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            try {
                //그리드2의 셀이 선택되면 텍스트 박스에 글자 지정 
                User book = dataGridView2.CurrentRow.DataBoundItem as User;
                textBox3.Text = book.Id.ToString();
            }
            catch(Exception exception) {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "") {
                MessageBox.Show("Isbn을 입력해주세요");
            }
            else if(textBox3.Text.Trim() == "") {
                MessageBox.Show("사용자 ID를 입력해주세요");
            }
            else {
            try {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox3.Text);
                    if(book.isBorrowed) {
                        MessageBox.Show("이미 대여중인 도서");
                    }
                    else {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox3.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();

                        MessageBox.Show("\"" + book.Name + "\"이/가" + user.Name + "\"님께 대여되었습니다.");
                    }
            }
            catch(Exception exception) {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자");
            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "") {
                MessageBox.Show("Isbn 입력");
            }
            else {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    if (book.isBorrowed)
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == book.UserId.ToString());
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        dataGridView1.DataSource = null;
                        dataGridView2.DataSource = DataManager.Books;
                        DataManager.Save();

                        if (book.BorrowedAt.AddDays(7) > DateTime.Now)
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 연체 상태로 반납되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 반납되었습니다.");

                        }
                    }
                    else
                    {
                        MessageBox.Show("대여 상태가 아닙니다.");
                    }
                }
                catch(Exception exception) {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자 입니다.");
                }
            }
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}
