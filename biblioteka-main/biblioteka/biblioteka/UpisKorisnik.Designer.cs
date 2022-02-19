namespace biblioteka
{
    partial class UpisKorisnik
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
            this.btnunesi = new System.Windows.Forms.Button();
            this.txtoib = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.btndodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnunesi
            // 
            this.btnunesi.Location = new System.Drawing.Point(625, 80);
            this.btnunesi.Margin = new System.Windows.Forms.Padding(4);
            this.btnunesi.Name = "btnunesi";
            this.btnunesi.Size = new System.Drawing.Size(133, 28);
            this.btnunesi.TabIndex = 0;
            this.btnunesi.Text = "Unesi";
            this.btnunesi.UseVisualStyleBackColor = true;
            this.btnunesi.Click += new System.EventHandler(this.btnunesi_Click);
            // 
            // txtoib
            // 
            this.txtoib.Location = new System.Drawing.Point(333, 157);
            this.txtoib.Margin = new System.Windows.Forms.Padding(4);
            this.txtoib.Name = "txtoib";
            this.txtoib.Size = new System.Drawing.Size(132, 22);
            this.txtoib.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "OIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime";
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(333, 230);
            this.txtime.Margin = new System.Windows.Forms.Padding(4);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(132, 22);
            this.txtime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezime";
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(333, 87);
            this.txtprezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(132, 22);
            this.txtprezime.TabIndex = 5;
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(625, 150);
            this.btndodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(133, 28);
            this.btndodaj.TabIndex = 7;
            this.btndodaj.Text = "Dodaj";
            this.btndodaj.UseVisualStyleBackColor = true;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(333, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 180);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ime";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prezime";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "OIB";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // UpisKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtoib);
            this.Controls.Add(this.btnunesi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpisKorisnik";
            this.Text = "Upis korisnika";
            this.Load += new System.EventHandler(this.UpisKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnunesi;
        private System.Windows.Forms.TextBox txtoib;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}