using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    class Converter
    {
        private double _usd;
        private double _eu;
        private double _rub;
        private double _ua { get; set; }
        public Converter(double ua) 
        {
            this._ua = ua;

        }
        public double Usd(double _usd,double ua)
        {
            _usd = ua / 28;
            return _usd;
        }
        public double Eu(double _eu, double ua)
        {
            _eu = ua / 33.3;
            return _eu;
        }
        public double Rub(double _rub, double ua)
        {
            _rub = ua / 0.3;
            return _rub;
        }
        public void Show()
        {
            Console.WriteLine($"Долар {Usd(_usd, _ua)}");
            Console.WriteLine($"Євро {Eu(_eu,_ua)}");
            Console.WriteLine($"Рубль {Rub(_rub,_ua)}");
        }
    }
}
