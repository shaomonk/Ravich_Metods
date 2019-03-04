using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK
{
    class InputTableData
    {
        public string Fuel;
        public string Boiler;
        public double C;
        public double K;
        public double Qpn;
        public double tmax;
        public double qt;
        public double B;
        public double F;
        public double tf;

        public InputTableData(string _Fuel, string _Boiler, double _C, double _K, double _Qpn, double _tmax, double _qt, double _B, double _F, double _tf)
        {
            Fuel = _Fuel;
            Boiler = _Boiler;
            C = _C;
            K = _K;
            B = _B;
            Qpn = _Qpn;
            tmax = _tmax;
            qt = _qt;
            F = _F;
            tf = _tf;
        }
    }
}
