namespace Zadatak03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.udBroj = new System.Windows.Forms.NumericUpDown();
            this.btnPrekini = new System.Windows.Forms.Button();
            this.btnRacunaj = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.tajmer = new System.Windows.Forms.Timer(this.components);
            this.bwWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.udBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trenutno vrijeme: ";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(110, 9);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(10, 13);
            this.lblVrijeme.TabIndex = 1;
            this.lblVrijeme.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odaberite koliko brojeva zelite izacunati: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 216);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "--idle--";
            // 
            // udBroj
            // 
            this.udBroj.Location = new System.Drawing.Point(218, 44);
            this.udBroj.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.udBroj.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.udBroj.Name = "udBroj";
            this.udBroj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.udBroj.Size = new System.Drawing.Size(249, 20);
            this.udBroj.TabIndex = 4;
            this.udBroj.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // btnPrekini
            // 
            this.btnPrekini.Location = new System.Drawing.Point(307, 82);
            this.btnPrekini.Name = "btnPrekini";
            this.btnPrekini.Size = new System.Drawing.Size(160, 52);
            this.btnPrekini.TabIndex = 5;
            this.btnPrekini.Text = "Prekini";
            this.btnPrekini.UseVisualStyleBackColor = true;
            this.btnPrekini.Click += new System.EventHandler(this.btnPrekini_Click);
            // 
            // btnRacunaj
            // 
            this.btnRacunaj.Location = new System.Drawing.Point(15, 82);
            this.btnRacunaj.Name = "btnRacunaj";
            this.btnRacunaj.Size = new System.Drawing.Size(286, 52);
            this.btnRacunaj.TabIndex = 6;
            this.btnRacunaj.Text = "Izracunaj";
            this.btnRacunaj.UseVisualStyleBackColor = true;
            this.btnRacunaj.Click += new System.EventHandler(this.btnRacunaj_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(15, 140);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(452, 59);
            this.pbProgress.TabIndex = 7;
            // 
            // tajmer
            // 
            this.tajmer.Tick += new System.EventHandler(this.tajmer_Tick);
            // 
            // bwWorker
            // 
            this.bwWorker.WorkerReportsProgress = true;
            this.bwWorker.WorkerSupportsCancellation = true;
            this.bwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwWorker_DoWork);
            this.bwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwWorker_ProgressChanged);
            this.bwWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 238);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnRacunaj);
            this.Controls.Add(this.btnPrekini);
            this.Controls.Add(this.udBroj);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.udBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown udBroj;
        private System.Windows.Forms.Button btnPrekini;
        private System.Windows.Forms.Button btnRacunaj;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Timer tajmer;
        private System.ComponentModel.BackgroundWorker bwWorker;
    }
}

