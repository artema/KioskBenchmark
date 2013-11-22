using Gecko;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewBenchmark.FormsGeckoFx
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Xpcom.Initialize(ConfigurationManager.ConnectionStrings["XulRunner"].ConnectionString);

            var form = new Form();
            form.WindowState = FormWindowState.Normal;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;

            var browser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            browser.Navigate(ConfigurationManager.ConnectionStrings["HomeUrl"].ConnectionString);
            form.Controls.Add(browser);
            Application.Run(form);
        }
    }
}
