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
using Xilium.CefGlue;

namespace WebViewBenchmark.WpfXiliumCefGlue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CefRuntime.Load();

            var settings = new CefSettings();
            settings.MultiThreadedMessageLoop = true;
            settings.ReleaseDCheckEnabled = true;
            settings.LogSeverity = CefLogSeverity.Verbose;
            settings.LogFile = "cef.log";
            settings.ResourcesDirPath = System.IO.Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetEntryAssembly().CodeBase).LocalPath);

            CefRuntime.Initialize(new CefMainArgs(new string[0]), settings, null);

            InitializeComponent();

            webView.NavigateTo(ConfigurationManager.ConnectionStrings["HomeUrl"].ConnectionString);
        }
    }
}
