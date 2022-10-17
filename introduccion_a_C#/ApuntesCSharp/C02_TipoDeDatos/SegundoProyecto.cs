using System;
using System.Linq.Expressions;
using Msg = System.Console;

public class SegundoProyecto
{
    public static void Main()
    {
        Console.WriteLine("Segundo proyecto");
        Msg.WriteLine("Hola desde alias!");
        FuncionPideDatos();
        FunctionBool();
    }
    // Esta es nuestra función
    public static void FuncionPideDatos()
    {
        Msg.WriteLine("hola desde nuestra función!");
        Msg.Write("Hey there\nbud\nPlease tell me your name:\n");
        try
        {
            string ?myInput = Msg.ReadLine();
            Msg.Write($"Hey there {myInput}");
        }
        catch (Exception e)
        {
            Msg.WriteLine(e.Message);

        }

    }

    // funcion bool
    public static void FunctionBool()
    {
        Msg.WriteLine("Bienvenido a la función del interruptor");
        bool isLightOn = false;
        Msg.WriteLine(GetLightStatus(isLightOn));
        Msg.WriteLine("Encendemos el interruptor.");
        isLightOn = true;
        Msg.WriteLine(GetLightStatus(isLightOn)); ;
        Msg.WriteLine("Lo volvemos a papagar");
        isLightOn = false;
        Msg.WriteLine(GetLightStatus(isLightOn));

    }

    // funcion estado
    public static string GetLightStatus(bool isLightOn)
    {
        string cadena = "El interruptor está ";
         return cadena + (isLightOn ? "encendido" : "apagado");
    }
 }