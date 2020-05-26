namespace quiz6_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_over = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_over
            // 
            this.label1_over.AutoSize = true;
            this.label1_over.Font = new System.Drawing.Font("문체부 제목 돋음체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_over.Location = new System.Drawing.Point(38, 61);
            this.label1_over.Name = "label1_over";
            this.label1_over.Size = new System.Drawing.Size(322, 48);
            this.label1_over.TabIndex = 0;
            this.label1_over.Text = "Time Over ㅠㅠ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 182);
            this.Controls.Add(this.label1_over);
            this.Name = "Form2";
            this.Text = "X_X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_over;
    }
}