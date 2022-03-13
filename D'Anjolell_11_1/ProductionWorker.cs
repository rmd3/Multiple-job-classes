using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Anjolell_11_1
{
    class ProductionWorker : Employee
    {
        //Declare Variables
        private int _productionShift;
        private double _productionPay;

        //Constructor that sets all variables to default values
        public ProductionWorker()
        {
            
        }
        public int productionShift
        {
            //Getter and setter for shift variable
            get
            {
                return _productionShift;
            }
            set
            {
                _productionShift = value;
            }
        }

        public double productionPay
        {
            //Getter and setter for pay variable
            get
            {
                return _productionPay;
            }
            set
            {
                _productionPay = value;
            }
        }
    }
}
