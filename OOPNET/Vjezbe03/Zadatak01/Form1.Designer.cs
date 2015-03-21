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
            this.lbUIgri = new System.Windows.Forms.ListBox();
            this.lbNaKlupi = new System.Windows.Forms.ListBox();
            this.btnLijevoDesnoOdabrani = new System.Windows.Forms.Button();
            this.btnLijevoDesnoSve = new System.Windows.Forms.Button();
            this.btnDesnoLijevoOdabrani = new System.Windows.Forms.Button();
            this.btnDesnoLijevoSvi = new System.Windows.Forms.Button();
            this.cbSortiraj = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbUIgri
            // 
            this.lbUIgri.FormattingEnabled = true;
            this.lbUIgri.Location = new System.Drawing.Point(1, 12);
            this.lbUIgri.Name = "lbUIgri";
            this.lbUIgri.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbUIgri.Size = new System.Drawing.Size(104, 342);
            this.lbUIgri.TabIndex = 0;
            // 
            // lbNaKlupi
            // 
            this.lbNaKlupi.FormattingEnabled = true;
            this.lbNaKlupi.Location = new System.Drawing.Point(192, 12);
            this.lbNaKlupi.Name = "lbNaKlupi";
            this.lbNaKlupi.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNaKlupi.Size = new System.Drawing.Size(104, 342);
            this.lbNaKlupi.TabIndex = 1;
            // 
            // btnLijevoDesnoOdabrani
            // 
            this.btnLijevoDesnoOdabrani.Location = new System.Drawing.Point(111, 41);
            this.btnLijevoDesnoOdabrani.Name = "btnLijevoDesnoOdabrani";
            this.btnLijevoDesnoOdabrani.Size = new System.Drawing.Size(75, 23);
            this.btnLijevoDesnoOdabrani.TabIndex = 2;
            this.btnLijevoDesnoOdabrani.Text = ">";
            this.btnLijevoDesnoOdabrani.UseVisualStyleBackColor = true;
            this.btnLijevoDesnoOdabrani.Click += new System.EventHandler(this.btnLijevoDesnoOdabrani_Click);
            // 
            // btnLijevoDesnoSve
            // 
            this.btnLijevoDesnoSve.Location = new System.Drawing.Point(111, 12);
            this.btnLijevoDesnoSve.Name = "btnLijevoDesnoSve";
            this.btnLijevoDesnoSve.Size = new System.Drawing.Size(75, 23);
            this.btnLijevoDesnoSve.TabIndex = 3;
            this.btnLijevoDesnoSve.Text = ">>";
            this.btnLijevoDesnoSve.UseVisualStyleBackColor = true;
            this.btnLijevoDesnoSve.Click += new System.EventHandler(this.btnLijevoDesnoSve_Click);
            // 
            // btnDesnoLijevoOdabrani
            // 
            this.btnDesnoLijevoOdabrani.Location = new System.Drawing.Point(111, 295);
            this.btnDesnoLijevoOdabrani.Name = "btnDesnoLijevoOdabrani";
            this.btnDesnoLijevoOdabrani.Size = new System.Drawing.Size(75, 23);
            this.btnDesnoLijevoOdabrani.TabIndex = 4;
            this.btnDesnoLijevoOdabrani.Text = "<";
            this.btnDesnoLijevoOdabrani.UseVisualStyleBackColor = true;
            this.btnDesnoLijevoOdabrani.Click += new System.EventHandler(this.btnDesnoLijevoOdabrani_Click);
            // 
            // btnDesnoLijevoSvi
            // 
            this.btnDesnoLijevoSvi.Location = new System.Drawing.Point(111, 324);
            this.btnDesnoLijevoSvi.Name = "btnDesnoLijevoSvi";
            this.btnDesnoLijevoSvi.Size = new System.Drawing.Size(75, 23);
            this.btnDesnoLijevoSvi.TabIndex = 5;
            this.btnDesnoLijevoSvi.Text = "<<";
            this.btnDesnoLijevoSvi.UseVisualStyleBackColor = true;
            this.btnDesnoLijevoSvi.Click += new System.EventHandler(this.btnDesnoLijevoSvi_Click);
            // 
            // cbSortiraj
            // 
            this.cbSortiraj.AutoSize = true;
            this.cbSortiraj.Location = new System.Drawing.Point(128, 173);
            this.cbSortiraj.Name = "cbSortiraj";
            this.cbSortiraj.Size = new System.Drawing.Size(58, 17);
            this.cbSortiraj.TabIndex = 6;
            this.cbSortiraj.Text = "Sortiraj";
            this.cbSortiraj.UseVisualStyleBackColor = true;
            this.cbSortiraj.CheckedChanged += new System.EventHandler(this.cbSortiraj_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 359);
            this.Controls.Add(this.cbSortiraj);
            this.Controls.Add(this.btnDesnoLijevoSvi);
            this.Controls.Add(this.btnDesnoLijevoOdabrani);
            this.Controls.Add(this.btnLijevoDesnoSve);
            this.Controls.Add(this.btnLijevoDesnoOdabrani);
            this.Controls.Add(this.lbNaKlupi);
            this.Controls.Add(this.lbUIgri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUIgri;
        private System.Windows.Forms.ListBox lbNaKlupi;
        private System.Windows.Forms.Button btnLijevoDesnoOdabrani;
        private System.Windows.Forms.Button btnLijevoDesnoSve;
        private System.Windows.Forms.Button btnDesnoLijevoOdabrani;
        private System.Windows.Forms.Button btnDesnoLijevoSvi;
        private System.Windows.Forms.CheckBox cbSortiraj;
    }
}

