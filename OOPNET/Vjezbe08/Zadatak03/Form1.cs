using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tajmer.Start();
            btnPrekini.Enabled = false;
        }

        private void tajmer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            lblVrijeme.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void btnRacunaj_Click(object sender, EventArgs e)
        {
            btnPrekini.Enabled = true;
            btnRacunaj.Enabled = false;
            udBroj.Enabled = false;

            lblStatus.Text = "Racunam";

            int n = (int)udBroj.Value;

            bwWorker.RunWorkerAsync(n);
        }

        private void bwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int n = (int)e.Argument;

            long suma = 0;
            int percent = 0;
            int previousPercent = 0;

            for (int i = 1; i <= n; i++)
            {
                if (bwWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                percent = (int)((float)i / n * 100);

                if (percent != previousPercent)
                {
                    bwWorker.ReportProgress(percent);
                }
                previousPercent = percent;

                suma += i;
            }

            e.Result = suma;
        }

        private void bwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            udBroj.Enabled = true;
            btnPrekini.Enabled = false;
            btnRacunaj.Enabled = true;

            if (e.Cancelled)
            {
                lblStatus.Text = "Racunanje prekinuto";
            }
            else
            {
                lblStatus.Text = e.Result.ToString();
            }
        }

        private void btnPrekini_Click(object sender, EventArgs e)
        {
            bwWorker.CancelAsync();
        }

        private void bwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProgress.Value = e.ProgressPercentage;
        }
    }
}
