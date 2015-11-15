namespace Vjezbe07
{
    partial class Popis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBolidi = new System.Windows.Forms.ListBox();
            this.cbVozac = new System.Windows.Forms.ComboBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vozač:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bolidi: ";
            // 
            // lbBolidi
            // 
            this.lbBolidi.FormattingEnabled = true;
            this.lbBolidi.Location = new System.Drawing.Point(51, 55);
            this.lbBolidi.Name = "lbBolidi";
            this.lbBolidi.Size = new System.Drawing.Size(293, 212);
            this.lbBolidi.TabIndex = 2;
            // 
            // cbVozac
            // 
            this.cbVozac.FormattingEnabled = true;
            this.cbVozac.Location = new System.Drawing.Point(51, 19);
            this.cbVozac.Name = "cbVozac";
            this.cbVozac.Size = new System.Drawing.Size(293, 21);
            this.cbVozac.TabIndex = 3;
            this.cbVozac.SelectedIndexChanged += new System.EventHandler(this.cbVozac_SelectedIndexChanged);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.BackColor = System.Drawing.Color.Red;
            this.btnSpremiPromjene.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpremiPromjene.Location = new System.Drawing.Point(51, 312);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(293, 34);
            this.btnSpremiPromjene.TabIndex = 4;
            this.btnSpremiPromjene.Text = "SPREMI PROMJENE NA BAZI";
            this.btnSpremiPromjene.UseVisualStyleBackColor = false;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(253, 283);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(91, 23);
            this.btnBrisi.TabIndex = 5;
            this.btnBrisi.Text = "BRISI";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(154, 283);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(93, 23);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "UREDI";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(51, 283);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(97, 23);
            this.btnNovi.TabIndex = 7;
            this.btnNovi.Text = "NOVI";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // Popis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 350);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.cbVozac);
            this.Controls.Add(this.lbBolidi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Popis";
            this.Text = "Popis vozaca i automobila";
            this.Load += new System.EventHandler(this.Popis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbBolidi;
        private System.Windows.Forms.ComboBox cbVozac;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
    }
}

