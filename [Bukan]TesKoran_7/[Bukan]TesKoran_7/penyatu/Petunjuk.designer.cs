namespace _Bukan_TesKoran_7
{
    partial class Petunjuk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Petunjuk Permainan";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 123);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Pemain memilih waktu bermain.\r\n2. Pemain memilih operasi hitung yang akan dima" +
    "inkan.\r\n3. Ketika bermain, pemain hanya menjawab angka belakang dari hasil soal." +
    "";
            // 
            // btnOK
            // 
            this.btnOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.BorderRadius = 0;
            this.btnOK.ButtonText = "OK!";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.DisabledColor = System.Drawing.Color.Gray;
            this.btnOK.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOK.Iconimage = null;
            this.btnOK.Iconimage_right = null;
            this.btnOK.Iconimage_right_Selected = null;
            this.btnOK.Iconimage_Selected = null;
            this.btnOK.IconMarginLeft = 0;
            this.btnOK.IconMarginRight = 0;
            this.btnOK.IconRightVisible = true;
            this.btnOK.IconRightZoom = 0D;
            this.btnOK.IconVisible = true;
            this.btnOK.IconZoom = 90D;
            this.btnOK.IsTab = false;
            this.btnOK.Location = new System.Drawing.Point(40, 566);
            this.btnOK.Name = "btnOK";
            this.btnOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.btnOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOK.selected = false;
            this.btnOK.Size = new System.Drawing.Size(277, 31);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "OK!";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Textcolor = System.Drawing.Color.White;
            this.btnOK.TextFont = new System.Drawing.Font("Kristen ITC", 11F);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 104);
            this.label3.TabIndex = 31;
            this.label3.Text = "Contoh :\r\n7 + 4 = 1\r\n8 + 8 = 6\r\nYang lain? Coba pikir ";
            // 
            // Petunjuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(356, 609);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Petunjuk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petunjuk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnOK;
        private System.Windows.Forms.Label label3;
    }
}