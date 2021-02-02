using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneBiblioteca
{
    public partial class formGestionePrestiti : Form
    {
        // INIZIALIZZAZIONE DELLE VARIABILI //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;
        public formGestionePrestiti()
        {
            InitializeComponent();
        }

        // FUNZIONE CHE RITORNA L'ELENCO DEI PRESTITI //
        public DataTable GestionePrestiti()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Prenotazioni ORDER BY idUtente", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        private void formGestionePrestiti_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
                dgvGestionePrestiti.DataSource = GestionePrestiti();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }
    }
}
