using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Bukan_TesKoran_7
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            //popSound();
            cekSetting();
            
        }
        private void cekSetting()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = BTK";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cekSetting", connection);
                myCommand.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);


                if (data.Rows[0][1].ToString().Equals("1"))
                {
                    rbAktif_efek_suara.Checked = true;
                }
                else
                {
                    rbTidak_efek_suara.Checked = true;
                }

                if (data.Rows[0][2].ToString().Equals("1"))
                {
                    rbAktif_musik.Checked = true;
                }
                else
                {
                    rbTidak_musik.Checked = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("addDataScore : " + ex.ToString());
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            setSettingSuara();
            this.Close();
        }
        private void setSettingSuara()
        {
            int suara = rbAktif_efek_suara.Checked == true ? 1 : 0;
            int musik = rbAktif_musik.Checked == true ? 1 : 0;
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = BTK";

                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                SqlCommand myCommand = new SqlCommand("sp_updateSettingSuara", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                
                myCommand.Parameters.AddWithValue("suara", suara);
                myCommand.Parameters.AddWithValue("musik", musik);

                
                myCommand.ExecuteNonQuery();
                //by = 1;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("setSettingSuara : " + ex.ToString());
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }

        private void rbAktif_musik_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public void playMusik(Boolean i)
        {

            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Polman\Documents\Teddy-san\Semester 2\Tugas\Struktur Data\Project\Musik\Zelda & Chill (online-audio-converter.com).wav");
            if (i)
            {
                simpleSound.PlayLooping();
            }
            else
            {
                simpleSound.Stop();
            }
            
        }
        public void popSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Polman\Documents\Teddy-san\Semester 2\Tugas\Struktur Data\Project\Musik\Efek\popUp.wav");

            simpleSound.Play();

        }
        private void rbAktif_musik_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (rbAktif_musik.Checked == true)
            {
                playMusik(true);
            }
            else
            {
                playMusik(false);
            }
        }

        private void rbTidak_musik_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (rbAktif_musik.Checked == true)
            {
                playMusik(true);
            }
            else
            {
                playMusik(false);
            }
        }
    }
}
