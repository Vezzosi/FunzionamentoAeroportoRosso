
namespace Aeroporto
{
    partial class frmAvvio
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCaricamentoDati = new System.Windows.Forms.Button();
            this.btnVisualizzaAerei = new System.Windows.Forms.Button();
            this.btnStatistiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaricamentoDati
            // 
            this.btnCaricamentoDati.Location = new System.Drawing.Point(103, 110);
            this.btnCaricamentoDati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaricamentoDati.Name = "btnCaricamentoDati";
            this.btnCaricamentoDati.Size = new System.Drawing.Size(209, 55);
            this.btnCaricamentoDati.TabIndex = 0;
            this.btnCaricamentoDati.Text = "CARICAMENTO DATI";
            this.btnCaricamentoDati.UseVisualStyleBackColor = true;
            this.btnCaricamentoDati.Click += new System.EventHandler(this.btnCaricamentoDati_Click);
            // 
            // btnVisualizzaAerei
            // 
            this.btnVisualizzaAerei.Location = new System.Drawing.Point(421, 110);
            this.btnVisualizzaAerei.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizzaAerei.Name = "btnVisualizzaAerei";
            this.btnVisualizzaAerei.Size = new System.Drawing.Size(196, 55);
            this.btnVisualizzaAerei.TabIndex = 1;
            this.btnVisualizzaAerei.Text = "VISUALIZZA AEREI";
            this.btnVisualizzaAerei.UseVisualStyleBackColor = true;
            this.btnVisualizzaAerei.Click += new System.EventHandler(this.btnVisualizzaAerei_Click);
            // 
            // btnStatistiche
            // 
            this.btnStatistiche.Location = new System.Drawing.Point(481, 251);
            this.btnStatistiche.Name = "btnStatistiche";
            this.btnStatistiche.Size = new System.Drawing.Size(136, 53);
            this.btnStatistiche.TabIndex = 2;
            this.btnStatistiche.Text = "STATISTICHE";
            this.btnStatistiche.UseVisualStyleBackColor = true;
            this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 416);
            this.Controls.Add(this.btnStatistiche);
            this.Controls.Add(this.btnVisualizzaAerei);
            this.Controls.Add(this.btnCaricamentoDati);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAvvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avvio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaricamentoDati;
        private System.Windows.Forms.Button btnVisualizzaAerei;
        private System.Windows.Forms.Button btnStatistiche;
    }
}

