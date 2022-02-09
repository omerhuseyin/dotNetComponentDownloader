namespace dotnetUIFrameworkDownloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.installButton = new Guna.UI.WinForms.GunaButton();
            this.downloadProgress = new Guna.UI.WinForms.GunaProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDownloadSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frameworkList = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGithub = new System.Windows.Forms.PictureBox();
            this.elipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.pathButton = new Guna.UI.WinForms.GunaButton();
            this.Controller = new System.Windows.Forms.Timer(this.components);
            this.FadeExit = new System.Windows.Forms.Timer(this.components);
            this.lblDownloadStatus = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelHeader.Controls.Add(this.aboutButton);
            this.panelHeader.Controls.Add(this.minimizeButton);
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label10);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(701, 38);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderDownEvent);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderMoveEvent);
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.Image = global::dotnetUIFrameworkDownloader.Properties.Resources.about;
            this.aboutButton.Location = new System.Drawing.Point(634, 12);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(15, 15);
            this.aboutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutButton.TabIndex = 17;
            this.aboutButton.TabStop = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = global::dotnetUIFrameworkDownloader.Properties.Resources.minimized;
            this.minimizeButton.Location = new System.Drawing.Point(649, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(15, 15);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 16;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::dotnetUIFrameworkDownloader.Properties.Resources.close;
            this.exitButton.Location = new System.Drawing.Point(664, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(15, 15);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 15;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dotnetUIFrameworkDownloader.Properties.Resources.dotnetico;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = ".NET Component Downloader";
            // 
            // installButton
            // 
            this.installButton.AnimationHoverSpeed = 0.07F;
            this.installButton.AnimationSpeed = 0.03F;
            this.installButton.BackColor = System.Drawing.Color.Transparent;
            this.installButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(213)))));
            this.installButton.BorderColor = System.Drawing.Color.Black;
            this.installButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.installButton.FocusedColor = System.Drawing.Color.Empty;
            this.installButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.installButton.ForeColor = System.Drawing.Color.White;
            this.installButton.Image = null;
            this.installButton.ImageSize = new System.Drawing.Size(20, 20);
            this.installButton.Location = new System.Drawing.Point(291, 306);
            this.installButton.Name = "installButton";
            this.installButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.installButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.installButton.OnHoverForeColor = System.Drawing.Color.White;
            this.installButton.OnHoverImage = null;
            this.installButton.OnPressedColor = System.Drawing.Color.Black;
            this.installButton.Radius = 20;
            this.installButton.Size = new System.Drawing.Size(144, 49);
            this.installButton.TabIndex = 1;
            this.installButton.Text = "Install";
            this.installButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // downloadProgress
            // 
            this.downloadProgress.BackColor = System.Drawing.Color.Transparent;
            this.downloadProgress.BorderColor = System.Drawing.Color.Black;
            this.downloadProgress.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.downloadProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.downloadProgress.Location = new System.Drawing.Point(22, 391);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(213)))));
            this.downloadProgress.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(213)))));
            this.downloadProgress.Radius = 5;
            this.downloadProgress.Size = new System.Drawing.Size(667, 10);
            this.downloadProgress.TabIndex = 2;
            this.downloadProgress.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(213)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 69);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = ".NET WinForms Component Downloader";
            // 
            // lblDownloadSize
            // 
            this.lblDownloadSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDownloadSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDownloadSize.ForeColor = System.Drawing.Color.White;
            this.lblDownloadSize.Location = new System.Drawing.Point(592, 375);
            this.lblDownloadSize.Name = "lblDownloadSize";
            this.lblDownloadSize.Size = new System.Drawing.Size(99, 13);
            this.lblDownloadSize.TabIndex = 4;
            this.lblDownloadSize.Text = "0MB / 0MB";
            this.lblDownloadSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDownloadSize.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Install";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bunifu, Guna, Siticone and more";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "frameworks for WinForms.";
            // 
            // frameworkList
            // 
            this.frameworkList.BackColor = System.Drawing.Color.Transparent;
            this.frameworkList.BaseColor = System.Drawing.Color.White;
            this.frameworkList.BorderColor = System.Drawing.Color.Silver;
            this.frameworkList.BorderSize = 0;
            this.frameworkList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frameworkList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.frameworkList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frameworkList.FocusedColor = System.Drawing.Color.Empty;
            this.frameworkList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.frameworkList.ForeColor = System.Drawing.Color.Black;
            this.frameworkList.FormattingEnabled = true;
            this.frameworkList.Items.AddRange(new object[] {
            "Bunifu.Licensing.dll",
            "Guna.UI.dll",
            "Siticone.UI.dll"});
            this.frameworkList.Location = new System.Drawing.Point(246, 269);
            this.frameworkList.Name = "frameworkList";
            this.frameworkList.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.frameworkList.OnHoverItemForeColor = System.Drawing.Color.White;
            this.frameworkList.Radius = 10;
            this.frameworkList.Size = new System.Drawing.Size(228, 26);
            this.frameworkList.TabIndex = 5;
            this.frameworkList.Tag = "Select Framework to Download";
            this.frameworkList.SelectedValueChanged += new System.EventHandler(this.frameworkList_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Downloadable Frameworks";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnGithub);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 27);
            this.panel3.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(661, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "v1.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(314, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "All Rights Are Free";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "github.com/omerhuseyingul";
            // 
            // btnGithub
            // 
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.Image = global::dotnetUIFrameworkDownloader.Properties.Resources.githubicon;
            this.btnGithub.Location = new System.Drawing.Point(7, 5);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(17, 17);
            this.btnGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGithub.TabIndex = 7;
            this.btnGithub.TabStop = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // elipseForm
            // 
            this.elipseForm.Radius = 10;
            this.elipseForm.TargetControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(308, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Installation Location\r\nClick to select\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathButton
            // 
            this.pathButton.AnimationHoverSpeed = 0.07F;
            this.pathButton.AnimationSpeed = 0.03F;
            this.pathButton.BackColor = System.Drawing.Color.Transparent;
            this.pathButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(213)))));
            this.pathButton.BorderColor = System.Drawing.Color.Black;
            this.pathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pathButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pathButton.FocusedColor = System.Drawing.Color.Empty;
            this.pathButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathButton.ForeColor = System.Drawing.Color.White;
            this.pathButton.Image = null;
            this.pathButton.ImageSize = new System.Drawing.Size(20, 20);
            this.pathButton.Location = new System.Drawing.Point(210, 200);
            this.pathButton.Name = "pathButton";
            this.pathButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.pathButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.pathButton.OnHoverForeColor = System.Drawing.Color.White;
            this.pathButton.OnHoverImage = null;
            this.pathButton.OnPressedColor = System.Drawing.Color.Black;
            this.pathButton.Radius = 15;
            this.pathButton.Size = new System.Drawing.Size(308, 37);
            this.pathButton.TabIndex = 11;
            this.pathButton.Text = "Select Location";
            this.pathButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // Controller
            // 
            this.Controller.Enabled = true;
            this.Controller.Interval = 1000;
            this.Controller.Tick += new System.EventHandler(this.Controller_Tick);
            // 
            // FadeExit
            // 
            this.FadeExit.Interval = 10;
            this.FadeExit.Tick += new System.EventHandler(this.FadeExit_Tick);
            // 
            // lblDownloadStatus
            // 
            this.lblDownloadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDownloadStatus.ForeColor = System.Drawing.Color.White;
            this.lblDownloadStatus.Location = new System.Drawing.Point(265, 367);
            this.lblDownloadStatus.Name = "lblDownloadStatus";
            this.lblDownloadStatus.Size = new System.Drawing.Size(200, 17);
            this.lblDownloadStatus.TabIndex = 12;
            this.lblDownloadStatus.Text = "DownloadStatus";
            this.lblDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDownloadStatus.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(701, 439);
            this.Controls.Add(this.lblDownloadStatus);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.frameworkList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDownloadSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Component Downloader";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI.WinForms.GunaButton installButton;
        private Guna.UI.WinForms.GunaProgressBar downloadProgress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDownloadSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox frameworkList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnGithub;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaElipse elipseForm;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton pathButton;
        private System.Windows.Forms.Timer Controller;
        private System.Windows.Forms.Timer FadeExit;
        private System.Windows.Forms.Label lblDownloadStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox aboutButton;
    }
}

