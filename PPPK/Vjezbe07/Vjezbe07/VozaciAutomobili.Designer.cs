namespace Vjezbe07
{
    partial class VozaciAutomobili
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
            this.cbVozaci = new System.Windows.Forms.ComboBox();
            this.lbBolidi = new System.Windows.Forms.ListBox();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bolidi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vozac";
            // 
            // cbVozaci
            // 
            this.cbVozaci.FormattingEnabled = true;
            this.cbVozaci.Location = new System.Drawing.Point(56, 29);
            this.cbVozaci.Name = "cbVozaci";
            this.cbVozaci.Size = new System.Drawing.Size(237, 21);
            this.cbVozaci.TabIndex = 2;
            this.cbVozaci.SelectedIndexChanged += new System.EventHandler(this.cbVozaci_SelectedIndexChanged);
            // 
            // lbBolidi
            // 
            this.lbBolidi.FormattingEnabled = true;
            this.lbBolidi.Location = new System.Drawing.Point(56, 74);
            this.lbBolidi.Name = "lbBolidi";
            this.lbBolidi.Size = new System.Drawing.Size(237, 160);
            this.lbBolidi.TabIndex = 3;
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(56, 243);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(75, 27);
            this.btnNovi.TabIndex = 4;
            this.btnNovi.Text = "NOVI";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(137, 243);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 27);
            this.btnUredi.TabIndex = 5;
            this.btnUredi.Text = "UREDI";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(218, 243);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 27);
            this.btnBrisi.TabIndex = 6;
            this.btnBrisi.Text = "BRISI";
            this.btnBrisi.UseVisualStyleBackColor = true;
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.BackColor = System.Drawing.Color.Red;
            this.btnSpremiPromjene.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpremiPromjene.Location = new System.Drawing.Point(56, 276);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(237, 44);
            this.btnSpremiPromjene.TabIndex = 7;
            this.btnSpremiPromjene.Text = "SPREMI PROMJENE NA BAZI";
            this.btnSpremiPromjene.UseVisualStyleBackColor = false;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // VozaciAutomobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 332);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.lbBolidi);
            this.Controls.Add(this.cbVozaci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VozaciAutomobili";
            this.Text = "Popis vozaca i automobila";
            this.Load += new System.EventHandler(this.VozaciAutomobili_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVozaci;
        private System.Windows.Forms.ListBox lbBolidi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnSpremiPromjene;
    }
}

