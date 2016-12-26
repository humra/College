namespace FarmaKrava
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
            this.lbKrave = new System.Windows.Forms.ListBox();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKrave
            // 
            this.lbKrave.FormattingEnabled = true;
            this.lbKrave.Location = new System.Drawing.Point(12, 12);
            this.lbKrave.Name = "lbKrave";
            this.lbKrave.Size = new System.Drawing.Size(280, 199);
            this.lbKrave.TabIndex = 0;
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(12, 217);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(280, 54);
            this.btnIzmjena.TabIndex = 1;
            this.btnIzmjena.Text = "IZMJENA ODABRANE KRAVE";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 320);
            this.Controls.Add(this.btnIzmjena);
            this.Controls.Add(this.lbKrave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKrave;
        private System.Windows.Forms.Button btnIzmjena;
    }
}

