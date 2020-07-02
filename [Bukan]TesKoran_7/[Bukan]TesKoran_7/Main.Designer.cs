namespace _Bukan_TesKoran_7
{
    partial class Main
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.uiGame = new _Bukan_TesKoran_7.UiGame();
            this.uiLevel = new _Bukan_TesKoran_7.UiLevel();
            this.uiProfile = new _Bukan_TesKoran_7.UiProfile();
            this.dashboard = new _Bukan_TesKoran_7.Dashboard();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            // 
            // uiGame
            // 
            this.uiGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.uiGame.Location = new System.Drawing.Point(-1, -2);
            this.uiGame.Name = "uiGame";
            this.uiGame.Size = new System.Drawing.Size(356, 609);
            this.uiGame.TabIndex = 28;
            this.uiGame.VisibleChanged += new System.EventHandler(this.uiGame_VisibleChanged);
            // 
            // uiLevel
            // 
            this.uiLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.uiLevel.Location = new System.Drawing.Point(-1, -2);
            this.uiLevel.Name = "uiLevel";
            this.uiLevel.Size = new System.Drawing.Size(356, 609);
            this.uiLevel.TabIndex = 26;
            this.uiLevel.VisibleChanged += new System.EventHandler(this.uiLevel_VisibleChanged);
            // 
            // uiProfile
            // 
            this.uiProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.uiProfile.Location = new System.Drawing.Point(-1, -2);
            this.uiProfile.Name = "uiProfile";
            this.uiProfile.Size = new System.Drawing.Size(356, 609);
            this.uiProfile.TabIndex = 29;
            this.uiProfile.VisibleChanged += new System.EventHandler(this.uiProfile_VisibleChanged);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.dashboard.Location = new System.Drawing.Point(-1, -2);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(356, 609);
            this.dashboard.TabIndex = 27;
            this.dashboard.VisibleChanged += new System.EventHandler(this.dashboard_VisibleChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(356, 609);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.uiGame);
            this.Controls.Add(this.uiLevel);
            this.Controls.Add(this.uiProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Bukan] Tes Koran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private UiLevel uiLevel;
        private Dashboard dashboard;
        private UiGame uiGame;
        private UiProfile uiProfile;
        private System.Windows.Forms.Timer Timer;
    }
}

