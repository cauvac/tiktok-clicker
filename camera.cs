using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiktok_clicker
{
    public partial class camera : Form
    {
        public camera(double tikkkok, double tiktik, double tps)
        {
            InitializeComponent();
            label1.Text = "You'll reach the next level in " + Math.Round(((tikkkok - tiktik) / tps) * 10) / 10 + " seconds";
        }

        private void camera_Load(object sender, EventArgs e)
        {
        }
    }
}
