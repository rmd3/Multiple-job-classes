using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductionWorker myWorker = new ProductionWorker();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            try
            {
                //Fill in data from user textboxes
                myWorker.employeeName = txtName.Text;
                myWorker.employeeNumber = int.Parse(txtNum.Text);
                myWorker.productionShift = int.Parse(txtShift.Text);
                myWorker.productionPay = double.Parse(txtPay.Text);

                //Output data to messagebox
                MessageBox.Show("Full Name: " + myWorker.employeeName + "\n" +
                    "Employee Number: " + myWorker.employeeNumber + "\n" + 
                    "Shift Number: " + myWorker.productionShift + "\n" + "Pay Rate: $"
                    + myWorker.productionPay);
            }
            catch (Exception error)
            {
                //Error messagebox
                MessageBox.Show(error.Message);
            }
        }
    }
}
