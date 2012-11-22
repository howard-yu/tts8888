using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using IniParser;

namespace _188.tts8888.net
{
    public partial class tts8888Form : Form
    {
        public tts8888Form()
        {
            InitializeComponent();
        }
        private static string URL = "http://173.192.127.5:5021/company/tw/login.asp";
        private void tts8888Form_Load(object sender, EventArgs e)
        {
            this.tts8888WebBrowser.Url = new System.Uri(URL, System.UriKind.Absolute);
        }

        private void tts8888WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (tts8888WebBrowser.ReadyState == WebBrowserReadyState.Complete)return;

            FileIniDataParser parser = new FileIniDataParser();
            IniData parserData = parser.LoadFile("C:/test.ini");

            KeyDataCollection Keycol = parserData["Info"];
            string iniUsername = Keycol["user"];
            string iniPassWord = Keycol["pass"];

            HtmlWindow windows = tts8888WebBrowser.Document.Window;
            var inputTagName = windows.Document.GetElementsByTagName("input");
            if (inputTagName.Count == 3) {
                if (inputTagName[0] == null || inputTagName[1] == null || inputTagName[2] == null) {
                    return;
                } else {
                    inputTagName[0].SetAttribute("value", iniUsername);
                    inputTagName[2].SetAttribute("value", iniPassWord);
                    inputTagName[1].InvokeMember("click");
                }
            }
        }

        private void tts8888WebBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}  

  