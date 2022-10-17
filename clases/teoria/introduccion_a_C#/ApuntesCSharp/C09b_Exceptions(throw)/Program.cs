using Msg = System.Console;

// throw
public class Program
{
    public static void Main()
    {
        throwingExceptions();
    } // end main
    public static void throwingExceptions()
    {

        Msg.WriteLine("Introduce the month number.");
        int NumeroMes = 0;
        // gestiona
        try
        {
            NumeroMes = int.Parse(Msg.ReadLine());
        }
        catch (FormatException e)
        {
            Msg.WriteLine("Month isn't a numeric value.");
        }
        catch (IndexOutOfRangeException e)
        {
            Msg.WriteLine("Numeric value out of integer 32 value.");
        }
        catch (Exception e)
        {
            Msg.WriteLine($"Unknown exception:\n{e.Message}");
        }
        try
        {
        
            Msg.WriteLine(NombreDelMes(NumeroMes));
        }
        catch (ArgumentOutOfRangeException e)
        {
            Msg.WriteLine("Month out of range.");
        }
        catch (Exception e)
        {
            Msg.WriteLine($"Unknown exception:\n{e.Message}");
        }
        Msg.WriteLine("Code continues executing.");
    } // end throw method

    public static string NombreDelMes(int mes)
    {
        switch(mes)
        {
            case 1:
                return "Enero";
            case 2:
                return "Febrero";
            case 3:
                return "Marzo";
            case 4:
                return "Abril";
            case 5:
                return "Mayo";
            case 6:
                return "Junio";
            default:
                throw new ArgumentOutOfRangeException();
        } // end of switch
    } // end of month method
} // end class