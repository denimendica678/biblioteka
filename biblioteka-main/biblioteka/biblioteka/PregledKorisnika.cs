using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class PregledKorisnika : Form
    {
        
        public PregledKorisnika()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void PregledKorisnika_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"D:\xmlkorisnik.xml");
            dataGridView1.Rows.Clear();

            foreach (DataRow item in ds.Tables["korisnik"].Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[0];
                dataGridView1.Rows[n].Cells[1].Value = item[1];
                dataGridView1.Rows[n].Cells[2].Value = item[2];
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }
    }
}
