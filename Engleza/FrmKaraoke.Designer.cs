namespace Engleza
{
    partial class FrmKaraoke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaraoke));
            this.lstLink = new System.Windows.Forms.ListBox();
            this.lstVideo = new System.Windows.Forms.ListBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInstructiuni = new System.Windows.Forms.Panel();
            this.pictureBoxEN = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRO = new System.Windows.Forms.PictureBox();
            this.lblIEngleza = new System.Windows.Forms.Label();
            this.lblIRomana = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Video = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInstructiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLink
            // 
            this.lstLink.FormattingEnabled = true;
            this.lstLink.Items.AddRange(new object[] {
            "https://www.youtube.com/v/b0NHrFNZWh0",
            "https://www.youtube.com/v/VayWP-SknPA",
            "https://www.youtube.com/v/fHqjNHxmB7c",
            "https://www.youtube.com/v/3xqqj9o7TgA",
            "https://www.youtube.com/v/tkpfg-1FJLU",
            "https://www.youtube.com/v/Zu6o23Pu0Do",
            "https://www.youtube.com/v/1dttq5p0xUM",
            "https://www.youtube.com/v/ZBjFYW_TrdM",
            "https://www.youtube.com/v/LIWbUjHZFTw",
            "https://www.youtube.com/v/03alr9k5tjU"});
            this.lstLink.Location = new System.Drawing.Point(325, 1);
            this.lstLink.Name = "lstLink";
            this.lstLink.Size = new System.Drawing.Size(229, 95);
            this.lstLink.TabIndex = 2;
            this.lstLink.Visible = false;
            // 
            // lstVideo
            // 
            this.lstVideo.BackColor = System.Drawing.Color.White;
            this.lstVideo.Font = new System.Drawing.Font("Kristen ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVideo.ForeColor = System.Drawing.Color.Purple;
            this.lstVideo.FormattingEnabled = true;
            this.lstVideo.ItemHeight = 17;
            this.lstVideo.Items.AddRange(new object[] {
            "Five Little Monkeys Jumping On The Bed",
            "ABCD Alphabet Song",
            "Numbers Song ",
            "The Finger Family Song ",
            "Let\'s Learn The Colors!",
            "Rain, Rain, Go Away ",
            "The Joy of Sharing!",
            " Clap Your Hands ",
            "Old MacDonald Had a Farm ",
            "Twinkle Twinkle Little Star "});
            this.lstVideo.Location = new System.Drawing.Point(0, 1);
            this.lstVideo.Name = "lstVideo";
            this.lstVideo.Size = new System.Drawing.Size(310, 123);
            this.lstVideo.TabIndex = 3;
            this.lstVideo.SelectedIndexChanged += new System.EventHandler(this.lstVideo_SelectedIndexChanged);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Red;
            this.lblExit.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(995, 1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 23);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 555);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelInstructiuni
            // 
            this.panelInstructiuni.BackColor = System.Drawing.Color.Transparent;
            this.panelInstructiuni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInstructiuni.BackgroundImage")));
            this.panelInstructiuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelInstructiuni.Controls.Add(this.pictureBoxEN);
            this.panelInstructiuni.Controls.Add(this.label1);
            this.panelInstructiuni.Controls.Add(this.pictureBoxRO);
            this.panelInstructiuni.Controls.Add(this.lblIEngleza);
            this.panelInstructiuni.Controls.Add(this.lblIRomana);
            this.panelInstructiuni.Location = new System.Drawing.Point(51, 441);
            this.panelInstructiuni.Name = "panelInstructiuni";
            this.panelInstructiuni.Size = new System.Drawing.Size(274, 161);
            this.panelInstructiuni.TabIndex = 8;
            this.panelInstructiuni.Visible = false;
            // 
            // pictureBoxEN
            // 
            this.pictureBoxEN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEN.BackgroundImage")));
            this.pictureBoxEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEN.Location = new System.Drawing.Point(39, 94);
            this.pictureBoxEN.Name = "pictureBoxEN";
            this.pictureBoxEN.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxEN.TabIndex = 3;
            this.pictureBoxEN.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxRO
            // 
            this.pictureBoxRO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRO.BackgroundImage")));
            this.pictureBoxRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRO.Location = new System.Drawing.Point(39, 27);
            this.pictureBoxRO.Name = "pictureBoxRO";
            this.pictureBoxRO.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxRO.TabIndex = 2;
            this.pictureBoxRO.TabStop = false;
            // 
            // lblIEngleza
            // 
            this.lblIEngleza.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIEngleza.ForeColor = System.Drawing.Color.Black;
            this.lblIEngleza.Location = new System.Drawing.Point(74, 94);
            this.lblIEngleza.Name = "lblIEngleza";
            this.lblIEngleza.Size = new System.Drawing.Size(165, 74);
            this.lblIEngleza.TabIndex = 1;
            this.lblIEngleza.Text = "Select a song from the list above, watch video and practice your pronunciation.";
            // 
            // lblIRomana
            // 
            this.lblIRomana.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRomana.ForeColor = System.Drawing.Color.Black;
            this.lblIRomana.Location = new System.Drawing.Point(74, 23);
            this.lblIRomana.Name = "lblIRomana";
            this.lblIRomana.Size = new System.Drawing.Size(172, 104);
            this.lblIRomana.TabIndex = 0;
            this.lblIRomana.Text = "Selecteaza o melodie din lista de mai sus , urmareste video-ul si exerseaza-ti pr" +
    "onuntia .";
            // 
            // Video
            // 
            this.Video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Video.Enabled = true;
            this.Video.Location = new System.Drawing.Point(173, 127);
            this.Video.MaximumSize = new System.Drawing.Size(688, 365);
            this.Video.MinimumSize = new System.Drawing.Size(688, 365);
            this.Video.Name = "Video";
            this.Video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Video.OcxState")));
            this.Video.Size = new System.Drawing.Size(688, 365);
            this.Video.TabIndex = 1;
            // 
            // FrmKaraoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 603);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.panelInstructiuni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lstVideo);
            this.Controls.Add(this.lstLink);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(173, 127);
            this.MaximumSize = new System.Drawing.Size(1016, 603);
            this.MinimumSize = new System.Drawing.Size(1016, 603);
            this.Name = "FrmKaraoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKaraoke";
            this.Load += new System.EventHandler(this.FrmKaraoke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInstructiuni.ResumeLayout(false);
            this.panelInstructiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstLink;
        private System.Windows.Forms.ListBox lstVideo;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInstructiuni;
        private System.Windows.Forms.PictureBox pictureBoxEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRO;
        private System.Windows.Forms.Label lblIEngleza;
        private System.Windows.Forms.Label lblIRomana;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AxShockwaveFlashObjects.AxShockwaveFlash Video;
    }
}