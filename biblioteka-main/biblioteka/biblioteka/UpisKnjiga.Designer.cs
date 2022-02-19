namespace biblioteka
{
    partial class UpisKnjiga
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.btnunesi = new System.Windows.Forms.Button();
            this.btndodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Autor";
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(375, 72);
            this.txtautor.Margin = new System.Windows.Forms.Padding(4);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(132, 22);
            this.txtautor.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Naziv";
            // 
            // txtnaziv
            // 
            this.txtnaziv.Location = new System.Drawing.Point(375, 216);
            this.txtnaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtnaziv.Name = "txtnaziv";
            this.txtnaziv.Size = new System.Drawing.Size(132, 22);
            this.txtnaziv.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ISBN";
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(375, 144);
            this.txtisbn.Margin = new System.Windows.Forms.Padding(4);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(132, 22);
            this.txtisbn.TabIndex = 8;
            // 
            // btnunesi
            // 
            this.btnunesi.Location = new System.Drawing.Point(650, 72);
            this.btnunesi.Margin = new System.Windows.Forms.Padding(4);
            this.btnunesi.Name = "btnunesi";
            this.btnunesi.Size = new System.Drawing.Size(133, 28);
            this.btnunesi.TabIndex = 7;
            this.btnunesi.Text = "Unesi";
            this.btnunesi.UseVisualStyleBackColor = true;
            this.btnunesi.Click += new System.EventHandler(this.btnunesi_Click);
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(650, 137);
            this.btndodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(133, 28);
            this.btndodaj.TabIndex = 14;
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
            this.dataGridView1.Location = new System.Drawing.Point(375, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Naziv";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Autor";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Isbn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // UpisKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.btnunesi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpisKnjiga";
            this.Text = "Upis knjige";
            this.Load += new System.EventHandler(this.UpisKnjiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Button btnunesi;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}