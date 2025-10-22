
using System;

class Program
{ 
    static void Main()
    {
        Console.WriteLine("=== Mini Calculator ===");

        Console.Write("Enter the first number: ");
        bool isNumber1 = double.TryParse(Console.ReadLine(), out double num1);

        
        Console.Write("Enter the second number: ");
        bool isNumber2 = double.TryParse(Console.ReadLine(), out double num2);

        
        if (!isNumber1 || !isNumber2)
        {
            Console.WriteLine("⚠️ Please enter valid numbers!");
            return;
        }

       
        Console.Write("Choose the operation type (+, -, *, /): ");
        string op = Console.ReadLine();

        double result = 0;
        bool validOperation = true;

        // 4. Hesaplama
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("⚠️ 0 division error!");
                    validOperation = false;
                }
                else
                    result = num1 / num2;
                break;
            default:
                Console.WriteLine("⚠️ You chose invalid operation!");
                validOperation = false;
                break;
        }

        // 5. Sonuç
        if (validOperation)
            Console.WriteLine($"Result: {result}");
    }
}
