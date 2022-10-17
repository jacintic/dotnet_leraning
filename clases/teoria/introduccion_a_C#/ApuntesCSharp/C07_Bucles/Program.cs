using Msg = System.Console;

public class Program
{
    public static void Main()
    {
        string[] armas = new string[6] {"Espada", "Puñal", "Shurikens", "Daga", "Arco", "Garrote" };
        // for basico
        for (int i = 0; i < armas.Length; i++)
        {
            Console.WriteLine(armas[i]);
        }
        // foreach
        foreach(string arma in armas)
        {
            Console.WriteLine(arma);
        }

        /// Control de bucles
        /// break
        for(int i = 0; i < 100; i++)
        {
            Msg.WriteLine(i);
            if (i == 30)
            {
                break;
            }
        }
        Console.Clear();
        //// continue
        for (int i = 0; i < 100; i++)
        {
            if (i < 90)
            {
                continue; // skip to next iteration of the loop
            }
            Msg.WriteLine(i);
        }
        Console.Clear();
        // mostrar impares 1-50
        for (int i = 0; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Msg.WriteLine(i);
        }

        // while
        int contador = 1;
        Console.Clear();
        while (contador <= 10)
        {
            
            if (contador++ % 2 == 0)
            {
                contador++;
                continue;
            }
            Msg.WriteLine(contador);
            contador++;
        }

        // do while
        int contII = 1;
        do
        {
            Msg.WriteLine(contII);
            contII++;
        } while (contII <= 10);

        // switch
        Console.Clear();
        int var = 3;
        switch (var)
        {
            case 0:
                Msg.WriteLine("It's 0");
                break;
            case 1:
                Msg.WriteLine("It's 1");
                break;
            case 3:
                Msg.WriteLine("It's 3");
                break;
            default:
                Msg.WriteLine("It's Unknown");
                break;
        }
    }
}