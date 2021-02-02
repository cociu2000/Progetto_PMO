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
    public partial class formRestituisciLibro : Form
    {
        // IMPLEMENTAZIONE DUE VARIABILI DERIVANTI DAL FORM DASHBOARD - AMMINISTRATORE //
        public string _username;
        public string _generePreferito;

        // INIZIALIZZAZIONE VARIABILI //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;
        public int idutente;
        public DateTime dataInizio;
        public DateTime dataFine;
        public int idLibro = 0;
        public int idPrenotazione = 0;  

        public formRestituisciLibro(string username, string generePreferito)
        {
            InitializeComponent();
            this._username = username;
            this._generePreferito = generePreferito;
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

        // FUNZIONE CHE CARICA TUTTE LE PRENOTAZIONI ATTIVE PER UN DETERMINATO UTENTE //
        public DataTable PrenotazioniAttive()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT idPrenotazione, titoloLibro FROM Prenotazioni, Libro WHERE Prenotazioni.idUtente=@idutente AND Prenotazioni.Consegnato = 0 AND Prenotazioni.idLibro = Libro.idLibro", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("idUtente", SqlDbType.Int).Value = idutente;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // FUNZIONE CHE RESTITUISCE IL LIBRO //
        public bool RestituisciLibro(Restituzione rst)
        {
            bool check;

            // AGGIORNAMENTO CAMPO CONSEGNATO SUL DB PRONOTAZIONI //
            cmd = new SqlCommand("UPDATE Prenotazioni SET Consegnato=1 WHERE Prenotazioni.idPrenotazione=@idPrenotazione", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idPrenotazione", SqlDbType.Int).Value = rst.idPrenotazione;
            int x = cmd.ExecuteNonQuery();
            if (x==1)
            {
                // AGGIORNAMENTO GIORNI DI RITARDO //
                if (rst.GiorniRitardo > 0)
                {
                    cmd = new SqlCommand("UPDATE Prenotazioni SET GiorniRitardo=@giorni WHERE Prenotazioni.idLibro=@idLibro", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@giorni", SqlDbType.Int).Value = rst.GiorniRitardo;
                    cmd.Parameters.Add("@idLibro", SqlDbType.Int).Value = rst.idLibro;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("UPDATE Libro SET numeroCopie=numeroCopie+1 WHERE Libro.idLibro=@idLibro", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@idLibro", SqlDbType.Int).Value = rst.idLibro;
                    cmd.ExecuteNonQuery();
                }
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

        private void formRestituisciLibro_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();

                // INIZIALIZZAZIONE CASELLE DI TESTO //
                txtRestituisciLibroGenerePreferito.Text = this._generePreferito;
                txtRestituisciLibroUsername.Text = this._username;
                idutente = RitornaIdUtente(this._username);
                if (PrenotazioniAttive().Rows.Count > 0)
                {
                    cmbRestituisciLibroRestituisciLibro.DataSource = PrenotazioniAttive();
                    cmbRestituisciLibroRestituisciLibro.DisplayMember = "titoloLibro";
                    cmbRestituisciLibroRestituisciLibro.ValueMember = "titoloLibro";
                }
                else
                {
                    MessageBox.Show("Non ci sono più prenotazioni attive per questo utente");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void btnRestituisciLibroAnnulla_Click(object sender, EventArgs e)
        {
            if (PrenotazioniAttive().Rows.Count>0)
            cmbRestituisciLibroRestituisciLibro.SelectedIndex = 0;
        }

        private void btnRestituisciLibro_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT dataInizio, dataFine,idPrenotazione FROM Prenotazioni WHERE Prenotazioni.idLibro=@idLibro AND Prenotazioni.idUtente=@idUtente and Prenotazioni.Consegnato=0", connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@idLibro", SqlDbType.Int).Value = idLibro;
                cmd.Parameters.Add("@idUtente", SqlDbType.Int).Value = idutente;
                cmd.ExecuteNonQuery();
                DataTable tb = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                adp.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    dataInizio = Convert.ToDateTime(tb.Rows[0][0].ToString());
                    dataFine = Convert.ToDateTime(tb.Rows[0][1].ToString());
                    idPrenotazione = Convert.ToInt32(tb.Rows[0][2].ToString());
                }

                DateTime oggi = DateTime.Now;
                if (oggi > dataFine)
                {
                    TimeSpan difference = dataFine.Date - oggi.Date;
                    int days = (int)difference.TotalDays * (-1);
                    Restituzione rst = new Restituzione();
                    rst.idPrenotazione = idPrenotazione;
                    rst.idUtente = idutente;
                    rst.idLibro = idLibro;
                    rst.GiorniRitardo = days;

                    if (RestituisciLibro(rst))
                    {
                        MessageBox.Show("Libro riconsegnato con successo con aggiornamento dei giorni di ritardo");
                        if (PrenotazioniAttive().Rows.Count > 0)
                        {
                            cmbRestituisciLibroRestituisciLibro.DataSource = PrenotazioniAttive();
                            cmbRestituisciLibroRestituisciLibro.DisplayMember = "titoloLibro";
                            cmbRestituisciLibroRestituisciLibro.ValueMember = "titoloLibro";
                            cmbRestituisciLibroRestituisciLibro.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Non ci sono più prenotazioni attive per questo utente");
                        }
                    }
                    else
                        MessageBox.Show("Libro non consegnato con successo");
                }
                else if (oggi < dataFine)
                {
                    Restituzione rst = new Restituzione();
                    rst.idPrenotazione = idPrenotazione;
                    rst.idUtente = idutente;
                    rst.idLibro = idLibro;
                    rst.GiorniRitardo = 0;

                    if (RestituisciLibro(rst))
                    {
                        MessageBox.Show("Libro riconsegnato con successo");
                        if (PrenotazioniAttive().Rows.Count > 0)
                        {
                            cmbRestituisciLibroRestituisciLibro.DataSource = PrenotazioniAttive();
                            cmbRestituisciLibroRestituisciLibro.DisplayMember = "titoloLibro";
                            cmbRestituisciLibroRestituisciLibro.ValueMember = "titoloLibro";
                            cmbRestituisciLibroRestituisciLibro.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Non ci sono più prenotazioni attive per questo utente");
                        }
                    }
                    else
                        MessageBox.Show("Libro non consegnato con successo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella consegna del libro: " + ex.Message);
            }
        }

        private void cmbRestituisciLibroRestituisciLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // estraggo il numero del film in base al film selezionato dalla combobox
                string titoloLibro = cmbRestituisciLibroRestituisciLibro.Text;
                cmd = new SqlCommand("SELECT idLibro FROM Libro WHERE Libro.titoloLibro=@titoloLibro", connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@titoloLibro", SqlDbType.VarChar, 255).Value = titoloLibro;
                int x = cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                SqlDataAdapter adpFilm = new SqlDataAdapter();
                adpFilm.SelectCommand = cmd;
                adpFilm.Fill(td);
                if (td.Rows.Count > 0)
                    idLibro = Convert.ToInt32(td.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel ricalco dei giorni passati dal noleggio:" + ex.Message);
            }
        }
    }
}
