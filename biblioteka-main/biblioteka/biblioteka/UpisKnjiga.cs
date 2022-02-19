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
    public partial class UpisKnjiga : Form
    {
        public UpisKnjiga()
        {
            InitializeComponent();
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txtisbn.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtnaziv.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtautor.Text;
            
        }

        private void EmptyTexts()
        {
            txtisbn.Text = "";
            txtnaziv.Text = "";
            txtautor.Text = "";
        }

        private void btnunesi_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "knjiga";
            dt.Columns.Add("isbn");
            dt.Columns.Add("naziv");
            dt.Columns.Add("autor");
            ds.Tables.Add(dt);
            EmptyTexts();

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["knjiga"].NewRow();

                row["isbn"] = r.Cells[0].Value;
                row["naziv"] = r.Cells[1].Value;
                row["autor"] = r.Cells[2].Value;

                ds.Tables["knjiga"].Rows.Add(row);
            }

            ds.WriteXml(@"D:\knjige.xml");
        }

        private void UpisKnjiga_Load(object sender, EventArgs e)
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
