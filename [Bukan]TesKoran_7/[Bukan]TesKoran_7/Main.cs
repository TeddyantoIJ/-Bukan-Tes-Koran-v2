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
    public partial class Main : Form
    {
        private int highscore = 0;
        public Main()
        {
            InitializeComponent();
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

                // =========================== SUARA ========================
                // if (data.Rows[0][1].ToString().Equals("1"))
                //  {
                //        rbAktif_efek_suara.Checked = true;
                //    }    

                // =================== MUSIK =================
                MessageBox.Show("Bahasa\t\t: "+ (data.Rows[0][0].ToString().Equals("0")  ? "Indonesia" : "Inggris") + 
                                "\nSuara efek\t: "+(data.Rows[0][1].ToString().Equals("1") ? "Aktif" : "Tidak aktif") +
                                "\nMusik\t\t: "+(data.Rows[0][2].ToString().Equals("1") ? "Aktif" : "Tidak aktif"),"Informasi Setting",MessageBoxButtons.OK);
                if (data.Rows[0][2].ToString().Equals("1"))
                {
                    playMusik();
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
        public void playMusik()
        {
            //@"C:\Users\Polman\Documents\Teddy-san\Semester 2\Tugas\Struktur Data\Project\Musik\Zelda & Chill (online-audio-converter.com).wav"

            //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            //Media.MP3Player mplayer = new MP3Player();

            String path = @"..\\Musik\\Zelda & Chill Fairy Fountain Mikel Lofi Remix.wav";            
            SoundPlayer simpleSound = new SoundPlayer(path);
            simpleSound.PlayLooping();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
        }
        private void show(UserControl masuk)
        {
            uiLevel.SendToBack();
            uiGame.SendToBack();
            dashboard.SendToBack();
            uiProfile.SendToBack();
            uiGrafik.SendToBack();

            masuk.BringToFront();
            bunifuTransition.ShowSync(masuk, true, BunifuAnimatorNS.Animation.Scale);
            //masuk.Visible = true;
            
            //MessageBox.Show(masuk.Name.ToString());
        }
        private void hide(UserControl masuk)
        {
            masuk.SendToBack();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            
        }

        private void Next2_Click(object sender, EventArgs e)
        {
           
            
        }



        private void dashboard_VisibleChanged(object sender, EventArgs e)
        {
            uiGame.txtBenar.Text = "0";
            uiGame.counter = 0;
            uiGame.txtWaktu.Text = "00:00";
            uiLevel.main = 0;

            if (!dashboard.Visible)
            {
                validate();
            }
            
            
        }
        private void uiLevel_VisibleChanged(object sender, EventArgs e)
        {
            if (!uiLevel.Visible)
            {
                validate();
            }
        }

        private void uiGame_VisibleChanged(object sender, EventArgs e)
        {
            uiGrafik.txtBenar.Text = uiGame.benar.ToString();
            uiGrafik.txtSoal.Text = uiGame.soal.ToString();
            uiGrafik.txtSalah.Text = uiGame.salah.ToString();
            uiGrafik.txtKecepatan.Text = uiGame.kecepatan.ToString();
            uiGrafik.txtKetepatan.Text = uiGame.ketepatan.ToString();
            if (!uiGame.Visible)
            {
                if (uiGame.gameover && !uiGrafik.done && !uiGame.mundur)
                {
                    //MessageBox.Show("uiGame.gameover && !uiGrafik.done "+uiGame.benar.ToString());
                    show(uiGrafik);
                }
                else if (uiGame.gameover && uiGame.mundur)
                {
                    MessageBox.Show("Selesai Tombol klik");
                    uiGame.gameover = false;
                    uiLevel.main = -1;
                    validate();
                }
            }
            
        }


        private void validate()
        {
            
            if (dashboard.main && uiLevel.main == 0)
            {
                show(uiLevel);
            }
            else if (uiLevel.main == -1)
            {
                dashboard.main = false;
                show(dashboard);
                backtoNormal();
            }
            else if(uiLevel.main == 1)
            {
                show(uiGame);
                uiGame.kode_operasi = uiLevel.operasi;
                
                switch (uiGame.kode_operasi)
                {
                    case 1:
                        {
                            highscore = Convert.ToInt32(dashboard.hs1.Text);
                            break;
                        }
                    case 2:
                        {
                            highscore = Convert.ToInt32(dashboard.hs2.Text);
                            break;
                        }
                    case 3:
                        {
                            highscore = Convert.ToInt32(dashboard.hs3.Text);
                            break;
                        }
                    case 4:
                        {
                            highscore = Convert.ToInt32(dashboard.hs4.Text);
                            break;
                        }
                    case 5:
                        {
                            highscore = Convert.ToInt32(dashboard.hs5.Text);
                            break;
                        }
                }
                //MessageBox.Show("Highscore : " + highscore.ToString());
                uiGame.playtime.Enabled = true;
                uiGame.waktu = uiLevel.waktu;
                uiGame.gameover = false;
                uiGame.Play();
            }
            else if(uiGame.gameover)
            {
                backtoNormal();
                show(dashboard);
            }
            else
            {
                
            }
        }

        private void backtoNormal()
        {
            dashboard.main = false;
            uiGame.benar = 0;
            uiGrafik.done = false;
            uiGame.mundur = false;
            uiGrafik.done = false;
        }

        private void ubahHighScore()
        {
            switch (uiGame.kode_operasi)
            {
                case 1:
                    {
                        dashboard.hsnama1.Text = uiProfile.nama;
                        dashboard.hs1.Text = uiGame.benar.ToString();
                        break;
                    }
                case 2:
                    {
                        dashboard.hsnama2.Text = uiProfile.nama;
                        dashboard.hs2.Text = uiGame.benar.ToString();
                        break;
                    }
                case 3:
                    {
                        dashboard.hsnama3.Text = uiProfile.nama;
                        dashboard.hs3.Text = uiGame.benar.ToString();
                        break;
                    }
                case 4:
                    {
                        dashboard.hsnama4.Text = uiProfile.nama;
                        dashboard.hs4.Text = uiGame.benar.ToString();
                        break;
                    }
                case 5:
                    {
                        dashboard.hsnama5.Text = uiProfile.nama;
                        dashboard.hs5.Text = uiGame.benar.ToString();
                        break;
                    }
            }
            uiGame.benar = 0;
            uiProfile.nama = "";
        }

        private void uiProfile_VisibleChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("uiProfile_VisibleChanged "+uiGame.benar.ToString());
            //MessageBox.Show("Highscore : " + highscore.ToString());
            if (!uiProfile.Visible)
            {
                if (uiGame.gameover && dashboard.main)
                {
                    uiGame.gameover = false;
                    uiGame.playtime.Enabled = false;

                    if (uiGame.benar > highscore)
                    {
                        ubahHighScore();
                        MessageBox.Show("Highscore");
                    }
                    else
                    {
                        MessageBox.Show("Doesnt Highscore");
                    }
                    backtoNormal();
                    show(dashboard);
                }
            }
            
        }

        private void uiGrafik_VisibleChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("uiGrafik_VisibleChanged " + uiGame.benar.ToString());
            
            if (!uiGrafik.Visible)
            {
                if (uiGame.benar > highscore && uiGrafik.done)
                {
                    show(uiProfile);
                }
                else if (uiGrafik.done)
                {
                    uiGame.gameover = false;
                    uiLevel.main = -1;
                    validate();
                }
            }
        }
    }
}
