using Msg = System.Console;

public class Program
{
    public static void Main()
    {
        intMaxVal();
    } // end main
    // valor maximo de int
    public static void intMaxVal()
    {
        /*
         Checked & unchecked only works for:
        .int
        .long
         */


        checked // forces exception 
        {
            int number = int.MaxValue;
            Msg.WriteLine(number);
            Msg.WriteLine(number + 1);  // doesn't throw exception by default                                        // BUT throws exception if compilation options are checked for arithmetic overflow
            Msg.WriteLine((number + 1) - 1);
        }
        int number2 = int.MaxValue;
        number2 = checked(number2 +1); // another way of checking arythmetic overflow
        Msg.WriteLine(number2); 

        int number3 = int.MaxValue;
        number3 = unchecked(number3 + 1); // avoids arythmetic overflow exception
        Msg.WriteLine(number3);

    }
} // end class