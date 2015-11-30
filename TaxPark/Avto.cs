using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    abstract class Avto
    {
        private string _model;
        private string _fueltype;
        private double _fuelConsumption;
        private int _seatCount;
        private int _price;
        public abstract void Show();

        public string model 
        {
            get { return _model; }
            set { this._model = value;}
        }

        public string fueltype
        {
            get { return _fueltype; }
            set { this._fueltype = value; }
        }
        public double fuelConsumption
        {
            get { return _fuelConsumption; }
            set { this._fuelConsumption = value; }
        }
        public int seatCount
        {
            get { return _seatCount; }
            set { this._seatCount = value; }
        }

        public int price
        {
            get { return _price; }
            set { this._price = value; }
        }



    }
}
