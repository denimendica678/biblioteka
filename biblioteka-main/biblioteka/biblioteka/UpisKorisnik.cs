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
    public partial class UpisKorisnik : Form
    {
        public UpisKorisnik()
        {
            InitializeComponent();
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txtoib.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtime.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtprezime.Text;
            EmptyTexts();
        }

        private void EmptyTexts()
        {
            txtoib.Text = "";
            txtime.Text = "";
            txtprezime.Text = "";
        }
        private void btnunesi_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "korisnik";
            dt.Columns.Add("oib");
            dt.Columns.Add("ime");
            dt.Columns.Add("prezime");
            ds.Tables.Add(dt);
            EmptyTexts();

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["korisnik"].NewRow();

                row["oib"] = r.Cells[0].Value;
                row["ime"] = r.Cells[1].Value;
                row["prezime"] = r.Cells[2].Value;

                ds.Tables["korisnik"].Rows.Add(row);
            }

            ds.WriteXml(@"D:\xmlkorisnik.xml");

        }

        private void UpisKorisnik_Load(object sender, EventArgs e)
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
        
    }
}
