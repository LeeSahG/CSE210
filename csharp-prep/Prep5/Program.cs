using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        // Noticed that in including functions in Main function, ensure you list vairiables
        // in order to avoid "Cannot use local variable before it is declared" error
        //Noticed when I put the squaredNumber variable above the userNumber variable
        string theUserName = UserName();
        int userNumber = FavoriteNumber();
        int squaredNumber = GetInteger(userNumber);
        
         

        DisplayResult(theUserName, squaredNumber);
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome!");
        }

    static string UserName()
        {
            Console.Write("What is your username? ");

            string userName = Console.ReadLine();

            return userName;
        }

    static int FavoriteNumber()
        {
        Console.Write("What is your favorite number? ");
        int faveNumber = int.Parse(Console.ReadLine());

        return faveNumber;
        }

    static int GetInteger(int integer)
        {
            int square = integer * integer;

            return square;
        }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
    }
}
    

