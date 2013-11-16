using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xilium.CefGlue;
using Xilium.CefGlue.WindowsForms;

namespace KioskBenchmark.FormsXiliumCefGlue
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private CefWebBrowser webView;

        private void Form_Load(object sender, EventArgs e)
        {
            CefRuntime.Load();

            var settings = new CefSettings();
            settings.MultiThreadedMessageLoop = true;
            settings.ReleaseDCheckEnabled = true;
            settings.SingleProcess = true;
            settings.LogSeverity = CefLogSeverity.Warning;
            settings.LogFile = "cef.log";
            settings.ResourcesDirPath = System.IO.Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetEntryAssembly().CodeBase).LocalPath);

            CefRuntime.Initialize(new CefMainArgs(new string[0]), settings, null);

            webView = new CefWebBrowser {
                StartUrl = ConfigurationManager.ConnectionStrings["HomeUrl"].ConnectionString                
            };
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);
        }
    }
}
