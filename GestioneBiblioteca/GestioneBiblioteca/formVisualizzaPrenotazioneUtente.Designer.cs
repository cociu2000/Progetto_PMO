
namespace GestioneBiblioteca
{
    partial class formVisualizzaPrenotazioneUtente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVisualizzaPrenotazioneUtente));
            this.lblVisualizzaPrenotazioneUtenteTitle = new System.Windows.Forms.Label();
            this.dgvMostraPrenotazioni = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraPrenotazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisualizzaPrenotazioneUtenteTitle
            // 
            this.lblVisualizzaPrenotazioneUtenteTitle.AutoSize = true;
            this.lblVisualizzaPrenotazioneUtenteTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizzaPrenotazioneUtenteTitle.Location = new System.Drawing.Point(335, 99);
            this.lblVisualizzaPrenotazioneUtenteTitle.Name = "lblVisualizzaPrenotazioneUtenteTitle";
            this.lblVisualizzaPrenotazioneUtenteTitle.Size = new System.Drawing.Size(384, 23);
            this.lblVisualizzaPrenotazioneUtenteTitle.TabIndex = 1;
            this.lblVisualizzaPrenotazioneUtenteTitle.Text = "Questi sono tutti i libri che hai prenotato :";
            // 
            // dgvMostraPrenotazioni
            // 
            this.dgvMostraPrenotazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraPrenotazioni.Location = new System.Drawing.Point(24, 158);
            this.dgvMostraPrenotazioni.Name = "dgvMostraPrenotazioni";
            this.dgvMostraPrenotazioni.RowHeadersWidth = 51;
            this.dgvMostraPrenotazioni.RowTemplate.Height = 24;
            this.dgvMostraPrenotazioni.Size = new System.Drawing.Size(962, 344);
            this.dgvMostraPrenotazioni.TabIndex = 2;
            // 
            // formVisualizzaPrenotazioneUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 567);
            this.Controls.Add(this.dgvMostraPrenotazioni);
            this.Controls.Add(this.lblVisualizzaPrenotazioneUtenteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formVisualizzaPrenotazioneUtente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formVisualizzaPrenotazioneUtente";
            this.Load += new System.EventHandler(this.formVisualizzaPrenotazioneUtente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraPrenotazioni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizzaPrenotazioneUtenteTitle;
        private System.Windows.Forms.DataGridView dgvMostraPrenotazioni;
    }
}