using System;

class Program
{
static void Main(string[] args)
    {
        Fraction c1 = new Fraction();
        Console.WriteLine (c1.GetFractionString());
        Console.WriteLine (c1.GetDecimalValue());

        Fraction c2 = new Fraction(6);
        Console.WriteLine (c2.GetFractionString());
        Console.WriteLine (c2.GetDecimalValue());

        Fraction c3 = new Fraction(3,4);
        Console.WriteLine (c3.GetFractionString());
        Console.WriteLine (c3.GetDecimalValue());

        Fraction c4 = new Fraction(1,3);
        Console.WriteLine (c4.GetFractionString());
        Console.WriteLine (c4.GetDecimalValue());
    }

}