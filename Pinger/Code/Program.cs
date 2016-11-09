using System;
using System.IO;
using System.Windows.Forms;

namespace PingTester
{
    static class Program
    {
        /* TODO:
         * issue 1: add support to new file format (xml)
         * issue 2: add  full support for telnet, ssh, remote desktop, vnc (icons and prebuilt passwords)
         * issue 3: add log file to ping responses and state changes
         * issue 4: add status bar indication how much online/offline

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
                var culture = System.Configuration.ConfigurationManager.AppSettings["Globalization.CultureInfo"];
                if (!string.IsNullOrWhiteSpace(culture))
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
                
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
