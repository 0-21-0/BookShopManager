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
        private Point distance = new Point();
        private bool leftMouseDown = false;
        public FinishOrderForm()
        {
            InitializeComponent();
        }

        private void Button_Done_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FinishOrderForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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

        private void FinishOrderForm_MouseUp(object sender, MouseEventArgs e)
        {
            if(leftMouseDown)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(-distance.X, -distance.Y);
                Location = mousePosition;
            }
        }

        private void FinishOrderForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftMouseDown = false;
            }
        }
    }
}
