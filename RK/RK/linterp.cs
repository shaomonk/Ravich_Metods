﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK
{
    class linterp
    {
        // описание переменных
        public double x0;
        public double x1;
        public double x2;
        public double y0;
        public double y1;
        public double y2;

        //конструктор класса
        // все переменные
        public linterp(double _x0, double _x1, double _x2, double _y0, double _y1, double _y2)
        {
            x0 = _x0;
            x1 = _x1;
            x2 = _x2;
            y0 = _y0;
            y1 = _y1;
            y2 = _y2;
        }

        // конструктор
        public linterp()
        {
        }

        //проверка внутри класса можно ли производить интерполяцию 
        // если фолс то интерполяция не проводилась
        // если вернула тру то интерполяция провелась   
        public bool check()
        {
            bool z;
            if (x0 < x1 && x1 < x2)
            {
                z = true;
                if (y0 == 0) { y0 = (y1 * (x0 - x2) + y2 * (x1 - x0)) / (x1 - x2); }
                if (y1 == 0) { y1 = y0 + (x1 - x0) / (x2 - x0) * (y2 - y0); }
                if (y2 == 0) { y2 = y0 + (y1 - y0) * (x2 - x0) / (x1 - x0); }
            }
            else z = false;
            return z;
        }
    }
}
