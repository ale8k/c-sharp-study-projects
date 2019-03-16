using System;

namespace EnergyBillApp
{
    public class Payment
    {
        public decimal PaymentAmount { get; private set; }
        public DateTime DatePayed { get; private set; }

        public Payment(decimal payment, DateTime datePayed)
        {
            PaymentAmount = payment;
            DatePayed = datePayed;
        }
    }
}
