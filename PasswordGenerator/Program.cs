using System;
using System.Threading;
using System.Windows.Forms;

namespace PasswordGenerator
{
    static class Program
    {
        private static readonly Mutex mutex = new(true, "548336c8-42cd-4720-8c4d-d4db04a60627");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmPasswordGenerator());
                mutex.ReleaseMutex();
            }
        }
    }
}