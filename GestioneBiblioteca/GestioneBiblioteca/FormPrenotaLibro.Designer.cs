
namespace GestioneBiblioteca
{
    partial class FormPrenotaLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrenotaLibro));
            this.lblPrenotaLibroTitle = new System.Windows.Forms.Label();
            this.lblPrenotaLibroUsername = new System.Windows.Forms.Label();
            this.lblPrenotaLibroGenerePreferito = new System.Windows.Forms.Label();
            this.lblScegliUnLibro = new System.Windows.Forms.Label();
            this.txtPrenotaLibroUsername = new System.Windows.Forms.TextBox();
            this.txtPrenotaLibroGenerePreferito = new System.Windows.Forms.TextBox();
            this.ckhPrenotaLibroGenerePreferito = new System.Windows.Forms.CheckBox();
            this.cmbPrenotaLibroScegliLibro = new System.Windows.Forms.ComboBox();
            this.btnPrenotaLibro = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrenotaLibroTitle
            // 
            this.lblPrenotaLibroTitle.AutoSize = true;
            this.lblPrenotaLibroTitle.Font = new System.Drawing.Font("Colonna MT", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenotaLibroTitle.Location = new System.Drawing.Point(52, 23);
            this.lblPrenotaLibroTitle.Name = "lblPrenotaLibroTitle";
            this.lblPrenotaLibroTitle.Size = new System.Drawing.Size(433, 30);
            this.lblPrenotaLibroTitle.TabIndex = 1;
            this.lblPrenotaLibroTitle.Text = "Benvenuto nell\'area prenotazione";
            // 
            // lblPrenotaLibroUsername
            // 
            this.lblPrenotaLibroUsername.AutoSize = true;
            this.lblPrenotaLibroUsername.Font = new System.Drawing.Font("Chiller", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenotaLibroUsername.Location = new System.Drawing.Point(25, 88);
            this.lblPrenotaLibroUsername.Name = "lblPrenotaLibroUsername";
            this.lblPrenotaLibroUsername.Size = new System.Drawing.Size(108, 33);
            this.lblPrenotaLibroUsername.TabIndex = 2;
            this.lblPrenotaLibroUsername.Text = "Username:";
            // 
            // lblPrenotaLibroGenerePreferito
            // 
            this.lblPrenotaLibroGenerePreferito.AutoSize = true;
            this.lblPrenotaLibroGenerePreferito.Font = new System.Drawing.Font("Chiller", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenotaLibroGenerePreferito.Location = new System.Drawing.Point(16, 159);
            this.lblPrenotaLibroGenerePreferito.Name = "lblPrenotaLibroGenerePreferito";
            this.lblPrenotaLibroGenerePreferito.Size = new System.Drawing.Size(178, 33);
            this.lblPrenotaLibroGenerePreferito.TabIndex = 3;
            this.lblPrenotaLibroGenerePreferito.Text = "Genere Preferito:";
            // 
            // lblScegliUnLibro
            // 
            this.lblScegliUnLibro.AutoSize = true;
            this.lblScegliUnLibro.Font = new System.Drawing.Font("Chiller", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScegliUnLibro.Location = new System.Drawing.Point(25, 314);
            this.lblScegliUnLibro.Name = "lblScegliUnLibro";
            this.lblScegliUnLibro.Size = new System.Drawing.Size(161, 33);
            this.lblScegliUnLibro.TabIndex = 4;
            this.lblScegliUnLibro.Text = "Scegli un Libro:";
            // 
            // txtPrenotaLibroUsername
            // 
            this.txtPrenotaLibroUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenotaLibroUsername.Location = new System.Drawing.Point(229, 94);
            this.txtPrenotaLibroUsername.Name = "txtPrenotaLibroUsername";
            this.txtPrenotaLibroUsername.ReadOnly = true;
            this.txtPrenotaLibroUsername.Size = new System.Drawing.Size(220, 27);
            this.txtPrenotaLibroUsername.TabIndex = 5;
            // 
            // txtPrenotaLibroGenerePreferito
            // 
            this.txtPrenotaLibroGenerePreferito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenotaLibroGenerePreferito.Location = new System.Drawing.Point(229, 159);
            this.txtPrenotaLibroGenerePreferito.Name = "txtPrenotaLibroGenerePreferito";
            this.txtPrenotaLibroGenerePreferito.ReadOnly = true;
            this.txtPrenotaLibroGenerePreferito.Size = new System.Drawing.Size(220, 27);
            this.txtPrenotaLibroGenerePreferito.TabIndex = 6;
            // 
            // ckhPrenotaLibroGenerePreferito
            // 
            this.ckhPrenotaLibroGenerePreferito.AutoSize = true;
            this.ckhPrenotaLibroGenerePreferito.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckhPrenotaLibroGenerePreferito.Location = new System.Drawing.Point(132, 254);
            this.ckhPrenotaLibroGenerePreferito.Name = "ckhPrenotaLibroGenerePreferito";
            this.ckhPrenotaLibroGenerePreferito.Size = new System.Drawing.Size(220, 37);
            this.ckhPrenotaLibroGenerePreferito.TabIndex = 7;
            this.ckhPrenotaLibroGenerePreferito.Text = "Mostra Tutti i Libri";
            this.ckhPrenotaLibroGenerePreferito.UseVisualStyleBackColor = true;
            this.ckhPrenotaLibroGenerePreferito.CheckedChanged += new System.EventHandler(this.ckhPrenotaLibroGenerePreferito_CheckedChanged);
            // 
            // cmbPrenotaLibroScegliLibro
            // 
            this.cmbPrenotaLibroScegliLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrenotaLibroScegliLibro.FormattingEnabled = true;
            this.cmbPrenotaLibroScegliLibro.Location = new System.Drawing.Point(229, 314);
            this.cmbPrenotaLibroScegliLibro.Name = "cmbPrenotaLibroScegliLibro";
            this.cmbPrenotaLibroScegliLibro.Size = new System.Drawing.Size(220, 28);
            this.cmbPrenotaLibroScegliLibro.TabIndex = 8;
            // 
            // btnPrenotaLibro
            // 
            this.btnPrenotaLibro.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPrenotaLibro.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrenotaLibro.Location = new System.Drawing.Point(22, 400);
            this.btnPrenotaLibro.Name = "btnPrenotaLibro";
            this.btnPrenotaLibro.Size = new System.Drawing.Size(221, 81);
            this.btnPrenotaLibro.TabIndex = 9;
            this.btnPrenotaLibro.Text = "PRENOTA";
            this.btnPrenotaLibro.UseVisualStyleBackColor = false;
            this.btnPrenotaLibro.Click += new System.EventHandler(this.btnPrenotaLibro_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.Gold;
            this.btnAnnulla.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(279, 472);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(206, 80);
            this.btnAnnulla.TabIndex = 10;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblPrenotaLibroTitle);
            this.panel1.Controls.Add(this.btnAnnulla);
            this.panel1.Controls.Add(this.btnPrenotaLibro);
            this.panel1.Controls.Add(this.cmbPrenotaLibroScegliLibro);
            this.panel1.Controls.Add(this.lblPrenotaLibroUsername);
            this.panel1.Controls.Add(this.ckhPrenotaLibroGenerePreferito);
            this.panel1.Controls.Add(this.lblPrenotaLibroGenerePreferito);
            this.panel1.Controls.Add(this.lblScegliUnLibro);
            this.panel1.Controls.Add(this.txtPrenotaLibroGenerePreferito);
            this.panel1.Controls.Add(this.txtPrenotaLibroUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 564);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(528, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(511, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // FormPrenotaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 564);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrenotaLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Prenotazione Libri";
            this.Load += new System.EventHandler(this.FormPrenotaLibro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrenotaLibroTitle;
        private System.Windows.Forms.Label lblPrenotaLibroUsername;
        private System.Windows.Forms.Label lblPrenotaLibroGenerePreferito;
        private System.Windows.Forms.Label lblScegliUnLibro;
        private System.Windows.Forms.TextBox txtPrenotaLibroUsername;
        private System.Windows.Forms.TextBox txtPrenotaLibroGenerePreferito;
        private System.Windows.Forms.CheckBox ckhPrenotaLibroGenerePreferito;
        private System.Windows.Forms.ComboBox cmbPrenotaLibroScegliLibro;
        private System.Windows.Forms.Button btnPrenotaLibro;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}