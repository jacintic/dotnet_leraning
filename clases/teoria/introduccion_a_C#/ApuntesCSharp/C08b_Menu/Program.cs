using Msg = System.Console;

public class Program
{
    public static void Main()
    {

        string? Option;
        do 
        {
            
            PrintMenu();
            Option = Msg.ReadLine();
            switch (Option)
            {
                case "1":
                    PrintRangeMain();
                    break;
                case "2":
                    Print("Hey!");
                    break;
                case "3":
                    Print("Ho!");
                    break;
                case "4":
                    isPrimePrompt();
                    break;
                default:
                    break;
            }
            if(Option != "-1")
            {
                Msg.WriteLine("Press any key to proceed.");
                Console.ReadKey();
                Console.Clear();
            }
        } while (Option != "-1");

    } // Main end

    // print menu
    public static void PrintMenu()
    {
        Msg.WriteLine("Bienvenido al Menu");
        Msg.WriteLine("Lista de items");
        Msg.WriteLine("1. Imprimir rango de numeros");
        Msg.WriteLine("2. Imprimir 'Hey!'");
        Msg.WriteLine("3. Imprimir 'Ho!'");
        Msg.WriteLine("4. Comprovar si numero es primo");
        Msg.WriteLine("Introduce el numero de item que quieres ejecutar");
        Msg.WriteLine("Introduce '-1' para salir del programa");
    }

    public static void PrintRangeMain()
    {
        Msg.WriteLine("This program prints a number range from number x to number y. Press any key to proceed.");
        Console.ReadKey(); // Pause execution 
        Console.Clear(); // Clear console
        Msg.WriteLine("Introduce the smaller number.");
        int smallVal = Convert.ToInt32(Msg.ReadLine());
        Msg.WriteLine("Introduce the bigger number.");
        int bigVal = Convert.ToInt32(Msg.ReadLine());
        PrintRange(smallVal, bigVal);


    }

    // print range funct
    public static void PrintRange(int min, int max)
    {
        Msg.WriteLine("Press any key to print the range.");
        Console.ReadKey(); // Pause execution 
        Console.Clear(); // Clear console
        for (int i = min; i <= max; i++)
        {
            Msg.Write(i);
            if (i != max)
            {
                Msg.Write(",");
            } else
            {
                Msg.WriteLine("");
            }
        }
    }

    // Print string
    public static void Print(string msg)
    {
        Msg.WriteLine(msg);
    }

    // is prime prompt
    public static void isPrimePrompt()
    {
        Console.Clear();
        Msg.WriteLine("Introduce the number to check for prime condition.");
        int num = Convert.ToInt32(Msg.ReadLine());
        if (NumberIsPrime(num))
        {
            Msg.WriteLine($"{num} is a prime number");
        } else
        {
            Msg.WriteLine($"{num} is not a prime number");
        }
    }

    // determine prime number
    public static bool NumberIsPrime(int n)
    {
        if (n <= 1)
            return false;

        // Check if n=2 or n=3
        if (n == 2 || n == 3)
            return true;

        // Check whether n is divisible by 2 or 3
        if (n % 2 == 0 || n % 3 == 0)
            return false;

        // Check from 5 to square root of n
        // Iterate i by (i+6)
        for (int i = 5; i <= Math.Sqrt(n); i = i + 6)
            if (n % i == 0 || n % (i + 2) == 0)
                return false;

        return true;
    }
}  // Class end


