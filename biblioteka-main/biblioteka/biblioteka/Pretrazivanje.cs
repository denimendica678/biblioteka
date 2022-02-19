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
    public partial class Pretrazivanje : Form
    {
        public Pretrazivanje()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pretrazivanje_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"D:\xmlkorisnik.xml");
            dataGridView1.Rows.Clear();

            foreach (DataRow item in ds.Tables["korisnik"].Rows)
            {
                int n = dataGridView1.Rows.Add();

                
                dataGridView1.Rows[n].Cells[0].Value = item[1];
                dataGridView1.Rows[n].Cells[4].Value = item[0];

            }

            DataSet ds2 = new DataSet();
            ds2.ReadXml(@"D:\knjige.xml");
            dataGridView1.Rows.Clear();

            foreach (DataRow item in ds2.Tables["knjiga"].Rows)
            {
                int n = dataGridView1.Rows.Add();

                
                dataGridView1.Rows[n].Cells[5].Value = item[1];
                dataGridView1.Rows[n].Cells[3].Value = item[0];

            }

            DataSet ds3 = new DataSet();
            ds3.ReadXml(@"D:\posudbe.xml");
            dataGridView1.Rows.Clear();

            foreach (DataRow item in ds3.Tables["posudbe"].Rows)
            {
                int n = dataGridView1.Rows.Add();
            
                dataGridView1.Rows[n].Cells[1].Value = item[0];
                dataGridView1.Rows[n].Cells[2].Value = item[1];
               
            }
        }
    }
}
