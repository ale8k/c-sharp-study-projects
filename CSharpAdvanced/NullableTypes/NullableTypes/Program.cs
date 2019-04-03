using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? y = null;

            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today; // default || today

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;



            Console.WriteLine(date2);



        }
    }
}
