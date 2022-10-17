using System;
using System.Reflection.Metadata.Ecma335;
using Msg = System.Console;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Condicionales");
        // -- Programa para compara variables introducidas por teclado -- //
        Prompt();
        Prompt();        
    }

    // in-out prompt
    public static void Prompt()
    {
        Msg.WriteLine("Introduce el primer valor integer");
        int val1 = Convert.ToInt32(Msg.ReadLine());
        Msg.WriteLine("Introduce el segundo valor integer");
        int val2 = Convert.ToInt32(Msg.ReadLine());
        CompareValues(val1, val2);
    }

    // compare function
    public static void CompareValues(int val1, int val2)
    {
        Msg.Write($"\nLos valores {val1} y {val2} son ");
        if (val1 == val2)
        {
            Msg.Write("iguales\n");
        } else 
        {
            Msg.Write("diferentes\n");
            string a = "34";
        }
    }
    public static void Videojuego(int val1, int val2)
    {
        Msg.WriteLine("Bienvenido al videojuego!");
        int puntosVida = 100;
        int score = 0;
        Msg.WriteLine($"Tu vida es de {puntosVida} puntos, tu score es de {score} puntos");
        Msg.WriteLine("Encuentras un enemigo. Lanza tu ataque. Escrive un numero del 1 al 2");
        Random rnd = new Random();
        int dicethrow = Convert.ToInt32(Console.ReadLine());
        bool attackIsSuccessful = dicethrow == (Convert.ToInt32(rnd.Next(2)) + 1);
        if (attackIsSuccessful)
        {
            Msg.WriteLine("Has matado al enemigo!");
            --puntosVida;
            ++score;
        }
        else
        {
            Msg.WriteLine("Has fallado, tu enemigo te mató");
            puntosVida = 0;
        }
        Msg.WriteLine($"Tu vida es de {puntosVida} puntos, tu score es de {score} puntos");
    }
    
    // identificador de caracteres
    public static void IdChar()
    {
        char caracter = '♥';
        // analizaremos el caracter analizado con varios if anidados  
        if (char.IsLower(caracter))
        {
            Msg.WriteLine("El caracter es MINUSCULA");
        }
        else if (char.IsUpper(caracter))
        {
            Msg.WriteLine("El caracter es MAYUSCULA");
        }
        else if (char.IsDigit(caracter))
        {
            Msg.WriteLine("Es minuscula NUMERO");
        }
        else if (char.IsAscii(caracter))
        {
            Msg.WriteLine("Es Ascii");
        }
        else if (char.IsSymbol(caracter))
        {
            Msg.WriteLine("Es Simbolo");
        }
        else if (char.IsWhiteSpace(caracter))
        {
            Msg.WriteLine("Es espacio");
        }
    }
}