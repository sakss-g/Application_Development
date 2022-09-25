// See https://aka.ms/new-console-template for more information

using ConsoleApp.Basics;
using ConsoleApp.Calculator;

int num1 = 0;
int num2 = 0;

//getting input from users
// Declare variables and then initialize to zero.


// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Use a switch statement to do the math.
var result = true;

while (result) 
{
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("Press 1 for Addition");
    Console.WriteLine("Press 2 for Subtraction");
    Console.WriteLine("Press 3 for Multiplication");
    Console.WriteLine("Press 4 for Division");
    Console.WriteLine("Press 5 for Jagged Arrays");
    Console.WriteLine("Press 6 for SingleDimensional Arrays");
    Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
    Console.WriteLine("Press 8 for MultiDimensional Arrays");
    Console.Write("Your option? ");
    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            num1 = Calculator.FirstNum();
            num2 = Calculator.SecondNum();
            Calculator.Additions(num1, num2);
            break;
        case "2":
            num1 = Calculator.FirstNum();
            num2 = Calculator.SecondNum();
            Calculator.Subtraction(num1, num2);
            break;
        case "3":
            num1 = Calculator.FirstNum();
            num2 = Calculator.SecondNum();
            Calculator.Multiplication(num1, num2);
            break;
        case "4":
            num1 = Calculator.FirstNum();
            num2 = Calculator.SecondNum();
            Calculator.Division(num1, num2);
            break;
        case "5":
            Arrays.JaggedArray();
            break;
        case "6":
            Arrays.SingleDimensionalArray();
            break;
        case "7":
            Arrays.ImplicitlyTypedArray();
            break;
        case "8":
            Arrays.MultiDimensionalArray();
            break;
        default:
            Interpolation.StringInterpolation();
            break;
    }

    Console.WriteLine("Do you want to continue? (y/n)");
    var runAgain = Console.ReadLine();

    if (runAgain == "Y" || runAgain == "y")
    {
        result = true;
    }
    else 
    {
        result = false;
    }
}


// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
