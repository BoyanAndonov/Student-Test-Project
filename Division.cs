using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int divisibleBy2Count = 0;
        int divisibleBy3Count = 0;
        int divisibleBy4Count = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                divisibleBy2Count++;
            }

            if (number % 3 == 0)
            {
                divisibleBy3Count++;
            }

            if (number % 4 == 0)
            {
                divisibleBy4Count++;
            }
        }

        double percentDivisibleBy2 = (double)divisibleBy2Count / n * 100;
        double percentDivisibleBy3 = (double)divisibleBy3Count / n * 100;
        double percentDivisibleBy4 = (double)divisibleBy4Count / n * 100;

        Console.WriteLine($"{percentDivisibleBy2:F2}%");
        Console.WriteLine($"{percentDivisibleBy3:F2}%");
        Console.WriteLine($"{percentDivisibleBy4:F2}%");
    }
}
