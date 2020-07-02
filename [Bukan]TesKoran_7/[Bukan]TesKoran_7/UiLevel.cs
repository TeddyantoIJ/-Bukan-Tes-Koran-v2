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
    public partial class UiLevel : UserControl
    {
        public int waktu = 0;
        public int operasi = -1;
        public int main = 0;
        public UiLevel()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (t1.Checked)
            {
                waktu = 1;
            }
            if (t2.Checked)
            {
                waktu = 2;
            }
            if (t5.Checked)
            {
                waktu = 5;
            }
            if (t10.Checked)
            {
                waktu = 10;
            }

            if (op1.Checked)
            {
                operasi = 1;
            }
            if (op2.Checked)
            {
                operasi = 2;
            }
            if (op3.Checked)
            {
                operasi = 3;
            }
            if (op4.Checked)
            {
                operasi = 4;
            }
            if (op5.Checked)
            {
                operasi = 5;
            }
            waktu = waktu * 60;
            this.main = 1;
            this.Visible = false;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.main = -1;
            this.Visible = false;
        }

        private void UiLevel_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
