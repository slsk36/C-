﻿namespace SimpleCalc1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 22F);
            this.textBox1.Location = new System.Drawing.Point(41, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 41);
            this.textBox1.TabIndex = 0;
            // 
            // btn_click
            // 
            this.btn_click.Font = new System.Drawing.Font("굴림", 16F);
            this.btn_click.Location = new System.Drawing.Point(41, 117);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(63, 41);
            this.btn_click.TabIndex = 1;
            this.btn_click.Text = "7";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.num_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 16F);
            this.button2.Location = new System.Drawing.Point(124, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.num_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 16F);
            this.button3.Location = new System.Drawing.Point(205, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.num_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 16F);
            this.button4.Location = new System.Drawing.Point(285, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 16F);
            this.button5.Location = new System.Drawing.Point(41, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 41);
            this.button5.TabIndex = 8;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.num_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 16F);
            this.button6.Location = new System.Drawing.Point(124, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 41);
            this.button6.TabIndex = 7;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.num_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("굴림", 16F);
            this.button7.Location = new System.Drawing.Point(205, 180);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.num_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("굴림", 16F);
            this.button8.Location = new System.Drawing.Point(285, 180);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 41);
            this.button8.TabIndex = 5;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("굴림", 16F);
            this.button9.Location = new System.Drawing.Point(41, 247);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 41);
            this.button9.TabIndex = 12;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.num_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("굴림", 16F);
            this.button10.Location = new System.Drawing.Point(124, 247);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 41);
            this.button10.TabIndex = 11;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.num_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("굴림", 16F);
            this.button11.Location = new System.Drawing.Point(205, 247);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 41);
            this.button11.TabIndex = 10;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.num_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("굴림", 16F);
            this.button12.Location = new System.Drawing.Point(285, 247);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(63, 41);
            this.button12.TabIndex = 9;
            this.button12.Text = "×";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btn_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("굴림", 16F);
            this.button13.Location = new System.Drawing.Point(41, 316);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(63, 41);
            this.button13.TabIndex = 16;
            this.button13.Text = "CE";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btn_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("굴림", 16F);
            this.button14.Location = new System.Drawing.Point(124, 316);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(63, 41);
            this.button14.TabIndex = 15;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.num_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("굴림", 16F);
            this.button15.Location = new System.Drawing.Point(205, 316);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(63, 41);
            this.button15.TabIndex = 14;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btn_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("굴림", 16F);
            this.button16.Location = new System.Drawing.Point(285, 316);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(63, 41);
            this.button16.TabIndex = 13;
            this.button16.Text = "÷";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 388);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

