using System;
using System.IO;
using System.Windows.Forms;

namespace PingTester
{
    static class Program
    {
        /* TODO:
         * add support to new file format (xml)
         * add  full support for telnet, ssh, remote desktop, vnc (icons and prebuilt passwords)
         * add log file to ping responses and state changes
         * add indication to name of opend file
         * add status bar indication how much online/offline
         * 
         * add support for rapid ping (lots of users sending ping at once)
         * add response time to stats (min, max, avg)
         */
        public const string LastPingerFileName = "pinger_history.txt";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {            
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                FrmMain main = new FrmMain();
                main.LastPingerFileName = Path.Combine(System.Environment.CurrentDirectory, Program.LastPingerFileName);

                if (Args.Length > 0)
                    main.StartupFileName = Args[0];
                else
                    main.StartupFileName = main.LastPingerFileName;

                Application.Run(main);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
