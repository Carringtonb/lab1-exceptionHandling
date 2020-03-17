using System;

namespace Lab_01_exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
                GetQuotient(GetProduct);
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
		}
    }
}
