using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DataProvider;
using GrepEngine;

namespace GrepUI
{
    public partial class Form1 : Form
    {
        private readonly Downloader _downloader = new Downloader();
        private bool _isRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            IEnumerable<string> webResult;

            try
            {
                webResult = _downloader.DownloadWebpageAsText(httpAddressTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (backgroundWorker.CancellationPending)
                return;

            var grep = new Grep(webResult);
            e.Result = grep.GetLinesContainingSpecifiedToken(tokenTextBox.Text);
        }

        private void startCancelButton_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _downloader.CancelRequest();
                backgroundWorker.CancelAsync();
            }
            else
            {
                resultsListBox.Items.Clear();
                backgroundWorker.RunWorkerAsync();
                startCancelButton.Text = "Cancel";
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                foreach (var line in e.Result as IEnumerable<string>)
                {
                    var shortened = line.Substring(0, line.Length > 1000 ? 1000 : line.Length);
                    resultsListBox.Items.Add(shortened.Trim());
                }
            }

            startCancelButton.Text = "Start";
        }
    }
}
