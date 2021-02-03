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
    public partial class FormPrenotaLibro : Form
    {
        // VARIABILI DERIVANTI DAL FORM DASHBOARD //
        private string _username;
        private string _generepreferito;

        // INIZIALIZZAZIONE DELLE VARIABILI //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;
        public int IdGenerePreferito;
        public int idutente;

        public FormPrenotaLibro(string username, string generepreferito)
        {
            InitializeComponent();
            this._username = username;
            this._generepreferito = generepreferito;
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

        // FUNZIONE CHE RITORNA L'ID DEL GENERE //
        public int RitornaIdGenere(string genere)
        {
            int x;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT IdGenere FROM Genere WHERE Genere.nomeGenere =@nomeGenere", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nomeGenere", SqlDbType.VarChar, 255).Value = genere;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            x = Convert.ToInt32(tb.Rows[0][0].ToString());

            return x;
        }

        // FUNZIONE CHE CARICA ESCLUSIVAMENTE I LIBRI DEL GENERE PREFERITO //
        public DataTable CaricaLibriGenerePreferito()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT idLibro, titoloLibro, dataUscita, numeroCopie, nomeGenere FROM Libro,Genere WHERE libro.idGenere=@idGenere AND Genere.idGenere=libro.idGenere AND Libro.numeroCopie>0 AND Libro.disponibile=1", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idGenere", SqlDbType.Int).Value = IdGenerePreferito;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // FUNZIONE CHE CARICA COMPLESSIVAMENTE TUTTI I LIBRI //
        public DataTable CaricaLibri()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT idLibro, titoloLibro, dataUscita FROM Libro WHERE Libro.numeroCopie>0 AND Libro.disponibile=1", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // FUNZIONE CHE EFFETTUA LA PRENOTAZIONE //
        public bool RegistraPrenotazione(Prenotazione p)
        {
            bool check;
            DataTable tb = new DataTable();
            int copie = 0;
            cmd = new SqlCommand("INSERT INTO Prenotazioni (idUtente, idLibro, dataInizio, dataFine, GiorniRitardo) VALUES ( @idutente, @idlibro, @datainizio, @datafine, @giorniritardo)", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idutente", SqlDbType.Int).Value = p.idUtente;
            cmd.Parameters.Add("@idlibro", SqlDbType.Int).Value = p.idLibro;
            cmd.Parameters.Add("@datainizio", SqlDbType.Date).Value = p.dataInizio;
            cmd.Parameters.Add("@datafine", SqlDbType.Date).Value = p.dataFine;
            cmd.Parameters.Add("@giorniritardo", SqlDbType.Int).Value = p.GiorniRitardo;

            int x = cmd.ExecuteNonQuery();
            if (x == 1)
            {
                SqlCommand cmd2 = new SqlCommand("SELECT numeroCopie FROM Libro WHERE Libro.idLibro=@idlibro", connection);
                cmd2.Connection = connection;
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("@idlibro", SqlDbType.Int).Value = p.idLibro;
                cmd2.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd2;
                adp.Fill(tb);
                copie = Convert.ToInt32(tb.Rows[0][0]);
                if (copie > 1)
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Libro SET numeroCopie=numeroCopie-1 WHERE Libro.idLibro=@idlibro", connection);
                    cmd3.Connection = connection;
                    cmd3.CommandType = CommandType.Text;
                    cmd3.Parameters.Add("@idlibro", SqlDbType.Int).Value = p.idLibro;
                    cmd3.ExecuteNonQuery();
                }
                else if (copie <= 1)
                {
                    SqlCommand cmd4 = new SqlCommand("UPDATE Libro SET numeroCopie=numeroCopie-1, disponibile=0 WHERE Libro.idLibro=@idlibro", connection);
                    cmd4.Connection = connection;
                    cmd4.CommandType = CommandType.Text;
                    cmd4.Parameters.Add("@idlibro", SqlDbType.Int).Value = p.idLibro;
                    cmd4.ExecuteNonQuery();
                }
                check = true;
            }
            else
                check = false;

            return check;
        }

        // FUNZIONE CHE SVUOTA I CONTROLLI //
        public void SvuotaDati(ComboBox cmb1, CheckBox ckh)
        {
            cmb1.SelectedIndex = 0;
            ckh.Checked = false;
        }

        // Trovo l'id del film 
        public int TrovaIdFilm(string titoloLibro)
        {
            int id;
            SqlCommand cmd3 = new SqlCommand("SELECT idLibro FROM Libro WHERE Libro.titoloLibro=@titoloLibro", connection);
            cmd3.Connection = connection;
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("@titoloLibro", SqlDbType.VarChar, 255).Value = titoloLibro;
            cmd3.ExecuteNonQuery();
            DataTable tb = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd3;
            adp.Fill(tb);
            id = Convert.ToInt32(tb.Rows[0][0]);
            return id;
        }
        private void FormPrenotaLibro_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();

                // STAMPA A VIDEO USERNAME E GENERE PREFERITO NELLE RISPETTIVE TEXTBOX ( CASELLE DI TESTO ) //
                txtPrenotaLibroGenerePreferito.Text = this._generepreferito;
                txtPrenotaLibroUsername.Text = this._username;

                // SALVIAMO L'ID DEL GENERE PREFERITO //
                IdGenerePreferito = RitornaIdGenere(this._generepreferito);

                // SALVIAMO L'ID DELL'UTENTE //
                idutente = RitornaIdUtente(this._username);

                // CONTROLLO SE L'UTENTE HA INTENZIONE DI VEDERE SOLO I LIBRI CONSIGLIATI O MENO //
                if (!ckhPrenotaLibroGenerePreferito.Checked)
                {
                    cmbPrenotaLibroScegliLibro.DataSource = CaricaLibriGenerePreferito();
                    cmbPrenotaLibroScegliLibro.DisplayMember = "titoloLibro";
                    cmbPrenotaLibroScegliLibro.ValueMember = "titoloLibro";
                }
                else
                {
                    // CARICAMENTO COMPLESSIVO DEI FILM //
                    cmbPrenotaLibroScegliLibro.DataSource = CaricaLibri();
                    cmbPrenotaLibroScegliLibro.DisplayMember = "titoloLibro";
                    cmbPrenotaLibroScegliLibro.ValueMember = "titoloLibro";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void ckhPrenotaLibroGenerePreferito_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckhPrenotaLibroGenerePreferito.Checked)
            {
                cmbPrenotaLibroScegliLibro.DataSource = CaricaLibriGenerePreferito();
                cmbPrenotaLibroScegliLibro.DisplayMember = "titoloLibro";
                cmbPrenotaLibroScegliLibro.ValueMember = "titoloLibro";
            }
            else
            {
                // CARICAMENTO COMPLESSIVO DEI FILM //
                cmbPrenotaLibroScegliLibro.DataSource = CaricaLibri();
                cmbPrenotaLibroScegliLibro.DisplayMember = "titoloLibro";
                cmbPrenotaLibroScegliLibro.ValueMember = "titoloLibro";
            }
        }
        private void btnPrenotaLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrenotaLibroGenerePreferito.Text != "" && txtPrenotaLibroUsername.Text != "")
                {
                    Prenotazione prenotazione = new Prenotazione();
                    prenotazione.idLibro = TrovaIdFilm(cmbPrenotaLibroScegliLibro.Text);
                    prenotazione.idUtente = idutente;
                    prenotazione.dataInizio = DateTime.Now;
                    prenotazione.dataFine = DateTime.Now.AddDays(30);
                    prenotazione.GiorniRitardo = 0;
                    if (RegistraPrenotazione(prenotazione))
                    {
                        MessageBox.Show("Libro prenotato correttamente");
                        SvuotaDati(cmbPrenotaLibroScegliLibro, ckhPrenotaLibroGenerePreferito); ;
                    }
                    else
                    {
                        MessageBox.Show("Errore nella prenotazione");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nella prenotazione del Libro" + ex.Message);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            SvuotaDati(cmbPrenotaLibroScegliLibro, ckhPrenotaLibroGenerePreferito);
        }
    }
}
