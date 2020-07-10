using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _Bukan_TesKoran_7
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        
        private void Exit(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        
        private void Setting(object sender, EventArgs e)
        {
            Setting set = new Setting();
            set.ShowDialog(this);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.ShowDialog(this);
        }

        private void btnPetunjuk_Click(object sender, EventArgs e)
        {
            Petunjuk petunjuk = new Petunjuk();
            petunjuk.ShowDialog(this);
        }

        private void btnTentang_Click(object sender, EventArgs e)
        {
            Tentang tentang = new Tentang();
            tentang.ShowDialog(this);
        }
    }
}
