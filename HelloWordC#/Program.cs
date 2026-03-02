using System.Globalization;

class MyFirstProgram
{
    static void Main(string[] args)
    {
        //Exercise1();
        //Exercise2();
        //Exercise3();
        // Exercise4();
        Exercise5();
    }
    static void Exercise1()
    {
        // This program displays a simple menu to the user,
        // allows selecting operations (addition or multiplication of two numbers),
        // and continues running until the user chooses to exit.
        // It includes input validation using TryParse.
        Console.WriteLine("Please give your Name");
        string name = Console.ReadLine();
        Console.WriteLine("Please give your age");
        string age = Console.ReadLine();
        int ageValue;
        bool success = int.TryParse(age, out ageValue);
        while (!success)
        {
            Console.WriteLine("Please give again a valid age");
            age = Console.ReadLine();
            success = int.TryParse(age, out ageValue);
        }
        int futureAge = ageValue + 10;
        Console.WriteLine("Hello " + name + " you will be  " + futureAge + " years old after 10 years");
    }




    static void ExerciseOperation()
    {
        string menu = "Please select an operation:\n" +
                      "1. Add two numbers\n" +
                      "2. Multiply two numbers\n" +
                      "3. Exit";

        int menuValue;

        while (true)
        {
            Console.WriteLine(menu);
            string choice = Console.ReadLine();

            if (int.TryParse(choice, out menuValue) &&
                (menuValue == 1 || menuValue == 2 || menuValue == 3))
            {
                break;
            }

            Console.WriteLine("Please give again a valid choice\n");
        }

        if (menuValue == 3)
            return;

        int firstValue = ReadNumber("Please give the first number");
        int secondValue = ReadNumber("Please give the second number");

        if (menuValue == 1)
            Console.WriteLine($"{firstValue} + {secondValue} = {firstValue + secondValue}");
        else
            Console.WriteLine($"{firstValue} * {secondValue} = {firstValue * secondValue}");
    }

    static int ReadNumber(string message)
    {
        int number;
        string input;

        Console.WriteLine(message);
        input = Console.ReadLine();

        while (!int.TryParse(input, out number))
        {
            Console.WriteLine("Please give again a valid number");
            input = Console.ReadLine();
        }

        return number;
    }
    static double ReadDouble(string message)
    {
        double temperature;
        string? input;//? Επιτρέπει να είναι null, καθώς το Console.ReadLine() μπορεί να επιστρέψει null

        while (true)
        {
            Console.WriteLine(message);
            input = Console.ReadLine();

            // Έλεγχος null
            if (input is null)
            {
                Console.WriteLine("Input cannot be empty. Try again.");
                continue;
            }

            // Προσπαθούμε να κάνουμε parse ως double (δέχεται και integers)
            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out temperature))
            {
                break;
            }

            Console.WriteLine("Please give a valid temperature (numbers only).");
        }

        return temperature;
    }
    static void Exercise2()
    {
        int number = 1;
        string str = "121Ax";
        char ch = 'a';
        decimal amount = 132.1m;
        bool success = false;
        Console.WriteLine("Number:" + number + "\nString:" + str + "\nchar:" + ch + "\ndecimal:" + amount + "\nbool:" + success);
    }


    static void Exercise4()
    {
        double celsius = ReadDouble("Please give the temperature in Celsius");
        double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        static double ConvertCelsiusToFahrenheit(double Celsius)
        {
            //°F = °C * 9/5 + 32
            return Celsius * 1.8 + 32; ;
        }
    }

    static void Exercise5()
    {
        Console.WriteLine("Please select an operator (+, -, *, /)");
        string Operator = Console.ReadLine();
        double firstValue, secondValue;
        switch (Operator)
        {
            case "+":
                firstValue = ReadDouble("Please give the first number");
                secondValue = ReadDouble("Please give the second number");
                Console.WriteLine($"{firstValue} + {secondValue} = {firstValue + secondValue}");
                break;
            case "-":
                firstValue = ReadDouble("Please give the first number");
                secondValue = ReadDouble("Please give the second number");
                Console.WriteLine($"{firstValue} - {secondValue} = {firstValue - secondValue}");
                break;
            case "*":
                firstValue = ReadDouble("Please give the first number");
                secondValue = ReadDouble("Please give the second number");
                Console.WriteLine($"{firstValue} * {secondValue} = {firstValue * secondValue}");
                break;
            case "/":
                firstValue = ReadDouble("Please give the first number");
                secondValue = ReadDouble("Please give the second number");
                Console.WriteLine($"{firstValue} / {secondValue} = {firstValue / secondValue}");
                break;
            default:
                Exercise5();
                break;
        }

    }

}







