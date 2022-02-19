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
    public partial class PregledKnjiga : Form
    {
        public PregledKnjiga()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PregledKnjiga_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"D:\knjige.xml");
            dataGridView1.Rows.Clear();

            foreach (DataRow item in ds.Tables["knjiga"].Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[0];
                dataGridView1.Rows[n].Cells[1].Value = item[1];
                dataGridView1.Rows[n].Cells[2].Value = item[2];
            }
        }
    }
}
