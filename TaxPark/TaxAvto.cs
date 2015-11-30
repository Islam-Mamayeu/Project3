using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    class TaxAvto :Avto
    {

        private string _type;

        override public void Show()
        {
        }
        public TaxAvto(string model,string type,string fueltype,double fuelConsumption,int price,int seatCount)
        {
            this.model = model;
            this.type = type;
            this.fueltype = fueltype;
            this.fuelConsumption = fuelConsumption;
            this.price = price;
            this.seatCount = seatCount;
        }
        public string type
        {
            get { return _type; }
            set { this._type = value; }
        }

    }
}
