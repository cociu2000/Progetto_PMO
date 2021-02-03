
namespace GestioneBiblioteca
{
    partial class formElencoLibri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formElencoLibri));
            this.lblElencoLibriTitle = new System.Windows.Forms.Label();
            this.dgvElencoLibri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElencoLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElencoLibriTitle
            // 
            this.lblElencoLibriTitle.AutoSize = true;
            this.lblElencoLibriTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElencoLibriTitle.Location = new System.Drawing.Point(328, 36);
            this.lblElencoLibriTitle.Name = "lblElencoLibriTitle";
            this.lblElencoLibriTitle.Size = new System.Drawing.Size(314, 23);
            this.lblElencoLibriTitle.TabIndex = 0;
            this.lblElencoLibriTitle.Text = "Questi sono tutti i libri disponibili :";
            // 
            // dgvElencoLibri
            // 
            this.dgvElencoLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElencoLibri.Location = new System.Drawing.Point(230, 77);
            this.dgvElencoLibri.Name = "dgvElencoLibri";
            this.dgvElencoLibri.RowHeadersWidth = 51;
            this.dgvElencoLibri.RowTemplate.Height = 24;
            this.dgvElencoLibri.Size = new System.Drawing.Size(497, 407);
            this.dgvElencoLibri.TabIndex = 1;
            // 
            // formElencoLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 496);
            this.Controls.Add(this.dgvElencoLibri);
            this.Controls.Add(this.lblElencoLibriTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formElencoLibri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elenco Libri";
            this.Load += new System.EventHandler(this.formElencoLibri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElencoLibri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElencoLibriTitle;
        private System.Windows.Forms.DataGridView dgvElencoLibri;
    }
}