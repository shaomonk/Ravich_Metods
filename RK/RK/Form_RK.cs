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

        public List<FirstCalculation>TableResult= new List<FirstCalculation>();
        // class calculation
        FirstCalculation calc = new FirstCalculation();
        // class interpolation
        linterp lint = new linterp();

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

        //обработчик клика кнопки далее
        private void button4_Click(object sender, EventArgs e)
        {
            if (tbF.Text == "")
            {
                MessageBox.Show("Укажите площадь ПНК", "Ошибка");
                if (tbTf.Text == "")
                {
                    MessageBox.Show("Укажите температуру ПНК", "Ошибка");
                    if (tbPK.Text == "")
                    {
                        MessageBox.Show("Укажите мощность котла", "Ошибка");
                    }
                    else
                    {
                         groupBox3.Visible = true;
                         groupBox4.Visible = true;
                         btnRas.Visible = true;
                    }
                }
            }
        }  
        //обработчик для кнопки "расчет" в меню
        private void рассчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
 
        }
            //обработчик клика на кнопку расчет
        private void btnRas_Click(object sender, EventArgs e)
        {           
            if (tbPK.Text == "")
            {
                MessageBox.Show("Укажите мощность котла", "Ошибка");
            }
            if (tbF.Text == "")
            {
                MessageBox.Show("Укажите площадь ПНК", "Ошибка");
            }
            if (tbTf.Text == "")
            {
                MessageBox.Show("Укажите температуру ПНК", "Ошибка");
            }
            if (tbQn.Text == "")
            {
                MessageBox.Show("Укажите низшую теплоту сгорания", "Ошибка");
            }
            if (tbFuel.Text == "")
            {
                MessageBox.Show("Укажите расход топлива", "Ошибка");
            }
            if (tbPb.Text == "")
            {
                MessageBox.Show("Укажите температуру топлива", "Ошибка");
            }
            if (tbPair.Text == "")
            {
                MessageBox.Show("Укажите температуру воздуха", "Ошибка");
            }
            if (tbGwater.Text == "")
            {
                MessageBox.Show("Укажите расход воды", "Ошибка");
            }
            if (tbCO2.Text == "")
            {
                MessageBox.Show("Укажите содержание СО2", "Ошибка");
            }
            if (tbCO.Text == "")
            {
                MessageBox.Show("Укажите содержание СО", "Ошибка");
            }
            if (tbNO2.Text == "")
            {
                MessageBox.Show("Укажите содержание NO2", "Ошибка");
            }
            if (tbCH4.Text == "")
            {
                MessageBox.Show("Укажите содержание CH4", "Ошибка");
            }
            if (tbYgaz.Text == "")
            {
                MessageBox.Show("Укажите температуру уходящих газов", "Ошибка");
            }
            else
            {
                calc.Qn = Convert.ToDouble(tbQn.Text);
                calc.B = Convert.ToDouble(tbFuel.Text);
                calc.CO2 = Convert.ToDouble(tbCO2.Text);
                calc.CO = Convert.ToDouble(tbCO.Text);
                calc.NO2 = Convert.ToDouble(tbNO2.Text);
                calc.CH4 = Convert.ToDouble(tbCH4.Text);
                calc.Tr = Convert.ToDouble(tbPb.Text);
                calc.Tv = Convert.ToDouble(tbPair.Text);
                calc.F = Convert.ToDouble(tbF.Text);
                calc.Tf = Convert.ToDouble(tbTf.Text);
                calc.Tyx = Convert.ToDouble(tbYgaz.Text);
                calc.Gv = Convert.ToDouble(tbGwater.Text);
                calc.Qsn = Convert.ToDouble(tbQsn.Text);

                calc.Qk = Convert.ToDouble(tbPK.Text);

                calc.Calc();

                TableResult.Add(calc);

                btnRetry.Visible = true;
                btnReport.Visible = true;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                dataResult.Visible = true;
            }          
        }
        private void btnRetry_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            dataResult.Visible = false;

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
        //проверка текстбоксов на заполнение числами и только одной точкой
        private void text_press(object sender, KeyPressEventArgs e)
        {
            TextBox TBox = (TextBox)sender;
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') && (TBox.Text.IndexOf(".") == -1) && (TBox.Text.Length != 0)))
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
        }


           
    }
    
}
