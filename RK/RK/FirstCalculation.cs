using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK
{
    class FirstCalculation
    {
        double Qn;          //низшая теплота сгораняи топлива в кДж
        double B;           //расход топлива
        double Tr;          //рабочая температура топлива
        double Gv;          //расход воды через котел
        double Tyx;         //температура уходящих газов
        double Tv;          //температура воздуха
        double NO2;         //содержание NO2 в продуктах сгорания
        double CO2;         //содержание CO2 в продуктах сгорания         
        double CH4;         //содержание CH4 в продуктах сгорания
        double CO;          //содержание CO в продуктах сгорания
        double Qsn;         //расход тепла на собственные нужды

        double C2;          //содержание в топливе
        double H2;          //содержание в топливе
        double N2;          //содержание в топливе
        double O2;          //содержание в топливе

        double h2;          //энтальпия воды на входе в котел
        double h1;          //энтальпия воды на выходе из котла
        double Kk;          //поправочный коэффициент К
        double Kc;          //поправочный коэффициент С
        double Kb;          //поправочный коэффициент В

        double F;           //площадь поверхности нагрева котла
        double Tf;          //температура обмуровки котла
        double Qk;          //мощность котла

        double Kh;          //поправочный коэффициент Н          
        double RO2max;      //максимальное содержание трехатомных газов в ПС
        double RO2;         //фактическое содержание NO и SO в ПС

        double alpha;       //коэФФИЦИЕНТ ИЗБЫТКА ВОЗДУХА
        double Vsg;         //объем ПС

        double Q2;          //потери с уходящими газами
        double Q3;          //потери от хим недожега
        double Q4;          //потери от мех недожега
        double alphaV;      //коэффициент потерь тепла в ОС
        double Q5;          //потери в ОС

        double KPDbr1;      //кпд брутто номинальный


        double By;          //расход топлива удельный
        double KPDkotla;    //кпд котлоагрегата
        double Bysl;        //расход условного топлива


        public List<InputTableData> tempTable = new List<InputTableData>();

        //содержание RO2max
        public double  CostMax(double CO2)
        {
            return RO2max = (CO2 * 100) / (100 - 4.76);
        }

        //коэффициент Kh
        public double KoefK(double RO2max, double CO2, double CO, double CH4)
        {
            return Kh = RO2max / (CO2 + CO + CH4);
        }

        //коэффициент избытка воздуха
        public double KoefA(double Kh, double Kb)
        {
            return alpha = 1 + (Kh -1) * Kb;
        }
        // определение объемов продуктов сгорания
        public double PSvozd(double C2, double CO2, double H2, double CO, double Kh)
        {
            return Vsg = (Kh - 1) * 1.86 * C2 / (CO2 + CO);
        }

        // потери Q2
        public double LostQ2(double Tyx, double Tv, double Kc, double Kb, double Kh, double Kk, double tmax)
        {
            return Q2 = (Tyx - Tv) / (tmax - 30) * (Kc + (Kh - 1) * Kb * Kk);
        }

        // потери Q3
        public double LostQ3(double CO, double H2, double CH4, double Kh, double qt)
        {
            return Q3 = (30.2 * CO + 25.8 * H2 + 85.5 * CH4) * Kh / qt;
        }

        // потери Q5
        public double LostQ5(double tf, double Tv, double F)
        {
            return Q5 = 10.06 * (tf - Tv) * F / 1000;
        }

        //средние за расчетный период часовые нормируемые значения тепловых потерь пу-тем пересчета нормируемых
        //среднегодовых потерь с расчетного (проектного) сред-негодового режима на режим работы теплосети в расчетном периоде
        // КПД брутто
        public double KoefBR(double Q2, double Q3, double Q5)
        {
            return KPDbr1 = 100 - Q2 - Q3 - Q5;
        }

        //удельный расход топлива
        public double BYdel(double KPDbr1)
        {
            return By = 142.86 / KPDbr1;
        }

        //расход условного топлива
        public double BYslovnoe(double Qsn, double KPDbr1)
        {
            return Bysl = 1000 * (KPDbr1 - Qsn) / 7;
        }
    }

}
