using System;
using System.Dynamic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Tyler", "Math");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Tyler", "Math", "4.1", "8, 9, 10, 11");
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Tyler", "Writing", "To Kill a Mockingbird");
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}