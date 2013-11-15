using CefSharp;
using CefSharp.WinForms;
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

namespace KioskBenchmark.FormsCefSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private WebView webView;

        private void Form_Load(object sender, EventArgs e)
        {
            webView = new WebView(ConfigurationManager.ConnectionStrings["HomeUrl"].ConnectionString, new BrowserSettings());
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);
        }
    }
}
