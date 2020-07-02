namespace _Bukan_TesKoran_7
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAktif_efek_suara = new System.Windows.Forms.RadioButton();
            this.rbAktif_musik = new System.Windows.Forms.RadioButton();
            this.rbTidak_efek_suara = new System.Windows.Forms.RadioButton();
            this.rbTidak_musik = new System.Windows.Forms.RadioButton();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rbAktif_efek_suara
            // 
            resources.ApplyResources(this.rbAktif_efek_suara, "rbAktif_efek_suara");
            this.rbAktif_efek_suara.Name = "rbAktif_efek_suara";
            this.rbAktif_efek_suara.TabStop = true;
            this.rbAktif_efek_suara.UseVisualStyleBackColor = true;
            // 
            // rbAktif_musik
            // 
            resources.ApplyResources(this.rbAktif_musik, "rbAktif_musik");
            this.rbAktif_musik.Name = "rbAktif_musik";
            this.rbAktif_musik.TabStop = true;
            this.rbAktif_musik.UseVisualStyleBackColor = true;
            this.rbAktif_musik.CheckedChanged += new System.EventHandler(this.rbAktif_musik_CheckedChanged);
            this.rbAktif_musik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbAktif_musik_MouseClick);
            // 
            // rbTidak_efek_suara
            // 
            resources.ApplyResources(this.rbTidak_efek_suara, "rbTidak_efek_suara");
            this.rbTidak_efek_suara.Name = "rbTidak_efek_suara";
            this.rbTidak_efek_suara.TabStop = true;
            this.rbTidak_efek_suara.UseVisualStyleBackColor = true;
            // 
            // rbTidak_musik
            // 
            resources.ApplyResources(this.rbTidak_musik, "rbTidak_musik");
            this.rbTidak_musik.Name = "rbTidak_musik";
            this.rbTidak_musik.TabStop = true;
            this.rbTidak_musik.UseVisualStyleBackColor = true;
            this.rbTidak_musik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbTidak_musik_MouseClick);
            // 
            // btnSelesai
            // 
            resources.ApplyResources(this.btnSelesai, "btnSelesai");
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAktif_efek_suara);
            this.groupBox1.Controls.Add(this.rbTidak_efek_suara);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTidak_musik);
            this.groupBox2.Controls.Add(this.rbAktif_musik);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Setting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAktif_efek_suara;
        private System.Windows.Forms.RadioButton rbAktif_musik;
        private System.Windows.Forms.RadioButton rbTidak_efek_suara;
        private System.Windows.Forms.RadioButton rbTidak_musik;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}