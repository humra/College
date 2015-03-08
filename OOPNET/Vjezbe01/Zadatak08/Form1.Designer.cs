namespace Zadatak08
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
            this.btnNovaForma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaForma
            // 
            this.btnNovaForma.Location = new System.Drawing.Point(69, 78);
            this.btnNovaForma.Name = "btnNovaForma";
            this.btnNovaForma.Size = new System.Drawing.Size(75, 23);
            this.btnNovaForma.TabIndex = 0;
            this.btnNovaForma.Text = "Nova forma";
            this.btnNovaForma.UseVisualStyleBackColor = true;
            this.btnNovaForma.Click += new System.EventHandler(this.btnNovaForma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 219);
            this.Controls.Add(this.btnNovaForma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaForma;
    }
}

