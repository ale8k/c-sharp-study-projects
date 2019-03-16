using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyBillApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account alex = new Account(currentReading: 5735,
                                       previousReading: 5556,
                                       currentUsageRate: 789.000m,
                                       fuelAdjustRate: 2);

            alex.Pay(new Payment(50, DateTime.Now));
            alex.Pay(new Payment(400, DateTime.Now));

            BillCalc alexsCalc = new BillCalc(alex, 9.660m);
            Logger alexsLogger = new Logger(alexsCalc);
            alexsLogger.LogBill();

            DateTime x = DateTime.Now;
            Console.WriteLine(x.ToShortDateString());

            Console.ReadLine();
            
        }
    }
}
