﻿using System;
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
         * issue 4: add indication to name of opend file
         * issue 5: add status bar indication how much online/offline
         * 
         * issue 6: add support for rapid ping (lots of users sending ping at once)
         * issue 7: add response time to stats (min, max, avg)
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
