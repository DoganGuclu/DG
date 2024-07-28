using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uyeDataSet1.Tablo1' table. You can move, or remove it, as needed.
            this.tablo1TableAdapter.Fill(this.uyeDataSet1.Tablo1);

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        OleDbDataAdapter da;
        DataSet ds;
        private void liste()
        {
            oleDbConnection1.Open();
            da = new OleDbDataAdapter("select * from Tablo1", oleDbConnection1);
            ds = new DataSet();
            da.Fill(ds, "Tablo1");
            dataGridView1.DataSource = ds.Tables["Tablo1"];
            oleDbConnection1.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "delete from Tablo1 where daireno='" + textBox2.Text.ToString() + "'";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Kayıt Silindi.");
            oleDbConnection1.Close();
            liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText="insert into Tablo1 (daireno,adisoyadi,tel,aidat,demirbas,gaz) values ('"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+0+"','"+0+"','"+0+"')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Kayıt Oldu.");
            oleDbConnection1.Close();
            liste();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "update Tablo1 ser daireno='" + textBox2.Text + "',adisoyadi='" + textBox3.Text + "',tel='" + textBox4.Text + "'";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Kayıt Güncellendi.");
            oleDbConnection1.Close();
            liste();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "update Tablo1 set daireno='" + textBox2.Text + "',adisoyadi='" + textBox3.Text + "',tel='" + textBox4.Text + "'";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Kayıt Güncellendi.");
            oleDbConnection1.Close();
            liste();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
