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
    public partial class UiGame : UserControl
    {
        public int benar = 0;
        public int waktu = 1;
        public int soal = 0;
        public int salah = 0;
        public float kecepatan = 0f;
        public float ketepatan = 0f;
        public List<int> Strike = new List<int>();



        public bool gameover = false;
        public bool mundur = false;

        public int counter = 0;
        private int jawaban = -1;

        public int kode_operasi = -1;
        private int hasil = -1;
        private int beruntun = 0;

        public UiGame()
        {
            InitializeComponent();

            //waktu = waktu * 60;
            
            benar = 0;


            Play();
        }

        public void Play()
        {
            Random random = new Random();
            
            // ========== Penentuan kode operasi
            int kode = 0;
            if (kode_operasi == 5)
            {

                kode = random.Next(5);

            }
            else
            {
                kode = kode_operasi;
            }


            // Merubah bentuk operasi
            switch (kode)
            {
                case 1:
                    {
                        operasi.Text = "+";
                        break;
                    }
                case 2:
                    {
                        operasi.Text = "-";
                        break;
                    }
                case 3:
                    {
                        operasi.Text = "*";
                        break;
                    }
                case 4:
                    {
                        operasi.Text = "/";
                        break;
                    }
            }


            // =========== GENERATE ANGKA
            int kiri = 0;
            int kanan = 0;

            /// JIKA PEMBAGIAN
            if (kode == 4)
            {
                do
                {
                    kanan = random.Next(10);
                } while (kanan == 0);
                
                kiri = kanan * random.Next(1,10);
                
            }
            //JIKA PENGURANGAN
            else if (kode == 2)
            {
                kiri = random.Next(100);
                
                 kanan = random.Next(1,kiri);
                
                
            }
            //JIKA PLUS ATAU KALI
            else
            {
                kiri = random.Next(9);
                kanan = random.Next(9);
            }

            //Memuncul kan pada permainan
            txtkiri.Text = kiri.ToString();
            txtkanan.Text = kanan.ToString();
            switch (kode)
            {
                case 1:
                    {
                        hasil = kiri + kanan;
                        hasil = Convert.ToInt32(hasil.ToString().Substring(hasil.ToString().Length - 1));
                        break;
                    }
                case 2:
                    {
                        hasil = kiri - kanan;
                        hasil = Convert.ToInt32(hasil.ToString().Substring(hasil.ToString().Length - 1));
                        break;
                    }
                case 3:
                    {
                        hasil = kiri * kanan;
                        hasil = Convert.ToInt32(hasil.ToString().Substring(hasil.ToString().Length - 1));
                        break;
                    }
                case 4:
                    {
                        hasil = kiri / kanan;
                        hasil = Convert.ToInt32(hasil.ToString().Substring(hasil.ToString().Length - 1));
                        break;
                    }
            }

        }

        private void time_Tick(object sender, EventArgs e)
        {
            if(counter == 0)
            {
                beruntun = 0;
            }
            if (!gameover)
            {
                if (beruntun >= 3)
                {
                    Strike.Add(beruntun);
                }
                TimeSpan result = TimeSpan.FromSeconds(counter);
                //MessageBox.Show(result.ToString());
                txtWaktu.Text = result.ToString("mm':'ss");
                if (counter == waktu)
                {
                    gameover = true;
                    MessageBox.Show("Waktu habis");
                    this.Visible = false;
                }
                counter++;
            }
            
        }

        private void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("tes");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            jawab(1);
        }
        private void jawab(int masuk)
        {
            
            
            jawaban = masuk;
            if (jawaban == hasil)
            {
                txtBenar.Text = (Convert.ToUInt32(txtBenar.Text) + 1).ToString();
                beruntun++;
            }
            else
            {
                if (beruntun >= 3)
                {
                    Strike.Add(beruntun);
                }
                
                beruntun = 0;
            }
            benar = Convert.ToInt32(txtBenar.Text);
            soal++;
            salah = soal - benar;
            kecepatan = (float) soal / waktu;
            ketepatan = (float) benar / soal;
            //MessageBox.Show(benar.ToString() + "\n" + soal.ToString() + "\n" + salah.ToString() + "\n" + kecepatan.ToString() + "\n" + ketepatan.ToString());
            jawaban = -1;
            Play();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            jawab(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            jawab(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            jawab(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            jawab(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            jawab(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            jawab(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            jawab(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            jawab(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            jawab(0);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            mundur = true;
            playtime.Enabled = false;
            gameover = true;
            counter = 0;
            this.Visible = false;
        }
    }
}
