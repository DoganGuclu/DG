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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "update Tablo1 set toplam = (aidat+gaz+demirbas)";
            oleDbCommand1.ExecuteNonQuery();
            oleDbConnection1.Close();
            // TODO: Bu kod satırı 'uyeDataSet.Tablo1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tablo1TableAdapter1.Fill(this.uyeDataSet.Tablo1);
            // TODO: Bu kod satırı 'uyeDataSet8.Tablo1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tablo1TableAdapter.Fill(this.uyeDataSet8.Tablo1);
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
        private void button1_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            if((textBox7.Text !="") && (textBox1.Text !=""))
            {
                oleDbCommand1.CommandText="update Tablo1 set aidat=aidat -'"+textBox7.Text+"'where Kimlik ="+textBox1.Text+"";
                int sonuc = oleDbCommand1.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Kayıt Oldu");
            }
            if((textBox8.Text !="") && (textBox1.Text !=""))
            {
                oleDbCommand1.CommandText = "update Tablo1 set demirbas=demirbas-'" + textBox8.Text + "'where Kimlik =" + textBox1.Text + "";
                int sonuc = oleDbCommand1.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Kayıt Oldu");
            }
            if((textBox9.Text !="")&& (textBox1.Text !=""))
            {
                oleDbCommand1.CommandText = "update Tablo1 set gaz=gaz-'" + textBox9.Text + "'where Kimlik =" + textBox1.Text + "";
                int sonuc = oleDbCommand1.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Kayıt Oldu");

            }
            oleDbConnection1.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label9.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString() + "TL aidat" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "TL damirbas" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "TL gaz TOPLAM=" + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "TL BORCUNUZ VARDIR";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "select sum(toplam) from Tablo1";
            label9.Text = "Toplam=" + oleDbCommand1.ExecuteScalar().ToString() + "  Hesapta Para Vardır.";
            oleDbConnection1.Close();
            liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm5 = new Form3();
            frm5.Show();
            this.Hide();
        }
    }
}
