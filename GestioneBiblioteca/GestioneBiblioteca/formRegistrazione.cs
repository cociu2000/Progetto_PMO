using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// INSERIMENTO DEGLI USING PER CONNETTERMI AL DATABASE //
using System.Data.SqlClient;
using GestioneBiblioteca.Classi;
using System.Text.RegularExpressions;

namespace GestioneBiblioteca
{
    public partial class formRegistrazione : Form
    {
        // CREAZIONE VARIABILI PUBBLICHE NECESSARIE AL DATABASE E PER LA GESTIONE DEGLI INPUT //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;
        public SqlParameter p1;
        public bool checkEmail;

        public formRegistrazione()
        {
            InitializeComponent();
        }

        // INIZIALIZZAZIONE DEL PRIMO VALORE DELLA COMBOBOX CON LA SCRITTA "--SELEZIONA"
        public void InizializzaCampoVuotoComboBox(ComboBox cmb1, ComboBox cmb2)
        {
            cmb1.Items.Add("--Seleziona");
            cmb2.Items.Add("--Seleziona");
        }

        // FUNZIONE CHE PERMETTE DI SVUOTARE I DATI //
        public void SvuotaDati(TextBox tCognome, TextBox tNome, TextBox tEmail, TextBox tPassword, TextBox tConfermapassword, ComboBox cCitta, ComboBox cGenere)
        {
            tCognome.Clear();
            tNome.Clear();
            tEmail.Clear();
            tPassword.Clear();
            tConfermapassword.Clear();
            cCitta.SelectedIndex = 0;
            cGenere.SelectedIndex = 0;
        }

        private void formRegistrazione_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
                // INIZIALIZZAZIONE DEI CAMPI VUOTI SULLE COMBOBOX //
                InizializzaCampoVuotoComboBox(cmbGenerepreferito, cmbCitta);
                // VISUALIZZAZIONE DEI CAMPI DEL GENERE PREFERITO
                cmbGenerepreferito.DataSource = RitornaGeneri();
                cmbGenerepreferito.ValueMember = "nomeGenere";
                cmbGenerepreferito.DisplayMember = "nomeGenere";
                // VISUALIZZAZIONE DEI CAMPI DEL GENERE PREFERITO //
                cmbCitta.DataSource = RitornaCitta();
                cmbCitta.ValueMember = "NomeCitta";
                cmbCitta.DisplayMember = "NomeCitta";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        // FUNZIONE CHE RITORNA I GENERI //
        public DataTable RitornaGeneri()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM Genere";
            cmd = new SqlCommand(sql,connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // FUNZIONE CHE RITORNA LE CITTA // 
        public DataTable RitornaCitta()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM Citta";
            cmd = new SqlCommand(sql, connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // FUNZIONE CHE RITORNA TRUE / FALSE SE L'UTENTE E GIA REGISTRATO //

        public bool VerificaEmail(string email)
        {
            bool check;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Utenti WHERE Utenti.emaiL=@email", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = email;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            if (tb.Rows.Count >= 1)
                check = true;

            else
                check = false;

            return check;
        }

        // FUNZIONE CHE INSERISCE L'UTENTE //

        public bool RegistraUtente(Utenti ut)
        {
            bool check = true;
            cmd = new SqlCommand("INSERT INTO utenti(cognome,nome,email,password,IdCitta,IdGenere,IsAdministrator) VALUES (@cognome,@nome,@email,@password,@idcitta,@idgenere,@isadministrator)", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cognome", SqlDbType.VarChar, 255).Value = ut.cognome;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 255).Value = ut.nome;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = ut.password;
            cmd.Parameters.Add("@idcitta", SqlDbType.VarChar, 255).Value = ut.idCitta;
            cmd.Parameters.Add("@idgenere", SqlDbType.VarChar, 255).Value = ut.idGenere;
            cmd.Parameters.Add("@isadministrator", SqlDbType.VarChar, 255).Value = ut.isAdministrator;

            int x = cmd.ExecuteNonQuery();
            if (x == 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            try
            {
                SvuotaDati(txtCognome, txtNome, txtEmail, txtPassword, txtConfermapassword,cmbCitta,cmbGenerepreferito);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'annulamento dei dati dei controlli: " + ex.Message);
            }
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCognome.Text != "" && txtNome.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtConfermapassword.Text != "")
                {
                    if (txtPassword.TextLength > 4 && txtConfermapassword.TextLength > 4)
                    {
                        if (txtPassword.Text == txtConfermapassword.Text)
                        {
                            if (checkEmail)
                            {

                                if (!VerificaEmail(txtEmail.Text))
                                {
                                    MessageBox.Show("Email non presente");
                                    // CONTINUO REGISTRAZIONE //
                                    //MessageBox.Show(cmbGenerePreferito.SelectedIndex.ToString());
                                    //MessageBox.Show(cmbGenerePreferito.SelectedValue.ToString());
                                    Utenti utente = new Utenti();
                                    utente.cognome = txtCognome.Text;
                                    utente.nome = txtNome.Text;
                                    utente.email = txtEmail.Text;
                                    utente.password = txtPassword.Text;
                                    utente.idGenere = cmbGenerepreferito.SelectedIndex + 1;
                                    utente.idCitta = cmbCitta.SelectedIndex + 1;
                                    utente.isAdministrator = 0;
                                    if (RegistraUtente(utente))
                                    {
                                        MessageBox.Show("Utente registrato correttamente");
                                        SvuotaDati(txtCognome, txtNome, txtEmail, txtPassword, txtConfermapassword, cmbCitta, cmbGenerepreferito);
                                        // REINDIRIZZAMENTO FORM LOGIN //
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Email presente");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email non è del formato corretto");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Le due password non coincidono");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lunghezza password non valida la password deve essere lunga dai 4 caratteri in poi");
                    }

                }
                else
                {
                    MessageBox.Show("Campi vuoti");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel registrare i dati utente: " + ex.Message);
            }
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void formRegistrazione_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void formRegistrazione_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            Regex reg = new Regex(pattern,RegexOptions.None);
            if (reg.IsMatch(Convert.ToString(txtEmail.Text)))
            {
                checkEmail = true;
            }
            else
            {
                checkEmail = false;

            }
        }
    }
}
