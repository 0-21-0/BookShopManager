﻿using System;
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
    public partial class AddCategoryForm : Form
    {
        private Point distance = new Point();
        private bool leftMouseDown = false;
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryForm_MouseDown(object sender, MouseEventArgs e)
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

        private void AddCategoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseDown)
            {
                Point mousePositon = Control.MousePosition;
                mousePositon.Offset(-distance.X, -distance.Y);
                Location = mousePositon;
            }
        }

        private void AddCategoryForm_MouseUp(object sender, MouseEventArgs e)
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
