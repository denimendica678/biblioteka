using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace biblioteka
{
    public partial class Posudbe : Form
    {

        public Posudbe()
        {
            InitializeComponent();

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"D:\xmlkorisnik.xml");
            this.comboBox1.DataSource = dataSet.Tables[0];
            this.comboBox1.DisplayMember = "ime";

            DataSet ds = new DataSet();
            ds.ReadXml(@"D:\knjige.xml");
            this.comboBox2.DataSource = ds.Tables[0];
            this.comboBox2.DisplayMember = "naziv";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Posudbe_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"D:\posudbe.xml");
            dataGridView1.Rows.Clear();

            foreach (DataRow item in ds.Tables["posudbe"].Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[0];
                dataGridView1.Rows[n].Cells[1].Value = item[1];
                dataGridView1.Rows[n].Cells[2].Value = item[2];
                dataGridView1.Rows[n].Cells[3].Value = item[3];
            }


        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "posudbe";
            dt.Columns.Add("posudba");
            dt.Columns.Add("vracanje");
            dt.Columns.Add("korisnik");
            dt.Columns.Add("naziv");
            ds.Tables.Add(dt);
            

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row = ds.Tables["posudbe"].NewRow();

                row["posudba"] = r.Cells[0].Value;
                row["vracanje"] = r.Cells[1].Value;
                row["korisnik"] = r.Cells[2].Value;
                row["naziv"] = r.Cells[3].Value;

                ds.Tables["posudbe"].Rows.Add(row);
            }

            ds.WriteXml(@"D:\posudbe.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = dateTimePicker1.Text;
            dataGridView1.Rows[n].Cells[1].Value = dateTimePicker2.Text;
            dataGridView1.Rows[n].Cells[2].Value = comboBox1.Text;
            dataGridView1.Rows[n].Cells[3].Value = comboBox2.Text;
        }
    }
}
