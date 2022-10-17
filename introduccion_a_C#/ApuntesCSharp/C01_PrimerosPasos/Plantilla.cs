using System;
using Msg = System.Console;

public class Plantilla
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        Msg.WriteLine("Hola desde alias!");
        FuncionPideDatos();
    }
    // Esta es nuestra función
    public static void FuncionPideDatos()
    {
        Msg.WriteLine("hola desde nuestra función!");
    }
}