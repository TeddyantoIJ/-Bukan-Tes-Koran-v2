namespace _Bukan_TesKoran_7
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRiwayat = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataRiwayat = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbgrup = new System.Windows.Forms.ComboBox();
            this.btnKembali1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHapus1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRiwayat
            // 
            this.lblRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRiwayat.AutoSize = true;
            this.lblRiwayat.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiwayat.ForeColor = System.Drawing.Color.White;
            this.lblRiwayat.Location = new System.Drawing.Point(364, 9);
            this.lblRiwayat.Name = "lblRiwayat";
            this.lblRiwayat.Size = new System.Drawing.Size(101, 29);
            this.lblRiwayat.TabIndex = 1;
            this.lblRiwayat.Text = "Riwayat";
            // 
            // dataRiwayat
            // 
            this.dataRiwayat.AllowUserToAddRows = false;
            this.dataRiwayat.AllowUserToDeleteRows = false;
            this.dataRiwayat.AllowUserToResizeColumns = false;
            this.dataRiwayat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRiwayat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRiwayat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.dataRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRiwayat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataRiwayat.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRiwayat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataRiwayat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.dataRiwayat.Location = new System.Drawing.Point(12, 73);
            this.dataRiwayat.MultiSelect = false;
            this.dataRiwayat.Name = "dataRiwayat";
            this.dataRiwayat.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRiwayat.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataRiwayat.RowHeadersVisible = false;
            this.dataRiwayat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataRiwayat.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataRiwayat.Size = new System.Drawing.Size(805, 295);
            this.dataRiwayat.TabIndex = 2;
            this.dataRiwayat.TabStop = false;
            this.dataRiwayat.Sorted += new System.EventHandler(this.dataRiwayat_Sorted);
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 42;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nama";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Benar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 54;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Kecepatan";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 74;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Ketepatan";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 72;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Soal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 48;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "Tanggal";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 62;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column7.HeaderText = "Waktu";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 57;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column8.HeaderText = "Interval";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 62;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column9.HeaderText = "Operasi";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 62;
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            // 
            // cmbgrup
            // 
            this.cmbgrup.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrup.FormattingEnabled = true;
            this.cmbgrup.Location = new System.Drawing.Point(123, 43);
            this.cmbgrup.Name = "cmbgrup";
            this.cmbgrup.Size = new System.Drawing.Size(121, 24);
            this.cmbgrup.TabIndex = 5;
            this.cmbgrup.SelectedIndexChanged += new System.EventHandler(this.cmbgrup_SelectedIndexChanged);
            // 
            // btnKembali1
            // 
            this.btnKembali1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnKembali1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnKembali1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKembali1.BorderRadius = 0;
            this.btnKembali1.ButtonText = "Kembali";
            this.btnKembali1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembali1.DisabledColor = System.Drawing.Color.Gray;
            this.btnKembali1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKembali1.Iconimage = null;
            this.btnKembali1.Iconimage_right = null;
            this.btnKembali1.Iconimage_right_Selected = null;
            this.btnKembali1.Iconimage_Selected = null;
            this.btnKembali1.IconMarginLeft = 0;
            this.btnKembali1.IconMarginRight = 0;
            this.btnKembali1.IconRightVisible = true;
            this.btnKembali1.IconRightZoom = 0D;
            this.btnKembali1.IconVisible = true;
            this.btnKembali1.IconZoom = 90D;
            this.btnKembali1.IsTab = false;
            this.btnKembali1.Location = new System.Drawing.Point(12, 413);
            this.btnKembali1.Name = "btnKembali1";
            this.btnKembali1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnKembali1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.btnKembali1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKembali1.selected = false;
            this.btnKembali1.Size = new System.Drawing.Size(137, 31);
            this.btnKembali1.TabIndex = 31;
            this.btnKembali1.Text = "Kembali";
            this.btnKembali1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKembali1.Textcolor = System.Drawing.Color.White;
            this.btnKembali1.TextFont = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali1.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnHapus1
            // 
            this.btnHapus1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnHapus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnHapus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapus1.BorderRadius = 0;
            this.btnHapus1.ButtonText = "Hapus Data";
            this.btnHapus1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus1.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapus1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapus1.Iconimage = null;
            this.btnHapus1.Iconimage_right = null;
            this.btnHapus1.Iconimage_right_Selected = null;
            this.btnHapus1.Iconimage_Selected = null;
            this.btnHapus1.IconMarginLeft = 0;
            this.btnHapus1.IconMarginRight = 0;
            this.btnHapus1.IconRightVisible = true;
            this.btnHapus1.IconRightZoom = 0D;
            this.btnHapus1.IconVisible = true;
            this.btnHapus1.IconZoom = 90D;
            this.btnHapus1.IsTab = false;
            this.btnHapus1.Location = new System.Drawing.Point(680, 413);
            this.btnHapus1.Name = "btnHapus1";
            this.btnHapus1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnHapus1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.btnHapus1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapus1.selected = false;
            this.btnHapus1.Size = new System.Drawing.Size(137, 31);
            this.btnHapus1.TabIndex = 32;
            this.btnHapus1.Text = "Hapus Data";
            this.btnHapus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHapus1.Textcolor = System.Drawing.Color.White;
            this.btnHapus1.TextFont = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus1.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 48);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 19);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "Berdasarkan";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnHapus1);
            this.Controls.Add(this.btnKembali1);
            this.Controls.Add(this.cmbgrup);
            this.Controls.Add(this.dataRiwayat);
            this.Controls.Add(this.lblRiwayat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblRiwayat;
        private System.Windows.Forms.DataGridView dataRiwayat;
        
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilaibenarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kecepatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketepatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktumainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ComboBox cmbgrup;
        private Bunifu.Framework.UI.BunifuFlatButton btnKembali1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHapus1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}