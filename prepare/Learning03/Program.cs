using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one_over_one = new Fraction();
        Console.WriteLine(one_over_one.GetFractionString());
        Console.WriteLine(one_over_one.GetDecimalValue());
        
        Fraction choice_over_one = new Fraction(2);
        Console.WriteLine(choice_over_one.GetFractionString());
        Console.WriteLine(choice_over_one.GetDecimalValue());

        Fraction choice_over_choice = new Fraction(6, 7);
        Console.WriteLine(choice_over_choice.GetFractionString());
        Console.WriteLine(choice_over_choice.GetDecimalValue());
        
        Fraction choice_over_choice = new Fraction(4,9);
        Console.WriteLine(choice_over_choice.GetFractionString());
        Console.WriteLine(choice_over_choice.GetDecimalValue());

    }
}