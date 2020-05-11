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
    public partial class UserControlPushTemp : UserControl
    {
        public UserControlPushTemp()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            using(ChoseLactureForm choseLactureForm  = new ChoseLactureForm())
            {
                choseLactureForm.ShowDialog();
            }
        }
    }
}
