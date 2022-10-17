using Msg = System.Console;

public class Program
{
    public static void Main()
    {
        PrintRangeMain();
    } // Main end

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
            }
        }
    }
}  // Class end


