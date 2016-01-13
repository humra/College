namespace Vjezbe10
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
            this.lbDrzave = new System.Windows.Forms.ListBox();
            this.lbGrad = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.btnBrisiGrad = new System.Windows.Forms.Button();
            this.btnBrisiDrzavu = new System.Windows.Forms.Button();
            this.btnDrzavaUredi = new System.Windows.Forms.Button();
            this.btnDodajGrad = new System.Windows.Forms.Button();
            this.btnUrediGrad = new System.Windows.Forms.Button();
            this.btnDrzavaDodaj = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDrzave
            // 
            this.lbDrzave.FormattingEnabled = true;
            this.lbDrzave.Location = new System.Drawing.Point(12, 12);
            this.lbDrzave.Name = "lbDrzave";
            this.lbDrzave.Size = new System.Drawing.Size(168, 186);
            this.lbDrzave.TabIndex = 0;
            this.lbDrzave.SelectedIndexChanged += new System.EventHandler(this.lbDrzave_SelectedIndexChanged);
            // 
            // lbGrad
            // 
            this.lbGrad.FormattingEnabled = true;
            this.lbGrad.Location = new System.Drawing.Point(186, 12);
            this.lbGrad.Name = "lbGrad";
            this.lbGrad.Size = new System.Drawing.Size(179, 186);
            this.lbGrad.TabIndex = 1;
            this.lbGrad.SelectedIndexChanged += new System.EventHandler(this.lbGrad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drzava:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grad:";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(186, 229);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(179, 20);
            this.txtGrad.TabIndex = 4;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(12, 229);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(168, 20);
            this.txtDrzava.TabIndex = 5;
            // 
            // btnBrisiGrad
            // 
            this.btnBrisiGrad.Location = new System.Drawing.Point(186, 301);
            this.btnBrisiGrad.Name = "btnBrisiGrad";
            this.btnBrisiGrad.Size = new System.Drawing.Size(179, 23);
            this.btnBrisiGrad.TabIndex = 7;
            this.btnBrisiGrad.Text = "OBRISI GRAD";
            this.btnBrisiGrad.UseVisualStyleBackColor = true;
            this.btnBrisiGrad.Click += new System.EventHandler(this.btnBrisiGrad_Click);
            // 
            // btnBrisiDrzavu
            // 
            this.btnBrisiDrzavu.Location = new System.Drawing.Point(12, 301);
            this.btnBrisiDrzavu.Name = "btnBrisiDrzavu";
            this.btnBrisiDrzavu.Size = new System.Drawing.Size(168, 23);
            this.btnBrisiDrzavu.TabIndex = 8;
            this.btnBrisiDrzavu.Text = "OBRISI DRZAVU";
            this.btnBrisiDrzavu.UseVisualStyleBackColor = true;
            this.btnBrisiDrzavu.Click += new System.EventHandler(this.btnBrisiDrzavu_Click);
            // 
            // btnDrzavaUredi
            // 
            this.btnDrzavaUredi.Location = new System.Drawing.Point(105, 261);
            this.btnDrzavaUredi.Name = "btnDrzavaUredi";
            this.btnDrzavaUredi.Size = new System.Drawing.Size(75, 23);
            this.btnDrzavaUredi.TabIndex = 9;
            this.btnDrzavaUredi.Text = "UREDI";
            this.btnDrzavaUredi.UseVisualStyleBackColor = true;
            this.btnDrzavaUredi.Click += new System.EventHandler(this.btnDrzavaUredi_Click);
            // 
            // btnDodajGrad
            // 
            this.btnDodajGrad.Location = new System.Drawing.Point(186, 261);
            this.btnDodajGrad.Name = "btnDodajGrad";
            this.btnDodajGrad.Size = new System.Drawing.Size(75, 23);
            this.btnDodajGrad.TabIndex = 10;
            this.btnDodajGrad.Text = "DODAJ";
            this.btnDodajGrad.UseVisualStyleBackColor = true;
            this.btnDodajGrad.Click += new System.EventHandler(this.btnDodajGrad_Click);
            // 
            // btnUrediGrad
            // 
            this.btnUrediGrad.Location = new System.Drawing.Point(290, 261);
            this.btnUrediGrad.Name = "btnUrediGrad";
            this.btnUrediGrad.Size = new System.Drawing.Size(75, 23);
            this.btnUrediGrad.TabIndex = 11;
            this.btnUrediGrad.Text = "UREDI";
            this.btnUrediGrad.UseVisualStyleBackColor = true;
            this.btnUrediGrad.Click += new System.EventHandler(this.btnUrediGrad_Click);
            // 
            // btnDrzavaDodaj
            // 
            this.btnDrzavaDodaj.Location = new System.Drawing.Point(15, 261);
            this.btnDrzavaDodaj.Name = "btnDrzavaDodaj";
            this.btnDrzavaDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDrzavaDodaj.TabIndex = 12;
            this.btnDrzavaDodaj.Text = "DODAJ";
            this.btnDrzavaDodaj.UseVisualStyleBackColor = true;
            this.btnDrzavaDodaj.Click += new System.EventHandler(this.btnDrzavaDodaj_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 328);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 350);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDrzavaDodaj);
            this.Controls.Add(this.btnUrediGrad);
            this.Controls.Add(this.btnDodajGrad);
            this.Controls.Add(this.btnDrzavaUredi);
            this.Controls.Add(this.btnBrisiDrzavu);
            this.Controls.Add(this.btnBrisiGrad);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGrad);
            this.Controls.Add(this.lbDrzave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDrzave;
        private System.Windows.Forms.ListBox lbGrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.Button btnBrisiGrad;
        private System.Windows.Forms.Button btnBrisiDrzavu;
        private System.Windows.Forms.Button btnDrzavaUredi;
        private System.Windows.Forms.Button btnDodajGrad;
        private System.Windows.Forms.Button btnUrediGrad;
        private System.Windows.Forms.Button btnDrzavaDodaj;
        private System.Windows.Forms.Label lblInfo;
    }
}

