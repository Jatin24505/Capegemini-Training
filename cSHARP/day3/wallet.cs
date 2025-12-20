using System.Reflection.Metadata.Ecma335;

class Wallet
{
    private double money;
    public void addMoney(double amount)

    {
        money += amount;
    }
    public double getBalance()
    {
        return money;
    }
}
class Mathops
{
    public int add(int a , int b)
    {
        return a +b;
    }
    public int add(int a,int b, int c)
    {
        return a+b+c;
    }
    public double add(double a, double b)
    {
        return a + b;
    }
 }

// using System;

// namespace day3{
// class Program
// {
//     static void Main(string[] args)
//     {
//         Mathops math = new Mathops();

//         // Demonstrating overloaded methods
//         Console.WriteLine("Add two integers: " + math.add(5, 10));
//         Console.WriteLine("Add three integers: " + math.add(2, 4, 6));
//         Console.WriteLine("Add two doubles: " + math.add(3.5, 4.7));

//         Console.ReadLine();
//     }
// }
// }
