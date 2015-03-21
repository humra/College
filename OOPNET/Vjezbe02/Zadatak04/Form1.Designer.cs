namespace Zadatak04
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
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.txtbxTekst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(140, 12);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(122, 23);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            this.btnBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBlue_MouseClick);
            this.btnBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBlue_MouseDown);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(12, 12);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(122, 23);
            this.btnRed.TabIndex = 3;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            this.btnRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRed_MouseClick);
            this.btnRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRed_MouseDown);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(268, 12);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(122, 23);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            this.btnGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGreen_MouseClick);
            this.btnGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGreen_MouseDown);
            // 
            // txtbxTekst
            // 
            this.txtbxTekst.Location = new System.Drawing.Point(12, 41);
            this.txtbxTekst.Name = "txtbxTekst";
            this.txtbxTekst.Size = new System.Drawing.Size(378, 20);
            this.txtbxTekst.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 349);
            this.Controls.Add(this.txtbxTekst);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.TextBox txtbxTekst;
    }
}

