namespace BookShopManagement
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_DashBoard = new System.Windows.Forms.Panel();
            this.panel_CurrentSign = new System.Windows.Forms.Panel();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.Button_ViewSales = new System.Windows.Forms.Button();
            this.Button_Users = new System.Windows.Forms.Button();
            this.Button_Expenses = new System.Windows.Forms.Button();
            this.Button_Purchased = new System.Windows.Forms.Button();
            this.Button_SaleBooks = new System.Windows.Forms.Button();
            this.Button_Home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Position = new System.Windows.Forms.Label();
            this.Label_ShopName = new System.Windows.Forms.Label();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Button_Minimize = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_UserRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_DateTime = new System.Windows.Forms.Label();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.Timer_ChangeDashboardWidth = new System.Windows.Forms.Timer(this.components);
            this.Timer_UpdateTime = new System.Windows.Forms.Timer(this.components);
            this.Timer_MoveCurrentSign = new System.Windows.Forms.Timer(this.components);
            this.panel_DashBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.Panel_Title.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DashBoard
            // 
            this.panel_DashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel_DashBoard.Controls.Add(this.panel_CurrentSign);
            this.panel_DashBoard.Controls.Add(this.Button_Settings);
            this.panel_DashBoard.Controls.Add(this.Button_ViewSales);
            this.panel_DashBoard.Controls.Add(this.Button_Users);
            this.panel_DashBoard.Controls.Add(this.Button_Expenses);
            this.panel_DashBoard.Controls.Add(this.Button_Purchased);
            this.panel_DashBoard.Controls.Add(this.Button_SaleBooks);
            this.panel_DashBoard.Controls.Add(this.Button_Home);
            this.panel_DashBoard.Controls.Add(this.panel1);
            this.panel_DashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_DashBoard.Location = new System.Drawing.Point(0, 0);
            this.panel_DashBoard.Name = "panel_DashBoard";
            this.panel_DashBoard.Size = new System.Drawing.Size(215, 720);
            this.panel_DashBoard.TabIndex = 0;
            this.panel_DashBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel_DashBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel_DashBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // panel_CurrentSign
            // 
            this.panel_CurrentSign.BackColor = System.Drawing.Color.White;
            this.panel_CurrentSign.Location = new System.Drawing.Point(0, 150);
            this.panel_CurrentSign.Name = "panel_CurrentSign";
            this.panel_CurrentSign.Size = new System.Drawing.Size(5, 50);
            this.panel_CurrentSign.TabIndex = 2;
            // 
            // Button_Settings
            // 
            this.Button_Settings.FlatAppearance.BorderSize = 0;
            this.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Settings.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Settings.ForeColor = System.Drawing.Color.White;
            this.Button_Settings.Image = ((System.Drawing.Image)(resources.GetObject("Button_Settings.Image")));
            this.Button_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Settings.Location = new System.Drawing.Point(0, 450);
            this.Button_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button_Settings.Size = new System.Drawing.Size(215, 50);
            this.Button_Settings.TabIndex = 1;
            this.Button_Settings.Text = "   Settings";
            this.Button_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Settings.UseVisualStyleBackColor = true;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // Button_ViewSales
            // 
            this.Button_ViewSales.FlatAppearance.BorderSize = 0;
            this.Button_ViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ViewSales.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_ViewSales.ForeColor = System.Drawing.Color.White;
            this.Button_ViewSales.Image = ((System.Drawing.Image)(resources.GetObject("Button_ViewSales.Image")));
            this.Button_ViewSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ViewSales.Location = new System.Drawing.Point(0, 400);
            this.Button_ViewSales.Margin = new System.Windows.Forms.Padding(0);
            this.Button_ViewSales.Name = "Button_ViewSales";
            this.Button_ViewSales.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button_ViewSales.Size = new System.Drawing.Size(215, 50);
            this.Button_ViewSales.TabIndex = 1;
            this.Button_ViewSales.Text = "   View Sales";
            this.Button_ViewSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_ViewSales.UseVisualStyleBackColor = true;
            this.Button_ViewSales.Click += new System.EventHandler(this.Button_ViewSales_Click);
            // 
            // Button_Users
            // 
            this.Button_Users.FlatAppearance.BorderSize = 0;
            this.Button_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Users.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Users.ForeColor = System.Drawing.Color.White;
            this.Button_Users.Image = ((System.Drawing.Image)(resources.GetObject("Button_Users.Image")));
            this.Button_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Users.Location = new System.Drawing.Point(0, 350);
            this.Button_Users.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Users.Name = "Button_Users";
            this.Button_Users.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button_Users.Size = new System.Drawing.Size(215, 50);
            this.Button_Users.TabIndex = 1;
            this.Button_Users.Text = "   Users";
            this.Button_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Users.UseVisualStyleBackColor = true;
            this.Button_Users.Click += new System.EventHandler(this.Button_Users_Click);
            // 
            // Button_Expenses
            // 
            this.Button_Expenses.FlatAppearance.BorderSize = 0;
            this.Button_Expenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Expenses.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Expenses.ForeColor = System.Drawing.Color.White;
            this.Button_Expenses.Image = ((System.Drawing.Image)(resources.GetObject("Button_Expenses.Image")));
            this.Button_Expenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Expenses.Location = new System.Drawing.Point(0, 300);
            this.Button_Expenses.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Expenses.Name = "Button_Expenses";
            this.Button_Expenses.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button_Expenses.Size = new System.Drawing.Size(215, 50);
            this.Button_Expenses.TabIndex = 1;
            this.Button_Expenses.Text = "   Expenses";
            this.Button_Expenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Expenses.UseVisualStyleBackColor = true;
            this.Button_Expenses.Click += new System.EventHandler(this.Button_Expenses_Click);
            // 
            // Button_Purchased
            // 
            this.Button_Purchased.FlatAppearance.BorderSize = 0;
            this.Button_Purchased.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Purchased.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Purchased.ForeColor = System.Drawing.Color.White;
            this.Button_Purchased.Image = ((System.Drawing.Image)(resources.GetObject("Button_Purchased.Image")));
            this.Button_Purchased.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Purchased.Location = new System.Drawing.Point(0, 250);
            this.Button_Purchased.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Purchased.Name = "Button_Purchased";
            this.Button_Purchased.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button_Purchased.Size = new System.Drawing.Size(215, 50);
            this.Button_Purchased.TabIndex = 1;
            this.Button_Purchased.Text = "   Purchased";
            this.Button_Purchased.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Purchased.UseVisualStyleBackColor = true;
            this.Button_Purchased.Click += new System.EventHandler(this.Button_Purchased_Click);
            // 
            // Button_SaleBooks
            // 
            this.Button_SaleBooks.FlatAppearance.BorderSize = 0;
            this.Button_SaleBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SaleBooks.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_SaleBooks.ForeColor = System.Drawing.Color.White;
            this.Button_SaleBooks.Image = ((System.Drawing.Image)(resources.GetObject("Button_SaleBooks.Image")));
            this.Button_SaleBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_SaleBooks.Location = new System.Drawing.Point(0, 200);
            this.Button_SaleBooks.Margin = new System.Windows.Forms.Padding(0);
            this.Button_SaleBooks.Name = "Button_SaleBooks";
            this.Button_SaleBooks.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button_SaleBooks.Size = new System.Drawing.Size(215, 50);
            this.Button_SaleBooks.TabIndex = 1;
            this.Button_SaleBooks.Text = "   Sale Books";
            this.Button_SaleBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_SaleBooks.UseVisualStyleBackColor = true;
            this.Button_SaleBooks.Click += new System.EventHandler(this.Button_SaleBooks_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.FlatAppearance.BorderSize = 0;
            this.Button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Home.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Home.ForeColor = System.Drawing.Color.White;
            this.Button_Home.Image = ((System.Drawing.Image)(resources.GetObject("Button_Home.Image")));
            this.Button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Home.Location = new System.Drawing.Point(0, 150);
            this.Button_Home.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button_Home.Size = new System.Drawing.Size(215, 50);
            this.Button_Home.TabIndex = 1;
            this.Button_Home.Text = "   Home";
            this.Button_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Home.UseVisualStyleBackColor = true;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_Position);
            this.panel1.Controls.Add(this.Label_ShopName);
            this.panel1.Controls.Add(this.PictureBox_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 150);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // Label_Position
            // 
            this.Label_Position.AutoSize = true;
            this.Label_Position.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Position.ForeColor = System.Drawing.Color.White;
            this.Label_Position.Location = new System.Drawing.Point(28, 96);
            this.Label_Position.Name = "Label_Position";
            this.Label_Position.Size = new System.Drawing.Size(159, 22);
            this.Label_Position.TabIndex = 1;
            this.Label_Position.Text = "Kangbashen Erdos";
            // 
            // Label_ShopName
            // 
            this.Label_ShopName.AutoSize = true;
            this.Label_ShopName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ShopName.ForeColor = System.Drawing.Color.White;
            this.Label_ShopName.Location = new System.Drawing.Point(30, 74);
            this.Label_ShopName.Name = "Label_ShopName";
            this.Label_ShopName.Size = new System.Drawing.Size(154, 22);
            this.Label_ShopName.TabIndex = 1;
            this.Label_ShopName.Text = "North Book Shop";
            // 
            // PictureBox_Logo
            // 
            this.PictureBox_Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Logo.Image")));
            this.PictureBox_Logo.Location = new System.Drawing.Point(82, 21);
            this.PictureBox_Logo.Name = "PictureBox_Logo";
            this.PictureBox_Logo.Size = new System.Drawing.Size(50, 50);
            this.PictureBox_Logo.TabIndex = 0;
            this.PictureBox_Logo.TabStop = false;
            this.PictureBox_Logo.Click += new System.EventHandler(this.PictureBox_Logo_Click);
            // 
            // Panel_Title
            // 
            this.Panel_Title.Controls.Add(this.Button_Minimize);
            this.Panel_Title.Controls.Add(this.Button_Close);
            this.Panel_Title.Controls.Add(this.label6);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(215, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(985, 50);
            this.Panel_Title.TabIndex = 1;
            this.Panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // Button_Minimize
            // 
            this.Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Minimize.FlatAppearance.BorderSize = 0;
            this.Button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Button_Minimize.Image")));
            this.Button_Minimize.Location = new System.Drawing.Point(885, 0);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(50, 50);
            this.Button_Minimize.TabIndex = 0;
            this.Button_Minimize.UseVisualStyleBackColor = true;
            this.Button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = ((System.Drawing.Image)(resources.GetObject("Button_Close.Image")));
            this.Button_Close.Location = new System.Drawing.Point(935, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(50, 50);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(39, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "North Books Shop, NLI Market Erdos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Controls.Add(this.Label_UserRole);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Label_DateTime);
            this.panel3.Controls.Add(this.Label_UserName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(215, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 100);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // Label_UserRole
            // 
            this.Label_UserRole.AutoSize = true;
            this.Label_UserRole.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_UserRole.ForeColor = System.Drawing.Color.White;
            this.Label_UserRole.Location = new System.Drawing.Point(138, 50);
            this.Label_UserRole.Name = "Label_UserRole";
            this.Label_UserRole.Size = new System.Drawing.Size(64, 22);
            this.Label_UserRole.TabIndex = 1;
            this.Label_UserRole.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Role:";
            // 
            // Label_DateTime
            // 
            this.Label_DateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label_DateTime.AutoSize = true;
            this.Label_DateTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_DateTime.ForeColor = System.Drawing.Color.White;
            this.Label_DateTime.Location = new System.Drawing.Point(841, 39);
            this.Label_DateTime.Name = "Label_DateTime";
            this.Label_DateTime.Size = new System.Drawing.Size(94, 22);
            this.Label_DateTime.TabIndex = 1;
            this.Label_DateTime.Text = "HH:mm:ss";
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_UserName.ForeColor = System.Drawing.Color.White;
            this.Label_UserName.Location = new System.Drawing.Point(138, 28);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(56, 22);
            this.Label_UserName.TabIndex = 1;
            this.Label_UserName.Text = "Reyes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wlecome：";
            // 
            // panel_Controls
            // 
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Controls.Location = new System.Drawing.Point(215, 150);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(985, 570);
            this.panel_Controls.TabIndex = 3;
            // 
            // Timer_ChangeDashboardWidth
            // 
            this.Timer_ChangeDashboardWidth.Interval = 20;
            this.Timer_ChangeDashboardWidth.Tick += new System.EventHandler(this.Timer_ChangeDashboardWidth_Tick);
            // 
            // Timer_UpdateTime
            // 
            this.Timer_UpdateTime.Interval = 1000;
            this.Timer_UpdateTime.Tick += new System.EventHandler(this.Timer_UpdateTime_Tick);
            // 
            // Timer_MoveCurrentSign
            // 
            this.Timer_MoveCurrentSign.Interval = 20;
            this.Timer_MoveCurrentSign.Tick += new System.EventHandler(this.Timer_MoveCurrentSign_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.panel_DashBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panel_DashBoard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_DashBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_Position;
        private System.Windows.Forms.Label Label_ShopName;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Button Button_Minimize;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.Button Button_Home;
        private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.Button Button_ViewSales;
        private System.Windows.Forms.Button Button_Users;
        private System.Windows.Forms.Button Button_Expenses;
        private System.Windows.Forms.Button Button_Purchased;
        private System.Windows.Forms.Button Button_SaleBooks;
        private System.Windows.Forms.Panel panel_CurrentSign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label_UserRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_DateTime;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer_ChangeDashboardWidth;
        private System.Windows.Forms.Timer Timer_UpdateTime;
        private System.Windows.Forms.Timer Timer_MoveCurrentSign;
    }
}

