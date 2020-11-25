
namespace Aeroporto
{
    partial class frmStatistiche
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblInfo5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 217);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label1";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(13, 290);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "label2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(11, 365);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "label3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(12, 437);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(46, 17);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "label4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(13, 513);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(46, 17);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "label5";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(391, 181);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(432, 362);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 175);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(321, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 100);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "AEROPORTO ROSSO";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Aeroporto.Properties.Resources.download1;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 175);
            this.panel2.TabIndex = 0;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Red;
            this.lblInfo1.Location = new System.Drawing.Point(10, 181);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(290, 20);
            this.lblInfo1.TabIndex = 7;
            this.lblInfo1.Text = "Aereo che ha effettuato più voli : ";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Red;
            this.lblInfo2.Location = new System.Drawing.Point(11, 254);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(290, 20);
            this.lblInfo2.TabIndex = 7;
            this.lblInfo2.Text = "Aereo che ha effettuato più voli : ";
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo4.ForeColor = System.Drawing.Color.Red;
            this.lblInfo4.Location = new System.Drawing.Point(10, 401);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(290, 20);
            this.lblInfo4.TabIndex = 7;
            this.lblInfo4.Text = "Aereo che ha effettuato più voli : ";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo3.ForeColor = System.Drawing.Color.Red;
            this.lblInfo3.Location = new System.Drawing.Point(10, 324);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(290, 20);
            this.lblInfo3.TabIndex = 7;
            this.lblInfo3.Text = "Aereo che ha effettuato più voli : ";
            // 
            // lblInfo5
            // 
            this.lblInfo5.AutoSize = true;
            this.lblInfo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo5.ForeColor = System.Drawing.Color.Red;
            this.lblInfo5.Location = new System.Drawing.Point(10, 475);
            this.lblInfo5.Name = "lblInfo5";
            this.lblInfo5.Size = new System.Drawing.Size(290, 20);
            this.lblInfo5.TabIndex = 7;
            this.lblInfo5.Text = "Aereo che ha effettuato più voli : ";
            // 
            // frmStatistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 586);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo5);
            this.Controls.Add(this.lblInfo4);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmStatistiche";
            this.Text = "frmStatistiche";
            this.Load += new System.EventHandler(this.frmStatistiche_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo4;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label lblInfo5;
        private System.Windows.Forms.Panel panel3;
    }
}