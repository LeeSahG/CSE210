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

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}