using System;

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

            Populate(Array);
            GetSum(Array);
                GetProduct(Array, GetSum(Array));
                GetQuotient(GetProduct(Array, GetSum(Array)));
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
            
                for(int i = 0; i < populateArray.Length; i++)
			{
                Console.WriteLine($"Enter a number, {i} of {populateArray.length}");
                string userInput = Console.ReadLine();
                int convertedInput = Convert.ToInt32(userInput);
                populateArray[i] = convertedInput;
			}
            return populateArray;
		}

        static int[] GetSum(int[] sumArray)
		{
            int sum = 0;
            for (int i = 0; i < sumArray.length; i++)
			{
                sum += Array[i];
			}
                if (sum < 20)
				{
                    Console.WriteLine($"Value of {sum} is too low.")
				}
            return sumArray;
		}

        static int GetProduct(int[] productArr, int sum)
		{
			try
			{
                Console.WriteLine($"Enter a number between 1 and {productArr.length}");
                string userInput = Console.ReadLine();
                int convertedInput = Convert.ToInt32(userInput);

                var product = sum * productArr[convertedInput];

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

                Decimal value = decimal.Divide(divideNum, product);

                return value;
            }
			catch (DivideByZeroException ex)
			{
                return 0;
			}
       
		}
    }
}
