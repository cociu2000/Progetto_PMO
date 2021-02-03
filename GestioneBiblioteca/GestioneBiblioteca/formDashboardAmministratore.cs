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
    public partial class formDashboardAmministratore : Form
    {
        // INIZIALIZZAZIONE DELLA VARIABILE DERIVANTE DALL'ALTRO FORM //
        private string _username;

        // INIZIALIZZAZIONE DELLE VARIABILI //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;

        public formDashboardAmministratore(string username)
        {
            InitializeComponent();
            this._username = username;
            lblAccessoAmministratoreTitle.Text = "";

        }

        private void formDashboardAmministratore_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
                // LABEL DI BENVENUTO //
                lblAccessoAmministratoreTitle.Text = "Benvenuto " + this._username;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void formDashboardAmministratore_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {
            formRegistrazione reg = new formRegistrazione();
            reg.Show();

        }

        private void btnGoListUsers_Click(object sender, EventArgs e)
        {
            formListaUtenti formListaUtenti = new formListaUtenti();
            formListaUtenti.Show();
        }

        private void btnManageGenere_Click(object sender, EventArgs e)
        {
            formGestioneGenere gestGenere = new formGestioneGenere();
            gestGenere.Show();
        }

        private void btnViewListLibri_Click(object sender, EventArgs e)
        {
            formElencoLibri elencoLibri = new formElencoLibri();
            elencoLibri.Show();
        }

        private void btnManageLibri_Click(object sender, EventArgs e)
        {
            formGestioneLibri gestLibri = new formGestioneLibri();
            gestLibri.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionePrestiti_Click(object sender, EventArgs e)
        {
            formGestionePrestiti gestPrestiti = new formGestionePrestiti();
            gestPrestiti.Show();
        }
    }
}
