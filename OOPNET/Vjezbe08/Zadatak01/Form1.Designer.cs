namespace Zadatak01
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
            this.udBroj = new System.Windows.Forms.NumericUpDown();
            this.btnRacunaj = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.tajmer = new System.Windows.Forms.Timer(this.components);
            this.bwWorker = new System.ComponentModel.BackgroundWorker();
            this.btnPrekini = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trenutno vrijeme: ";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(119, 24);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(10, 13);
            this.lblVrijeme.TabIndex = 1;
            this.lblVrijeme.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odaberite fibonaccijev broj koji zelite izracunati:";
            // 
            // udBroj
            // 
            this.udBroj.Location = new System.Drawing.Point(301, 60);
            this.udBroj.Name = "udBroj";
            this.udBroj.Size = new System.Drawing.Size(76, 20);
            this.udBroj.TabIndex = 3;
            // 
            // btnRacunaj
            // 
            this.btnRacunaj.Location = new System.Drawing.Point(24, 91);
            this.btnRacunaj.Name = "btnRacunaj";
            this.btnRacunaj.Size = new System.Drawing.Size(227, 71);
            this.btnRacunaj.TabIndex = 4;
            this.btnRacunaj.Text = "Izracunaj";
            this.btnRacunaj.UseVisualStyleBackColor = true;
            this.btnRacunaj.Click += new System.EventHandler(this.btnRacunaj_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(21, 177);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(35, 13);
            this.lblRezultat.TabIndex = 5;
            this.lblRezultat.Text = "--idle--";
            // 
            // tajmer
            // 
            this.tajmer.Tick += new System.EventHandler(this.tajmer_Tick);
            // 
            // bwWorker
            // 
            this.bwWorker.WorkerSupportsCancellation = true;
            this.bwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwWorker_DoWork);
            this.bwWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwWorker_RunWorkerCompleted);
            // 
            // btnPrekini
            // 
            this.btnPrekini.Location = new System.Drawing.Point(257, 91);
            this.btnPrekini.Name = "btnPrekini";
            this.btnPrekini.Size = new System.Drawing.Size(120, 71);
            this.btnPrekini.TabIndex = 6;
            this.btnPrekini.Text = "Prekini";
            this.btnPrekini.UseVisualStyleBackColor = true;
            this.btnPrekini.Click += new System.EventHandler(this.btnPrekini_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnPrekini);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnRacunaj);
            this.Controls.Add(this.udBroj);
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
        private System.Windows.Forms.NumericUpDown udBroj;
        private System.Windows.Forms.Button btnRacunaj;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Timer tajmer;
        private System.ComponentModel.BackgroundWorker bwWorker;
        private System.Windows.Forms.Button btnPrekini;
    }
}

