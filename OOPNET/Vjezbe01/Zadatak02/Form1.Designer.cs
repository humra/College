namespace Zadatak02
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
            this.btnNovaFormaFix = new System.Windows.Forms.Button();
            this.btnNovaFormaCrvena = new System.Windows.Forms.Button();
            this.btnNovaFormaNoCtrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaFormaFix
            // 
            this.btnNovaFormaFix.Location = new System.Drawing.Point(12, 12);
            this.btnNovaFormaFix.Name = "btnNovaFormaFix";
            this.btnNovaFormaFix.Size = new System.Drawing.Size(75, 23);
            this.btnNovaFormaFix.TabIndex = 0;
            this.btnNovaFormaFix.Text = "Nova forma";
            this.btnNovaFormaFix.UseVisualStyleBackColor = true;
            this.btnNovaFormaFix.Click += new System.EventHandler(this.btnNovaFormaFix_Click);
            // 
            // btnNovaFormaCrvena
            // 
            this.btnNovaFormaCrvena.Location = new System.Drawing.Point(12, 65);
            this.btnNovaFormaCrvena.Name = "btnNovaFormaCrvena";
            this.btnNovaFormaCrvena.Size = new System.Drawing.Size(109, 23);
            this.btnNovaFormaCrvena.TabIndex = 1;
            this.btnNovaFormaCrvena.Text = "Nova crvena forma";
            this.btnNovaFormaCrvena.UseVisualStyleBackColor = true;
            this.btnNovaFormaCrvena.Click += new System.EventHandler(this.btnNovaFormaCrvena_Click);
            // 
            // btnNovaFormaNoCtrl
            // 
            this.btnNovaFormaNoCtrl.Location = new System.Drawing.Point(12, 114);
            this.btnNovaFormaNoCtrl.Name = "btnNovaFormaNoCtrl";
            this.btnNovaFormaNoCtrl.Size = new System.Drawing.Size(109, 23);
            this.btnNovaFormaNoCtrl.TabIndex = 2;
            this.btnNovaFormaNoCtrl.Text = "Nova bez kontrola";
            this.btnNovaFormaNoCtrl.UseVisualStyleBackColor = true;
            this.btnNovaFormaNoCtrl.Click += new System.EventHandler(this.btnNovaFormaNoCtrl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 348);
            this.Controls.Add(this.btnNovaFormaNoCtrl);
            this.Controls.Add(this.btnNovaFormaCrvena);
            this.Controls.Add(this.btnNovaFormaFix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaFormaFix;
        private System.Windows.Forms.Button btnNovaFormaCrvena;
        private System.Windows.Forms.Button btnNovaFormaNoCtrl;
    }
}

