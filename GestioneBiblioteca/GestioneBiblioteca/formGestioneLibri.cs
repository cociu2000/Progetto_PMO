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
    public partial class formGestioneLibri : Form
    {
            // INIZIALIZZAZIONE DELLE VARIABILI //
            public string connectionString;
            public SqlConnection connection;
            public SqlCommand cmd;
            public int idLibro = 0;
            public int idGenere = 0;
            public formGestioneLibri()
            {
                InitializeComponent();
            }

            // FUNZIONE CHE SVUOTA I CAMPI //
            public void SvuotaDati(TextBox txt1, TextBox txt2, ComboBox cm1, CheckBox ch1, CheckBox ch2, CheckBox ch3)
            {
                txt1.Clear();
                txt2.Clear();
                cm1.SelectedIndex = 0;
                ch1.Checked = false;
                ch2.Checked = false;
                ch3.Checked = false;
            }

            // CARICAMENTO ELENCO LIBRI //
            public DataTable ElencoLibri()
            {
                DataTable tb = new DataTable();
                string sql = "SELECT * FROM Libro WHERE Libro.numeroCopie>0";
                cmd = new SqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                adp.Fill(tb);
                return tb;
            }

            // CARICAMENTO ELENCO GENERI //
            public DataTable ElencoGeneri()
            {
                DataTable tb = new DataTable();
                string sql = "SELECT * FROM Genere";
                cmd = new SqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                adp.Fill(tb);
                return tb;
            }


        private void btnGestioneLibriAnnulla_Click(object sender, EventArgs e)
        {
            SvuotaDati(txtGestioneLibriModificaLibri, txtGestioneLibriNuoviLibri, cmbGestioneLibriElencoLibri, chkGestioneLibriCreate, chkGestioneLibriDelete, chkGestioneLibriUpdate);
        }

        private void formGestioneLibri_Load(object sender, EventArgs e)
        {
            try
            {
                // CONNESSIONE DATABASE //
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\BibliotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
                // imposto i film nella combobox
                cmbGestioneLibriElencoLibri.DataSource = ElencoLibri();
                cmbGestioneLibriElencoLibri.DisplayMember = "titoloLibro";
                cmbGestioneLibriElencoLibri.ValueMember = "titoloLibro";
                chkGestioneLibriCreate.Checked = false;
                chkGestioneLibriDelete.Checked = false;
                chkGestioneLibriUpdate.Checked = false;
                cmbGestioneLibriElencoGenere.Enabled = false;
                dtpDataUscita.Enabled = false;
                cmbGestioneLibriElencoGenere.DataSource = ElencoGeneri();
                cmbGestioneLibriElencoGenere.DisplayMember = "nomeGenere";
                cmbGestioneLibriElencoGenere.ValueMember = "nomeGenere";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void formGestioneLibri_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void chkGestioneLibriDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGestioneLibriDelete.Checked)
            {
                txtGestioneLibriModificaLibri.ReadOnly = true;
                txtGestioneLibriNuoviLibri.ReadOnly = true;
            }
            else
            {
                txtGestioneLibriModificaLibri.ReadOnly = false;
                txtGestioneLibriNuoviLibri.ReadOnly = false;
            }
        }

        private void chkGestioneLibriUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGestioneLibriUpdate.Checked)
                txtGestioneLibriNuoviLibri.ReadOnly = true;
            else
                txtGestioneLibriNuoviLibri.ReadOnly = false;
        }

        private void chkGestioneLibriCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGestioneLibriCreate.Checked)
            {
                txtGestioneLibriNuoviLibri.ReadOnly = false;
                txtGestioneLibriModificaLibri.ReadOnly = true;
                cmbGestioneLibriElencoGenere.Enabled = true;
                dtpDataUscita.Enabled = true;
            }
            else
            {
                txtGestioneLibriNuoviLibri.ReadOnly = false;
                txtGestioneLibriModificaLibri.ReadOnly = false;
                cmbGestioneLibriElencoGenere.Enabled = false;
                dtpDataUscita.Enabled = false;
            }
        }

        private void btnGestioneLibri_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkGestioneLibriDelete.Checked == true)
                {
                    cmd = new SqlCommand("DELETE Libro FROM Libro WHERE Libro.idLibro=@id", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idLibro;
                    int x = cmd.ExecuteNonQuery();
                    MessageBox.Show("Libro rimosso correttamente");
                    if (ElencoLibri().Rows.Count > 0)
                    {
                        cmbGestioneLibriElencoLibri.DataSource = ElencoLibri();
                        cmbGestioneLibriElencoLibri.DisplayMember = "titoloLibro";
                        cmbGestioneLibriElencoLibri.ValueMember = "titoloLibro";
                    }
                    else { MessageBox.Show("Non ci sono libri da caricare"); }
                }

                if (chkGestioneLibriUpdate.Checked == true)
                {
                    cmd = new SqlCommand("Update Libro SET titoloLibro=@titoloLibro FROM Libro WHERE Libro.idLibro=@id", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@titoloLibro", SqlDbType.VarChar, 255).Value = txtGestioneLibriModificaLibri.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idLibro;
                    int x = cmd.ExecuteNonQuery();
                    MessageBox.Show("Libro modificato correttamente");
                    if (ElencoLibri().Rows.Count > 0)
                    {
                        cmbGestioneLibriElencoLibri.DataSource = ElencoLibri();
                        cmbGestioneLibriElencoLibri.DisplayMember = "titoloLibro";
                        cmbGestioneLibriElencoLibri.ValueMember = "titoloLibro";
                    }
                    else { MessageBox.Show("Non ci sono libri da caricare"); }
                }

                if (chkGestioneLibriCreate.Checked == true)
                {
                    cmd = new SqlCommand("SELECT titoloLibro FROM  Libro WHERE Libro.titoloLibro=@titolo", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@titolo", SqlDbType.VarChar, 255).Value = txtGestioneLibriNuoviLibri.Text;
                    int x = cmd.ExecuteNonQuery();
                    DataTable tb = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cmd;
                    adp.Fill(tb);
                    if (tb.Rows.Count > 0)
                    {
                        MessageBox.Show("Il libro che tenti di creare esiste gia");
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Libro (titoloLibro,idGenere,dataUscita) VALUES(@titolo,@idGenere,@datauscita)", connection);
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@titolo", SqlDbType.VarChar, 255).Value = txtGestioneLibriNuoviLibri.Text;
                        cmd.Parameters.Add("@idGenere", SqlDbType.Int).Value = idGenere;
                        cmd.Parameters.Add("@datauscita", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpDataUscita.Value.ToShortDateString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Film creato correttamente");
                        if (ElencoLibri().Rows.Count > 0)
                        {
                            cmbGestioneLibriElencoLibri.DataSource = ElencoLibri();
                            cmbGestioneLibriElencoLibri.DisplayMember = "titoloLibro";
                            cmbGestioneLibriElencoLibri.ValueMember = "titoloLibro";
                        }
                        else { MessageBox.Show("Non ci sono libri da caricare"); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'effettuare il crud sul libro: " + " " + ex.Message);
            }
        }

        private void cmbGestioneLibriElencoGenere_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // estraggo il numero del film in base al film selezionato dalla combobox
                string nomeGenere = cmbGestioneLibriElencoGenere.Text;
                cmd = new SqlCommand("SELECT idGenere FROM Genere WHERE Genere.nomeGenere=@nomeGenere", connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@nomeGenere", SqlDbType.VarChar, 255).Value = nomeGenere;
                int x = cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                SqlDataAdapter adpFilm = new SqlDataAdapter();
                adpFilm.SelectCommand = cmd;
                adpFilm.Fill(td);
                if (td.Rows.Count > 0)
                    idGenere = Convert.ToInt32(td.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel ricalco del codice id del genere:" + ex.Message);
            }
        }
    }
}
