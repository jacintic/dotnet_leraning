using System;
using Msg = System.Console;

public class Operadores
{
    public static void Main()
    {

        // Operadores //
        Msg.WriteLine("");

        // -- asignación  
        int puntuacion = 100;
        puntuacion = 150;
        string fraseAMostrar = "El programa ha finalizado";

        // .. asignar en cadena
        int a = 1, b = 5, c = 15;
        // .. ..
        a = b = c = 100;


        // -- aritmeticos
        int z = a + b + c;
        // .. bool
        bool ordenBool = 3 > 2;
        // .. shorthand
        double number = 3;
        number *= 4;
        // .. incrementos
        number++; // incrementa 1 => muestra variable Y LUEGO incrementa
        ++number; // incrementa 1  => incrementa y muestra
        // .. shorthand if
        int dificultad = number < 18 ? 4 : 7;

        // -- 
        // -- 
        // ..
    }
}