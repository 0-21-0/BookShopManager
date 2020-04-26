namespace BookShopManagement.UserControls
{
    partial class UserControlManagerExpense
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlManagerExpense));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_AddNewBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(10, 560);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(965, 10);
            this.panel7.TabIndex = 12;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseDown);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseMove);
            this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 10);
            this.panel4.TabIndex = 11;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(975, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 570);
            this.panel3.TabIndex = 10;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 570);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Button_AddNewBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 50);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(679, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Expenses";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(235, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "  Delete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Button_AddNewBook
            // 
            this.Button_AddNewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddNewBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_AddNewBook.FlatAppearance.BorderSize = 0;
            this.Button_AddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddNewBook.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_AddNewBook.ForeColor = System.Drawing.Color.White;
            this.Button_AddNewBook.Image = ((System.Drawing.Image)(resources.GetObject("Button_AddNewBook.Image")));
            this.Button_AddNewBook.Location = new System.Drawing.Point(0, 0);
            this.Button_AddNewBook.Name = "Button_AddNewBook";
            this.Button_AddNewBook.Size = new System.Drawing.Size(235, 50);
            this.Button_AddNewBook.TabIndex = 0;
            this.Button_AddNewBook.Text = "  Add New Expense";
            this.Button_AddNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_AddNewBook.UseVisualStyleBackColor = true;
            this.Button_AddNewBook.Click += new System.EventHandler(this.Button_AddNewBook_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(371, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "  Refresh";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 500);
            this.dataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Expense Title";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // UserControlManagerExpense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UserControlManagerExpense";
            this.Size = new System.Drawing.Size(985, 570);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControlManagerExpense_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button_AddNewBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
