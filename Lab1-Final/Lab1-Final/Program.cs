uusing System;

namespace Lab_01_exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");
            StartSequence();
        }
        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than zero");
                string inputNumber = Console.ReadLine();
                int numberConverted = Convert.ToInt32(inputNumber);

                //Populate(Array);
                //GetSum(Array);
                //GetProduct(Array, GetSum(Array));
                //GetQuotient(GetProduct(Array, GetSum(Array)));

                int[] array = new int[numberConverted];

                int[] arr = Populate(array);

                int sum = GetSum(arr);

                int product = GetProduct(array, sum);

                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your array size is {array.Length}");
                Console.WriteLine("Your numbers in the array are [{0}]", string.Join(", ", arr));
                Console.WriteLine($"Your sum of the array is {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {product / quotient} = {quotient}");
                Console.WriteLine($"Program is complete");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static int[] Populate(int[] populateArray)
        {

            for (int i = 0; i < populateArray.Length; i++)
            {
                Console.WriteLine($"Enter a number, {i + 1} of {populateArray.Length}");
                string userInput = Console.ReadLine();
                int convertedInput = Convert.ToInt32(userInput);
                populateArray[i] = convertedInput;
            }
            return populateArray;
        }

        static int GetSum(int[] sumArray)
        {
            int sum = 0;
            for (int i = 0; i < sumArray.Length; i++)
            {
                sum += sumArray[i];
            }
            if (sum < 20)
            {
                Console.WriteLine($"Value of {sum} is too low.");

            }
            return sum;
        }

        static int GetProduct(int[] productArr, int sum)
        {
            try
            {
                Console.WriteLine($"Enter a number between 1 and {productArr.Length}");
                string userInput = Console.ReadLine();
                int convertedInput = Convert.ToInt32(userInput);

                var product = sum * productArr[convertedInput - 1];

                return product;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine("Please enter a number to divide your product by");
                string input = Console.ReadLine();

                int divideNum = Convert.ToInt32(input);

                Decimal value = decimal.Divide(product, divideNum);

                return value;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
    }
}
