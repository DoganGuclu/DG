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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)


        {
            string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=uye.mdb;";
            string sql = "SELECT Kimlik,daireno,adisoyadi,aidat,demirbas,gaz FROM Tablo1";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Tablo1");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tablo1";
            liste();


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
            if ((checkBox1.Checked == true) & (textBox4.Text != ""))
            {
                int a = Convert.ToInt32(textBox4.Text);
                oleDbCommand1.CommandText = "update Tablo1 set aidat=aidat+" + a + "";
                int sonuc = oleDbCommand1.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Aidatlar Eklendi.");
            }
            else if ((checkBox2.Checked == true) & (textBox5.Text != ""))
            {
                int b = Convert.ToInt32(textBox5.Text);
                oleDbCommand1.CommandText = "update Tablo1 set demirbas=demirbas+" + b + "";
                int sonuc = oleDbCommand1.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Demirbaşlar Eklendi.");
            }
            else if ((textBox6.Text != "") & (textBox1.Text != ""))
            {
                int c = Convert.ToInt32(textBox6.Text);
                oleDbCommand1.CommandText = "update Tablo1 set gaz=gaz+" + c + "";
                int sonuc = oleDbCommand1.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Gazlar Eklendi.");
            }
            else if ((checkBox1.Checked == false) & (textBox4.Text != "") & (textBox1.Text != ""))
            {
                int d = Convert.ToInt32(textBox4.Text);
                oleDbCommand1.CommandText = "update Tablo1 set aidat=aidat+" + d +" where Kimlik="+ textBox1.Text +"";
                int sonuc = oleDbCommand1.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Aidatlar Eklendi.");
            }
            else if ((checkBox2.Checked == false) & (textBox5.Text != "") & (textBox1.Text != ""))
            {
                int f = Convert.ToInt32(textBox5.Text);
                oleDbCommand1.CommandText = "update Tablo1 set demirbas=demirbas+" + f + "where Kimlik=" + textBox1.Text + "";
                int sonuc = oleDbCommand1.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Demirbaşlar Eklendi.");
            }
            oleDbConnection1.Close();
            liste();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm6 = new Form3();
            frm6.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}