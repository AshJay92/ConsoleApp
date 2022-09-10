namespace ConsoleApp
{
    internal class Number
    {
        private const int MinValue = 1;
        private const int MaxValue = 100;

        private const string DivisibleByThree = "Fizz";
        private const string DivisibleByFive = "Buzz";
        private const string PrimeNumber = "PRIME";

        private string[] units = new string[] {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
         "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
         "Seventeen", "Eighteen", "Nineteen"};
        private string[] tens = new string[] {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy",
         "Eighty", "Ninety"};

        public string GetNumberRepresentation(int number)
        {
            if (!(number >= MinValue && number <= MaxValue))
                return "Number is not in acceptable range 1 to 100";

            string result = string.Empty;

            if (number % 3 == 0)
            {
                result += DivisibleByThree;
            }

            if (number % 5 == 0)
            {
                result += DivisibleByFive;
            }

            if (result == string.Empty && IsPrime(number))
            {
                result = PrimeNumber;
            }

            if (result == string.Empty)
            {
                result = NumberToText(number);
            }

            return result;
        }

        private bool IsPrime(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            return count == 2;
        }

        private string NumberToText(int number)
        {
            string text = string.Empty;

            if (number > 0 && number <= 19)
            {
                return units[number - 1];
            }
            else if (number > 19 && number <= 99)
            {
                return tens[number / 10 - 2] + " " + NumberToText(number % 10);
            }

            return text;
        }
    }
}
