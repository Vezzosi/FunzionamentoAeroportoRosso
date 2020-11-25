
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
            this.SuspendLayout();
            // 
            // btnCaricamentoDati
            // 
            this.btnCaricamentoDati.Location = new System.Drawing.Point(77, 89);
            this.btnCaricamentoDati.Name = "btnCaricamentoDati";
            this.btnCaricamentoDati.Size = new System.Drawing.Size(157, 45);
            this.btnCaricamentoDati.TabIndex = 0;
            this.btnCaricamentoDati.Text = "CARICAMENTO DATI";
            this.btnCaricamentoDati.UseVisualStyleBackColor = true;
            this.btnCaricamentoDati.Click += new System.EventHandler(this.btnCaricamentoDati_Click);
            // 
            // btnVisualizzaAerei
            // 
            this.btnVisualizzaAerei.Location = new System.Drawing.Point(316, 89);
            this.btnVisualizzaAerei.Name = "btnVisualizzaAerei";
            this.btnVisualizzaAerei.Size = new System.Drawing.Size(147, 45);
            this.btnVisualizzaAerei.TabIndex = 1;
            this.btnVisualizzaAerei.Text = "VISUALIZZA AEREI";
            this.btnVisualizzaAerei.UseVisualStyleBackColor = true;
            this.btnVisualizzaAerei.Click += new System.EventHandler(this.btnVisualizzaAerei_Click);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 338);
            this.Controls.Add(this.btnVisualizzaAerei);
            this.Controls.Add(this.btnCaricamentoDati);
            this.Name = "frmAvvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avvio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaricamentoDati;
        private System.Windows.Forms.Button btnVisualizzaAerei;
    }
}

