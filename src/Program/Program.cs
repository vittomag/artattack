﻿Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));


// Esta clase implementa la operación división
public class Division
{
    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}

// Esta clase implementa la operación resta
public class Resta
{
    public static int Restar(int a, int b)
    {
        return a - b;
    }
}

