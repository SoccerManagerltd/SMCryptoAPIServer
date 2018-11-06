using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace SMCryptoAPIServer
{
    static class Program
    {
        public static void startListening()
        {
            SMCrypto.StartListening();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread listenThread = new Thread(new ThreadStart(startListening));
            listenThread.Start();
            ///Application.EnableVisualStyles();
            ///Application.SetCompatibleTextRenderingDefault(false);
            ///Application.Run(new Server());

        }
    }
}
