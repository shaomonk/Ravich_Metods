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
        FormDataBase FormDataBase = new FormDataBase(); // new form FormDataBase

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
            FormDataBase.ShowDialog();
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
            dataResult.Visible = true;
            
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rezhimKardDB._boiler_gabarit_water_gaz_zhidkoe". При необходимости она может быть перемещена или удалена.
            this.boiler_gabarit_water_gaz_zhidkoeTableAdapter.Fill(this.rezhimKardDB._boiler_gabarit_water_gaz_zhidkoe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rezhimKardDB.boiler_gabarit_steam". При необходимости она может быть перемещена или удалена.
            this.boiler_gabarit_steamTableAdapter.Fill(this.rezhimKardDB.boiler_gabarit_steam);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rezhimKardDB.boiler". При необходимости она может быть перемещена или удалена.
            this.boilerTableAdapter.Fill(this.rezhimKardDB.boiler);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rezhimKardDB.char_zhidkoe". При необходимости она может быть перемещена или удалена.
            this.char_zhidkoeTableAdapter.Fill(this.rezhimKardDB.char_zhidkoe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rezhimKardDB.fuel". При необходимости она может быть перемещена или удалена.
            this.fuelTableAdapter.Fill(this.rezhimKardDB.fuel);

        }


    }
}
