using System;
using System.Collections.Generic;

namespace SubarrayRepetitionsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maximumNumber = 30;
            int minimumNumber = 1;
            int number;
            int[][] numberArrayNumbers = new int[30][];
            int[] maximumNumberArray;

            for (int i = 0; i < numberArrayNumbers.Length; i++)
            {
                number = random.Next(minimumNumber, maximumNumber);
                numberArrayNumbers[i] = new int[random.Next(minimumNumber, maximumNumber)];

                for (int j = 0; j < numberArrayNumbers[i].Length; j++)
                {
                    numberArrayNumbers[i][j] = number;
                }
            }

            Console.WriteLine("Все массивы:" +
                              "\n------------------------------------------------------------------------------------------");

            foreach (var numbersArray in numberArrayNumbers)
            {
                foreach (var numberArray in numbersArray)
                {
                    Console.Write(numberArray + "|");
                }

                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------------------------------------------------");
            int[] tempNumber = new int[0];

            for (int i = 0; i < numberArrayNumbers.Length; i++)
            {
                if (tempNumber.Length < numberArrayNumbers[i].Length)
                {
                    tempNumber = numberArrayNumbers[i];
                }
            }

            maximumNumberArray = tempNumber;
            Console.WriteLine("Массив:");

            foreach (int numberArray in maximumNumberArray)
            {
                Console.Write(numberArray + "|");
            }

            Console.WriteLine($"\nЧисло: {maximumNumberArray[0]}" +
                              $"\nКол-во повторений: {maximumNumberArray.Length}");
        }
    }
}