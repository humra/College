namespace Ishod06
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
            this.components = new System.ComponentModel.Container();
            this.gvKupac = new System.Windows.Forms.DataGridView();
            this.adventureWorksOBPDataSet = new Ishod06.AdventureWorksOBPDataSet();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupacTableAdapter = new Ishod06.AdventureWorksOBPDataSetTableAdapters.KupacTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvKupac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksOBPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvKupac
            // 
            this.gvKupac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKupac.Location = new System.Drawing.Point(0, 0);
            this.gvKupac.Name = "gvKupac";
            this.gvKupac.Size = new System.Drawing.Size(753, 150);
            this.gvKupac.TabIndex = 0;
            // 
            // adventureWorksOBPDataSet
            // 
            this.adventureWorksOBPDataSet.DataSetName = "AdventureWorksOBPDataSet";
            this.adventureWorksOBPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "Kupac";
            this.kupacBindingSource.DataSource = this.adventureWorksOBPDataSet;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 318);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gvKupac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKupac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksOBPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvKupac;
        private AdventureWorksOBPDataSet adventureWorksOBPDataSet;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private AdventureWorksOBPDataSetTableAdapters.KupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.ListBox listBox1;

    }
}

