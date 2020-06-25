namespace oraWinform622
{
    partial class MainForm
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
            this.createTable = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // createTable
            // 
            this.createTable.Depth = 0;
            this.createTable.Icon = null;
            this.createTable.Location = new System.Drawing.Point(25, 100);
            this.createTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.createTable.Name = "createTable";
            this.createTable.Primary = true;
            this.createTable.Size = new System.Drawing.Size(150, 36);
            this.createTable.TabIndex = 0;
            this.createTable.Text = "테이블 생성";
            this.createTable.UseVisualStyleBackColor = true;
            this.createTable.Click += new System.EventHandler(this.createTable_Click);
            // 
            // button2
            // 
            this.button2.Depth = 0;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(208, 100);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Primary = true;
            this.button2.Size = new System.Drawing.Size(150, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "테이블 삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onDropTable);
            // 
            // button3
            // 
            this.button3.Depth = 0;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(25, 385);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.Primary = true;
            this.button3.Size = new System.Drawing.Size(150, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "데이터 보기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onShowDB);
            // 
            // button4
            // 
            this.button4.Depth = 0;
            this.button4.Icon = null;
            this.button4.Location = new System.Drawing.Point(25, 195);
            this.button4.MouseState = MaterialSkin.MouseState.HOVER;
            this.button4.Name = "button4";
            this.button4.Primary = true;
            this.button4.Size = new System.Drawing.Size(150, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "직접 데이터 추가";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onInsert);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Depth = 0;
            this.button5.Icon = null;
            this.button5.Location = new System.Drawing.Point(110, 480);
            this.button5.MouseState = MaterialSkin.MouseState.HOVER;
            this.button5.Name = "button5";
            this.button5.Primary = true;
            this.button5.Size = new System.Drawing.Size(150, 36);
            this.button5.TabIndex = 7;
            this.button5.Text = "프로그램 종료";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.onExit);
            // 
            // button6
            // 
            this.button6.Depth = 0;
            this.button6.Icon = null;
            this.button6.Location = new System.Drawing.Point(208, 385);
            this.button6.MouseState = MaterialSkin.MouseState.HOVER;
            this.button6.Name = "button6";
            this.button6.Primary = true;
            this.button6.Size = new System.Drawing.Size(150, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "도움말";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.onHelp);
            // 
            // button7
            // 
            this.button7.Depth = 0;
            this.button7.Icon = null;
            this.button7.Location = new System.Drawing.Point(208, 290);
            this.button7.MouseState = MaterialSkin.MouseState.HOVER;
            this.button7.Name = "button7";
            this.button7.Primary = true;
            this.button7.Size = new System.Drawing.Size(150, 36);
            this.button7.TabIndex = 5;
            this.button7.Text = "데이터 수정";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Depth = 0;
            this.button8.Icon = null;
            this.button8.Location = new System.Drawing.Point(25, 290);
            this.button8.MouseState = MaterialSkin.MouseState.HOVER;
            this.button8.Name = "button8";
            this.button8.Primary = true;
            this.button8.Size = new System.Drawing.Size(150, 36);
            this.button8.TabIndex = 4;
            this.button8.Text = "데이터 삭제";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Depth = 0;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(208, 195);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "랜덤 데이터 추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(407, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createTable);
            this.Name = "Form1";
            this.Text = "오라클DB 관리 프로그램 v1.4";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton createTable;
        private MaterialSkin.Controls.MaterialRaisedButton button2;
        private MaterialSkin.Controls.MaterialRaisedButton button3;
        private MaterialSkin.Controls.MaterialRaisedButton button4;
        private MaterialSkin.Controls.MaterialRaisedButton button5;
        private MaterialSkin.Controls.MaterialRaisedButton button6;
        private MaterialSkin.Controls.MaterialRaisedButton button7;
        private MaterialSkin.Controls.MaterialRaisedButton button8;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

