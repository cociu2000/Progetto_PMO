
namespace GestioneBiblioteca
{
    partial class formGestioneLibri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGestioneLibri));
            this.txtGestioneLibriModificaLibri = new System.Windows.Forms.TextBox();
            this.txtGestioneLibriNuoviLibri = new System.Windows.Forms.TextBox();
            this.btnGestioneLibriAnnulla = new System.Windows.Forms.Button();
            this.btnGestioneLibri = new System.Windows.Forms.Button();
            this.lblGestioneLibriUpdateLibri = new System.Windows.Forms.Label();
            this.lblGestioneLibriNewLibri = new System.Windows.Forms.Label();
            this.chkGestioneLibriCreate = new System.Windows.Forms.CheckBox();
            this.chkGestioneLibriUpdate = new System.Windows.Forms.CheckBox();
            this.chkGestioneLibriDelete = new System.Windows.Forms.CheckBox();
            this.lblGestioneLibriChoose = new System.Windows.Forms.Label();
            this.cmbGestioneLibriElencoLibri = new System.Windows.Forms.ComboBox();
            this.lblGestioneLibriTitle = new System.Windows.Forms.Label();
            this.lblGestioneLibriElencoLibri = new System.Windows.Forms.Label();
            this.cmbGestioneLibriElencoGenere = new System.Windows.Forms.ComboBox();
            this.lblGestioneLibriElencoGenere = new System.Windows.Forms.Label();
            this.lblGestioneLibriDataUscita = new System.Windows.Forms.Label();
            this.dtpDataUscita = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtGestioneLibriModificaLibri
            // 
            this.txtGestioneLibriModificaLibri.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneLibriModificaLibri.Location = new System.Drawing.Point(450, 489);
            this.txtGestioneLibriModificaLibri.Name = "txtGestioneLibriModificaLibri";
            this.txtGestioneLibriModificaLibri.Size = new System.Drawing.Size(291, 28);
            this.txtGestioneLibriModificaLibri.TabIndex = 43;
            // 
            // txtGestioneLibriNuoviLibri
            // 
            this.txtGestioneLibriNuoviLibri.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneLibriNuoviLibri.Location = new System.Drawing.Point(450, 431);
            this.txtGestioneLibriNuoviLibri.Name = "txtGestioneLibriNuoviLibri";
            this.txtGestioneLibriNuoviLibri.Size = new System.Drawing.Size(291, 28);
            this.txtGestioneLibriNuoviLibri.TabIndex = 42;
            // 
            // btnGestioneLibriAnnulla
            // 
            this.btnGestioneLibriAnnulla.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGestioneLibriAnnulla.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneLibriAnnulla.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGestioneLibriAnnulla.Location = new System.Drawing.Point(450, 564);
            this.btnGestioneLibriAnnulla.Name = "btnGestioneLibriAnnulla";
            this.btnGestioneLibriAnnulla.Size = new System.Drawing.Size(139, 69);
            this.btnGestioneLibriAnnulla.TabIndex = 41;
            this.btnGestioneLibriAnnulla.Text = "ANNULLA";
            this.btnGestioneLibriAnnulla.UseVisualStyleBackColor = false;
            this.btnGestioneLibriAnnulla.Click += new System.EventHandler(this.btnGestioneLibriAnnulla_Click);
            // 
            // btnGestioneLibri
            // 
            this.btnGestioneLibri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGestioneLibri.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneLibri.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGestioneLibri.Location = new System.Drawing.Point(135, 553);
            this.btnGestioneLibri.Name = "btnGestioneLibri";
            this.btnGestioneLibri.Size = new System.Drawing.Size(260, 91);
            this.btnGestioneLibri.TabIndex = 40;
            this.btnGestioneLibri.Text = "SALVA";
            this.btnGestioneLibri.UseVisualStyleBackColor = false;
            this.btnGestioneLibri.Click += new System.EventHandler(this.btnGestioneLibri_Click);
            // 
            // lblGestioneLibriUpdateLibri
            // 
            this.lblGestioneLibriUpdateLibri.AutoSize = true;
            this.lblGestioneLibriUpdateLibri.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneLibriUpdateLibri.Location = new System.Drawing.Point(39, 488);
            this.lblGestioneLibriUpdateLibri.Name = "lblGestioneLibriUpdateLibri";
            this.lblGestioneLibriUpdateLibri.Size = new System.Drawing.Size(378, 23);
            this.lblGestioneLibriUpdateLibri.TabIndex = 39;
            this.lblGestioneLibriUpdateLibri.Text = "Nome nuovo del libro da modificare:";
            // 
            // lblGestioneLibriNewLibri
            // 
            this.lblGestioneLibriNewLibri.AutoSize = true;
            this.lblGestioneLibriNewLibri.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneLibriNewLibri.Location = new System.Drawing.Point(39, 430);
            this.lblGestioneLibriNewLibri.Name = "lblGestioneLibriNewLibri";
            this.lblGestioneLibriNewLibri.Size = new System.Drawing.Size(233, 23);
            this.lblGestioneLibriNewLibri.TabIndex = 38;
            this.lblGestioneLibriNewLibri.Text = "Nome del nuovo libro:";
            // 
            // chkGestioneLibriCreate
            // 
            this.chkGestioneLibriCreate.AutoSize = true;
            this.chkGestioneLibriCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGestioneLibriCreate.Location = new System.Drawing.Point(532, 186);
            this.chkGestioneLibriCreate.Name = "chkGestioneLibriCreate";
            this.chkGestioneLibriCreate.Size = new System.Drawing.Size(195, 27);
            this.chkGestioneLibriCreate.TabIndex = 37;
            this.chkGestioneLibriCreate.Text = "Crea nuovo libro";
            this.chkGestioneLibriCreate.UseVisualStyleBackColor = true;
            this.chkGestioneLibriCreate.CheckedChanged += new System.EventHandler(this.chkGestioneLibriCreate_CheckedChanged);
            // 
            // chkGestioneLibriUpdate
            // 
            this.chkGestioneLibriUpdate.AutoSize = true;
            this.chkGestioneLibriUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGestioneLibriUpdate.Location = new System.Drawing.Point(381, 185);
            this.chkGestioneLibriUpdate.Name = "chkGestioneLibriUpdate";
            this.chkGestioneLibriUpdate.Size = new System.Drawing.Size(118, 27);
            this.chkGestioneLibriUpdate.TabIndex = 36;
            this.chkGestioneLibriUpdate.Text = "Modifica";
            this.chkGestioneLibriUpdate.UseVisualStyleBackColor = true;
            this.chkGestioneLibriUpdate.CheckedChanged += new System.EventHandler(this.chkGestioneLibriUpdate_CheckedChanged);
            // 
            // chkGestioneLibriDelete
            // 
            this.chkGestioneLibriDelete.AutoSize = true;
            this.chkGestioneLibriDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGestioneLibriDelete.Location = new System.Drawing.Point(255, 186);
            this.chkGestioneLibriDelete.Name = "chkGestioneLibriDelete";
            this.chkGestioneLibriDelete.Size = new System.Drawing.Size(101, 27);
            this.chkGestioneLibriDelete.TabIndex = 35;
            this.chkGestioneLibriDelete.Text = "Elimina";
            this.chkGestioneLibriDelete.UseVisualStyleBackColor = true;
            this.chkGestioneLibriDelete.CheckedChanged += new System.EventHandler(this.chkGestioneLibriDelete_CheckedChanged);
            // 
            // lblGestioneLibriChoose
            // 
            this.lblGestioneLibriChoose.AutoSize = true;
            this.lblGestioneLibriChoose.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneLibriChoose.Location = new System.Drawing.Point(62, 178);
            this.lblGestioneLibriChoose.Name = "lblGestioneLibriChoose";
            this.lblGestioneLibriChoose.Size = new System.Drawing.Size(106, 34);
            this.lblGestioneLibriChoose.TabIndex = 34;
            this.lblGestioneLibriChoose.Text = "Scegli:";
            // 
            // cmbGestioneLibriElencoLibri
            // 
            this.cmbGestioneLibriElencoLibri.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGestioneLibriElencoLibri.FormattingEnabled = true;
            this.cmbGestioneLibriElencoLibri.Location = new System.Drawing.Point(369, 116);
            this.cmbGestioneLibriElencoLibri.Name = "cmbGestioneLibriElencoLibri";
            this.cmbGestioneLibriElencoLibri.Size = new System.Drawing.Size(267, 26);
            this.cmbGestioneLibriElencoLibri.TabIndex = 33;
            // 
            // lblGestioneLibriTitle
            // 
            this.lblGestioneLibriTitle.AutoSize = true;
            this.lblGestioneLibriTitle.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneLibriTitle.Location = new System.Drawing.Point(234, 9);
            this.lblGestioneLibriTitle.Name = "lblGestioneLibriTitle";
            this.lblGestioneLibriTitle.Size = new System.Drawing.Size(319, 47);
            this.lblGestioneLibriTitle.TabIndex = 32;
            this.lblGestioneLibriTitle.Text = "Area modifica libri";
            // 
            // lblGestioneLibriElencoLibri
            // 
            this.lblGestioneLibriElencoLibri.AutoSize = true;
            this.lblGestioneLibriElencoLibri.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneLibriElencoLibri.Location = new System.Drawing.Point(131, 117);
            this.lblGestioneLibriElencoLibri.Name = "lblGestioneLibriElencoLibri";
            this.lblGestioneLibriElencoLibri.Size = new System.Drawing.Size(163, 23);
            this.lblGestioneLibriElencoLibri.TabIndex = 31;
            this.lblGestioneLibriElencoLibri.Text = "Elenco dei Libri:";
            // 
            // cmbGestioneLibriElencoGenere
            // 
            this.cmbGestioneLibriElencoGenere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGestioneLibriElencoGenere.FormattingEnabled = true;
            this.cmbGestioneLibriElencoGenere.Location = new System.Drawing.Point(362, 271);
            this.cmbGestioneLibriElencoGenere.Name = "cmbGestioneLibriElencoGenere";
            this.cmbGestioneLibriElencoGenere.Size = new System.Drawing.Size(324, 29);
            this.cmbGestioneLibriElencoGenere.TabIndex = 45;
            this.cmbGestioneLibriElencoGenere.SelectedIndexChanged += new System.EventHandler(this.cmbGestioneLibriElencoGenere_SelectedIndexChanged);
            // 
            // lblGestioneLibriElencoGenere
            // 
            this.lblGestioneLibriElencoGenere.AutoSize = true;
            this.lblGestioneLibriElencoGenere.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneLibriElencoGenere.Location = new System.Drawing.Point(124, 272);
            this.lblGestioneLibriElencoGenere.Name = "lblGestioneLibriElencoGenere";
            this.lblGestioneLibriElencoGenere.Size = new System.Drawing.Size(191, 23);
            this.lblGestioneLibriElencoGenere.TabIndex = 44;
            this.lblGestioneLibriElencoGenere.Text = "Elenco dei Generi:";
            // 
            // lblGestioneLibriDataUscita
            // 
            this.lblGestioneLibriDataUscita.AutoSize = true;
            this.lblGestioneLibriDataUscita.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneLibriDataUscita.Location = new System.Drawing.Point(131, 331);
            this.lblGestioneLibriDataUscita.Name = "lblGestioneLibriDataUscita";
            this.lblGestioneLibriDataUscita.Size = new System.Drawing.Size(151, 23);
            this.lblGestioneLibriDataUscita.TabIndex = 46;
            this.lblGestioneLibriDataUscita.Text = "Data di Uscita:";
            // 
            // dtpDataUscita
            // 
            this.dtpDataUscita.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataUscita.Location = new System.Drawing.Point(362, 330);
            this.dtpDataUscita.Name = "dtpDataUscita";
            this.dtpDataUscita.Size = new System.Drawing.Size(324, 28);
            this.dtpDataUscita.TabIndex = 47;
            // 
            // formGestioneLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 667);
            this.Controls.Add(this.dtpDataUscita);
            this.Controls.Add(this.lblGestioneLibriDataUscita);
            this.Controls.Add(this.cmbGestioneLibriElencoGenere);
            this.Controls.Add(this.lblGestioneLibriElencoGenere);
            this.Controls.Add(this.txtGestioneLibriModificaLibri);
            this.Controls.Add(this.txtGestioneLibriNuoviLibri);
            this.Controls.Add(this.btnGestioneLibriAnnulla);
            this.Controls.Add(this.btnGestioneLibri);
            this.Controls.Add(this.lblGestioneLibriUpdateLibri);
            this.Controls.Add(this.lblGestioneLibriNewLibri);
            this.Controls.Add(this.chkGestioneLibriCreate);
            this.Controls.Add(this.chkGestioneLibriUpdate);
            this.Controls.Add(this.chkGestioneLibriDelete);
            this.Controls.Add(this.lblGestioneLibriChoose);
            this.Controls.Add(this.cmbGestioneLibriElencoLibri);
            this.Controls.Add(this.lblGestioneLibriTitle);
            this.Controls.Add(this.lblGestioneLibriElencoLibri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formGestioneLibri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Libri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formGestioneLibri_FormClosed);
            this.Load += new System.EventHandler(this.formGestioneLibri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGestioneLibriModificaLibri;
        private System.Windows.Forms.TextBox txtGestioneLibriNuoviLibri;
        private System.Windows.Forms.Button btnGestioneLibriAnnulla;
        private System.Windows.Forms.Button btnGestioneLibri;
        private System.Windows.Forms.Label lblGestioneLibriUpdateLibri;
        private System.Windows.Forms.Label lblGestioneLibriNewLibri;
        private System.Windows.Forms.CheckBox chkGestioneLibriCreate;
        private System.Windows.Forms.CheckBox chkGestioneLibriUpdate;
        private System.Windows.Forms.CheckBox chkGestioneLibriDelete;
        private System.Windows.Forms.Label lblGestioneLibriChoose;
        private System.Windows.Forms.ComboBox cmbGestioneLibriElencoLibri;
        private System.Windows.Forms.Label lblGestioneLibriTitle;
        private System.Windows.Forms.Label lblGestioneLibriElencoLibri;
        private System.Windows.Forms.ComboBox cmbGestioneLibriElencoGenere;
        private System.Windows.Forms.Label lblGestioneLibriElencoGenere;
        private System.Windows.Forms.Label lblGestioneLibriDataUscita;
        private System.Windows.Forms.DateTimePicker dtpDataUscita;
    }
}