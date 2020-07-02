using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Bukan_TesKoran_7
{
    public partial class Dashboard : UserControl
    {
        public bool main = false;
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            mySetting.Visible = true;
            mySetting.BringToFront();
            
        }

        private void mySetting_MouseClick(object sender, MouseEventArgs e)
        {
            mySetting.Visible = false;
            mySetting.SendToBack();

        }

        private void Start_Click(object sender, EventArgs e)
        {
            main = true;
            this.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            main = false;
        }

        private void Dashboard_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
