using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookShopManagement.UserControls
{
    public partial class UserControlHome : System.Windows.Forms.UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            var points = chart1.Series[0].Points;
            points.Clear();
            Random random = new Random();
            points.AddXY(1, random.Next(0,20));
            points.AddXY(2, random.Next(0, 20));
            points.AddXY(3, random.Next(0, 20));
            points.AddXY(4, random.Next(0, 20));
            points.AddXY(5, random.Next(0, 20));
            points.AddXY(6, random.Next(0, 20));
            points.AddXY(7, random.Next(0, 20));
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
