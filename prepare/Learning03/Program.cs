using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;



class program
{\
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Control.WriteLine(frac1.GetFractionString());
        Control.WriteLine(frac1.GetDecimalValue());

        Fraction frac2 = new Fraction(5);
        Control.WriteLine(frac2.GetFractionString());
        Control.WriteLine(frac2.GetDecimalValue());

        Fraction frac3 = new Fraction(3,4);
        Control.WriteLine(frac3.GetFractionString());
        Control.WriteLine(frac3.GetDecimalValue());

        raction frac3 = new Fraction(1,3);
        Control.WriteLine(frac4.GetFractionString());
        Control.WriteLine(frac4.GetDecimalValue());
    }
}