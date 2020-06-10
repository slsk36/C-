namespace UiControl
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
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.pgDownload = new System.Windows.Forms.ProgressBar();
            this.btn_Modal = new System.Windows.Forms.Button();
            this.btn_Modaless = new System.Windows.Forms.Button();
            this.btn_Msg = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tn_root = new System.Windows.Forms.Button();
            this.btn_child = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
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
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(24, 117);
            this.tbDummy.Maximum = 100;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(336, 45);
            this.tbDummy.TabIndex = 5;
            this.tbDummy.Scroll += new System.EventHandler(this.tbDummy_Scroll);
            // 
            // pgDownload
            // 
            this.pgDownload.Location = new System.Drawing.Point(35, 168);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Size = new System.Drawing.Size(336, 16);
            this.pgDownload.TabIndex = 6;
            // 
            // btn_Modal
            // 
            this.btn_Modal.Location = new System.Drawing.Point(35, 204);
            this.btn_Modal.Name = "btn_Modal";
            this.btn_Modal.Size = new System.Drawing.Size(75, 23);
            this.btn_Modal.TabIndex = 7;
            this.btn_Modal.Text = "Modal";
            this.btn_Modal.UseVisualStyleBackColor = true;
            this.btn_Modal.Click += new System.EventHandler(this.btn_Modal_Click);
            // 
            // btn_Modaless
            // 
            this.btn_Modaless.Location = new System.Drawing.Point(152, 204);
            this.btn_Modaless.Name = "btn_Modaless";
            this.btn_Modaless.Size = new System.Drawing.Size(75, 23);
            this.btn_Modaless.TabIndex = 8;
            this.btn_Modaless.Text = "Modaless";
            this.btn_Modaless.UseVisualStyleBackColor = true;
            this.btn_Modaless.Click += new System.EventHandler(this.btn_Modaless_Click);
            // 
            // btn_Msg
            // 
            this.btn_Msg.Location = new System.Drawing.Point(270, 204);
            this.btn_Msg.Name = "btn_Msg";
            this.btn_Msg.Size = new System.Drawing.Size(75, 23);
            this.btn_Msg.TabIndex = 9;
            this.btn_Msg.Text = "Message";
            this.btn_Msg.UseVisualStyleBackColor = true;
            this.btn_Msg.Click += new System.EventHandler(this.btn_Msg_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(35, 261);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(243, 261);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tn_root
            // 
            this.tn_root.Location = new System.Drawing.Point(35, 364);
            this.tn_root.Name = "tn_root";
            this.tn_root.Size = new System.Drawing.Size(75, 23);
            this.tn_root.TabIndex = 12;
            this.tn_root.Text = "루트 추가";
            this.tn_root.UseVisualStyleBackColor = true;
            this.tn_root.Click += new System.EventHandler(this.tn_root_Click);
            // 
            // btn_child
            // 
            this.btn_child.Location = new System.Drawing.Point(127, 364);
            this.btn_child.Name = "btn_child";
            this.btn_child.Size = new System.Drawing.Size(75, 23);
            this.btn_child.TabIndex = 13;
            this.btn_child.Text = "자식 추가";
            this.btn_child.UseVisualStyleBackColor = true;
            this.btn_child.Click += new System.EventHandler(this.btn_child_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 399);
            this.Controls.Add(this.btn_child);
            this.Controls.Add(this.tn_root);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_Msg);
            this.Controls.Add(this.btn_Modaless);
            this.Controls.Add(this.btn_Modal);
            this.Controls.Add(this.pgDownload);
            this.Controls.Add(this.tbDummy);
            this.Controls.Add(this.sample_text);
            this.Controls.Add(this.itelic);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cm_font);
            this.Name = "Form1";
            this.Text = "UI컨트롤러 연습";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cm_font;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox itelic;
        private System.Windows.Forms.TextBox sample_text;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.ProgressBar pgDownload;
        private System.Windows.Forms.Button btn_Modal;
        private System.Windows.Forms.Button btn_Modaless;
        private System.Windows.Forms.Button btn_Msg;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button tn_root;
        private System.Windows.Forms.Button btn_child;
    }
}

