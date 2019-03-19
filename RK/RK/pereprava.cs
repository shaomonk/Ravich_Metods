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
        static public string Calculation;// номер расчета
        static public double RO2max;// макс содержание трехатомных газов
        static public double Kh;// поправочный коэф
        static public double allpha;//коэф избытка воздуха
        static public double Vsg;//объем ПС
        static public double Q2, Q3, Q5; //кушки , потери тепла
        static public double[,] heatLossMass; // масив потерь
        static public double KPDbr1;// КПД брутто котла
        static public double By;//расход топлива удельный
        static public double KPDkotla;//кпд котлоагрегата
        static public double Bysl;//расход условного топлива


    }
}
