using System;
using System.Text;
namespace EnergyBillApp
{
    public class Logger
    {
        private BillCalc _billCalc;

        public Logger(BillCalc billCalc)
        {
            _billCalc = billCalc;
        }

        public void LogBill()
        {
            StringBuilder sb = new StringBuilder();


            //_billCalc.Account // get all account details from here
            // make string builder for account

            Console.WriteLine(_billCalc.CurrentCharges + " Current charges");
            Console.WriteLine(_billCalc.Subtotal + " Subtotal");
            Console.WriteLine(_billCalc.FiCharge + " FiCharge");
            Console.WriteLine(_billCalc.FeAdjust + " FeAdjust");
            Console.WriteLine(_billCalc.TotalChargesBeforeTax + " Total charges before tax");
            Console.WriteLine(_billCalc.NontaxableCharges + " Nontaxable charges");
            Console.WriteLine(_billCalc.TaxableCharges + " Taxable charges");
        }
    }
}
