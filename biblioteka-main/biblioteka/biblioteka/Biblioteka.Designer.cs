namespace biblioteka
{
    partial class Biblioteka
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
            this.btnUpisKorisnika = new System.Windows.Forms.Button();
            this.btnUpisKnjige = new System.Windows.Forms.Button();
            this.btnPregledKnjiga = new System.Windows.Forms.Button();
            this.btnPregledKorisnika = new System.Windows.Forms.Button();
            this.btnPretrazivanje = new System.Windows.Forms.Button();
            this.btnPosudba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpisKorisnika
            // 
            this.btnUpisKorisnika.Location = new System.Drawing.Point(190, 114);
            this.btnUpisKorisnika.Name = "btnUpisKorisnika";
            this.btnUpisKorisnika.Size = new System.Drawing.Size(169, 49);
            this.btnUpisKorisnika.TabIndex = 0;
            this.btnUpisKorisnika.Text = "Upis korisnika";
            this.btnUpisKorisnika.UseVisualStyleBackColor = true;
            this.btnUpisKorisnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpisKnjige
            // 
            this.btnUpisKnjige.Location = new System.Drawing.Point(190, 169);
            this.btnUpisKnjige.Name = "btnUpisKnjige";
            this.btnUpisKnjige.Size = new System.Drawing.Size(169, 49);
            this.btnUpisKnjige.TabIndex = 1;
            this.btnUpisKnjige.Text = "Upis knjige";
            this.btnUpisKnjige.UseVisualStyleBackColor = true;
            this.btnUpisKnjige.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPregledKnjiga
            // 
            this.btnPregledKnjiga.Location = new System.Drawing.Point(401, 169);
            this.btnPregledKnjiga.Name = "btnPregledKnjiga";
            this.btnPregledKnjiga.Size = new System.Drawing.Size(169, 49);
            this.btnPregledKnjiga.TabIndex = 2;
            this.btnPregledKnjiga.Text = "Pregled knjiga";
            this.btnPregledKnjiga.UseVisualStyleBackColor = true;
            this.btnPregledKnjiga.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Location = new System.Drawing.Point(401, 114);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(169, 49);
            this.btnPregledKorisnika.TabIndex = 3;
            this.btnPregledKorisnika.Text = "Pregled korisnika";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            this.btnPregledKorisnika.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPretrazivanje
            // 
            this.btnPretrazivanje.Location = new System.Drawing.Point(190, 297);
            this.btnPretrazivanje.Name = "btnPretrazivanje";
            this.btnPretrazivanje.Size = new System.Drawing.Size(380, 49);
            this.btnPretrazivanje.TabIndex = 4;
            this.btnPretrazivanje.Text = "Pretraživanje";
            this.btnPretrazivanje.UseVisualStyleBackColor = true;
            this.btnPretrazivanje.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPosudba
            // 
            this.btnPosudba.Location = new System.Drawing.Point(190, 242);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(380, 49);
            this.btnPosudba.TabIndex = 5;
            this.btnPosudba.Text = "Posudba";
            this.btnPosudba.UseVisualStyleBackColor = true;
            this.btnPosudba.Click += new System.EventHandler(this.button6_Click);
            // 
            // Biblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPosudba);
            this.Controls.Add(this.btnPretrazivanje);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.btnPregledKnjiga);
            this.Controls.Add(this.btnUpisKnjige);
            this.Controls.Add(this.btnUpisKorisnika);
            this.Name = "Biblioteka";
            this.Text = "Biblioteka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpisKorisnika;
        private System.Windows.Forms.Button btnUpisKnjige;
        private System.Windows.Forms.Button btnPregledKnjiga;
        private System.Windows.Forms.Button btnPregledKorisnika;
        private System.Windows.Forms.Button btnPretrazivanje;
        private System.Windows.Forms.Button btnPosudba;
    }
}

