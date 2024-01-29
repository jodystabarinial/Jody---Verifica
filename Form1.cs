using MySql.Data.MySqlClient;
namespace Jody___Verifica
{

    public partial class Form1 : Form
    {
        string ConnectionString = "server = 127.0.0.1;" +
                                  "database = verifica-js;" +
                                    "uid = root;";
        public Form1()
        {
            InitializeComponent();
            popolatabella("");
        }

        private void popolatabella(string q)
        {
            dataGridView1.Rows.Clear();
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
               
                connessione.Open();
                string query = $"SELECT * FROM componenti";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    dataGridView1.Rows.Add(
                    dr.GetInt32("id").ToString(),
                    dr.GetString("codicefarnel"),
                    dr.GetString("codiceproduttore"),
                    dr.GetString("quantità"),
                    dr.GetDecimal("prezzo").ToString()
                   ) ;
                }
                connessione.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Impossibilw connettersi al DB"+ ex.Message);
            }
        }

        private void textBoxCerca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            FormModifica formModifica = new FormModifica(id);

            formModifica.ShowDialog();

            popolatabella("");
        }
    }
}