using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK
{
    class InputTableData
    {
        public double Calculation;
        public double Gv;
        public double Tv;
        public double Tyx;
        public double B;
        public double CO2;
        public double CH4;
        public double CO;
        public double NO2;
        public double Tr;
        public double Qsn;
        public double Qk;

        public double F;
        public double Tf;

        public InputTableData(double _Calculation, double _F, double _Tf, double _Gv, double _Tv, double _Tyx, double _B, double _CO2, double _CO, double _CH4, double _NO2, double _Tr, double _Qsn, double _Qk)
        {
            Calculation = _Calculation;
            F = _F;
            Tf = _Tf;
            Gv = _Gv;
            Tv = _Tv;
            B = _B;
            Tyx = _Tyx;
            CO2 = _CO2;
            CH4 = _CH4;
            CO = _CO;
            NO2 = _NO2;
            Tr = _Tr;
            Qsn = _Qsn;
            Qk = _Qk;

        }
    }
}
