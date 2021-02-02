using GestioneBiblioteca.Classi;
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
    public partial class formDashboard : Form
    {
        // INIZIALIZZAZIONE DELLA VARIABILE DERIVANTE DALL'ALTRO FORM //
        private string _username;

        // INIZIALIZZAZIONE DELLE VARIABILI //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;
        public string generePreferito;

        public formDashboard(string username)
        {
            InitializeComponent();
            this._username = username;
            lblAccessoTitle.Text = "";
            lblGenerePreferito.Text = "";
            
        }

        // FUNZIONE CHE RITORNA IL GENERE PREFERITO DELL'UTENTE //
        public string GenerePreferitoUtente(Utenti ut)
        {
            string genere;

            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT Genere.nomeGenere FROM Utenti, Genere WHERE Utenti.email = @email AND Utenti.IdGenere = Genere.idGenere", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            genere = tb.Rows[0][0].ToString();

            return genere;

        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
                Utenti utente = new Utenti();
                utente.email = this._username;
                generePreferito = GenerePreferitoUtente(utente);
                lblAccessoTitle.Text = "Benvenuto, " + this._username;
                lblGenerePreferito.Text = "Il tuo genere preferito è: " + generePreferito;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void formDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void lblAccessoTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLibriConsigliati_Click(object sender, EventArgs e)
        {
            formLibriConsigliati formLibriConsigliati = new formLibriConsigliati(this._username, generePreferito);
            formLibriConsigliati.Show();
        }

        private void btnElencoLibri_Click(object sender, EventArgs e)
        {
            formElencoLibri elencoLibri = new formElencoLibri();
            elencoLibri.Show();
        }

        private void btnPrenotaLibro_Click(object sender, EventArgs e)
        {
            FormPrenotaLibro prenotaLibro = new FormPrenotaLibro(this._username, generePreferito);
            prenotaLibro.Show();
        }

        private void btnGestionePrestiti_Click(object sender, EventArgs e)
        {
            formVisualizzaPrenotazioneUtente visualizzaPrestiti = new formVisualizzaPrenotazioneUtente(this._username);
            visualizzaPrestiti.Show();
        }

        private void btnRestituisciLibro_Click(object sender, EventArgs e)
        {
            formRestituisciLibro restituisciLibro = new formRestituisciLibro(this._username, generePreferito);
            restituisciLibro.Show();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
