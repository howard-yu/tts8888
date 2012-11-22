namespace _188.tts8888.net
{
    partial class tts8888Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tts8888WebBrowser = new System.Windows.Forms.WebBrowser();
            this.timerone = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tts8888WebBrowser
            // 
            this.tts8888WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tts8888WebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.tts8888WebBrowser.Location = new System.Drawing.Point(0, 0);
            this.tts8888WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.tts8888WebBrowser.Name = "tts8888WebBrowser";
            this.tts8888WebBrowser.ScriptErrorsSuppressed = true;
            this.tts8888WebBrowser.Size = new System.Drawing.Size(1071, 570);
            this.tts8888WebBrowser.TabIndex = 1;
            this.tts8888WebBrowser.TabStop = false;
            this.tts8888WebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.tts8888WebBrowser.WebBrowserShortcutsEnabled = false;
            this.tts8888WebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.tts8888WebBrowser_DocumentCompleted);
            this.tts8888WebBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.tts8888WebBrowser_NewWindow);
            // 
            // tts8888Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 570);
            this.Controls.Add(this.tts8888WebBrowser);
            this.Name = "tts8888Form";
            this.ShowIcon = false;
            this.Text = "TTS8888";
            this.Load += new System.EventHandler(this.tts8888Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser tts8888WebBrowser;
        private System.Windows.Forms.Timer timerone;
    }
}

