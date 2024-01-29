using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jody___Verifica
{
 
    public partial class FormModifica : Form
    {
        
        public string id_prodotto;
        public FormModifica(string codicefarnel)
        {
            InitializeComponent();
            id_prodotto = codicefarnel;
            popolaform();
        }

        private void popolaform()
        {
            string ConnectionString = "server = 127.0.0.1;" +
                                   "database = verifica-js;" +
                                     "uid = root;";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {           
                connessione.Open();
                string query = $"SELECT * FROM componenti WHERE id = '{id_prodotto}'";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                textBoxDescrizione.Text = dr.GetString("descrizione");
                textBoxProduttore.Text = dr.GetString("produttore");
                textBoxCodiceFarnel.Text = dr.GetString("codicefarnel");
                textBoxCodiceProduttore.Text = dr.GetString("codiceproduttore");
                textBoxQuantita.Text = dr.GetString("quantità");
                textBoxPrezzo.Text = dr.GetDecimal("prezzo").ToString();

                dr.Close();
                
                connessione.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Impossibilw connettersi al DB" + ex.Message);
            }
        }
        private void FormModifica_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrezzo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantita_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodiceProduttore_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodiceFarnel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProduttore_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescrizione_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsalva_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server = 127.0.0.1;" +
                                  "database = verifica-js;" +
                                    "uid = root;";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
            
                connessione.Open();
                string query = $"UPDATE componenti " +
                    $"SET " +
                    $"descrizione = '{textBoxDescrizione.Text}', " +
                    $"produttore = '{textBoxProduttore.Text}', " +
                    $"codicefarnel = '{textBoxCodiceFarnel.Text}', " +
                    $"codiceproduttore = '{textBoxCodiceProduttore.Text}', " +
                    $"quantità = '{textBoxQuantita.Text}', " +
                    $"prezzo = '{textBoxPrezzo.Text}'" +
                    $"WHERE id = {id_prodotto}";
                    
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                cmd.ExecuteNonQuery();
                connessione.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Impossibile modificare il DB" + ex.Message);
            }
            this.Close();
        }

        private void buttonannulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
