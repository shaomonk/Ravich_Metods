using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK
{
    static class pereprava
    {
        // таблица исходных данных
        static public List<InputTableData> tempTable = new List<InputTableData>();
        // Флаг админа
        static public bool check = false;
        //Переменые вывода данных
        static public double Calculation;// номер расчета(испытания)
        static public double Qk;// мощность котла
        static public double Qn;// низшая теплота сгорания
        static public double B;// расход топлива
        static public double Tr;//температура топлива
        static public double Tf;//температура поверхности нагрева котла
        static public double F;//площадь поверхности нагрева котла
        static public double CO2, CO, CH4, NO2; //компоненты продуктов сгорания
        
        static public double Gv;// расход воды через котел
        static public double Tv;//температура воздуха

        static public double Tyx;//температура уходящих газов
        static public double Qsn;//расход на собственные нужды


    }
}
