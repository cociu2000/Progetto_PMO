
namespace GestioneBiblioteca
{
    partial class formListaUtenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formListaUtenti));
            this.lblGestioneUtenteTitle = new System.Windows.Forms.Label();
            this.dgvListaUtenti = new System.Windows.Forms.DataGridView();
            this.tabControlGestioneUtente = new System.Windows.Forms.TabPage();
            this.btnGestioneUtenteAnnulla = new System.Windows.Forms.Button();
            this.btnGestioneUtenteEliminaUtente = new System.Windows.Forms.Button();
            this.txtGestioneUtenteDeleteId = new System.Windows.Forms.TextBox();
            this.lblGestioneUtenteEliminaID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtGestioneUtenteModificaEmail = new System.Windows.Forms.TextBox();
            this.txtGestioneUtenteModificaCognome = new System.Windows.Forms.TextBox();
            this.txtGestioneUtenteModificaNome = new System.Windows.Forms.TextBox();
            this.lblGestioneUtenteModificaUtentEmail = new System.Windows.Forms.Label();
            this.lblGestioneUtenteModificaUtenteCognome = new System.Windows.Forms.Label();
            this.lblGestioneUtenteModificaUtenteNome = new System.Windows.Forms.Label();
            this.lblGestioneUtenteModificaUtenteIDUtente = new System.Windows.Forms.Label();
            this.btnAnnullaUpdateUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.txtGestioneUtenteModificaIDUtente = new System.Windows.Forms.TextBox();
            this.lblGestioneUtenteModificaIDUtente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUtenti)).BeginInit();
            this.tabControlGestioneUtente.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestioneUtenteTitle
            // 
            this.lblGestioneUtenteTitle.AutoSize = true;
            this.lblGestioneUtenteTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteTitle.ForeColor = System.Drawing.Color.Black;
            this.lblGestioneUtenteTitle.Location = new System.Drawing.Point(469, 9);
            this.lblGestioneUtenteTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestioneUtenteTitle.Name = "lblGestioneUtenteTitle";
            this.lblGestioneUtenteTitle.Size = new System.Drawing.Size(133, 28);
            this.lblGestioneUtenteTitle.TabIndex = 20;
            this.lblGestioneUtenteTitle.Text = "Benvenuto";
            // 
            // dgvListaUtenti
            // 
            this.dgvListaUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUtenti.Location = new System.Drawing.Point(28, 63);
            this.dgvListaUtenti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaUtenti.Name = "dgvListaUtenti";
            this.dgvListaUtenti.RowHeadersWidth = 51;
            this.dgvListaUtenti.Size = new System.Drawing.Size(1019, 278);
            this.dgvListaUtenti.TabIndex = 21;
            // 
            // tabControlGestioneUtente
            // 
            this.tabControlGestioneUtente.Controls.Add(this.btnGestioneUtenteAnnulla);
            this.tabControlGestioneUtente.Controls.Add(this.btnGestioneUtenteEliminaUtente);
            this.tabControlGestioneUtente.Controls.Add(this.txtGestioneUtenteDeleteId);
            this.tabControlGestioneUtente.Controls.Add(this.lblGestioneUtenteEliminaID);
            this.tabControlGestioneUtente.Location = new System.Drawing.Point(4, 30);
            this.tabControlGestioneUtente.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlGestioneUtente.Name = "tabControlGestioneUtente";
            this.tabControlGestioneUtente.Padding = new System.Windows.Forms.Padding(4);
            this.tabControlGestioneUtente.Size = new System.Drawing.Size(1015, 175);
            this.tabControlGestioneUtente.TabIndex = 0;
            this.tabControlGestioneUtente.Text = "Elimina Utente";
            this.tabControlGestioneUtente.UseVisualStyleBackColor = true;
            // 
            // btnGestioneUtenteAnnulla
            // 
            this.btnGestioneUtenteAnnulla.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneUtenteAnnulla.Location = new System.Drawing.Point(160, 83);
            this.btnGestioneUtenteAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestioneUtenteAnnulla.Name = "btnGestioneUtenteAnnulla";
            this.btnGestioneUtenteAnnulla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGestioneUtenteAnnulla.Size = new System.Drawing.Size(115, 50);
            this.btnGestioneUtenteAnnulla.TabIndex = 25;
            this.btnGestioneUtenteAnnulla.Text = "Annulla";
            this.btnGestioneUtenteAnnulla.UseVisualStyleBackColor = true;
            this.btnGestioneUtenteAnnulla.Click += new System.EventHandler(this.btnGestioneUtenteAnnulla_Click);
            // 
            // btnGestioneUtenteEliminaUtente
            // 
            this.btnGestioneUtenteEliminaUtente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneUtenteEliminaUtente.Location = new System.Drawing.Point(37, 83);
            this.btnGestioneUtenteEliminaUtente.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestioneUtenteEliminaUtente.Name = "btnGestioneUtenteEliminaUtente";
            this.btnGestioneUtenteEliminaUtente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGestioneUtenteEliminaUtente.Size = new System.Drawing.Size(115, 50);
            this.btnGestioneUtenteEliminaUtente.TabIndex = 24;
            this.btnGestioneUtenteEliminaUtente.Text = "Elimina";
            this.btnGestioneUtenteEliminaUtente.UseVisualStyleBackColor = true;
            this.btnGestioneUtenteEliminaUtente.Click += new System.EventHandler(this.btnGestioneUtenteEliminaUtente_Click);
            // 
            // txtGestioneUtenteDeleteId
            // 
            this.txtGestioneUtenteDeleteId.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteDeleteId.Location = new System.Drawing.Point(129, 28);
            this.txtGestioneUtenteDeleteId.Margin = new System.Windows.Forms.Padding(4);
            this.txtGestioneUtenteDeleteId.Name = "txtGestioneUtenteDeleteId";
            this.txtGestioneUtenteDeleteId.Size = new System.Drawing.Size(143, 27);
            this.txtGestioneUtenteDeleteId.TabIndex = 23;
            // 
            // lblGestioneUtenteEliminaID
            // 
            this.lblGestioneUtenteEliminaID.AutoSize = true;
            this.lblGestioneUtenteEliminaID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteEliminaID.Location = new System.Drawing.Point(33, 32);
            this.lblGestioneUtenteEliminaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestioneUtenteEliminaID.Name = "lblGestioneUtenteEliminaID";
            this.lblGestioneUtenteEliminaID.Size = new System.Drawing.Size(89, 21);
            this.lblGestioneUtenteEliminaID.TabIndex = 22;
            this.lblGestioneUtenteEliminaID.Text = "Id utente:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabControlGestioneUtente);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(24, 362);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 209);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtGestioneUtenteModificaEmail);
            this.tabPage2.Controls.Add(this.txtGestioneUtenteModificaCognome);
            this.tabPage2.Controls.Add(this.txtGestioneUtenteModificaNome);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaUtentEmail);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaUtenteCognome);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaUtenteNome);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaUtenteIDUtente);
            this.tabPage2.Controls.Add(this.btnAnnullaUpdateUser);
            this.tabPage2.Controls.Add(this.btnUpdateUser);
            this.tabPage2.Controls.Add(this.txtGestioneUtenteModificaIDUtente);
            this.tabPage2.Controls.Add(this.lblGestioneUtenteModificaIDUtente);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1015, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modifica Utente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGestioneUtenteModificaEmail
            // 
            this.txtGestioneUtenteModificaEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteModificaEmail.Location = new System.Drawing.Point(430, 35);
            this.txtGestioneUtenteModificaEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtGestioneUtenteModificaEmail.Name = "txtGestioneUtenteModificaEmail";
            this.txtGestioneUtenteModificaEmail.Size = new System.Drawing.Size(143, 27);
            this.txtGestioneUtenteModificaEmail.TabIndex = 34;
            // 
            // txtGestioneUtenteModificaCognome
            // 
            this.txtGestioneUtenteModificaCognome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteModificaCognome.Location = new System.Drawing.Point(129, 116);
            this.txtGestioneUtenteModificaCognome.Margin = new System.Windows.Forms.Padding(4);
            this.txtGestioneUtenteModificaCognome.Name = "txtGestioneUtenteModificaCognome";
            this.txtGestioneUtenteModificaCognome.Size = new System.Drawing.Size(143, 27);
            this.txtGestioneUtenteModificaCognome.TabIndex = 33;
            // 
            // txtGestioneUtenteModificaNome
            // 
            this.txtGestioneUtenteModificaNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteModificaNome.Location = new System.Drawing.Point(129, 71);
            this.txtGestioneUtenteModificaNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtGestioneUtenteModificaNome.Name = "txtGestioneUtenteModificaNome";
            this.txtGestioneUtenteModificaNome.Size = new System.Drawing.Size(143, 27);
            this.txtGestioneUtenteModificaNome.TabIndex = 32;
            // 
            // lblGestioneUtenteModificaUtentEmail
            // 
            this.lblGestioneUtenteModificaUtentEmail.AutoSize = true;
            this.lblGestioneUtenteModificaUtentEmail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaUtentEmail.Location = new System.Drawing.Point(333, 35);
            this.lblGestioneUtenteModificaUtentEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestioneUtenteModificaUtentEmail.Name = "lblGestioneUtenteModificaUtentEmail";
            this.lblGestioneUtenteModificaUtentEmail.Size = new System.Drawing.Size(56, 21);
            this.lblGestioneUtenteModificaUtentEmail.TabIndex = 31;
            this.lblGestioneUtenteModificaUtentEmail.Text = "Email";
            this.lblGestioneUtenteModificaUtentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGestioneUtenteModificaUtenteCognome
            // 
            this.lblGestioneUtenteModificaUtenteCognome.AutoSize = true;
            this.lblGestioneUtenteModificaUtenteCognome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaUtenteCognome.Location = new System.Drawing.Point(33, 108);
            this.lblGestioneUtenteModificaUtenteCognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestioneUtenteModificaUtenteCognome.Name = "lblGestioneUtenteModificaUtenteCognome";
            this.lblGestioneUtenteModificaUtenteCognome.Size = new System.Drawing.Size(88, 21);
            this.lblGestioneUtenteModificaUtenteCognome.TabIndex = 30;
            this.lblGestioneUtenteModificaUtenteCognome.Text = "Cognome:";
            // 
            // lblGestioneUtenteModificaUtenteNome
            // 
            this.lblGestioneUtenteModificaUtenteNome.AutoSize = true;
            this.lblGestioneUtenteModificaUtenteNome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaUtenteNome.Location = new System.Drawing.Point(59, 71);
            this.lblGestioneUtenteModificaUtenteNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestioneUtenteModificaUtenteNome.Name = "lblGestioneUtenteModificaUtenteNome";
            this.lblGestioneUtenteModificaUtenteNome.Size = new System.Drawing.Size(62, 21);
            this.lblGestioneUtenteModificaUtenteNome.TabIndex = 29;
            this.lblGestioneUtenteModificaUtenteNome.Text = "Nome:";
            // 
            // lblGestioneUtenteModificaUtenteIDUtente
            // 
            this.lblGestioneUtenteModificaUtenteIDUtente.AutoSize = true;
            this.lblGestioneUtenteModificaUtenteIDUtente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaUtenteIDUtente.Location = new System.Drawing.Point(33, 30);
            this.lblGestioneUtenteModificaUtenteIDUtente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestioneUtenteModificaUtenteIDUtente.Name = "lblGestioneUtenteModificaUtenteIDUtente";
            this.lblGestioneUtenteModificaUtenteIDUtente.Size = new System.Drawing.Size(89, 21);
            this.lblGestioneUtenteModificaUtenteIDUtente.TabIndex = 28;
            this.lblGestioneUtenteModificaUtenteIDUtente.Text = "Id utente:";
            // 
            // btnAnnullaUpdateUser
            // 
            this.btnAnnullaUpdateUser.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaUpdateUser.Location = new System.Drawing.Point(459, 79);
            this.btnAnnullaUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnullaUpdateUser.Name = "btnAnnullaUpdateUser";
            this.btnAnnullaUpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnnullaUpdateUser.Size = new System.Drawing.Size(115, 50);
            this.btnAnnullaUpdateUser.TabIndex = 27;
            this.btnAnnullaUpdateUser.Text = "Annulla";
            this.btnAnnullaUpdateUser.UseVisualStyleBackColor = true;
            this.btnAnnullaUpdateUser.Click += new System.EventHandler(this.btnAnnullaUpdateUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(337, 79);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateUser.Size = new System.Drawing.Size(115, 50);
            this.btnUpdateUser.TabIndex = 26;
            this.btnUpdateUser.Text = "Modifica";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // txtGestioneUtenteModificaIDUtente
            // 
            this.txtGestioneUtenteModificaIDUtente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneUtenteModificaIDUtente.Location = new System.Drawing.Point(129, 26);
            this.txtGestioneUtenteModificaIDUtente.Margin = new System.Windows.Forms.Padding(4);
            this.txtGestioneUtenteModificaIDUtente.Name = "txtGestioneUtenteModificaIDUtente";
            this.txtGestioneUtenteModificaIDUtente.ReadOnly = true;
            this.txtGestioneUtenteModificaIDUtente.Size = new System.Drawing.Size(143, 27);
            this.txtGestioneUtenteModificaIDUtente.TabIndex = 25;
            // 
            // lblGestioneUtenteModificaIDUtente
            // 
            this.lblGestioneUtenteModificaIDUtente.AutoSize = true;
            this.lblGestioneUtenteModificaIDUtente.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneUtenteModificaIDUtente.Location = new System.Drawing.Point(33, 30);
            this.lblGestioneUtenteModificaIDUtente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestioneUtenteModificaIDUtente.Name = "lblGestioneUtenteModificaIDUtente";
            this.lblGestioneUtenteModificaIDUtente.Size = new System.Drawing.Size(0, 21);
            this.lblGestioneUtenteModificaIDUtente.TabIndex = 24;
            // 
            // formListaUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 589);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvListaUtenti);
            this.Controls.Add(this.lblGestioneUtenteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formListaUtenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Utenti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formListaUtenti_FormClosed);
            this.Load += new System.EventHandler(this.formListaUtenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUtenti)).EndInit();
            this.tabControlGestioneUtente.ResumeLayout(false);
            this.tabControlGestioneUtente.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGestioneUtenteTitle;
        private System.Windows.Forms.DataGridView dgvListaUtenti;
        private System.Windows.Forms.TabPage tabControlGestioneUtente;
        private System.Windows.Forms.Button btnGestioneUtenteAnnulla;
        private System.Windows.Forms.Button btnGestioneUtenteEliminaUtente;
        private System.Windows.Forms.TextBox txtGestioneUtenteDeleteId;
        private System.Windows.Forms.Label lblGestioneUtenteEliminaID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtGestioneUtenteModificaEmail;
        private System.Windows.Forms.TextBox txtGestioneUtenteModificaCognome;
        private System.Windows.Forms.TextBox txtGestioneUtenteModificaNome;
        private System.Windows.Forms.Label lblGestioneUtenteModificaUtentEmail;
        private System.Windows.Forms.Label lblGestioneUtenteModificaUtenteCognome;
        private System.Windows.Forms.Label lblGestioneUtenteModificaUtenteNome;
        private System.Windows.Forms.Label lblGestioneUtenteModificaUtenteIDUtente;
        private System.Windows.Forms.Button btnAnnullaUpdateUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TextBox txtGestioneUtenteModificaIDUtente;
        private System.Windows.Forms.Label lblGestioneUtenteModificaIDUtente;
    }
}