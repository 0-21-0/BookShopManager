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
    public partial class AddExpenseForm : Form
    {
        private Point distance = new Point();
        private bool leftMouseDown = false;
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void AddExpenseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.GetType() == sender.GetType())
                {
                    distance.X = e.X;
                    distance.Y = e.Y;

                }
                else
                {
                    distance.X = e.X + ((Control)sender).Location.X;
                    distance.Y = e.Y + ((Control)sender).Location.Y;
                }
                leftMouseDown = true;
            }
        }

        private void AddExpenseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseDown)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(-distance.X, -distance.Y);
                Location = mousePosition;
            }
        }

        private void AddExpenseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftMouseDown = false;
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
