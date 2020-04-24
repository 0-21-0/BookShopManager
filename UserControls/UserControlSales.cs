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
    public partial class UserControlSales : UserControl
    {
        public UserControlSales()
        {
            InitializeComponent();
        }

        private void Button_Finish_Click(object sender, EventArgs e)
        {
            using(FinishOrderForm finishOrderForm = new FinishOrderForm())
            {
                finishOrderForm.ShowDialog();
            }
        }
    }
}
