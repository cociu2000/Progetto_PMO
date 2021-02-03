
namespace GestioneBiblioteca
{
    partial class formDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDashboard));
            this.lblAccessoTitle = new System.Windows.Forms.Label();
            this.lblDashboardUtenteSubtitle2 = new System.Windows.Forms.Label();
            this.btnLibriConsigliati = new System.Windows.Forms.Button();
            this.btnElencoLibri = new System.Windows.Forms.Button();
            this.btnGestionePrestiti = new System.Windows.Forms.Button();
            this.lblGenerePreferito = new System.Windows.Forms.Label();
            this.lblDashboardUtenteSubtitle3 = new System.Windows.Forms.Label();
            this.btnPrenotaLibro = new System.Windows.Forms.Button();
            this.btnRestituisciLibro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccessoTitle
            // 
            this.lblAccessoTitle.AutoSize = true;
            this.lblAccessoTitle.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessoTitle.Location = new System.Drawing.Point(13, 119);
            this.lblAccessoTitle.Name = "lblAccessoTitle";
            this.lblAccessoTitle.Size = new System.Drawing.Size(117, 24);
            this.lblAccessoTitle.TabIndex = 0;
            this.lblAccessoTitle.Text = "Benvenuto";
            this.lblAccessoTitle.Click += new System.EventHandler(this.lblAccessoTitle_Click);
            // 
            // lblDashboardUtenteSubtitle2
            // 
            this.lblDashboardUtenteSubtitle2.AutoSize = true;
            this.lblDashboardUtenteSubtitle2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardUtenteSubtitle2.Location = new System.Drawing.Point(109, 20);
            this.lblDashboardUtenteSubtitle2.Name = "lblDashboardUtenteSubtitle2";
            this.lblDashboardUtenteSubtitle2.Size = new System.Drawing.Size(165, 23);
            this.lblDashboardUtenteSubtitle2.TabIndex = 2;
            this.lblDashboardUtenteSubtitle2.Text = "Gestione Prestiti";
            // 
            // btnLibriConsigliati
            // 
            this.btnLibriConsigliati.BackColor = System.Drawing.Color.Gold;
            this.btnLibriConsigliati.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibriConsigliati.Location = new System.Drawing.Point(38, 220);
            this.btnLibriConsigliati.Name = "btnLibriConsigliati";
            this.btnLibriConsigliati.Size = new System.Drawing.Size(169, 75);
            this.btnLibriConsigliati.TabIndex = 1;
            this.btnLibriConsigliati.Text = "Libri Consigliati";
            this.btnLibriConsigliati.UseVisualStyleBackColor = false;
            this.btnLibriConsigliati.Click += new System.EventHandler(this.btnLibriConsigliati_Click);
            // 
            // btnElencoLibri
            // 
            this.btnElencoLibri.BackColor = System.Drawing.Color.Gold;
            this.btnElencoLibri.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElencoLibri.Location = new System.Drawing.Point(253, 220);
            this.btnElencoLibri.Name = "btnElencoLibri";
            this.btnElencoLibri.Size = new System.Drawing.Size(156, 75);
            this.btnElencoLibri.TabIndex = 2;
            this.btnElencoLibri.Text = "Elenco Libri";
            this.btnElencoLibri.UseVisualStyleBackColor = false;
            this.btnElencoLibri.Click += new System.EventHandler(this.btnElencoLibri_Click);
            // 
            // btnGestionePrestiti
            // 
            this.btnGestionePrestiti.BackColor = System.Drawing.Color.Red;
            this.btnGestionePrestiti.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionePrestiti.Location = new System.Drawing.Point(70, 62);
            this.btnGestionePrestiti.Name = "btnGestionePrestiti";
            this.btnGestionePrestiti.Size = new System.Drawing.Size(232, 78);
            this.btnGestionePrestiti.TabIndex = 5;
            this.btnGestionePrestiti.Text = "PRESTITI ATTIVI";
            this.btnGestionePrestiti.UseVisualStyleBackColor = false;
            this.btnGestionePrestiti.Click += new System.EventHandler(this.btnGestionePrestiti_Click);
            // 
            // lblGenerePreferito
            // 
            this.lblGenerePreferito.AutoSize = true;
            this.lblGenerePreferito.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerePreferito.Location = new System.Drawing.Point(34, 176);
            this.lblGenerePreferito.Name = "lblGenerePreferito";
            this.lblGenerePreferito.Size = new System.Drawing.Size(206, 21);
            this.lblGenerePreferito.TabIndex = 6;
            this.lblGenerePreferito.Text = "Genere preferito utente:";
            // 
            // lblDashboardUtenteSubtitle3
            // 
            this.lblDashboardUtenteSubtitle3.AutoSize = true;
            this.lblDashboardUtenteSubtitle3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardUtenteSubtitle3.Location = new System.Drawing.Point(85, 319);
            this.lblDashboardUtenteSubtitle3.Name = "lblDashboardUtenteSubtitle3";
            this.lblDashboardUtenteSubtitle3.Size = new System.Drawing.Size(292, 21);
            this.lblDashboardUtenteSubtitle3.TabIndex = 7;
            this.lblDashboardUtenteSubtitle3.Text = "Vuoi prendere in prestito un Libro?";
            // 
            // btnPrenotaLibro
            // 
            this.btnPrenotaLibro.BackColor = System.Drawing.Color.Yellow;
            this.btnPrenotaLibro.Font = new System.Drawing.Font("Century", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrenotaLibro.Location = new System.Drawing.Point(100, 357);
            this.btnPrenotaLibro.Name = "btnPrenotaLibro";
            this.btnPrenotaLibro.Size = new System.Drawing.Size(263, 74);
            this.btnPrenotaLibro.TabIndex = 8;
            this.btnPrenotaLibro.Text = "PRENOTA";
            this.btnPrenotaLibro.UseVisualStyleBackColor = false;
            this.btnPrenotaLibro.Click += new System.EventHandler(this.btnPrenotaLibro_Click);
            // 
            // btnRestituisciLibro
            // 
            this.btnRestituisciLibro.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRestituisciLibro.Font = new System.Drawing.Font("Century", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestituisciLibro.Location = new System.Drawing.Point(70, 158);
            this.btnRestituisciLibro.Name = "btnRestituisciLibro";
            this.btnRestituisciLibro.Size = new System.Drawing.Size(232, 81);
            this.btnRestituisciLibro.TabIndex = 10;
            this.btnRestituisciLibro.Text = "RESTITUISCI LIBRO";
            this.btnRestituisciLibro.UseVisualStyleBackColor = false;
            this.btnRestituisciLibro.Click += new System.EventHandler(this.btnRestituisciLibro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblGenerePreferito);
            this.panel1.Controls.Add(this.btnLibriConsigliati);
            this.panel1.Controls.Add(this.btnPrenotaLibro);
            this.panel1.Controls.Add(this.btnElencoLibri);
            this.panel1.Controls.Add(this.lblDashboardUtenteSubtitle3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 722);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblAccessoTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 152);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblDashboardUtenteSubtitle2);
            this.panel3.Controls.Add(this.btnRestituisciLibro);
            this.panel3.Controls.Add(this.btnGestionePrestiti);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(442, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 263);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(358, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(456, 263);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(442, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(809, 460);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1198, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 722);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formDashboard_FormClosed);
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccessoTitle;
        private System.Windows.Forms.Label lblDashboardUtenteSubtitle2;
        private System.Windows.Forms.Button btnLibriConsigliati;
        private System.Windows.Forms.Button btnElencoLibri;
        private System.Windows.Forms.Button btnGestionePrestiti;
        private System.Windows.Forms.Label lblGenerePreferito;
        private System.Windows.Forms.Label lblDashboardUtenteSubtitle3;
        private System.Windows.Forms.Button btnPrenotaLibro;
        private System.Windows.Forms.Button btnRestituisciLibro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}