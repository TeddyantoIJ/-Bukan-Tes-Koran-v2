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
    public partial class Dashboard : UserControl
    {
        public bool main = false;
        public int[,] hs_nilai = new int[4,5];
        public String[,] hs_nama = new String[4,5];
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
            setHighscoreDB();
            setHighscoreDashboard();
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
            setHighscoreDashboard();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            setHighscoreDashboard();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            setHighscoreDashboard();
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            setHighscoreDashboard();
        }
        public void setHighscoreDB()
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    try
                    {
                        //======================

                        string connectionString = "integrated security = true; data source = localhost; initial catalog = BTK";

                        SqlConnection connection = new SqlConnection(connectionString);
                        
                        SqlCommand myCommand = new SqlCommand("sp_setHighscrore", connection);
                        myCommand.CommandType = CommandType.StoredProcedure;
                        
                        connection.Open();
                        char operasi1 = ' ';
                        switch (j)
                        {
                            case 0:
                                {
                                    operasi1 = '+';
                                    break;
                                }
                            case 1:
                                {
                                    operasi1 = '-';
                                    break;
                                }
                            case 2:
                                {
                                    operasi1 = '*';
                                    break;
                                }
                            case 3:
                                {
                                    operasi1 = '/';
                                    break;
                                }
                            case 4:
                                {
                                    operasi1 = '?';
                                    break;
                                }
                        }
                        int i1 = 0;
                        switch (i)
                        {
                            case 0:
                                {
                                    i1 = 1;
                                    break;
                                }
                            case 1:
                                {
                                    i1 = 2;
                                    break;
                                }
                            case 2:
                                {
                                    i1 = 5;
                                    break;
                                }
                            case 3:
                                {
                                    i1 = 10;
                                    break;
                                }
                        }

                        myCommand.Parameters.AddWithValue("@operasi", operasi1);
                        
                        myCommand.Parameters.AddWithValue("@waktu_main", i1);
                        
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        DataTable data = new DataTable();
                        adapter.SelectCommand = myCommand;
                        adapter.Fill(data);
                        
                        connection.Close();

                        //MessageBox.Show("AAA\n" + data.Rows[0][0].ToString() + "\n" + data.Rows[0][1].ToString());
                        hs_nama[i, j] = data.Rows[0][0].ToString(); //(String)tableTemp[0, 0].Value;

                        hs_nilai[i,j] = Convert.ToInt32(data.Rows[0][1]);   //tableTemp[0, 0].Value;
                        if(hs_nama[i, j].ToString().Equals(""))
                        {
                            hs_nama[i, j] = "Belum ada";
                        }

                    }
                    catch (Exception ex)
                    {
                        hs_nama[i, j] = "Belum ada"; //(String)tableTemp[0, 0].Value;
                        hs_nilai[i, j] = 0;   //tableTemp[0, 0].Value;
                        //MessageBox.Show(ex.ToString());
                        //btnUpdate.Enabled = false;
                        //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                        //clear();
                    }
                }
                
            }
            
        }
        public void setHighscoreDashboard()
        {
            int show = 0;
            if (rb1.Checked)
            {
                show = 0;
            }
            if (rb2.Checked)
            {
                show = 1;
            }
            if (rb5.Checked)
            {
                show = 2;
            }
            if (rb10.Checked)
            {
                show = 3;
            }
            highscore(show);
        }
        public void highscore(int i)
        {
            try
            {
                hs1.Text = hs_nilai[i, 0].ToString();
                hs2.Text = hs_nilai[i, 1].ToString();
                hs3.Text = hs_nilai[i, 2].ToString();
                hs4.Text = hs_nilai[i, 3].ToString();
                hs5.Text = hs_nilai[i, 4].ToString();

                hsnama1.Text = hs_nama[i, 0].ToString();
                hsnama2.Text = hs_nama[i, 1].ToString();
                hsnama3.Text = hs_nama[i, 2].ToString();
                hsnama4.Text = hs_nama[i, 3].ToString();
                hsnama5.Text = hs_nama[i, 4].ToString();
            }catch(Exception e)
            {
                MessageBox.Show("ERROR : " + e.ToString());
            }
            
        }
    }
}
