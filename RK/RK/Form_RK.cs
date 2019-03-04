using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel; // connect bibl


namespace RK
{
    public partial class Form_RK : Form
    {
        Fuel fuel1 = new Fuel();
        FormAboutBD FormAboutBD = new FormAboutBD(); // new form aboutBD
        FormSpravka FormSpravka = new FormSpravka(); // new form Spravka
        FormAboutProg FormAboutProg = new FormAboutProg(); // new form aboutProg

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
            /* Gaz Gaz1 = new Gaz();
             Gaz1.PowerBoiler = Convert.ToDouble(tbQ.Text);
             Gaz1.FlowFuel = Convert.ToDouble(tbPrk.Text);
             Gaz1.FlowWater = Convert.ToDouble(tbGwater.Text);
             Gaz1.TempFuel = Convert.ToDouble(tbPb.Text);
             Gaz1.TempAir = Convert.ToInt16(tbPair.Text);

             Gaz1.CostCH4 = Convert.ToDouble(tbCH4.Text);
             Gaz1.CostCO = Convert.ToDouble(tbCO.Text);
             Gaz1.CostCO2 = Convert.ToDouble(tbCO2.Text);
             Gaz1.CostNO2 = Convert.ToDouble(tbNO2.Text);
             Gaz1.TempSmokeGaz = Convert.ToDouble(tbYgaz.Text);

             label12.Text = Convert.ToString(Gaz1.RO2max);*/
            //fuel1(222, "dsaygdsya");
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

            tbFuel.Clear();
            tbCO2.Clear();
            tbCO.Clear();
            tbCH4.Clear();
            tbNO2.Clear();
            
            tbYgaz.Clear();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
         // call form Spravka
            
            FormSpravka.ShowDialog();
            

        }

        private void программаToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 FormAboutProg.ShowDialog();        // call this form
        }

        private void поискПоБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FormAboutBD.ShowDialog(); // cal form AboutBD
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
            var workBook = new ClosedXML.Excel.XLWorkbook(); // new exelFile
            var worksheet = workBook.Worksheets.Add("hellow_file"); // new worlshhet
            
            workBook.SaveAs("c:\\helow.xlsx"); // save file
            




        }

        private void tbQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_RK_Load(object sender, EventArgs e)
        {

        }
    }
}
