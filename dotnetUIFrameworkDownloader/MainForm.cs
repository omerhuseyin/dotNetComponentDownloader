namespace dotnetUIFrameworkDownloader
{
    using ByteSizeLib;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Media;
    using System.Net;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Point lastPoint;
        private Uri globalUri = null;
        private string downloadPath = string.Empty;
        private string downloadSize = string.Empty;
        private string targetFramework = string.Empty;
        private string combinedFile = string.Empty;



        private void pathButton_Click(object sender, EventArgs e)
        {
            PlaySound("OPEN_SOUND");
            pathButton.Text = "Selecting...";
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                downloadPath = folderDlg.SelectedPath;
                pathButton.Text = downloadPath;
            }

            else if (result == DialogResult.Cancel)
            {
                pathButton.Text = "Select Location";
            }
        }


        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                string fileName = Path.Combine(downloadPath, targetFramework);
                FileInfo fi = new FileInfo(fileName);
                this.lblDownloadStatus.Visible = true;
                lblDownloadSize.Visible = true;
                lblDownloadSize.Text = ByteSize.FromBytes(fi.Length).ToString() + "/" + downloadSize;
                downloadProgress.Visible = true;
                downloadProgress.Value = e.ProgressPercentage;
            }

            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private static string GetFileSize(Uri uriPath)
        {
            try
            {
                var webRequest = HttpWebRequest.Create(uriPath);
                webRequest.Method = "HEAD";

                using (var webResponse = webRequest.GetResponse())
                {
                    var fileSize = webResponse.Headers.Get("Content-Length");
                    var fileSizeInMegaByte = Math.Round(Convert.ToDouble(fileSize) / 1024.0 / 1024.0, 2);
                    return fileSizeInMegaByte + " MB";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            try
            {
                combinedFile = Path.Combine(downloadPath, targetFramework);
                Uri globalUri = new Uri(Properties.Settings.Default.InstallerDomain + targetFramework);
                if (!File.Exists(combinedFile))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        installButton.Text = $"Installing";
                        lblDownloadStatus.Text = $"Installing {targetFramework}";
                        installButton.Enabled = false;
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                        webClient.DownloadFileAsync(globalUri, combinedFile);
                        downloadSize = GetFileSize(globalUri);
                    }
                }

                else
                {
                    PlaySound("WARNING_SOUND");
                    MessageBox.Show($"You Already Have A Folder Called {targetFramework} In Your {downloadPath} Folder!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}

        }

        private void PlaySound(string param)
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer())
                {
                    if (param == "SUCCESS_SOUND") player.SoundLocation = @"success.wav";
                    else if (param == "OPEN_SOUND") player.SoundLocation = @"open.wav";
                    else if (param == "WARNING_SOUND") player.SoundLocation = @"warning.wav";
                    else if (param == "ERROR_SOUND") player.SoundLocation = @"error.wav";
                    player.Play();
                    player.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            downloadPath = string.Empty;
            downloadSize = string.Empty;
            targetFramework = string.Empty;
            combinedFile = string.Empty;
            globalUri = null;
            installButton.Text = "Install";
            installButton.Enabled = true;
            frameworkList.Text = "";
            frameworkList.SelectedItem = null;
            pathButton.Text = "Select Location";
            PlaySound("SUCCESS_SOUND");
            lblDownloadStatus.Text = ($"{targetFramework} Successfully Installed!");
        }

        private void Controller_Tick(object sender, EventArgs e)
        {
            if (downloadPath == string.Empty && targetFramework == string.Empty)
                installButton.Enabled = false;

            else if (downloadPath != string.Empty && targetFramework != string.Empty)
                installButton.Enabled =true;

        }

        private void frameworkList_SelectedValueChanged(object sender, EventArgs e)
        {
            targetFramework = frameworkList.Text;
        }

        private void FadeExit_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0) Environment.Exit(0);
            Opacity -= .1;
        }

        private void HeaderDownEvent(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void HeaderMoveEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/omerhuseyingul/");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            FadeExit.Start();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/omerhuseyingul/dotnet-ui-components");
        }
    }
}
