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

        #region Global Variables
        private Point lastPoint = default;
        private Uri globalUri = default;
        private string downloadPath = default;
        private string downloadSize = default;
        private string targetFramework = default;
        private string combinedFile = default;
        #endregion

        #region File Download Functions
        /// <summary>
        /// File Download Controller Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Returns the MB value of the file to be downloaded
        /// </summary>
        /// <param name="uriPath"></param>
        /// <returns></returns>
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
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }         
        }

        /// <summary>
        /// The Event that Starts the Installation Process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void installButton_Click(object sender, EventArgs e)
        {
            try
            {
                combinedFile = Path.Combine(downloadPath, targetFramework);
                globalUri = new Uri(Properties.Settings.Default.InstallerDomain + targetFramework);
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

        /// <summary>
        /// It is the Event that Triggers the Commands to be Executed Once the File Download is Complete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            downloadPath = default;
            downloadSize = default;
            targetFramework = default;
            combinedFile = default;
            globalUri = default;
            installButton.Text = "Install";
            installButton.Enabled = true;
            frameworkList.Text = "";
            frameworkList.SelectedItem = null;
            pathButton.Text = "Select Location";
            PlaySound("SUCCESS_SOUND");
            lblDownloadStatus.Text = ($"{targetFramework} Successfully Installed!");
        }
        #endregion

        #region Other Functions
        /// <summary>
        /// Download Location Selecting Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// It is the function that plays sound effects after the running events.
        /// </summary>
        /// <param name="param"></param>
        private void PlaySound(string param)
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer())
                {

                    player.SoundLocation = 
                        param == "SUCCESS_SOUND" ? @"success.wav" : 
                        param == "OPEN_SOUND" ? @"open.wav" : 
                        param == "WARNING_SOUND" ? @"warning.wav" : 
                        param == "ERROR_SOUND" ? @"error.wav" : null;
                    
                    player.Play();
                    player.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        /// <summary>
        /// It is the event that controls whether the download can be started.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion
    }
}
