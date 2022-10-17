using Msg = System.Console;
using System.IO;

public class Program
{
    public static void Main()
    {
        ExceptionHandling();
    } // end main
    public static void ExceptionHandling()
    {
        StreamReader archivo = null;
        try
        {
            string linea;
            string Ubicación = @"D:\jacint_clases\.net\dotnet_leraning\clases\teoria\introduccion_a_C#\ApuntesCSharp\archivos\arch01.txt";
            archivo = new StreamReader(Ubicación);
            // !
            // StreamWriter
            while ((linea = archivo.ReadLine()) != null)
            {
                Msg.WriteLine(linea);
            }
        }
        catch (Exception e)
        {
            Msg.WriteLine(e.Message);
        }
        finally
        {
            if (archivo != null)
            {
                archivo.Close();
                Msg.WriteLine("La conexión con el fichero se cerrró correctamente.");
            }
        }
    }
} // end class