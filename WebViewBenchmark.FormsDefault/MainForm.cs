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

namespace WebViewBenchmark.FormsDefault
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            webView.Url = new Uri(ConfigurationManager.ConnectionStrings["HomeUrl"].ConnectionString);
        }
    }
}
