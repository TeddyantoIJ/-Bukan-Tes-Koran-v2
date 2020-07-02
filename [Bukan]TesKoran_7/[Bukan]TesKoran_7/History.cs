using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Bukan_TesKoran_7
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            addDataScore();
            addCmbItem();
        }

        public void addDataScore()
        {
            dataRiwayat.DataSource = null;
            dataRiwayat.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = BTK";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_getAllScoreIndonesia", connection);
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);

                dataRiwayat.DataSource = data;

                for (int i = 0; i < dataRiwayat.Columns.Count; i++)
                {
                    this.dataRiwayat.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dataRiwayat.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.dataRiwayat.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataRiwayat.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                
                

                this.dataRiwayat.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataRiwayat.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataRiwayat.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                //by = 1;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("addDataScore : "+ex.ToString());
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }
        public void addDataScore(String operasi)
        {
            MessageBox.Show(operasi);
            dataRiwayat.DataSource = null;
            dataRiwayat.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = BTK";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_getAllScoreIndonesiaBy", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("operasi", operasi);

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);

                dataRiwayat.DataSource = data;

                for (int i = 0; i < dataRiwayat.Columns.Count; i++)
                {
                    this.dataRiwayat.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dataRiwayat.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.dataRiwayat.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataRiwayat.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataRiwayat.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;



                this.dataRiwayat.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataRiwayat.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataRiwayat.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //by = 1;
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
        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reset data?\nTindakan ini akan menghapus seluruh data riwayat permainan"
                    , "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
            }
            else
            {
                return;
            }
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = BTK";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_deleteScore", connection);
                myCommand.CommandType = CommandType.StoredProcedure;
                connection.Open();

                //by = 1;
                myCommand.ExecuteNonQuery();
                connection.Close();
                addDataScore();
            }
            catch (Exception ex)
            {
                MessageBox.Show("addDataScore : " + ex.ToString());
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }
        private void addCmbItem()
        {
            cmbgrup.Items.Add("Semua");
            cmbgrup.Items.Add("+");
            cmbgrup.Items.Add("-");
            cmbgrup.Items.Add("/");
            cmbgrup.Items.Add("*");
            cmbgrup.Items.Add("?");

            cmbgrup.SelectedIndex = 0;
        }
        private void addColumn()
        {
            //Bug tidak digunakan
            dataRiwayat.DataSource = null;
            dataRiwayat.ColumnCount = 11;
            dataRiwayat.Columns[0].HeaderText = "No";
            dataRiwayat.Columns[1].HeaderText = "Nama";
            dataRiwayat.Columns[2].HeaderText = "Benar";
            dataRiwayat.Columns[3].HeaderText = "Kecepatan";
            dataRiwayat.Columns[4].HeaderText = "Ketepatan";
            dataRiwayat.Columns[5].HeaderText = "Soal";
            dataRiwayat.Columns[6].HeaderText = "Tanggal";
            dataRiwayat.Columns[7].HeaderText = "Waktu";
            dataRiwayat.Columns[8].HeaderText = "Periode";
            dataRiwayat.Columns[10].HeaderText = "Operasi";

            for (int i = 0; i < dataRiwayat.Columns.Count; i++)
            {
                this.dataRiwayat.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataRiwayat.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.dataRiwayat.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataRiwayat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataRiwayat.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataRiwayat.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataRiwayat.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataRiwayat.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataRiwayat.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataRiwayat.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;



            this.dataRiwayat.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataRiwayat.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataRiwayat.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void cmbgrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbgrup.SelectedIndex == 0)
            {
                addDataScore();
            }
            else
            {
                addDataScore(cmbgrup.SelectedItem.ToString());
            }
            
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
