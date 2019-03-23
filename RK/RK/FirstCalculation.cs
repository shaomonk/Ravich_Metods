using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK
{
   public class FirstCalculation
    {
        public double Qn;          //низшая теплота сгораняи топлива в кДж
        public double B;           //расход топлива
        public double Tr;          //рабочая температура топлива
        public double Gv;          //расход воды через котел
        public double Tyx;         //температура уходящих газов
        public double Tv;          //температура воздуха
        public double NO2;         //содержание NO2 в продуктах сгорания
        public double CO2;         //содержание CO2 в продуктах сгорания         
        public double CH4;         //содержание CH4 в продуктах сгорания
        public double CO;          //содержание CO в продуктах сгорания
        public double Qsn;         //расход тепла на собственные нужды

        double C2;          //содержание в топливе
        double H2;          //содержание в топливе
        double N2;          //содержание в топливе
        double O2;          //содержание в топливе

        double h2;          //энтальпия воды на входе в котел
        double h1;          //энтальпия воды на выходе из котла
        double Kk;          //поправочный коэффициент К
        double Kc;          //поправочный коэффициент С
        double Kb;          //поправочный коэффициент В

        public double F;           //площадь поверхности нагрева котла
        public double Tf;          //температура обмуровки котла
        public double Qk;          //мощность котла

        public double Kh;          //поправочный коэффициент Н          
        public double RO2max;      //максимальное содержание трехатомных газов в ПС
        public double RO2;         //фактическое содержание NO и SO в ПС

        public double alpha;       //коэФФИЦИЕНТ ИЗБЫТКА ВОЗДУХА
        public double Vsg;         //объем ПС

        public double Q2;          //потери с уходящими газами
        public double Q3;          //потери от хим недожега
        public double Q4;          //потери от мех недожега
        public double alphaV;      //коэффициент потерь тепла в ОС
        public double Q5;          //потери в ОС

        public double KPDbr1;      //кпд брутто номинальный


        public double By;          //расход топлива удельный
        public double KPDkotla;    //кпд котлоагрегата
        public double Bysl;        //расход условного топлива


        

        //содержание RO2max
        public double  CostMax()
        {
             
            return RO2max = (CO2 * 100) / (100 - 4.76);
        }

        //коэффициент Kh
        public double KoefK()
        {
            return Kh = RO2max / (CO2 + CO + CH4);
        }

        //коэффициент избытка воздуха
        public double KoefA()
        {
            return alpha = 1 + (Kh -1) * Kb;
        }
        // определение объемов продуктов сгорания
        public double PSvozd()
        {
            return Vsg = (Kh - 1) * 1.86 * C2 / (CO2 + CO);
        }

        // потери Q2
        public double LostQ2()
        {
            return Q2 = (Tyx - Tv) / (2050 - 30) * (Kc + (Kh - 1) * Kb * Kk);
        }

        // потери Q3
        public double LostQ3()
        {
            return Q3 = (30.2 * CO + 25.8 * H2 + 85.5 * CH4) * Kh / 8000;
        }

        // потери Q5
        public double LostQ5()
        {
            return Q5 = 10.06 * (45 - Tv) * F / 1000;
        }

        //средние за расчетный период часовые нормируемые значения тепловых потерь пу-тем пересчета нормируемых
        //среднегодовых потерь с расчетного (проектного) сред-негодового режима на режим работы теплосети в расчетном периоде
        // КПД брутто
        public double KoefBR()
        {
            return KPDbr1 = 100 - Q2 - Q3 - Q5;
        }

        //удельный расход топлива
        public double BYdel()
        {
            return By = 142.86 / KPDbr1;
        }

        //расход условного топлива
        public double BYslovnoe()
        {
            return Bysl = 1000 * (KPDbr1 - Qsn) / 7;
        }

        public void Calc()
        {
            CostMax();
            KoefK();
            KoefA();
            PSvozd();
            LostQ2();
            LostQ3();
            LostQ5();
            KoefBR();
            BYdel();
            BYslovnoe(); // метод для всех расчетов на газ
        }
    }

}
