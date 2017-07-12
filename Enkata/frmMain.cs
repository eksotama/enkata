using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using Microsoft.Win32;

namespace Enkata
{   
    public partial class frmMain : Form
    {
        bool Terminating = false;
        public string cacheDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Enkata";

        public string urlGmail = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
        public string urlTelegram = "https://web.telegram.org/";
        public string urlWhatsApp = "https://web.whatsapp.com/";
        public string urlWire = "https://app.wire.com/";
        public string urlOutlook = "https://outlook.live.com/owa/";
        public string urlFbMessenger = "https://www.messenger.com/login/";

        public frmMain()
        {
            InitializeComponent();
            InitializeChromium();
        }
        
        private void InitializeChromium()
        {
            bool isNetworkAvailable = IsInternetAvailable();
            if(!isNetworkAvailable) {
                showPanel(Panel503);
                messagingToolStripMenuItem.Enabled = false;
            } else {
                // Cache Directory
                if (!Directory.Exists(cacheDir)) {
                    Directory.CreateDirectory(cacheDir);
                }

                // CEF Settings
                CefSettings Settings = new CefSettings();
                Settings.CefCommandLineArgs.Add("enable-media-stream", "1");
                Settings.CachePath = cacheDir;
                Cef.Initialize(Settings);

                // Telegram
                var cTelegram = new ChromiumWebBrowser(urlTelegram);
                PanelTelegram.Controls.Add(cTelegram);

                // WhatsApp
                var cWhatsApp = new ChromiumWebBrowser(urlWhatsApp);
                PanelWhatsApp.Controls.Add(cWhatsApp);

                // Wire
                var cWire = new ChromiumWebBrowser(urlWire);
                PanelWire.Controls.Add(cWire);

                // FB Messenger
                var cFbMessenger = new ChromiumWebBrowser(urlFbMessenger);
                PanelFbMessenger.Controls.Add(cFbMessenger);

                // Gmail
                var cGmail = new ChromiumWebBrowser(urlGmail);
                PanelGmail.Controls.Add(cGmail);

                showPanel(PanelWhatsApp);
            }
        }

        protected bool IsInternetAvailable()
        {
            System.Net.WebClient workstation = new System.Net.WebClient();
            byte[] data = null;

            try
            {
                data = workstation.DownloadData("http://www.bing.com");
                if (data != null && data.Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

        private void showPanel(Panel panelName)
        {
            foreach (var control in Controls) {
                if (control is Panel)
                    ((Panel)control).Visible = false;
            }
            panelName.Visible = true;
            panelName.Dock = DockStyle.Fill;
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Tray Icon and Form Control
            this.contextMenuStrip1.Items.Clear();
            this.contextMenuStrip1.Items.Add("&Restore");
            this.contextMenuStrip1.Items.Add("-");
            this.contextMenuStrip1.Items.Add("E&xit");
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(688,487); // 480,560 or 688,487
            this.Size = new Size(960,690);

            // Check Auto Running
            string regPath = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
            string regName = Application.ProductName;
            if (Registry.GetValue(regPath, regName, null) == null) {
                settingsToolStripMenuItem.Checked = false;
            } else {
                settingsToolStripMenuItem.Checked = true;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Terminating) {
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing && MessageBox.Show("Are you sure you want exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel) {
                e.Cancel = true;
            }
            
            if (!e.Cancel) {
                e.Cancel = true;
                this.notifyIcon1.Dispose();
                Terminating = true;
                this.timer1.Interval = 100;
                this.timer1.Enabled = true;
                this.timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            Cef.Shutdown();
            Application.Exit();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "&Restore") {
                Show();
                WindowState = FormWindowState.Normal;
                return;
            } else if (e.ClickedItem.Text == "E&xit") {
                this.Close();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(cacheDir)) {
                if (MessageBox.Show("Do you want to clear all data?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                    //Directory.Delete(cacheDir, true);
                    MessageBox.Show("Future feature!", "FYI:");
                }
            }
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(PanelTelegram);
            
        }

        private void whatsAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(PanelWhatsApp);
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(PanelGmail);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cb = new ChromiumWebBrowser(urlTelegram);
            cb.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wireWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(PanelWire);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fd = new frmAbout();
            fd.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSetting fd = new frmSetting();
            //fd.ShowDialog();
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (settingsToolStripMenuItem.Checked)
            {
                rk.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
            } else {
                rk.DeleteValue(Application.ProductName, false);
            }
        }

        private void fBMessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(PanelFbMessenger);
        }
    }
}
