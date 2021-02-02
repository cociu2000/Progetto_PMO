
namespace GestioneBiblioteca
{
    partial class formRecuperaPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRecuperaPassword));
            this.lblRecuperoPasswordSubtitle = new System.Windows.Forms.Label();
            this.lblPasswordPassword = new System.Windows.Forms.Label();
            this.lblRecuperaPasswordEmail = new System.Windows.Forms.Label();
            this.lblRecuperaPasswordConfermaPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfermaPassword = new System.Windows.Forms.TextBox();
            this.btnCambiaPassword = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecuperoPasswordSubtitle
            // 
            this.lblRecuperoPasswordSubtitle.AutoSize = true;
            this.lblRecuperoPasswordSubtitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperoPasswordSubtitle.Location = new System.Drawing.Point(46, 122);
            this.lblRecuperoPasswordSubtitle.Name = "lblRecuperoPasswordSubtitle";
            this.lblRecuperoPasswordSubtitle.Size = new System.Drawing.Size(523, 23);
            this.lblRecuperoPasswordSubtitle.TabIndex = 18;
            this.lblRecuperoPasswordSubtitle.Text = "Completa i seguenti campi per recuperare la password";
            // 
            // lblPasswordPassword
            // 
            this.lblPasswordPassword.AutoSize = true;
            this.lblPasswordPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordPassword.Location = new System.Drawing.Point(99, 249);
            this.lblPasswordPassword.Name = "lblPasswordPassword";
            this.lblPasswordPassword.Size = new System.Drawing.Size(101, 23);
            this.lblPasswordPassword.TabIndex = 20;
            this.lblPasswordPassword.Text = "Password:";
            // 
            // lblRecuperaPasswordEmail
            // 
            this.lblRecuperaPasswordEmail.AutoSize = true;
            this.lblRecuperaPasswordEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperaPasswordEmail.Location = new System.Drawing.Point(99, 187);
            this.lblRecuperaPasswordEmail.Name = "lblRecuperaPasswordEmail";
            this.lblRecuperaPasswordEmail.Size = new System.Drawing.Size(66, 23);
            this.lblRecuperaPasswordEmail.TabIndex = 19;
            this.lblRecuperaPasswordEmail.Text = "Email:";
            // 
            // lblRecuperaPasswordConfermaPassword
            // 
            this.lblRecuperaPasswordConfermaPassword.AutoSize = true;
            this.lblRecuperaPasswordConfermaPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperaPasswordConfermaPassword.Location = new System.Drawing.Point(99, 312);
            this.lblRecuperaPasswordConfermaPassword.Name = "lblRecuperaPasswordConfermaPassword";
            this.lblRecuperaPasswordConfermaPassword.Size = new System.Drawing.Size(198, 23);
            this.lblRecuperaPasswordConfermaPassword.TabIndex = 21;
            this.lblRecuperaPasswordConfermaPassword.Text = "Conferma Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(343, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 26);
            this.txtPassword.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(343, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 26);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtConfermaPassword
            // 
            this.txtConfermaPassword.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfermaPassword.Location = new System.Drawing.Point(343, 307);
            this.txtConfermaPassword.Name = "txtConfermaPassword";
            this.txtConfermaPassword.PasswordChar = '*';
            this.txtConfermaPassword.Size = new System.Drawing.Size(210, 26);
            this.txtConfermaPassword.TabIndex = 24;
            // 
            // btnCambiaPassword
            // 
            this.btnCambiaPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiaPassword.Location = new System.Drawing.Point(80, 368);
            this.btnCambiaPassword.Name = "btnCambiaPassword";
            this.btnCambiaPassword.Size = new System.Drawing.Size(196, 90);
            this.btnCambiaPassword.TabIndex = 26;
            this.btnCambiaPassword.Text = "CAMBIA";
            this.btnCambiaPassword.UseVisualStyleBackColor = true;
            this.btnCambiaPassword.Click += new System.EventHandler(this.btnCambiaPassword_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(343, 385);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(157, 57);
            this.btnAnnulla.TabIndex = 27;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // formRecuperaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnCambiaPassword);
            this.Controls.Add(this.txtConfermaPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRecuperaPasswordConfermaPassword);
            this.Controls.Add(this.lblPasswordPassword);
            this.Controls.Add(this.lblRecuperaPasswordEmail);
            this.Controls.Add(this.lblRecuperoPasswordSubtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRecuperaPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area recupero password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formRecuperaPassword_FormClosed);
            this.Load += new System.EventHandler(this.formRecuperaPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecuperoPasswordSubtitle;
        private System.Windows.Forms.Label lblPasswordPassword;
        private System.Windows.Forms.Label lblRecuperaPasswordEmail;
        private System.Windows.Forms.Label lblRecuperaPasswordConfermaPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfermaPassword;
        private System.Windows.Forms.Button btnCambiaPassword;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}