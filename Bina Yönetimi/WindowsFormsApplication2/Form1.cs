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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            OleDbDataReader dr;
            oleDbCommand1.CommandText = "select * from tablo";
            dr = oleDbCommand1.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                if ((dr[0].ToString() == textBox1.Text) && (dr[1].ToString() == textBox2.Text))
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                    i++;
                    break;
                }
            }
            if (i == 0)
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            oleDbConnection1.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
