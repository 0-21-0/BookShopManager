using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UserControlManagerExpense : UserControl
    {
        private Point distance = new Point();
        private bool leftMouseDown = false;
        public UserControlManagerExpense()
        {
            InitializeComponent();
        }

        private void UserControlManagerExpense_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                distance.X = e.X;
                distance.Y = e.Y;
                leftMouseDown = true;
            }
        }

        private void UserControlManagerExpense_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseDown)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(-distance.X, -distance.Y);
                Location = mousePosition;
            }
        }

        private void UserControlManagerExpense_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftMouseDown = false;
            }
        }

        private void Button_AddNewBook_Click(object sender, EventArgs e)
        {
            using(AddExpenseForm addExpenseForm = new AddExpenseForm())
            {
                addExpenseForm.ShowDialog();
            }
        }
    }
}
