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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbDataAdapter da;
        DataSet ds;
        private void liste()
        {
            oleDbConnection1.Open();
            da = new OleDbDataAdapter("select * from otel", oleDbConnection1);
            ds = new DataSet();
            da.Fill(ds, "otel");
            dataGridView1.DataSource = ds.Tables["otel"];
            oleDbConnection1.Close();
        }
        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yeni_Microsoft_Office_Access_2007_VeritabanıDataSet1.otel' table. You can move, or remove it, as needed.
            this.otelTableAdapter.Fill(this.yeni_Microsoft_Office_Access_2007_VeritabanıDataSet1.otel);
            groupBox1.Hide();
            groupBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText="insert into otel(adi,soyadi,tc_no,tel_no,şehir,kisi_sayısı,oda_no,giris_tarihi,cikis_tarihi,gün_sayısı,fiyat) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Kayıt Başarılı.");
            oleDbConnection1.Close();
            liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "delete from otel where sırano=" + textBox14.Text + "";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if(sonuc>0)
                MessageBox.Show("Kayıt Silindi.");
            oleDbConnection1.Close();
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "update otel set adi='" + textBox2.Text + "',soyadi='" + textBox3.Text + "',tc_no='" + textBox4.Text + "',tel_no='" + textBox5.Text + "',şehir='" + textBox6.Text + "',kisi_sayısı='" + textBox7.Text + "',oda_no='" + textBox8.Text + "',giris_tarihi='" + textBox9.Text + "',cikis_tarihi='" + textBox10.Text + "',gün_sayısı='" + textBox11.Text + "',fiyat='" + textBox12.Text + "' where sırano=" + textBox1.Text + "";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Güncelleme başarılı.");
            oleDbConnection1.Close();
            liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            da=new OleDbDataAdapter("select * from otel where sırano="+textBox13.Text+"",oleDbConnection1);
            ds = new DataSet();
            da.Fill(ds,"otel");
            dataGridView1.DataSource=ds.Tables["otel"];
            oleDbConnection1.Close();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
