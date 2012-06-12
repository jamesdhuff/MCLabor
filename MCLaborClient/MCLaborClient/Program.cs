using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace MCLaborClient
{
    static class Program
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            logger.Info(Environment.NewLine + Environment.NewLine + "::MCLabor Client Started");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
