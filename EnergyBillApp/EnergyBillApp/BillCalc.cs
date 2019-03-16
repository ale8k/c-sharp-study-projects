using System;


namespace EnergyBillApp
{
    public class BillCalc
    {

        public decimal CurrentCharges { get; private set; }
        public decimal Subtotal { get; private set; }
        public decimal FiCharge { get; private set; }
        public decimal FeAdjust { get; private set; }
        public decimal TotalChargesBeforeTax { get; private set; }
        public decimal NontaxableCharges { get; private set; }
        public Account Account { get; set; }

        private decimal _taxableCharges;
        
        public BillCalc(Account account, decimal rate)
        {
            Account = account;
            CurrentCharges = GetCurrentCharges(account.CurrentUsageRate, rate, account.CustomerCharge);
            Subtotal = GetSubtotal(CurrentCharges, account.CustomerCharge);
            FiCharge = GetFiCharge(CurrentCharges);
            FeAdjust = GetFeAdjust(Subtotal, account.FuelAdjustmentRate);
            TotalChargesBeforeTax = GetTCBT(Subtotal, FeAdjust, FiCharge);
            NontaxableCharges = TotalChargesBeforeTax;
            TaxableCharges = TaxableCharges; // mhm, could this be done better...?
        }

        private decimal GetCurrentCharges(decimal currUsage, decimal rate, decimal customCharge)
        {
            decimal currCharges;
            currCharges = (currUsage * rate) + customCharge;
            return currCharges;
        }

        private decimal GetSubtotal(decimal currCharges, decimal currCharge)
        {
            return currCharges + currCharge;
        }

        private decimal GetFiCharge(decimal currCharges)
        {
            return currCharges + 21.794m;
        }

        private decimal GetFeAdjust(decimal subtotal, double fuelAdjustRate)
        {
            return subtotal * (decimal) fuelAdjustRate;
        }

        private decimal GetTCBT(decimal subtotal, decimal fuelAdjustRate, decimal fiCharges)
        {
            return subtotal + fuelAdjustRate + fiCharges;
        }

        public decimal TaxableCharges
        {
            get
            {
                return _taxableCharges;
            }
            set
            {
                if (Account.CurrentUsageRate > 150)
                {
                    _taxableCharges = GetGCT(Account);
                }  
            }
        }

        private decimal GetGCT(Account account)
        {
            return (16.5m * account.CurrentUsageRate) / 100m;
        }
    }
}
