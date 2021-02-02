
namespace GestioneBiblioteca
{
    partial class formLibriConsigliati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLibriConsigliati));
            this.lblLibriConsigliatiTitle = new System.Windows.Forms.Label();
            this.lblLibriConsigliatiSubtitle = new System.Windows.Forms.Label();
            this.dgvLibriConsigliati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibriConsigliati)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLibriConsigliatiTitle
            // 
            this.lblLibriConsigliatiTitle.AutoSize = true;
            this.lblLibriConsigliatiTitle.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibriConsigliatiTitle.Location = new System.Drawing.Point(236, 25);
            this.lblLibriConsigliatiTitle.Name = "lblLibriConsigliatiTitle";
            this.lblLibriConsigliatiTitle.Size = new System.Drawing.Size(117, 24);
            this.lblLibriConsigliatiTitle.TabIndex = 0;
            this.lblLibriConsigliatiTitle.Text = "Benvenuto";
            // 
            // lblLibriConsigliatiSubtitle
            // 
            this.lblLibriConsigliatiSubtitle.AutoSize = true;
            this.lblLibriConsigliatiSubtitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibriConsigliatiSubtitle.Location = new System.Drawing.Point(24, 99);
            this.lblLibriConsigliatiSubtitle.Name = "lblLibriConsigliatiSubtitle";
            this.lblLibriConsigliatiSubtitle.Size = new System.Drawing.Size(107, 23);
            this.lblLibriConsigliatiSubtitle.TabIndex = 1;
            this.lblLibriConsigliatiSubtitle.Text = "Benvenuto";
            // 
            // dgvLibriConsigliati
            // 
            this.dgvLibriConsigliati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibriConsigliati.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvLibriConsigliati.Location = new System.Drawing.Point(110, 222);
            this.dgvLibriConsigliati.Name = "dgvLibriConsigliati";
            this.dgvLibriConsigliati.RowHeadersWidth = 51;
            this.dgvLibriConsigliati.RowTemplate.Height = 24;
            this.dgvLibriConsigliati.Size = new System.Drawing.Size(737, 308);
            this.dgvLibriConsigliati.TabIndex = 2;
            // 
            // formLibriConsigliati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 565);
            this.Controls.Add(this.dgvLibriConsigliati);
            this.Controls.Add(this.lblLibriConsigliatiSubtitle);
            this.Controls.Add(this.lblLibriConsigliatiTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLibriConsigliati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libri Consigliati";
            this.Load += new System.EventHandler(this.formLibriConsigliati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibriConsigliati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibriConsigliatiTitle;
        private System.Windows.Forms.Label lblLibriConsigliatiSubtitle;
        private System.Windows.Forms.DataGridView dgvLibriConsigliati;
    }
}