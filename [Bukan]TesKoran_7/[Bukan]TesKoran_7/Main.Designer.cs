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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.dashboard = new _Bukan_TesKoran_7.Dashboard();
            this.uiGame = new _Bukan_TesKoran_7.UiGame();
            this.uiLevel = new _Bukan_TesKoran_7.UiLevel();
            this.uiProfile = new _Bukan_TesKoran_7.UiProfile();
            this.uiGrafik = new _Bukan_TesKoran_7.UiGrafik();
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
            // bunifuTransition
            // 
            this.bunifuTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.bunifuTransition.DefaultAnimation = animation5;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.bunifuTransition.SetDecoration(this.dashboard, BunifuAnimatorNS.DecorationType.None);
            this.dashboard.Location = new System.Drawing.Point(-1, -2);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(356, 609);
            this.dashboard.TabIndex = 27;
            this.dashboard.VisibleChanged += new System.EventHandler(this.dashboard_VisibleChanged);
            // 
            // uiGame
            // 
            this.uiGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.bunifuTransition.SetDecoration(this.uiGame, BunifuAnimatorNS.DecorationType.None);
            this.uiGame.Location = new System.Drawing.Point(-1, -2);
            this.uiGame.Name = "uiGame";
            this.uiGame.Size = new System.Drawing.Size(356, 609);
            this.uiGame.TabIndex = 28;
            this.uiGame.VisibleChanged += new System.EventHandler(this.uiGame_VisibleChanged);
            // 
            // uiLevel
            // 
            this.uiLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.bunifuTransition.SetDecoration(this.uiLevel, BunifuAnimatorNS.DecorationType.None);
            this.uiLevel.Location = new System.Drawing.Point(-1, -2);
            this.uiLevel.Name = "uiLevel";
            this.uiLevel.Size = new System.Drawing.Size(356, 609);
            this.uiLevel.TabIndex = 26;
            this.uiLevel.VisibleChanged += new System.EventHandler(this.uiLevel_VisibleChanged);
            // 
            // uiProfile
            // 
            this.uiProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.bunifuTransition.SetDecoration(this.uiProfile, BunifuAnimatorNS.DecorationType.None);
            this.uiProfile.Location = new System.Drawing.Point(-1, -2);
            this.uiProfile.Name = "uiProfile";
            this.uiProfile.Size = new System.Drawing.Size(356, 609);
            this.uiProfile.TabIndex = 29;
            this.uiProfile.VisibleChanged += new System.EventHandler(this.uiProfile_VisibleChanged);
            // 
            // uiGrafik
            // 
            this.uiGrafik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.bunifuTransition.SetDecoration(this.uiGrafik, BunifuAnimatorNS.DecorationType.None);
            this.uiGrafik.Location = new System.Drawing.Point(-1, -2);
            this.uiGrafik.Name = "uiGrafik";
            this.uiGrafik.Size = new System.Drawing.Size(356, 609);
            this.uiGrafik.TabIndex = 30;
            this.uiGrafik.VisibleChanged += new System.EventHandler(this.uiGrafik_VisibleChanged);
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
            this.Controls.Add(this.uiGrafik);
            this.bunifuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
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
        private BunifuAnimatorNS.BunifuTransition bunifuTransition;
        private UiGrafik uiGrafik;
    }
}

