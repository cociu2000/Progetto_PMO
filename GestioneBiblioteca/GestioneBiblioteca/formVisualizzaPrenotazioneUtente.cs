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
    public partial class formVisualizzaPrenotazioneUtente : Form
    {
        private string _username;

        // INIZIALIZZAZIONE DELLE VARIABILI //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;
        public int idutente;
        public formVisualizzaPrenotazioneUtente(string username)
        {
            InitializeComponent();
            this._username = username;
        }

        // FUNZIONE CHE RITORNA L'ID UTENTE //
        public int RitornaIdUtente(string username)
        {
            int x;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT idUtente FROM Utenti WHERE Utenti.email=@username", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = username;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            x = Convert.ToInt32(tb.Rows[0][0].ToString());

            return x;
        }

        // FUNZIONE CHE RITORNA TUTTI I PRESTITI ATTIVI DELL'UTENTE //
        public DataTable ElencoPrenotazioniAttive()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("select * from Prenotazioni WHERE  Prenotazioni.dataInizio >= getdate() - 1 AND Prenotazioni.dataFine <= GETDATE() + 30 AND Prenotazioni.idUtente=@idutente", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idutente", SqlDbType.Int).Value = idutente;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        private void formVisualizzaPrenotazioneUtente_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();

                // RICEVO L'ID UTENTE //
                idutente = RitornaIdUtente(this._username);

                // INSERISCO I DATI NELLA TABELLA //
                dgvMostraPrenotazioni.DataSource = ElencoPrenotazioniAttive();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }
    }
}
