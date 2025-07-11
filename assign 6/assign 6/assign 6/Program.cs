using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Uncomment the method you want to run:

        //ValueTypeByValueAndRef();
        //ReferenceTypeByValueAndRef();
        //AddSubtract();
        // SumOfDigits();
        // CheckIsPrime();
        // MinMaxArray();
        // IterativeFactorial();
        // ChangeCharInString();
    }

    // 1. Value Type - Pass by value vs by reference
    static void ValueTypeByValueAndRef()
    {
        int a = 10;

        Console.WriteLine($"Original value: {a}");
        PassByValue(a);
        Console.WriteLine($"After pass by value: {a}");
        PassByRef(ref a);
        Console.WriteLine($"After pass by reference: {a}");
    }

    static void PassByValue(int x)
    {
        x = 20;
    }

    static void PassByRef(ref int x)
    {
        x = 30;
    }
    //ModifyValue doesn't change a because it works on a copy.

    //ModifyValueByRef changes a because it uses a reference to the original.



    // 2. Reference Type - Pass by value vs by reference
    class Person
    {
        public string Name;
    }

    static void ReferenceTypeByValueAndRef()
    {
        Person p = new Person { Name = "Alice" };

        Console.WriteLine("Original name: " + p.Name);
        ReferencePassByValue(p);
        Console.WriteLine("After pass by value: " + p.Name);
        ReferencePassByRef(ref p);
        Console.WriteLine("After pass by ref: " + p.Name);
    }

    static void ReferencePassByValue(Person p)
    {
        p.Name = "Bob";
        p = new Person { Name = "Charlie" };
    }

    static void ReferencePassByRef(ref Person p)
    {
        p = new Person { Name = "Dave" };
    }
    //1-(Passing by Value)The method receives a copy of the reference, so it can modify the object’s contents, but not the reference itself.
    //2-(Passing by Reference )The method can now modify both the object and the reference itself (assign a new object).
    // 3. Function to add & subtract two numbers
    static void AddSubtract()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int sum, diff;
        Calculate(a, b, out sum, out diff);

        Console.WriteLine($"Sum = {sum}, Difference = {diff}");
    }

    static void Calculate(int x, int y, out int sum, out int diff)
    {
        sum = x + y;
        diff = x - y;
    }

    // 4. Sum of digits of a number
    static void SumOfDigits()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int sum = 0, n = num;

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        Console.WriteLine($"The sum of the digits of the number {num} is: {sum}");
    }

    // 5. IsPrime
    static void CheckIsPrime()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n) ? "It is prime." : "It is not prime.");
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0)
                return false;
        return true;
    }

    // 6. MinMaxArray with ref parameters
    static void MinMaxArray()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int min = 0, max = 0;
        GetMinMax(arr, ref min, ref max);

        Console.WriteLine($"Min: {min}, Max: {max}");
    }

    static void GetMinMax(int[] arr, ref int min, ref int max)
    {
        min = max = arr[0];
        foreach (int n in arr)
        {
            if (n < min) min = n;
            if (n > max) max = n;
        }
    }

    // 7. Iterative factorial
    static void IterativeFactorial()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 2; i <= num; i++)
            result *= i;

        Console.WriteLine($"Factorial of {num} is: {result}");
    }

    // 8. Change character in string
    static void ChangeCharInString()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter index to modify: ");
        int index = int.Parse(Console.ReadLine());

        Console.Write("Enter new character: ");
        char ch = Console.ReadLine()[0];

        if (index < 0 || index >= input.Length)
        {
            Console.WriteLine("Invalid index.");
            return;
        }

        char[] arr = input.ToCharArray();
        arr[index] = ch;
        string result = new string(arr);

        Console.WriteLine("Modified string: " + result);
    }
}
