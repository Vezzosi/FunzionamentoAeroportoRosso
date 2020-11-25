using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroporto
{
    public partial class frmStatistiche : Form
    {
        public frmStatistiche()
        {
            InitializeComponent();
        }

        public frmStatistiche(string _lbl1, string _lbl2, string _lbl3, string _lbl4, string _lbl5)
        {
            
            InitializeComponent();
            lbl1.Text = _lbl1;
        }
        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmStatistiche_Load(object sender, EventArgs e)
        {
        }
    }
}
