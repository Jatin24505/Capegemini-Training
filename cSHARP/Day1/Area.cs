using System;

class Aoc
{
    public static void Area_of_circle()
    {
        Console.Write("Enter radius: ");
        string input = Console.ReadLine() ?? "";

        if (double.TryParse(input, out double r))
        {
            double area = Math.PI * r * r;
            Console.WriteLine($"Area of circle: {area}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}