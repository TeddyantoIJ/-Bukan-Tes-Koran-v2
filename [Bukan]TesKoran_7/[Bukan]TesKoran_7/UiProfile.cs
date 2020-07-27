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
    public partial class UiProfile : UserControl
    {
        public string nama = "";
        public bool selesai = false;

        public UiProfile()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            nama = txtNama.Text;
            selesai = true;
            this.Visible = false;
        }

        private void UiProfile_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtNama.Text.Length == 25)
            {
                e.Handled = true;
            }
        }
    }
}
