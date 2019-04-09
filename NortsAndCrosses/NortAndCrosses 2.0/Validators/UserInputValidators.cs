using System;

namespace NortAndCrosses_2._0.Validators
{
    public static class UserInputValidator
    {
        public static int ValidateInput(string input)
        {
            int usersInput;
            bool inputIsOk = false;

            while (!inputIsOk)
            {
                try
                {
                    if (InputIsDigit(input))
                    {
                        usersInput = Convert.ToInt32(input);
                        inputIsOk = true;
                        return usersInput;
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, try again.");
                    input = Console.ReadLine();
                }
                
            }
            return 0;
        }

        private static bool InputIsDigit(string input)
        {
            switch(input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    return true;
            }
            return false;
        }
    }
}
