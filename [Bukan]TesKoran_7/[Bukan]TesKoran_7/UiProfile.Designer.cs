namespace _Bukan_TesKoran_7
{
    partial class UiProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UiProfile));
            this.txtNama = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNama.HintForeColor = System.Drawing.Color.Empty;
            this.txtNama.HintText = "";
            this.txtNama.isPassword = false;
            this.txtNama.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNama.LineIdleColor = System.Drawing.Color.White;
            this.txtNama.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNama.LineThickness = 3;
            this.txtNama.Location = new System.Drawing.Point(34, 209);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(289, 29);
            this.txtNama.TabIndex = 1;
            this.txtNama.Text = "MASUKAN NAMA";
            this.txtNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 91);
            this.label1.TabIndex = 13;
            this.label1.Text = "Masukkan nama anda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnEnter.ButtonText = "Selesai";
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.MintCream;
            this.btnEnter.IdleBorderThickness = 1;
            this.btnEnter.IdleCornerRadius = 20;
            this.btnEnter.IdleFillColor = System.Drawing.Color.Empty;
            this.btnEnter.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEnter.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEnter.Location = new System.Drawing.Point(88, 563);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(181, 41);
            this.btnEnter.TabIndex = 18;
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnter.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // UiProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Name = "UiProfile";
            this.Size = new System.Drawing.Size(356, 609);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNama;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnter;
    }
}
