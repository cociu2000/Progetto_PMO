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
    public partial class formLibriConsigliati : Form
    {
        // INIZIALIZZAZIONE DELLA VARIABILE DERIVANTE DALL'ALTRO FORM //
        private string _username;
        private string _generePreferito;
        public int IdGenerePreferito;

        // INIZIALIZZAZIONE DELLE VARIABILI //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;

        public formLibriConsigliati(string username, string generePreferito)
        {
            InitializeComponent();
            this._username = username;
            this._generePreferito = generePreferito;
            lblLibriConsigliatiSubtitle.Text = "";
            lblLibriConsigliatiTitle.Text = "";
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

        // FUNZIONE CHE RITORNA I LIBRI CONSIGLIATI //
        public DataTable RitornaLibriConsigliati()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT idLibro, titoloLibro, dataUscita, numeroCopie, nomeGenere FROM Libro,Genere WHERE libro.idGenere=@idGenere AND Genere.idGenere=libro.idGenere AND Libro.numeroCopie>0 AND Libro.disponibile=1", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IdGenere", SqlDbType.Int).Value = IdGenerePreferito;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        private void formLibriConsigliati_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
                lblLibriConsigliatiTitle.Text = "Benvenuto, " + this._username;
                lblLibriConsigliatiSubtitle.Text = "Il tuo genere preferito è: " + this._generePreferito;
                IdGenerePreferito = RitornaIdGenere(this._generePreferito);
                dgvLibriConsigliati.DataSource = RitornaLibriConsigliati();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
