﻿namespace UiControl
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
            this.cm_font = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bold = new System.Windows.Forms.CheckBox();
            this.itelic = new System.Windows.Forms.CheckBox();
            this.sample_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cm_font
            // 
            this.cm_font.FormattingEnabled = true;
            this.cm_font.Location = new System.Drawing.Point(106, 35);
            this.cm_font.Name = "cm_font";
            this.cm_font.Size = new System.Drawing.Size(121, 20);
            this.cm_font.TabIndex = 0;
            this.cm_font.SelectedIndexChanged += new System.EventHandler(this.font_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "폰트";
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bold.Location = new System.Drawing.Point(243, 38);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(50, 16);
            this.bold.TabIndex = 2;
            this.bold.Text = "굵게";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // itelic
            // 
            this.itelic.AutoSize = true;
            this.itelic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itelic.Location = new System.Drawing.Point(299, 37);
            this.itelic.Name = "itelic";
            this.itelic.Size = new System.Drawing.Size(72, 16);
            this.itelic.TabIndex = 3;
            this.itelic.Text = "기울임꼴";
            this.itelic.UseVisualStyleBackColor = true;
            this.itelic.CheckedChanged += new System.EventHandler(this.itelic_CheckedChanged);
            // 
            // sample_text
            // 
            this.sample_text.Location = new System.Drawing.Point(35, 76);
            this.sample_text.Name = "sample_text";
            this.sample_text.Size = new System.Drawing.Size(192, 21);
            this.sample_text.TabIndex = 4;
            this.sample_text.Text = "C#프로그래밍";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 242);
            this.Controls.Add(this.sample_text);
            this.Controls.Add(this.itelic);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cm_font);
            this.Name = "Form1";
            this.Text = "UI컨트롤러 연습";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cm_font;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox itelic;
        private System.Windows.Forms.TextBox sample_text;
    }
}
