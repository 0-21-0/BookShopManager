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
    public partial class FinishOrderForm :Form
    {
        public FinishOrderForm()
        {
            InitializeComponent();
        }

        private void Button_Done_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
