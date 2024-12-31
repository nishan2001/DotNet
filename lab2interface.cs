using System;

interface ICalculator
{
    void Add(int a, int b);
    void Subtract(int a, int b);
    void Multiply(int a, int b);
    void Divide(int a, int b);
}

class Calculator : ICalculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition: {0} + {1} = {2}", a, b, a + b);
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction: {0} - {1} = {2}", a, b, a - b);
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication: {0} * {1} = {2}", a, b, a * b);
    }

    public void Divide(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine("Division: {0} / {1} = {2}", a, b, (double)a / b);
        }
        else
        {
            Console.WriteLine("Division by zero is indeterminant");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        calc.Add(num1, num2);
        calc.Subtract(num1, num2);
        calc.Multiply(num1, num2);
        calc.Divide(num1, num2);
        Console.ReadKey();
    }
}
