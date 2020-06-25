namespace oraWinform622
{
    partial class Viewform
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.count,
            this.name,
            this.age,
            this.addr});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 193);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.onGetItem);
            // 
            // count
            // 
            this.count.Text = "Num";
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 100;
            // 
            // age
            // 
            this.age.Text = "Age";
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addr
            // 
            this.addr.Text = "Address";
            this.addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addr.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ListView 데이터 보기";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnt,
            this.G_name,
            this.G_age,
            this.G_addr});
            this.dataGridView1.Location = new System.Drawing.Point(32, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(426, 149);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "GridView 데이터 보기";
            // 
            // cnt
            // 
            this.cnt.HeaderText = "번호";
            this.cnt.Name = "cnt";
            // 
            // G_name
            // 
            this.G_name.HeaderText = "이름";
            this.G_name.Name = "G_name";
            // 
            // G_age
            // 
            this.G_age.HeaderText = "나이";
            this.G_age.Name = "G_age";
            // 
            // G_addr
            // 
            this.G_addr.HeaderText = "주소";
            this.G_addr.Name = "G_addr";
            // 
            // Viewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Viewform";
            this.Text = "viewform";
            this.Load += new System.EventHandler(this.onViewLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_addr;
    }
}