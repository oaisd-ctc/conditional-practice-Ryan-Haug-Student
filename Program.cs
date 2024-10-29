
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        CheckForPositiveNegativeZero(1);
        CheckForPositiveNegativeZero(0);
        CheckForPositiveNegativeZero(-1);

        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);

        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);

        IsDivisibleBy5(5);
        IsDivisibleBy5(6);

        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);

        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');

        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);
        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:

    public static void CheckForPositiveNegativeZero(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("this number is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine("this number is zero");
        }
        else
        {
            Console.WriteLine("this number is negative");
        }
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 <= num2 && num1 <= num3)
        {
            Console.WriteLine("the minimum is " + num1);
        }

        else if (num2 <= num1 && num2 <= num3)
        {
            Console.WriteLine("the minimum is " + num2);
        }

        else
        {
            Console.WriteLine("the minimum is " + num3);
        }
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("the maximum is " + num1);
        }

        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine("the maximum is " + num2);
        }

        else
        {
            Console.WriteLine("the maximum is " + num3);
        }
    }

    public static void IsDivisibleBy5(int number)
    {
        if ((number % 5) == 0)
        {
            Console.WriteLine(number + " can be divided by 5");
        }
        else
        {
            Console.WriteLine(number + " cannot be divided by 5");
        }
    }

    public static void CheckEvenOrOdd(int number)
    {
        if ((number % 2) == 0)
        {
            Console.WriteLine(number + " is even");
        }
        else
        {
            Console.WriteLine(number + " is not even");
        }
    }

    public static void CheckVowelOrConsonant(char letter)
    {
        if ("aeiou".Contains(letter) || "AEIOU".Contains(letter))
        {
            Console.WriteLine(letter + " is a Vowel");
        }
        else
        {
            Console.WriteLine(letter + " Is a consonant");
        }
    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        if (dayCode == 0) { Console.WriteLine("Sunday"); }
        else if (dayCode == 1) { Console.WriteLine("Monday"); }
        else if (dayCode == 2) { Console.WriteLine("Tuesday"); }
        else if (dayCode == 3) { Console.WriteLine("Wednesday"); }
        else if (dayCode == 4) { Console.WriteLine("Thursday"); }
        else if (dayCode == 5) { Console.WriteLine("Friday"); }
        else if (dayCode == 6) { Console.WriteLine("Saturday"); }
    }
}
