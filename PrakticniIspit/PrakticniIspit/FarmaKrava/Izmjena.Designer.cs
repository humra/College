namespace FarmaKrava
{
    partial class Izmjena
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.ddlPasmina = new System.Windows.Forms.ComboBox();
            this.dateDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtJVB = new System.Windows.Forms.TextBox();
            this.numBrojTeladi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojTeladi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pasmina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "JVB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Broj teladi: ";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 190);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(114, 36);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(158, 190);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(114, 36);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(121, 9);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(151, 20);
            this.txtIme.TabIndex = 8;
            // 
            // ddlPasmina
            // 
            this.ddlPasmina.FormattingEnabled = true;
            this.ddlPasmina.Location = new System.Drawing.Point(121, 35);
            this.ddlPasmina.Name = "ddlPasmina";
            this.ddlPasmina.Size = new System.Drawing.Size(151, 21);
            this.ddlPasmina.TabIndex = 9;
            // 
            // dateDatumRodjenja
            // 
            this.dateDatumRodjenja.Location = new System.Drawing.Point(121, 65);
            this.dateDatumRodjenja.Name = "dateDatumRodjenja";
            this.dateDatumRodjenja.Size = new System.Drawing.Size(151, 20);
            this.dateDatumRodjenja.TabIndex = 10;
            // 
            // txtJVB
            // 
            this.txtJVB.Location = new System.Drawing.Point(121, 93);
            this.txtJVB.Name = "txtJVB";
            this.txtJVB.Size = new System.Drawing.Size(151, 20);
            this.txtJVB.TabIndex = 11;
            // 
            // numBrojTeladi
            // 
            this.numBrojTeladi.Location = new System.Drawing.Point(121, 123);
            this.numBrojTeladi.Name = "numBrojTeladi";
            this.numBrojTeladi.Size = new System.Drawing.Size(151, 20);
            this.numBrojTeladi.TabIndex = 13;
            // 
            // Izmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.numBrojTeladi);
            this.Controls.Add(this.txtJVB);
            this.Controls.Add(this.dateDatumRodjenja);
            this.Controls.Add(this.ddlPasmina);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Izmjena";
            this.Text = "Izmjena";
            this.Load += new System.EventHandler(this.Izmjena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBrojTeladi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ComboBox ddlPasmina;
        private System.Windows.Forms.DateTimePicker dateDatumRodjenja;
        private System.Windows.Forms.TextBox txtJVB;
        private System.Windows.Forms.NumericUpDown numBrojTeladi;
    }
}