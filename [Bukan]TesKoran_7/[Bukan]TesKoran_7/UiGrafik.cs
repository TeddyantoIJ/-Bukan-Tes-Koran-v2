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
    public partial class UiGrafik : UserControl
    {
        public int TotalBenar = 0;
        public bool done = false;
        public UiGrafik()
        {
            InitializeComponent();
            TotalBenar = 0;
            bunifuElipse.ApplyElipse(panelHasil,15);
        }

        private void UiGrafik_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            done = true;
            this.Visible = false;
        }
    }
}
