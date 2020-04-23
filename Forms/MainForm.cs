﻿using BookShopManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
    public partial class MainForm : Form
    {
        bool isCollapse;
        readonly int dashboardWidth;
        Button currentChecked;
        System.Windows.Forms.UserControl currentUC;
        public MainForm()
        {
            InitializeComponent();
            isCollapse = false;
            dashboardWidth = panel_DashBoard.Width;
            Label_DateTime.Text = DateTime.Now.ToString("HH:mm:ss");
            Timer_UpdateTime.Start();
            currentChecked = Button_Home;
            currentUC = new UserControlHome();
            AddControlsToPanel(currentUC);
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Timer_UpdateTime.Stop();
            this.Dispose();
        }

        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Timer_ChangeDashboardWidth_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                if (panel_DashBoard.Width < dashboardWidth)
                {
                    if(dashboardWidth - panel_DashBoard.Width > 5)
                    {
                        panel_DashBoard.Width += 5;
                    }
                    else
                    {
                        panel_DashBoard.Width = dashboardWidth;
                    }
                }
                else
                {
                    Timer_ChangeDashboardWidth.Stop();
                    isCollapse = !isCollapse;
                    Label_ShopName.Visible = true;
                    Label_Position.Visible = true;
                }
            }
            else
            {
                if (panel_DashBoard.Width > 60)
                {
                    if (panel_DashBoard.Width - 60 > 5)
                    {
                        panel_DashBoard.Width -= 5;
                    }
                    else
                    {
                        panel_DashBoard.Width = 60;
                    }
                }
                else
                {
                    Timer_ChangeDashboardWidth.Stop();
                    isCollapse = !isCollapse;
                }
            }
        }
        /// <summary>
        /// 点击logo对导航菜单进行缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Logo_Click(object sender, EventArgs e)
        {
            if (!isCollapse)
            {
                Label_ShopName.Visible = false;
                Label_Position.Visible = false;
                // panel_DashBoard.Width = 70;
            }
            else
            {
                // panel_DashBoard.Width = dashboardWidth - 10;
            }
            
            Timer_ChangeDashboardWidth.Start();
        }

        private void Timer_UpdateTime_Tick(object sender, EventArgs e)
        {
            Label_DateTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Timer_MoveCurrentSign_Tick(object sender, EventArgs e)
        {
            if (panel_CurrentSign.Top < currentChecked.Top)
            {
                panel_CurrentSign.Top += 2;
            }
            else if(panel_CurrentSign.Top > currentChecked.Top)
            {
                panel_CurrentSign.Top -= 2;
            }
            else
            {
                Timer_MoveCurrentSign.Stop();
            }
        }

        /// <summary>
        /// 每次点击按钮，对标记进行移动
        /// </summary>
        /// <param name="target"></param>
        private void MoveCurrentSign(Button target)
        {
            int distance = target.Top - currentChecked.Top;
            if(distance == 0)
            {
                return;
            }
            if(distance > 0)
            {
                panel_CurrentSign.Top = target.Top + 6;
            }
            else
            {
                panel_CurrentSign.Top = target.Top - 6;
            }
            currentChecked = target;
            Timer_MoveCurrentSign.Start();
        }
        private void Button_Home_Click(object sender, EventArgs e)
        {
            MoveCurrentSign(Button_Home);
            if (!currentUC.GetType().Name.Equals("UserControlHome"))
            {
                System.Windows.Forms.UserControl control = new UserControlHome();
                AddControlsToPanel(control);
                currentUC.Dispose();
                currentUC = control;
            }
        }

        private void Button_SaleBooks_Click(object sender, EventArgs e)
        {
            MoveCurrentSign(Button_SaleBooks);
        }

        private void Button_Purchased_Click(object sender, EventArgs e)
        {
            MoveCurrentSign(Button_Purchased);
        }

        private void Button_Expenses_Click(object sender, EventArgs e)
        {
            MoveCurrentSign(Button_Expenses);
        }

        private void Button_Users_Click(object sender, EventArgs e)
        {
            MoveCurrentSign(Button_Users);
        }

        private void Button_ViewSales_Click(object sender, EventArgs e)
        {
            MoveCurrentSign(Button_ViewSales);
        }

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            MoveCurrentSign(Button_Settings);
        }

        private void AddControlsToPanel(Control control)
        {
            control.Dock = DockStyle.Fill;
            panel_Controls.Controls.Clear();
            panel_Controls.Controls.Add(control);
        }
    }
}
