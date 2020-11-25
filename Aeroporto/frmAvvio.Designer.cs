
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCaricamentoDati
            // 
            this.btnCaricamentoDati.Location = new System.Drawing.Point(262, 152);
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
            this.btnVisualizzaAerei.Location = new System.Drawing.Point(262, 215);
            this.btnVisualizzaAerei.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizzaAerei.Name = "btnVisualizzaAerei";
            this.btnVisualizzaAerei.Size = new System.Drawing.Size(209, 55);
            this.btnVisualizzaAerei.TabIndex = 1;
            this.btnVisualizzaAerei.Text = "VISUALIZZA AEREI";
            this.btnVisualizzaAerei.UseVisualStyleBackColor = true;
            this.btnVisualizzaAerei.Click += new System.EventHandler(this.btnVisualizzaAerei_Click);
            // 
            // btnStatistiche
            // 
            this.btnStatistiche.Location = new System.Drawing.Point(262, 277);
            this.btnStatistiche.Name = "btnStatistiche";
            this.btnStatistiche.Size = new System.Drawing.Size(209, 53);
            this.btnStatistiche.TabIndex = 2;
            this.btnStatistiche.Text = "STATISTICHE";
            this.btnStatistiche.UseVisualStyleBackColor = true;
            this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 420);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(201, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 100);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 420);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStatistiche);
            this.Controls.Add(this.btnVisualizzaAerei);
            this.Controls.Add(this.btnCaricamentoDati);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAvvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avvio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaricamentoDati;
        private System.Windows.Forms.Button btnVisualizzaAerei;
        private System.Windows.Forms.Button btnStatistiche;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

