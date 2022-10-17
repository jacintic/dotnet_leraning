using System;
using Msg = System.Console;


public class Program
{


    public static void Main()
    {
        int a = 10;
        Msg.WriteLine(a);

        {
            int b = 20;
            Msg.WriteLine(b);
        }

        //Msg.WriteLine(b); // b no existe en este contexto
        Msg.WriteLine(a); // a si está dentro del contexto
    } //Finde Funcion Main

    void PrimeraFuncion()
    {
        numero1 = 1500;
        Msg.WriteLine(numero1);
        Msg.WriteLine(numero2);
    }

    void SegundaFuncion()
    {
        numero1 = 1800;
        Msg.WriteLine(numero2);
        Msg.WriteLine(numero1);
    }




    int numero1 = 1000;
    int numero2 = 2000;
}  // Fin de clase
