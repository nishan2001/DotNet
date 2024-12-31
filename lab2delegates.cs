using System;

class Sum
{
    public delegate void AddNum(int a, int b);
    public void SumNumbers(int a, int b)
    {
        Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, a + b);
    }

    public static void Main(string[] args)
    {
        Sum obj = new Sum();
        AddNum delObj = new AddNum(obj.SumNumbers);

     
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

       
        delObj(num1, num2);
        Console.ReadKey();
    }
}


