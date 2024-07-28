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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbDataAdapter dr;
        DataSet ds;
        private void liste()
        {
            oleDbConnection1.Open();
            dr = new OleDbDataAdapter("select*from arac", oleDbConnection1);
            ds = new DataSet();
            dr.Fill(ds, "arac");
            dataGridView1.DataSource = ds.Tables["arac"];
            oleDbConnection1.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iueuieDataSet1.arac' table. You can move, or remove it, as needed.
            this.aracTableAdapter.Fill(this.iueuieDataSet1.arac);
            groupBox1.Hide();
            groupBox2.Hide();
            groupbox3.Hide();
            groupBox6.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox7.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "AUDİ")
            { groupBox1.Show(); }
            if (comboBox1.SelectedItem.ToString() == "BMW" )
            { groupBox2.Show(); }
            if (comboBox1.SelectedItem.ToString() == "FİAT")
            { groupbox3.Show(); }
            if (comboBox1.SelectedItem.ToString() == "FORD")
            { groupBox4.Show(); }
            if (comboBox1.SelectedItem.ToString() == "HONDA")
            { groupBox6.Show(); }
            if (comboBox1.SelectedItem.ToString() == "MERCEDES-BENZ")
            { groupBox7.Show(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Araç Kiralandı.");

            oleDbConnection1.Close();
            liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupbox3.Hide();
        }

        private void groupbox3_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox4.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox6.Hide();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox7.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Araç Kiralandı.");
            }
            oleDbConnection1.Close();
            liste();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Araç Kiralandı.");
            oleDbConnection1.Close();
            liste();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Araç Kiralandı.");
            oleDbConnection1.Close();
            liste();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Araç Kiralandı.");
            oleDbConnection1.Close();
            liste();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Araç Kiralandı.");
            oleDbConnection1.Close();
            liste();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Araç Kiralandı.");
            oleDbConnection1.Close();
            liste();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Araç Kiralandı.");
            oleDbConnection1.Close();
            liste();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "insert into arac(marka,kirlamagünü) values ('" + comboBox1.SelectedItem.ToString() + "','" + textBox1.Text + "')";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Araç Kiralandı.");
            oleDbConnection1.Close();
            liste();
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText="delete from arac where marka='"+comboBox1.SelectedItem.ToString()+"'";
            int sonuc = oleDbCommand1.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Silindi");
            oleDbConnection1.Close();
            liste();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            dr = new OleDbDataAdapter("select * from arac where marka='" + textBox2.Text + "'", oleDbConnection1);
            ds = new DataSet();
            dr.Fill(ds, "arac");
            dataGridView1.DataSource = ds.Tables["arac"];
            MessageBox.Show("Araç daha önceden kiralanmış");
            oleDbConnection1.Close();
        }
    }
}
