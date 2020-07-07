namespace _Bukan_TesKoran_7
{
    partial class UiGrafik
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UiGrafik));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEnter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelHasil = new System.Windows.Forms.Panel();
            this.txtKetepatan = new System.Windows.Forms.Label();
            this.txtBenar = new System.Windows.Forms.Label();
            this.txtKecepatan = new System.Windows.Forms.Label();
            this.txtSalah = new System.Windows.Forms.Label();
            this.txtSoal = new System.Windows.Forms.Label();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(198, 31);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Grafik Pemain";
            // 
            // btnEnter
            // 
            this.btnEnter.ActiveBorderThickness = 1;
            this.btnEnter.ActiveCornerRadius = 25;
            this.btnEnter.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEnter.ActiveForecolor = System.Drawing.Color.White;
            this.btnEnter.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
            this.btnEnter.ButtonText = "Enter";
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.MintCream;
            this.btnEnter.IdleBorderThickness = 1;
            this.btnEnter.IdleCornerRadius = 20;
            this.btnEnter.IdleFillColor = System.Drawing.Color.Empty;
            this.btnEnter.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEnter.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEnter.Location = new System.Drawing.Point(88, 530);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(181, 41);
            this.btnEnter.TabIndex = 19;
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.chart1.BorderlineWidth = 0;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 47);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(356, 300);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(4, 4);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(125, 32);
            this.bunifuMaterialTextbox1.TabIndex = 21;
            this.bunifuMaterialTextbox1.Text = "Hasil Permainan";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Benar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Salah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Soal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kecepatan menjawab";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ketepatan menjawab";
            // 
            // panelHasil
            // 
            this.panelHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHasil.Controls.Add(this.txtKetepatan);
            this.panelHasil.Controls.Add(this.txtBenar);
            this.panelHasil.Controls.Add(this.txtKecepatan);
            this.panelHasil.Controls.Add(this.txtSalah);
            this.panelHasil.Controls.Add(this.txtSoal);
            this.panelHasil.Controls.Add(this.bunifuMaterialTextbox1);
            this.panelHasil.Controls.Add(this.label5);
            this.panelHasil.Controls.Add(this.label1);
            this.panelHasil.Controls.Add(this.label4);
            this.panelHasil.Controls.Add(this.label2);
            this.panelHasil.Controls.Add(this.label3);
            this.panelHasil.Location = new System.Drawing.Point(9, 353);
            this.panelHasil.Name = "panelHasil";
            this.panelHasil.Size = new System.Drawing.Size(331, 141);
            this.panelHasil.TabIndex = 27;
            // 
            // txtKetepatan
            // 
            this.txtKetepatan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKetepatan.ForeColor = System.Drawing.Color.White;
            this.txtKetepatan.Location = new System.Drawing.Point(166, 108);
            this.txtKetepatan.Name = "txtKetepatan";
            this.txtKetepatan.Size = new System.Drawing.Size(155, 17);
            this.txtKetepatan.TabIndex = 31;
            this.txtKetepatan.Text = "Ketepatan menjawab";
            // 
            // txtBenar
            // 
            this.txtBenar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBenar.ForeColor = System.Drawing.Color.White;
            this.txtBenar.Location = new System.Drawing.Point(166, 40);
            this.txtBenar.Name = "txtBenar";
            this.txtBenar.Size = new System.Drawing.Size(155, 17);
            this.txtBenar.TabIndex = 27;
            this.txtBenar.Text = "Benar";
            // 
            // txtKecepatan
            // 
            this.txtKecepatan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKecepatan.ForeColor = System.Drawing.Color.White;
            this.txtKecepatan.Location = new System.Drawing.Point(166, 91);
            this.txtKecepatan.Name = "txtKecepatan";
            this.txtKecepatan.Size = new System.Drawing.Size(155, 17);
            this.txtKecepatan.TabIndex = 30;
            this.txtKecepatan.Text = "Kecepatan menjawab";
            // 
            // txtSalah
            // 
            this.txtSalah.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSalah.ForeColor = System.Drawing.Color.White;
            this.txtSalah.Location = new System.Drawing.Point(166, 57);
            this.txtSalah.Name = "txtSalah";
            this.txtSalah.Size = new System.Drawing.Size(155, 17);
            this.txtSalah.TabIndex = 28;
            this.txtSalah.Text = "Salah";
            // 
            // txtSoal
            // 
            this.txtSoal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoal.ForeColor = System.Drawing.Color.White;
            this.txtSoal.Location = new System.Drawing.Point(167, 74);
            this.txtSoal.Name = "txtSoal";
            this.txtSoal.Size = new System.Drawing.Size(155, 17);
            this.txtSoal.TabIndex = 29;
            this.txtSoal.Text = "Soal";
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // UiGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.panelHasil);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "UiGrafik";
            this.Size = new System.Drawing.Size(356, 609);
            this.Load += new System.EventHandler(this.UiGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelHasil.ResumeLayout(false);
            this.panelHasil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
       // private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelHasil;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        public System.Windows.Forms.Label txtKetepatan;
        public System.Windows.Forms.Label txtBenar;
        public System.Windows.Forms.Label txtKecepatan;
        public System.Windows.Forms.Label txtSalah;
        public System.Windows.Forms.Label txtSoal;
    }
}
