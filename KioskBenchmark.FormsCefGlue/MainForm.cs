using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefGlue;
using CefGlue.Windows.Forms;
using System.Configuration;

namespace KioskBenchmark.FormsCefGlue
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
            var settings = new CefBrowserSettings();
            webView = new CefWebBrowser(settings, ConfigurationManager.ConnectionStrings["HomeUrl"].ConnectionString);
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);
        }
    }
}
