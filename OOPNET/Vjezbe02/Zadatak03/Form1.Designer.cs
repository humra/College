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
            this.btnBoja = new System.Windows.Forms.Button();
            this.btnStanje = new System.Windows.Forms.Button();
            this.btnGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoja
            // 
            this.btnBoja.Location = new System.Drawing.Point(12, 12);
            this.btnBoja.Name = "btnBoja";
            this.btnBoja.Size = new System.Drawing.Size(148, 23);
            this.btnBoja.TabIndex = 0;
            this.btnBoja.Text = "Promijeni boju";
            this.btnBoja.UseVisualStyleBackColor = true;
            this.btnBoja.Click += new System.EventHandler(this.btnBoja_Click);
            // 
            // btnStanje
            // 
            this.btnStanje.Location = new System.Drawing.Point(12, 41);
            this.btnStanje.Name = "btnStanje";
            this.btnStanje.Size = new System.Drawing.Size(148, 23);
            this.btnStanje.TabIndex = 1;
            this.btnStanje.Text = "Promijeni stanje";
            this.btnStanje.UseVisualStyleBackColor = true;
            this.btnStanje.Click += new System.EventHandler(this.btnStanje_Click);
            // 
            // btnGumb
            // 
            this.btnGumb.Location = new System.Drawing.Point(12, 70);
            this.btnGumb.Name = "btnGumb";
            this.btnGumb.Size = new System.Drawing.Size(148, 23);
            this.btnGumb.TabIndex = 2;
            this.btnGumb.Text = "Dodaj gumb";
            this.btnGumb.UseVisualStyleBackColor = true;
            this.btnGumb.Click += new System.EventHandler(this.btnGumb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 125);
            this.Controls.Add(this.btnGumb);
            this.Controls.Add(this.btnStanje);
            this.Controls.Add(this.btnBoja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoja;
        private System.Windows.Forms.Button btnStanje;
        private System.Windows.Forms.Button btnGumb;
    }
}

