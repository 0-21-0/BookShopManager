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
        /// <summary>
        /// 记录MouseDown触发时，鼠标到Form左上角的距离
        /// </summary>
        private Point distance;
        /// <summary>
        /// 鼠标左键按下为真
        /// </summary>
        private bool leftMouseDown;
        public AddNewBookForm()
        {
            InitializeComponent();
            leftMouseDown = false;
            distance = new Point();
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
                distance.X = e.X;
                distance.Y = e.Y;
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
                Point mousePositon = Control.MousePosition;
                mousePositon.Offset(-distance.X, -distance.Y);
                Location = mousePositon;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(AddCategoryForm addCategoryForm = new AddCategoryForm())
            {
                addCategoryForm.ShowDialog();
            }
        }
    }
}
