using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class AddNewBookForm : Form
    {
        private Point formPoint;
        private bool leftMouseDown;
        public AddNewBookForm()
        {
            InitializeComponent();
            leftMouseDown = false;
            formPoint = new Point();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddNewBookForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                leftMouseDown = true;
                // 获取鼠标单击的X、Y坐标
                formPoint.X = e.X;
                formPoint.Y = e.Y;
            }
        }

        private void AddNewBookForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftMouseDown = false;
            }
        }

        private void AddNewBookForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseDown)
            {
                Point mouseSet = Control.MousePosition; // 获取鼠标的位置
                mouseSet.Offset(-formPoint.X, -formPoint.Y);// 
                Location = mouseSet;
            }
        }
    }
}
