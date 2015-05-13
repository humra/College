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
            this.btnPrvi = new System.Windows.Forms.Button();
            this.btnCetvrti = new System.Windows.Forms.Button();
            this.btnDrugi = new System.Windows.Forms.Button();
            this.btnTreci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrvi
            // 
            this.btnPrvi.AllowDrop = true;
            this.btnPrvi.BackColor = System.Drawing.Color.Red;
            this.btnPrvi.Location = new System.Drawing.Point(12, 12);
            this.btnPrvi.Name = "btnPrvi";
            this.btnPrvi.Size = new System.Drawing.Size(100, 50);
            this.btnPrvi.TabIndex = 0;
            this.btnPrvi.Text = "Button 1";
            this.btnPrvi.UseVisualStyleBackColor = false;
            this.btnPrvi.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_DragDrop);
            this.btnPrvi.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_DragEnter);
            this.btnPrvi.DragLeave += new System.EventHandler(this.btn_DragLeave);
            this.btnPrvi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnCetvrti
            // 
            this.btnCetvrti.AllowDrop = true;
            this.btnCetvrti.Location = new System.Drawing.Point(664, 293);
            this.btnCetvrti.Name = "btnCetvrti";
            this.btnCetvrti.Size = new System.Drawing.Size(95, 53);
            this.btnCetvrti.TabIndex = 1;
            this.btnCetvrti.Text = "Button 4";
            this.btnCetvrti.UseVisualStyleBackColor = true;
            this.btnCetvrti.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_DragDrop);
            this.btnCetvrti.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_DragEnter);
            this.btnCetvrti.DragLeave += new System.EventHandler(this.btn_DragLeave);
            this.btnCetvrti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnDrugi
            // 
            this.btnDrugi.AllowDrop = true;
            this.btnDrugi.Location = new System.Drawing.Point(664, 0);
            this.btnDrugi.Name = "btnDrugi";
            this.btnDrugi.Size = new System.Drawing.Size(95, 62);
            this.btnDrugi.TabIndex = 2;
            this.btnDrugi.Text = "Button 2";
            this.btnDrugi.UseVisualStyleBackColor = true;
            this.btnDrugi.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_DragDrop);
            this.btnDrugi.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_DragEnter);
            this.btnDrugi.DragLeave += new System.EventHandler(this.btn_DragLeave);
            this.btnDrugi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnTreci
            // 
            this.btnTreci.AllowDrop = true;
            this.btnTreci.Location = new System.Drawing.Point(12, 293);
            this.btnTreci.Name = "btnTreci";
            this.btnTreci.Size = new System.Drawing.Size(100, 53);
            this.btnTreci.TabIndex = 3;
            this.btnTreci.Text = "Button 3";
            this.btnTreci.UseVisualStyleBackColor = true;
            this.btnTreci.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn_DragDrop);
            this.btnTreci.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn_DragEnter);
            this.btnTreci.DragLeave += new System.EventHandler(this.btn_DragLeave);
            this.btnTreci.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTreci);
            this.Controls.Add(this.btnDrugi);
            this.Controls.Add(this.btnCetvrti);
            this.Controls.Add(this.btnPrvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrvi;
        private System.Windows.Forms.Button btnCetvrti;
        private System.Windows.Forms.Button btnDrugi;
        private System.Windows.Forms.Button btnTreci;
        private System.Windows.Forms.Label label1;
    }
}

