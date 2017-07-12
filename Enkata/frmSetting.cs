using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Enkata
{
    public partial class frmSetting : Form
    {        
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            string regPath = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
            string regName = Application.ProductName;
            if (Registry.GetValue(regPath, regName, null) == null) {
                chkStartUp.Checked = false;
            } else {
                chkStartUp.Checked = true;
            }
        }

        private void chkStartUp_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (chkStartUp.Checked) {
                rk.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
            } else {
                rk.DeleteValue(Application.ProductName, false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
