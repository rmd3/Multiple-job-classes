using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Anjolell_11_1
{
    class Employee
    {
        //Declare Variables
        private string _employeeName;
        private int _employeeNumber;

        //Constructor that sets all variables to default values
        public Employee()
        {

        }

        public string employeeName 
        {
            //Getter and setter for name variable
            get
            {
                return _employeeName;
            }
            set
            {
                _employeeName = value;
            }
        }

        public int employeeNumber
        {
            //Getter and setter for Number variable
            get
            {
                return _employeeNumber;
            }
            set
            {
                _employeeNumber = value;
            }
        }
    }
}
