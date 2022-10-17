using Msg = System.Console;

public class Program
{
    public static void Main()
    {
        askForNumber();
    } // end main
    public static void askForNumber()
    {
        Msg.WriteLine("Introduce a number.");
        try
        {

            int? num = int.Parse(Msg.ReadLine());
        } 
        catch (OverflowException e)
        {
            Msg.WriteLine(e.ToString());
        }
        catch (Exception e) when (e.GetType() != typeof(FormatException)) // si queremos poner un exception
        // no especifico antes de los especificos, se haria de esta manera
        {
            Msg.WriteLine(e.ToString());
        }
        catch (FormatException e)
        {
            Msg.WriteLine(e.ToString());
        }
        catch (IOException e)
        {
            Msg.WriteLine(e.ToString());
        } 
        


    }
} // end class