
namespace GestioneBiblioteca
{
    partial class formGestioneGenere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGestioneGenere));
            this.lblGestioneGenereElencoGeneri = new System.Windows.Forms.Label();
            this.lblGestioneGenereTitle = new System.Windows.Forms.Label();
            this.cmbGestioneGenereElencoGeneri = new System.Windows.Forms.ComboBox();
            this.lblGestioneGenereChoose = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkCreate = new System.Windows.Forms.CheckBox();
            this.lblGestioneGenereNewGenere = new System.Windows.Forms.Label();
            this.lblGestioneGenereUpdateGenere = new System.Windows.Forms.Label();
            this.btnGestioneGenere = new System.Windows.Forms.Button();
            this.btnGestioneGenereAnnulla = new System.Windows.Forms.Button();
            this.txtGestioneGenereNuovoGenere = new System.Windows.Forms.TextBox();
            this.txtGestioneGenereModificaGenere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGestioneGenereElencoGeneri
            // 
            this.lblGestioneGenereElencoGeneri.AutoSize = true;
            this.lblGestioneGenereElencoGeneri.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneGenereElencoGeneri.Location = new System.Drawing.Point(156, 112);
            this.lblGestioneGenereElencoGeneri.Name = "lblGestioneGenereElencoGeneri";
            this.lblGestioneGenereElencoGeneri.Size = new System.Drawing.Size(192, 23);
            this.lblGestioneGenereElencoGeneri.TabIndex = 16;
            this.lblGestioneGenereElencoGeneri.Text = "Elenco dei generi:";
            // 
            // lblGestioneGenereTitle
            // 
            this.lblGestioneGenereTitle.AutoSize = true;
            this.lblGestioneGenereTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneGenereTitle.Location = new System.Drawing.Point(163, 21);
            this.lblGestioneGenereTitle.Name = "lblGestioneGenereTitle";
            this.lblGestioneGenereTitle.Size = new System.Drawing.Size(488, 28);
            this.lblGestioneGenereTitle.TabIndex = 17;
            this.lblGestioneGenereTitle.Text = "Questi sono tutti i generi dei libri presenti:";
            // 
            // cmbGestioneGenereElencoGeneri
            // 
            this.cmbGestioneGenereElencoGeneri.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGestioneGenereElencoGeneri.FormattingEnabled = true;
            this.cmbGestioneGenereElencoGeneri.Location = new System.Drawing.Point(402, 109);
            this.cmbGestioneGenereElencoGeneri.Name = "cmbGestioneGenereElencoGeneri";
            this.cmbGestioneGenereElencoGeneri.Size = new System.Drawing.Size(267, 26);
            this.cmbGestioneGenereElencoGeneri.TabIndex = 18;
            this.cmbGestioneGenereElencoGeneri.SelectedIndexChanged += new System.EventHandler(this.cmbGestioneGenereElencoGeneri_SelectedIndexChanged);
            // 
            // lblGestioneGenereChoose
            // 
            this.lblGestioneGenereChoose.AutoSize = true;
            this.lblGestioneGenereChoose.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneGenereChoose.Location = new System.Drawing.Point(49, 210);
            this.lblGestioneGenereChoose.Name = "lblGestioneGenereChoose";
            this.lblGestioneGenereChoose.Size = new System.Drawing.Size(90, 30);
            this.lblGestioneGenereChoose.TabIndex = 19;
            this.lblGestioneGenereChoose.Text = "Scegli:";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDelete.Location = new System.Drawing.Point(202, 209);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(101, 27);
            this.chkDelete.TabIndex = 20;
            this.chkDelete.Text = "Elimina";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdate.Location = new System.Drawing.Point(344, 212);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(118, 27);
            this.chkUpdate.TabIndex = 21;
            this.chkUpdate.Text = "Modifica";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // chkCreate
            // 
            this.chkCreate.AutoSize = true;
            this.chkCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreate.Location = new System.Drawing.Point(511, 209);
            this.chkCreate.Name = "chkCreate";
            this.chkCreate.Size = new System.Drawing.Size(223, 27);
            this.chkCreate.TabIndex = 22;
            this.chkCreate.Text = "Crea nuovo genere";
            this.chkCreate.UseVisualStyleBackColor = true;
            this.chkCreate.CheckedChanged += new System.EventHandler(this.chkCreate_CheckedChanged);
            // 
            // lblGestioneGenereNewGenere
            // 
            this.lblGestioneGenereNewGenere.AutoSize = true;
            this.lblGestioneGenereNewGenere.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneGenereNewGenere.Location = new System.Drawing.Point(30, 342);
            this.lblGestioneGenereNewGenere.Name = "lblGestioneGenereNewGenere";
            this.lblGestioneGenereNewGenere.Size = new System.Drawing.Size(302, 28);
            this.lblGestioneGenereNewGenere.TabIndex = 23;
            this.lblGestioneGenereNewGenere.Text = "Nome del nuovo genere:";
            // 
            // lblGestioneGenereUpdateGenere
            // 
            this.lblGestioneGenereUpdateGenere.AutoSize = true;
            this.lblGestioneGenereUpdateGenere.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneGenereUpdateGenere.Location = new System.Drawing.Point(30, 400);
            this.lblGestioneGenereUpdateGenere.Name = "lblGestioneGenereUpdateGenere";
            this.lblGestioneGenereUpdateGenere.Size = new System.Drawing.Size(475, 28);
            this.lblGestioneGenereUpdateGenere.TabIndex = 25;
            this.lblGestioneGenereUpdateGenere.Text = "Nome nuovo del genere da modificare:";
            // 
            // btnGestioneGenere
            // 
            this.btnGestioneGenere.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGestioneGenere.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneGenere.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGestioneGenere.Location = new System.Drawing.Point(160, 485);
            this.btnGestioneGenere.Name = "btnGestioneGenere";
            this.btnGestioneGenere.Size = new System.Drawing.Size(234, 114);
            this.btnGestioneGenere.TabIndex = 27;
            this.btnGestioneGenere.Text = "MODIFICA";
            this.btnGestioneGenere.UseVisualStyleBackColor = false;
            this.btnGestioneGenere.Click += new System.EventHandler(this.btnGestioneGenere_Click);
            // 
            // btnGestioneGenereAnnulla
            // 
            this.btnGestioneGenereAnnulla.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGestioneGenereAnnulla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneGenereAnnulla.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGestioneGenereAnnulla.Location = new System.Drawing.Point(444, 508);
            this.btnGestioneGenereAnnulla.Name = "btnGestioneGenereAnnulla";
            this.btnGestioneGenereAnnulla.Size = new System.Drawing.Size(207, 75);
            this.btnGestioneGenereAnnulla.TabIndex = 28;
            this.btnGestioneGenereAnnulla.Text = "ANNULLA";
            this.btnGestioneGenereAnnulla.UseVisualStyleBackColor = false;
            this.btnGestioneGenereAnnulla.Click += new System.EventHandler(this.btnGestioneGenereAnnulla_Click);
            // 
            // txtGestioneGenereNuovoGenere
            // 
            this.txtGestioneGenereNuovoGenere.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneGenereNuovoGenere.Location = new System.Drawing.Point(526, 339);
            this.txtGestioneGenereNuovoGenere.Name = "txtGestioneGenereNuovoGenere";
            this.txtGestioneGenereNuovoGenere.Size = new System.Drawing.Size(252, 36);
            this.txtGestioneGenereNuovoGenere.TabIndex = 29;
            // 
            // txtGestioneGenereModificaGenere
            // 
            this.txtGestioneGenereModificaGenere.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestioneGenereModificaGenere.Location = new System.Drawing.Point(526, 392);
            this.txtGestioneGenereModificaGenere.Name = "txtGestioneGenereModificaGenere";
            this.txtGestioneGenereModificaGenere.Size = new System.Drawing.Size(252, 36);
            this.txtGestioneGenereModificaGenere.TabIndex = 30;
            // 
            // formGestioneGenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 629);
            this.Controls.Add(this.txtGestioneGenereModificaGenere);
            this.Controls.Add(this.txtGestioneGenereNuovoGenere);
            this.Controls.Add(this.btnGestioneGenereAnnulla);
            this.Controls.Add(this.btnGestioneGenere);
            this.Controls.Add(this.lblGestioneGenereUpdateGenere);
            this.Controls.Add(this.lblGestioneGenereNewGenere);
            this.Controls.Add(this.chkCreate);
            this.Controls.Add(this.chkUpdate);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.lblGestioneGenereChoose);
            this.Controls.Add(this.cmbGestioneGenereElencoGeneri);
            this.Controls.Add(this.lblGestioneGenereTitle);
            this.Controls.Add(this.lblGestioneGenereElencoGeneri);
            this.Name = "formGestioneGenere";
            this.Text = "Area Gestione Genere";
            this.Load += new System.EventHandler(this.formGestioneGenere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestioneGenereElencoGeneri;
        private System.Windows.Forms.Label lblGestioneGenereTitle;
        private System.Windows.Forms.ComboBox cmbGestioneGenereElencoGeneri;
        private System.Windows.Forms.Label lblGestioneGenereChoose;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.CheckBox chkCreate;
        private System.Windows.Forms.Label lblGestioneGenereNewGenere;
        private System.Windows.Forms.Label lblGestioneGenereUpdateGenere;
        private System.Windows.Forms.Button btnGestioneGenere;
        private System.Windows.Forms.Button btnGestioneGenereAnnulla;
        private System.Windows.Forms.TextBox txtGestioneGenereNuovoGenere;
        private System.Windows.Forms.TextBox txtGestioneGenereModificaGenere;
    }
}