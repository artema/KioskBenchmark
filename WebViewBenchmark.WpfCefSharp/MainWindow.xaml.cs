using CefSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebViewBenchmark.WpfCefSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var cefSettings = new Settings();
            cefSettings.LogFile = @"./cef_log.txt";
            cefSettings.LogSeverity = LogSeverity.Info;

            do
            {
                CEF.Initialize(cefSettings);
            }
            while (!CEF.IsInitialized);


            InitializeComponent();

            webView.Address = ConfigurationManager.ConnectionStrings["HomeUrl"].ConnectionString;
        }

        protected override void OnClosed(EventArgs e)
        {
            CEF.Shutdown();

            base.OnClosed(e);
        }
    }
}
