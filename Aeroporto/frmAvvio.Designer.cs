
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label100 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCaricamentoDati
            // 
            this.btnCaricamentoDati.Location = new System.Drawing.Point(31, 181);
            this.btnCaricamentoDati.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaricamentoDati.Name = "btnCaricamentoDati";
            this.btnCaricamentoDati.Size = new System.Drawing.Size(209, 55);
            this.btnCaricamentoDati.TabIndex = 0;
            this.btnCaricamentoDati.Text = "CARICAMENTO DATI";
            this.btnCaricamentoDati.UseVisualStyleBackColor = true;
            this.btnCaricamentoDati.Click += new System.EventHandler(this.btnCaricamentoDati_Click);
            // 
            // btnVisualizzaAerei
            // 
            this.btnVisualizzaAerei.Location = new System.Drawing.Point(248, 181);
            this.btnVisualizzaAerei.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizzaAerei.Name = "btnVisualizzaAerei";
            this.btnVisualizzaAerei.Size = new System.Drawing.Size(209, 55);
            this.btnVisualizzaAerei.TabIndex = 1;
            this.btnVisualizzaAerei.Text = "VISUALIZZA AEREI";
            this.btnVisualizzaAerei.UseVisualStyleBackColor = true;
            this.btnVisualizzaAerei.Visible = false;
            this.btnVisualizzaAerei.Click += new System.EventHandler(this.btnVisualizzaAerei_Click);
            // 
            // btnStatistiche
            // 
            this.btnStatistiche.Location = new System.Drawing.Point(464, 180);
            this.btnStatistiche.Name = "btnStatistiche";
            this.btnStatistiche.Size = new System.Drawing.Size(209, 55);
            this.btnStatistiche.TabIndex = 2;
            this.btnStatistiche.Text = "STATISTICHE";
            this.btnStatistiche.UseVisualStyleBackColor = true;
            this.btnStatistiche.Visible = false;
            this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label100);
            this.panel3.Location = new System.Drawing.Point(201, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 175);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.Color.Red;
            this.label100.Location = new System.Drawing.Point(25, 70);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(447, 46);
            this.label100.TabIndex = 0;
            this.label100.Text = "AEROPORTO ROSSO";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Aeroporto.Properties.Resources.images;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 175);
            this.panel1.TabIndex = 5;
            // 
            // frmAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 248);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnStatistiche);
            this.Controls.Add(this.btnVisualizzaAerei);
            this.Controls.Add(this.btnCaricamentoDati);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAvvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avvio";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaricamentoDati;
        private System.Windows.Forms.Button btnVisualizzaAerei;
        private System.Windows.Forms.Button btnStatistiche;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Panel panel1;
    }
}

