using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a List of numbers. Type 0 when finished ");

        List<int> numbers = new List<int>();

        int num = 1;

        while (num != 0)
        {
            Console.Write("Enter a number: ");
            string user_num = Console.ReadLine();
            num = int.Parse(user_num);

            numbers.Add(num);
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = ((float)sum) / (numbers.Count - 1);

        int largest = 0;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number ;
            }
        }


        Console.WriteLine($"The Sum is: {sum}");
        Console.Write($"\nThe average is: {average}");
        Console.Write($"\nThe largest number is: {largest}");
        
    }
}