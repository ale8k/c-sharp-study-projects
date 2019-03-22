using System;

/*
 * 
 * Create an account from <Account>
 * Create a bill calculator for that account <BillCalc> and pass it an adjustment
 * Use the logger <Logger> to display the account details or alternatively access all public members manually.
 * 
 */

namespace EnergyBillApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter current reading:");
            int currReading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter previous reading:");
            int prevReading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter current usage rate:");
            decimal currUsageRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter fuel adjust rate:");
            int fuelAdjust = Convert.ToInt32(Console.ReadLine());

            Account alex = new Account(currentReading: currReading,
                                       previousReading: prevReading,
                                       currentUsageRate: currUsageRate,
                                       fuelAdjustRate: fuelAdjust);

            Console.WriteLine("Enter premises number or press return:");
            alex.PremisesNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account number or press return:");
            alex.AccountNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account name or press return:");
            alex.AccountName = Console.ReadLine();
            Console.WriteLine("Enter account address or press return:");
            alex.AccountAddress = Console.ReadLine();
            Console.WriteLine();

            alex.Pay(new Payment(50, DateTime.Now)); // pays value into account
            alex.Pay(new Payment(400, DateTime.Now)); // ""

            BillCalc alexsCalc = new BillCalc(alex, 9.660m); // Creates bill calculator for Account object
            Logger alexsLogger = new Logger(alexsCalc); // Logs all calculated values 

            alexsLogger.LogBill();
            Console.ReadLine();
            
        }
    }
}
