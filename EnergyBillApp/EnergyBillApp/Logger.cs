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
            sb
                .Append($"Account name: {_billCalc.Account.AccountName}").AppendLine()
                .Append($"Account address: {_billCalc.Account.AccountAddress}").AppendLine()
                .Append($"Account number: {_billCalc.Account.AccountNum}").AppendLine()
                .Append($"Premises number: {_billCalc.Account.PremisesNum}").AppendLine()
                .Append($"Account creation date: {_billCalc.Account.AccountCreationDate}").AppendLine()
                .Append($"Current reading: {_billCalc.Account.CurrentReading}").AppendLine()
                .Append($"Previous reading: {_billCalc.Account.PreviousReading}").AppendLine()
                .Append($"Current usage rate: {_billCalc.Account.CurrentUsageRate}").AppendLine()
                .Append($"Fuel adjustment rate: {_billCalc.Account.FuelAdjustmentRate}").AppendLine()
                .Append($"Latest payment of {_billCalc.Account.LatestPayment.PaymentAmount} was at {_billCalc.Account.LatestPayment.DatePayed.ToShortDateString()}").AppendLine()
                .Append($"Current charges: {_billCalc.CurrentCharges}").AppendLine()
                .Append($"Subtotal: {_billCalc.Subtotal}").AppendLine()
                .Append($"Subtotal: {_billCalc.Subtotal}").AppendLine()
                .Append($"F/E adjust: {_billCalc.FeAdjust}").AppendLine()
                .Append($"Total charges before tax: {_billCalc.TotalChargesBeforeTax}").AppendLine()
                .Append($"Nontaxable charges: {_billCalc.NontaxableCharges}").AppendLine()
                .Append($"Taxable charges: {_billCalc.TaxableCharges}").AppendLine();

            Console.WriteLine(sb);

            
        }
    }
}
