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
using System.Xml.Serialization;
using System.Diagnostics;


namespace RK
{
    public partial class Form_RK : Form
    {
        Timer timer = new Timer();
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
            Process.Start("RezhimKardDB.mdb");
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // видимоть первых
        void visible1()
        {
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            btnRas.Visible = true;
        }
        // НЕвидимоть первых
        void novisible1()
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            btnRas.Visible = false;
        }

        //обработчик клика кнопки далее
        private void button4_Click(object sender, EventArgs e)
        {
            if ((tbF.Text == "") || (tbPK.Text == "") || (tbTf.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
                novisible1();
            }
            else
                visible1();
        }
        //обработчик для кнопки "расчет" в меню
        private void рассчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;        
        }
            //обработчик клика на кнопку расчет
        private void btnRas_Click(object sender, EventArgs e)
        {           
            if ((tbPK.Text == "") || (tbF.Text == "") || (tbTf.Text == "") || (tbQn.Text == "") || (tbFuel.Text == "") || (tbPb.Text == "") || (tbPair.Text == "") || (tbGwater.Text == "") || (tbCO2.Text == "") || (tbCO.Text == "") || (tbNO2.Text == "") || (tbCH4.Text == "") || (tbYgaz.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
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

                calc.Calc();

                TableResult.Add(calc);
                
                btnRetry.Visible = true;
                btnReport.Visible = true;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                dataResult1.Visible = true;
                
                dataResult1.Left = 25; //X coordinate
                dataResult1.Top = 100; //Y coordinate
            
                dataResult1.Rows.Add();
              
                foreach (FirstCalculation i in TableResult)
                {
                        dataResult1[0, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.B);
                        dataResult1[1, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.RO2max);
                        dataResult1[2, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.Kh);
                        dataResult1[3, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.alpha);
                        dataResult1[4, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.Vsg);
                        dataResult1[5, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.Q2);
                        dataResult1[6, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.Q3);
                        dataResult1[7, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.Q5);
                        dataResult1[8, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.KPDbr1);
                        dataResult1[9, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.By);
                        dataResult1[10, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.Bysl);         
                }    
            }          
        }
        private void btnRetry_Click(object sender, EventArgs e)
        { 
            groupBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            dataResult1.Visible = false;

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
            var worksheet = workBook.Worksheets.Add("отчёт"); // new worlshhet
           // экспорт по ячейкам
                 foreach (FirstCalculation i in TableResult)
            {
                worksheet.Cell("A1").Value = Convert.ToString(i.B);
                worksheet.Cell("A2").Value = Convert.ToString(i.RO2max);
                worksheet.Cell("A3").Value = Convert.ToString(i.Kh);
                worksheet.Cell("A4").Value = Convert.ToString(i.alpha);
                worksheet.Cell("A5").Value = Convert.ToString(i.Vsg);
                worksheet.Cell("A6").Value = Convert.ToString(i.Q2);
                worksheet.Cell("A7").Value = Convert.ToString(i.Q3);
                worksheet.Cell("A8").Value = Convert.ToString(i.Q5);
                worksheet.Cell("A9").Value = Convert.ToString(i.KPDbr1);
                worksheet.Cell("A10").Value = Convert.ToString(i.By);
                worksheet.Cell("A11").Value = Convert.ToString(i.Bysl);

              //  dataResult1[10, dataResult1.Rows.Count - 1].Value = Convert.ToString(i.Bysl);
            }



            workBook.SaveAs("c:\\отчёт.xlsx"); // save file

        }
        private void Form_RK_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

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
        private void контактнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/1bqJOxoknwMKgyILQqtk5YWold98nqMaa-kgsbPSVyxI/edit?usp=drive_web");
        }

        private void внестиПредложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/1PaSyGqNStoUHIpx81TzIUvzYzn-Mecx06R-mqbbm0rU/edit?usp=drive_web");
        }

        private void сообщитьОПроблемеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/1DNl5fXhpGRdSfaPMSXonSeZCNl-C2hGN1vqAEkrror4/edit?usp=drive_web");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            string time = "";
            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }
            label28.Text = time;
        }
    }
    
}
