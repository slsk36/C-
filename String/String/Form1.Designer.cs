namespace String
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
            this.inputtest = new System.Windows.Forms.Label();
            this.inputbutton1 = new System.Windows.Forms.Button();
            this.inputcontain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputtest
            // 
            this.inputtest.AutoSize = true;
            this.inputtest.Location = new System.Drawing.Point(12, 23);
            this.inputtest.Name = "inputtest";
            this.inputtest.Size = new System.Drawing.Size(95, 12);
            this.inputtest.TabIndex = 0;
            this.inputtest.Text = "sample,test,text";
            this.inputtest.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputbutton1
            // 
            this.inputbutton1.Location = new System.Drawing.Point(144, 15);
            this.inputbutton1.Name = "inputbutton1";
            this.inputbutton1.Size = new System.Drawing.Size(58, 28);
            this.inputbutton1.TabIndex = 1;
            this.inputbutton1.Text = "실행";
            this.inputbutton1.UseVisualStyleBackColor = true;
            this.inputbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputcontain
            // 
            this.inputcontain.AutoSize = true;
            this.inputcontain.Location = new System.Drawing.Point(14, 60);
            this.inputcontain.Name = "inputcontain";
            this.inputcontain.Size = new System.Drawing.Size(47, 17);
            this.inputcontain.TabIndex = 2;
            this.inputcontain.Text = "contain";
            this.inputcontain.UseCompatibleTextRendering = true;
            this.inputcontain.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.inputcontain);
            this.Controls.Add(this.inputbutton1);
            this.Controls.Add(this.inputtest);
            this.Name = "Form1";
            this.Text = "sample ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputtest;
        private System.Windows.Forms.Button inputbutton1;
        private System.Windows.Forms.Label inputcontain;
    }
}

