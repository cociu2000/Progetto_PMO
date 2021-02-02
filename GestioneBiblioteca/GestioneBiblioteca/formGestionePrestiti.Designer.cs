
namespace GestioneBiblioteca
{
    partial class formGestionePrestiti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGestionePrestiti));
            this.lblElencoLibriTitle = new System.Windows.Forms.Label();
            this.dgvGestionePrestiti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionePrestiti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElencoLibriTitle
            // 
            this.lblElencoLibriTitle.AutoSize = true;
            this.lblElencoLibriTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElencoLibriTitle.Location = new System.Drawing.Point(438, 23);
            this.lblElencoLibriTitle.Name = "lblElencoLibriTitle";
            this.lblElencoLibriTitle.Size = new System.Drawing.Size(327, 23);
            this.lblElencoLibriTitle.TabIndex = 1;
            this.lblElencoLibriTitle.Text = "Questi sono tutti i prestiti effettuati :";
            // 
            // dgvGestionePrestiti
            // 
            this.dgvGestionePrestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionePrestiti.Location = new System.Drawing.Point(28, 82);
            this.dgvGestionePrestiti.Name = "dgvGestionePrestiti";
            this.dgvGestionePrestiti.RowHeadersWidth = 51;
            this.dgvGestionePrestiti.RowTemplate.Height = 24;
            this.dgvGestionePrestiti.Size = new System.Drawing.Size(1122, 437);
            this.dgvGestionePrestiti.TabIndex = 2;
            // 
            // formGestionePrestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 547);
            this.Controls.Add(this.dgvGestionePrestiti);
            this.Controls.Add(this.lblElencoLibriTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formGestionePrestiti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Prestiti";
            this.Load += new System.EventHandler(this.formGestionePrestiti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionePrestiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElencoLibriTitle;
        private System.Windows.Forms.DataGridView dgvGestionePrestiti;
    }
}