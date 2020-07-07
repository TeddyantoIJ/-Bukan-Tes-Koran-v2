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
            bunifuTransition.ShowSync(mySetting, false, BunifuAnimatorNS.Animation.HorizSlide);
            //mySetting.Visible = true;
            mySetting.BringToFront();
            
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

        private void mySetting_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            if (mySetting.Visible)
            {
                bunifuTransition.HideSync(mySetting, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
