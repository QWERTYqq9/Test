using System;

class Number
{
    protected int value;

    public Number(int value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return value.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Number other = (Number)obj;
        return value == other.value;
    }

    public override int GetHashCode()
    {
        return value.GetHashCode();
    }

    public static Number operator +(Number num1, Number num2)
    {
        return new Number(num1.value + num2.value);
    }

    public static Number operator -(Number num1, Number num2)
    {
        return new Number(num1.value - num2.value);
    }

    public static Number operator *(Number num1, Number num2)
    {
        return new Number(num1.value * num2.value);
    }

    public static Number operator /(Number num1, Number num2)
    {
        if (num2.value == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль!");
            return null;
        }

        return new Number(num1.value / num2.value);
    }
}

class Sign : Number
{
    public Sign(int value) : base(value)
    {
    }
}

class SimpleFraction
{
    private Number numerator;
    private Number denominator;

    public SimpleFraction(Number numerator, Number denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public override string ToString()
    {
        return numerator.ToString() + " / " + denominator.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        SimpleFraction other = (SimpleFraction)obj;
        return numerator.Equals(other.numerator) && denominator.Equals(other.denominator);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(numerator.GetHashCode(), denominator.GetHashCode());
    }

    public void Display()
    {
        Console.WriteLine("Простий дріб: " + ToString());
    }

    public static SimpleFraction Add(SimpleFraction frac1, SimpleFraction frac2)
    {
        Number num = frac1.numerator * frac2.denominator + frac2.numerator * frac1.denominator;
        Number den = frac1.denominator * frac2.denominator;
        return new SimpleFraction(num, den);
    }

    public static SimpleFraction Subtract(SimpleFraction frac1, SimpleFraction frac2)
    {
        Number num = frac1.numerator * frac2.denominator - frac2.numerator * frac1.denominator;
        Number den = frac1.denominator * frac2.denominator;
        return new SimpleFraction(num, den);
    }

    public static SimpleFraction Multiply(SimpleFraction frac1, SimpleFraction frac2)
    {
        Number num = frac1.numerator * frac2.numerator;
        Number den = frac1.denominator * frac2.denominator;
        return new SimpleFraction(num, den);
    }

    public static SimpleFraction Divide(SimpleFraction frac1, SimpleFraction frac2)
    {
        Number num = frac1.numerator * frac2.denominator;
        Number den = frac1.denominator * frac2.numerator;
        return new SimpleFraction(num, den);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SimpleFraction fraction1 = new SimpleFraction(new Sign(2), new Sign(3));
        SimpleFraction fraction2 = new SimpleFraction(new Sign(5), new Sign(6));

        fraction1.Display();
        fraction2.Display();

        SimpleFraction sum = SimpleFraction.Add(fraction1, fraction2);
        SimpleFraction difference = SimpleFraction.Subtract(fraction1, fraction2);
        SimpleFraction product = SimpleFraction.Multiply(fraction1, fraction2);
        SimpleFraction quotient = SimpleFraction.Divide(fraction1, fraction2);

        sum.Display();
        difference.Display();
        product.Display();
        quotient.Display();
    }
}
