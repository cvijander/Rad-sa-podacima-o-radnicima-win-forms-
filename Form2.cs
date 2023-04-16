using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podaci_o_radnicima___opcije
{
    public partial class Form2 : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cvijander\source\repos\Relja napredni kurs\Podaci o radnicima - opcije\Podaci o radnicima - opcije\bin\Debug\baza.mdb");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataAdapter adapter = new OleDbDataAdapter(komanda);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska prilikom prikaza.");
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