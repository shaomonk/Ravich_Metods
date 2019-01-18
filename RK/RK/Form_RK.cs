using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK
{
    public partial class Form_RK : Form
    {
        public Form_RK()
        {
            InitializeComponent();
        }

        void ShowChildForm(Form_RK form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void вывестиБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            btnRas.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void рассчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnRetry.Visible = true;
            btnReport.Visible = true;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            
            tbQ.Clear();
            tbPrk.Clear();
            tbPb.Clear();
            tbPair.Clear();
     
            tbTD.Clear();
            tbTP.Clear();
            tbYgaz.Clear();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
         // call form about
            FormSpravka FormSpravka = new FormSpravka();
            FormSpravka.ShowDialog();
            

        }

        private void программаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RK FormAboutProg = new Form_RK();
            FormAboutProg.ShowDialog();
        }

        private void поискПоБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RK FormAboutBD = new Form_RK();
            FormAboutBD.ShowDialog();
        }
    }
}
