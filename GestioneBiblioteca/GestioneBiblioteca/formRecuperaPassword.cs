using GestioneBiblioteca.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneBiblioteca
{
    public partial class formRecuperaPassword : Form
    {
        // INIZIALIZZAZIONE DELLE VARIABILI PUBBLICHE //
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;
        public bool checkEmail;


        public formRecuperaPassword()
        {
            InitializeComponent();
        }

        private void formRecuperaPassword_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        // SVUOTAMENTO DELLE CASELLE DI TESTO //
        public void SvuotaDati(TextBox txt1, TextBox txt2, TextBox txt3)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }


        // VERIFICA DELL'EMAIL //
        public bool ControlloEmail(Utenti ut)
        {
            bool check=true;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT * FROM utenti WHERE utenti.email=@email", connection);
            cmd.Connection = connection;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            if (tb.Rows.Count == 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            return check;
        }

        // FUNZIONE CHE PERMETTE DI CAMBIARE LA PASSWORD //
        public bool CambiaPassword(Utenti ut)
        {
            bool check = true;
            cmd = new SqlCommand("UPDATE utenti SET utenti.password=@password WHERE utenti.email=@email", connection);
            cmd.Connection = connection;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = ut.password;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            int x = cmd.ExecuteNonQuery();
            if (x == 1) check = true; else check = false;
            return check;
        }

        private void btnCambiaPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != "" && txtPassword.Text != "" && txtConfermaPassword.Text!= "")
                {
                    if (txtPassword.TextLength > 4 && txtConfermaPassword.TextLength > 4)
                    {
                        if (txtPassword.Text == txtConfermaPassword.Text)
                        {
                            if (checkEmail)
                            {
                                Utenti utente = new Utenti();
                                utente.email = txtEmail.Text;
                                utente.password = txtPassword.Text;
                                if (!ControlloEmail(utente))
                                {
                                    MessageBox.Show("L'Email non è presente nel Database", "AVVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    if (CambiaPassword(utente))
                                    {
                                        MessageBox.Show("La password è stata cambiata correttamente", "AVVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        formLogin login = new formLogin();
                                        login.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Errore nel cambiare la password", "AVVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email non è del formato corretto");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Le password non coincidono", "AVVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lunghezza password non valida, la password deve essere lunga almeno 4 caratteri");
                    }
                }
                else
                {
                    MessageBox.Show("Alcuni cambi non sono stati inseriri", "AVVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel cambiamento della Password: " + ex.Message);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            SvuotaDati(txtEmail, txtPassword, txtConfermaPassword);
        }

        private void formRecuperaPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            Regex reg = new Regex(pattern, RegexOptions.None);
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
