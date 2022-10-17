using System;
using Msg = System.Console;

public class Ambito2
{
    static string Nombre = "Gonzalo";
    public static void Main()
    {
        int edad = 30;
        Msg.WriteLine("Hola " + Nombre + " tienes " + edad + " años");
    }
}