using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Enkata
{
    static class Program
    {
        // Single Instance
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true)) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
                mutex.ReleaseMutex();
            } else {
                MessageBox.Show("Another Enkata is already running!", "Warning");
            }
        }
    }
}
