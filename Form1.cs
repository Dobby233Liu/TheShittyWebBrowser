using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheShittyWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        
        private void webBrowser1_NewWindow2(object sender, WebBrowserNewWindow2EventArgs e)
        {
        if (System.Globalization.CultureInfo.InstalledUICulture.NativeName = "中文(中华人民共和国)")
        {
        this.close();
        fm=new webBrowserzh()
        fm.Show();
        }
        }
        private void webBrowserzh_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        
        
    }
}
