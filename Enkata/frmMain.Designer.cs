namespace Enkata
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yahooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yandexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outlookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fBMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socialMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelWhatsApp = new System.Windows.Forms.Panel();
            this.PanelTelegram = new System.Windows.Forms.Panel();
            this.PanelWire = new System.Windows.Forms.Panel();
            this.PanelGmail = new System.Windows.Forms.Panel();
            this.PanelFbMessenger = new System.Windows.Forms.Panel();
            this.Panel503 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 10);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 6);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Enkata";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.messagingToolStripMenuItem,
            this.socialMediaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.clearDataToolStripMenuItem,
            this.toolStripMenuItem2,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "&Application";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.clearDataToolStripMenuItem.Text = "&Clear Data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Checked = true;
            this.settingsToolStripMenuItem.CheckOnClick = true;
            this.settingsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.settingsToolStripMenuItem.Text = "Run on Startup";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gmailToolStripMenuItem,
            this.yahooToolStripMenuItem,
            this.yandexToolStripMenuItem,
            this.outlookToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.emailToolStripMenuItem.Text = "&Email";
            this.emailToolStripMenuItem.Visible = false;
            // 
            // gmailToolStripMenuItem
            // 
            this.gmailToolStripMenuItem.Name = "gmailToolStripMenuItem";
            this.gmailToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gmailToolStripMenuItem.Text = "Gmail";
            this.gmailToolStripMenuItem.Click += new System.EventHandler(this.gmailToolStripMenuItem_Click);
            // 
            // yahooToolStripMenuItem
            // 
            this.yahooToolStripMenuItem.Name = "yahooToolStripMenuItem";
            this.yahooToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.yahooToolStripMenuItem.Text = "Yahoo";
            // 
            // yandexToolStripMenuItem
            // 
            this.yandexToolStripMenuItem.Name = "yandexToolStripMenuItem";
            this.yandexToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.yandexToolStripMenuItem.Text = "Yandex";
            // 
            // outlookToolStripMenuItem
            // 
            this.outlookToolStripMenuItem.Name = "outlookToolStripMenuItem";
            this.outlookToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.outlookToolStripMenuItem.Text = "Outlook";
            // 
            // messagingToolStripMenuItem
            // 
            this.messagingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telegramToolStripMenuItem,
            this.whatsAppToolStripMenuItem,
            this.wireWebToolStripMenuItem,
            this.fBMessengerToolStripMenuItem});
            this.messagingToolStripMenuItem.Name = "messagingToolStripMenuItem";
            this.messagingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.messagingToolStripMenuItem.Text = "&Messaging";
            // 
            // telegramToolStripMenuItem
            // 
            this.telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            this.telegramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.telegramToolStripMenuItem.Text = "Telegram";
            this.telegramToolStripMenuItem.Click += new System.EventHandler(this.telegramToolStripMenuItem_Click);
            // 
            // whatsAppToolStripMenuItem
            // 
            this.whatsAppToolStripMenuItem.Name = "whatsAppToolStripMenuItem";
            this.whatsAppToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.whatsAppToolStripMenuItem.Text = "WhatsApp";
            this.whatsAppToolStripMenuItem.Click += new System.EventHandler(this.whatsAppToolStripMenuItem_Click);
            // 
            // wireWebToolStripMenuItem
            // 
            this.wireWebToolStripMenuItem.Name = "wireWebToolStripMenuItem";
            this.wireWebToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wireWebToolStripMenuItem.Text = "Wire Chat";
            this.wireWebToolStripMenuItem.Click += new System.EventHandler(this.wireWebToolStripMenuItem_Click);
            // 
            // fBMessengerToolStripMenuItem
            // 
            this.fBMessengerToolStripMenuItem.Name = "fBMessengerToolStripMenuItem";
            this.fBMessengerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fBMessengerToolStripMenuItem.Text = "FB Messenger";
            this.fBMessengerToolStripMenuItem.Click += new System.EventHandler(this.fBMessengerToolStripMenuItem_Click);
            // 
            // socialMediaToolStripMenuItem
            // 
            this.socialMediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitterToolStripMenuItem,
            this.instagramToolStripMenuItem,
            this.facebookToolStripMenuItem});
            this.socialMediaToolStripMenuItem.Name = "socialMediaToolStripMenuItem";
            this.socialMediaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.socialMediaToolStripMenuItem.Text = "&Social Media";
            this.socialMediaToolStripMenuItem.Visible = false;
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            // 
            // instagramToolStripMenuItem
            // 
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.instagramToolStripMenuItem.Text = "Instagram";
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.facebookToolStripMenuItem.Text = "Facebook";
            // 
            // PanelWhatsApp
            // 
            this.PanelWhatsApp.Location = new System.Drawing.Point(280, 33);
            this.PanelWhatsApp.Name = "PanelWhatsApp";
            this.PanelWhatsApp.Size = new System.Drawing.Size(128, 80);
            this.PanelWhatsApp.TabIndex = 5;
            // 
            // PanelTelegram
            // 
            this.PanelTelegram.Location = new System.Drawing.Point(146, 33);
            this.PanelTelegram.Name = "PanelTelegram";
            this.PanelTelegram.Size = new System.Drawing.Size(128, 80);
            this.PanelTelegram.TabIndex = 6;
            // 
            // PanelWire
            // 
            this.PanelWire.Location = new System.Drawing.Point(12, 119);
            this.PanelWire.Name = "PanelWire";
            this.PanelWire.Size = new System.Drawing.Size(128, 80);
            this.PanelWire.TabIndex = 7;
            // 
            // PanelGmail
            // 
            this.PanelGmail.Location = new System.Drawing.Point(280, 119);
            this.PanelGmail.Name = "PanelGmail";
            this.PanelGmail.Size = new System.Drawing.Size(128, 80);
            this.PanelGmail.TabIndex = 8;
            // 
            // PanelFbMessenger
            // 
            this.PanelFbMessenger.Location = new System.Drawing.Point(146, 119);
            this.PanelFbMessenger.Name = "PanelFbMessenger";
            this.PanelFbMessenger.Size = new System.Drawing.Size(128, 80);
            this.PanelFbMessenger.TabIndex = 9;
            // 
            // Panel503
            // 
            this.Panel503.BackColor = System.Drawing.Color.Black;
            this.Panel503.BackgroundImage = global::Enkata.Properties.Resources.Disconnect;
            this.Panel503.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel503.Location = new System.Drawing.Point(12, 33);
            this.Panel503.Name = "Panel503";
            this.Panel503.Size = new System.Drawing.Size(128, 80);
            this.Panel503.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 381);
            this.Controls.Add(this.Panel503);
            this.Controls.Add(this.PanelFbMessenger);
            this.Controls.Add(this.PanelGmail);
            this.Controls.Add(this.PanelWire);
            this.Controls.Add(this.PanelTelegram);
            this.Controls.Add(this.PanelWhatsApp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Enkata - Multiple Instant Messaging In One Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socialMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yahooToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yandexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outlookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.Panel PanelWhatsApp;
        private System.Windows.Forms.Panel PanelTelegram;
        private System.Windows.Forms.Panel PanelWire;
        private System.Windows.Forms.Panel PanelGmail;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel PanelFbMessenger;
        private System.Windows.Forms.ToolStripMenuItem fBMessengerToolStripMenuItem;
        private System.Windows.Forms.Panel Panel503;
    }
}

