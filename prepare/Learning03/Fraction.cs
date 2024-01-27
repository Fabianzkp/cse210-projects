using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction (int Number)
    {
        _numerator = Number;
        _denominator = 1;
    }

    
    public Fraction (int up, int down)
    {
        _numerator = up;
        //This is to ensure the denominator is not set to zero.
        if(down !=0)
        {
            _denominator = down;
        }
         else
            {
                Console.WriteLine("Denominator cannot be zero. Setting to default value of 1");
                _denominator = 1;
            }
    }

    //Using properties for getters and setters.
    public int Numerator
    {
        get {return _numerator;}
        set {_numerator = value;}
    }

    public int Denominator
    {
        get {return _denominator;}
        set {_denominator = value;}
    }
    public string GetFractionString()
    {
        string word = $"{_numerator}/{_denominator}";
        return word;
    }
    
    public double GetDecimalValue()
    {
        return (double)_numerator/(double)_denominator;
    }

    
}