using System;

class Program
{
    static void Main(string[] args)
    {
      //  returnType FunctionName(dataType parameter1, dataType parameter2)
      //  {
      //      // function_body
      //  }

      // To define a standalone function in C#, use the "static" keyword before the return type

        DisplayWelcome();


        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));




    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string user_input = Console.ReadLine();
        int user_num = int.Parse(user_input);
        return user_num;
    }
    static int SquareNumber(int num_to_sq)
    {
        int num_sq = num_to_sq * num_to_sq;
        return num_sq;
    }
    static void DisplayResult(string userName, int sq_num)
    {
        Console.WriteLine($"{userName}, the square of your number is {sq_num}");
    }



    
}