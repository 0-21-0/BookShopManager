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
    public partial class UserControlPurchaseDetails : UserControl
    {
        public UserControlPurchaseDetails()
        {
            InitializeComponent();
        }

        private void UserControlPurchaseDetails_Load(object sender, EventArgs e)
        {

        }

        private void Button_AddNewBook_Click(object sender, EventArgs e)
        {
            using(AddNewBookForm addNewBookForm = new AddNewBookForm())
            {
                addNewBookForm.ShowDialog();
            }
        }
    }
}
