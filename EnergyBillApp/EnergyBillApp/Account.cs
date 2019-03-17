using System;
using System.Collections.Generic;


namespace EnergyBillApp
{
    public class Account
    {
        public int CurrentReading { get; set;}
        public int PreviousReading { get; set; }
        public decimal CurrentUsageRate { get; set; }
        public double FuelAdjustmentRate { get; set; }
        public decimal CustomerCharge { get; set; }
        public string AccountCreationDate { get; private set; }
        public List<Payment> PaymentHistory = new List<Payment>();
        public Payment LatestPayment { get; private set; }
        // balance? need someway to store balance for account...

        private int _premisesNum, _accNum;
        private string _accName, _accAddress;

        public Account(int currentReading, int previousReading, decimal currentUsageRate, double fuelAdjustRate)
        {
            CurrentReading = currentReading;
            PreviousReading = previousReading;
            CurrentUsageRate = currentUsageRate;
            FuelAdjustmentRate = fuelAdjustRate;
            CustomerCharge = 455;
            AccountCreationDate = DateTime.Now.ToShortDateString();
        }

        public int PremisesNum
        {
            get { return _premisesNum; }

            set
            {
                if (value.GetType() != typeof(Int32))
                {
                    throw new InvalidOperationException("Integers only");
                }
                else
                {
                    if (value <= 0)
                    {
                        throw new InvalidOperationException("Account number cannot be 0 or below");
                    }
                    else
                    {
                        _premisesNum = value;
                    }
                }
            }
        }

        public int AccountNum
        {
            get { return _accNum; }

            set
            {
                int myVal = value;


                if (myVal <= 0)
                {
                    throw new InvalidOperationException("Account number cannot be 0 or below");
                }
                else
                {
                    _accNum = value;
                }
            }
        }

        public string AccountName
        {
            get { return _accName; }

            set
            {
                if (value.Length >= 3 && value.GetType() == typeof(string))
                {
                    _accName = value;
                }
                else
                {
                    throw new InvalidOperationException("Account name cannot be 2 in length or below (i.e., a single character)");
                }
            }

        }

        /*
         * TODO: Create validation formatter for address
         */
        public string AccountAddress
        {
            get { return _accAddress; }

            set
            {
                string myVal = Convert.ToString(value);

                if (myVal.Length <= 3)
                {
                    throw new InvalidOperationException("Account address cannot be 3 in length or below");
                }
                else
                {
                    _accAddress = myVal;
                }
            }
        }

        public void Pay(Payment payment)
        {
            PaymentHistory.Add(payment);
            LatestPayment = payment;
        }
    }
}
