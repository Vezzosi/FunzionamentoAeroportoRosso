
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
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(249, 165);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(252, 186);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "label2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(252, 207);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "label3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(252, 228);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(46, 17);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "label4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(252, 249);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(46, 17);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "label5";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(563, 249);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(316, 175);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmStatistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmStatistiche";
            this.Text = "frmStatistiche";
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
    }
}