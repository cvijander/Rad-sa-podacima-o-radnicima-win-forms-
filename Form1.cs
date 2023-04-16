using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podaci_o_radnicima___opcije
{
    public partial class Form1 : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima - opcije\Podaci o radnicima - opcije\bin\Debug\baza.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void sveRadnikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void radnikeSaPlatomVecomOd50000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void imeIPrezimeZaSvakogRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select ime+' '+prezime from Radnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read() == true)
                {
                    string impr = citac[0].ToString();
                    listBox1.Items.Add(impr);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom upita " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                {
                    konekcija.Close();
                }
            }
        }
    }
}