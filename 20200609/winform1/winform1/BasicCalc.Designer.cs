namespace winform1
{
    partial class BasicCalc
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answer2 = new System.Windows.Forms.TextBox();
            this.answer3 = new System.Windows.Forms.TextBox();
            this.answer4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 36);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(72, 21);
            this.input1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(189, 195);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "확 인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.onExit);
            // 
            // btnInfo
            // 
            this.btnInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInfo.Location = new System.Drawing.Point(300, 195);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(114, 34);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "프로그램 정보";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.onHelp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(202, 34);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(72, 21);
            this.input2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(317, 34);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(69, 21);
            this.result.TabIndex = 6;
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(113, 102);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(61, 23);
            this.btn_multi.TabIndex = 7;
            this.btn_multi.Text = "×";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(113, 64);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(61, 23);
            this.btn_minus.TabIndex = 8;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(113, 141);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(61, 23);
            this.btn_div.TabIndex = 9;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(81, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 21);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 21);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 21);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(202, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 21);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(72, 21);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(202, 143);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(72, 21);
            this.textBox6.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "=";
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(317, 67);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(69, 21);
            this.answer2.TabIndex = 20;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(317, 102);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(69, 21);
            this.answer3.TabIndex = 21;
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(317, 143);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(69, 21);
            this.answer4.TabIndex = 22;
            // 
            // BasicCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 258);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.input1);
            this.Name = "BasicCalc";
            this.Text = "기본 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox answer2;
        private System.Windows.Forms.TextBox answer3;
        private System.Windows.Forms.TextBox answer4;
    }
}

