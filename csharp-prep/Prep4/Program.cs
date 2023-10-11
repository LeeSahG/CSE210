using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Defining variable to use later
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number, press 0 to quit: ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of your numbers is {sum}.");

        //Calculating the average requires sum and count of items
        int items = numbers.Count;
        float average = sum / items;

        Console.WriteLine($"The average is {average}.");

        // To get the highest number we iterate through list until
        // we find the highest
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"{max} is the highest number.")

    }
}