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
            Console.WriteLine($"Account name: {_billCalc.Account.AccountName}");
            Console.WriteLine($"Account address: {_billCalc.Account.AccountAddress}");
            Console.WriteLine($"Account number: {_billCalc.Account.AccountNum}");
            Console.WriteLine($"Premises number: {_billCalc.Account.PremisesNum}");
            Console.WriteLine($"Account creation date: {_billCalc.Account.AccountCreationDate}");

            Console.WriteLine();

            Console.WriteLine($"Current reading: {_billCalc.Account.CurrentReading}");
            Console.WriteLine($"Previous reading: {_billCalc.Account.PreviousReading}");
            Console.WriteLine($"Current usage rate: {_billCalc.Account.CurrentUsageRate}");
            Console.WriteLine($"Fuel adjustment rate: {_billCalc.Account.FuelAdjustmentRate}");
            Console.WriteLine($"Latest payment of {_billCalc.Account.LatestPayment.PaymentAmount} was at {_billCalc.Account.LatestPayment.DatePayed.ToShortDateString()}");

            Console.WriteLine();
                
            Console.WriteLine($"Current charges: {_billCalc.CurrentCharges}");
            Console.WriteLine($"Subtotal: {_billCalc.Subtotal}");
            Console.WriteLine($"Fuel & IPP charge: {_billCalc.FiCharge}");
            Console.WriteLine($"F/E adjust: {_billCalc.FeAdjust}");
            Console.WriteLine($"Total charges before tax: {_billCalc.TotalChargesBeforeTax}");
            Console.WriteLine($"Nontaxable charges: {_billCalc.NontaxableCharges}");
            Console.WriteLine($"Taxable charges: {_billCalc.TaxableCharges}");
            
        }
    }
}
