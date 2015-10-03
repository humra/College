using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrikaziVrijeme();
            tajmer.Start();
            btnPrekini.Enabled = false;
        }

        private void PrikaziVrijeme()
        {
            lblVrijeme.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void tajmer_Tick(object sender, EventArgs e)
        {
            PrikaziVrijeme();
        }

        private void btnRacunaj_Click(object sender, EventArgs e)
        {
            int n = (int)udBroj.Value;


            lblRezultat.Text = "Racunam...";
            udBroj.Enabled = false;
            btnRacunaj.Enabled = false;
            btnPrekini.Enabled = true;

            bwWorker.RunWorkerAsync(n);
        }

        private void bwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int n = (int)e.Argument;

            e.Result = Fib(n);

            if (bwWorker.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private int Fib(int n)
        {
            if (n <= 1 || bwWorker.CancellationPending)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        private void bwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            udBroj.Enabled = true;
            btnRacunaj.Enabled = true;

            if (e.Cancelled)
            {
                lblRezultat.Text = "Prekinuto";
            }
            else
            {
                lblRezultat.Text = e.Result.ToString();
            }
        }

        private void btnPrekini_Click(object sender, EventArgs e)
        {
            bwWorker.CancelAsync();
            
            btnRacunaj.Enabled = true;
            udBroj.Enabled = true;
            btnPrekini.Enabled = false;
        }
    }
}
