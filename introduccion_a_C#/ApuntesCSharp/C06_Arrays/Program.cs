
using System.Security.Cryptography.X509Certificates;
using Msg = System.Console;

public class Program
{
    public static void Main()
    {

        // metodos basicos array
        // MetodosBasicosArray();

        // programa, encontrar duplicados
        // declaración de array
        int[] arr = new int[] { 1, 2, 3, 2, 5, 4, 6, 5};
        PrintArray(ConstruirArrayDeUnicos(arr));
        HashSet<int> noDups = new HashSet<int>(arr);
        Msg.WriteLine(string.Join(", ", noDups));

        // methods taken from internet
        // #1
        // string arrayWithDuplicateValues=  {"hand", "leg", "hand", "leg" };
        /*var distinctArray = arrayWithDuplicateValues.Distinct().ToArray(); // after:  {"hand", "leg" }

        // #2
        var distinctArray = arrayWithDuplicateValues.ToHashSet().ToArray();

        // #3
        var hashSet = new HashSet<T>(arrayWithDuplicateValues);
        var distinctArray = hashSet.ToArray();*/

        //MetodosBasicosArrayII();

        // Crear un array 2D, llenarlo de datos autmoatico y realizar una busqueda en dicho array
        // // llenado de valores random
        // // introduce un valor a buscar (pedido por pantalla)

        PracticarArr2D();
    }

    // Encontrar duplicados
    public static int[] ConstruirArrayDeUnicos(int[] arr)
    {
        int[] sinDuplicados = new int[0];
        int posCounter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int curr = arr[i];
            if (Array.IndexOf(sinDuplicados, curr) == -1)
            {
                Array.Resize(ref sinDuplicados, sinDuplicados.Length + 1);
                sinDuplicados[posCounter++] = curr;
            }
        }
        return sinDuplicados;
    }

    // print array
    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            Console.Write(i != arr.Length - 1 ? ",": "\n"); 
        }

    }

    // arr 2D
    public static void PracticarArr2D()
    {

        // Crear un array 2D, llenarlo de datos autmoatico y realizar una busqueda en dicho array
        // // llenado de valores random
        // // introduce un valor a buscar (pedido por pantalla)
        // crear array
        int[,] arr = new int[2, 3];
        // llenarlo de valores random
        for (int fila = 0; fila < arr.GetLength(0); fila++)
        {
            for (int columna = 0; columna < arr.GetLength(1); columna++)
            {
                Random rnd = new Random();
                arr[fila, columna] = Convert.ToInt32(rnd.Next(10)) + 1;
            }
        }
        Print2DArr(arr);
        FindIntInArr(arr,3);
        //arrCorrection2D(arr,3);
    }

    // print array 2D
    public static void Print2DArr(int[,] arr)
    {
        Msg.WriteLine("Printing 2D array");
        for (int fila = 0; fila < arr.GetLength(0); fila++)
        {
            for (int columna = 0; columna < arr.GetLength(1); columna++)
            {
                Msg.WriteLine(arr[fila, columna]);
            }
        }
    }

    // find int in array 2D
    public static void FindIntInArr(int[,] arr, int num)

    {
        for (int fila = 0; fila < arr.GetLength(0); fila++)
        {
            for (int columna = 0; columna < arr.GetLength(1); columna++)
            {
                if (arr[fila, columna] == num)
                {
                    Msg.WriteLine($"La posición de {num} en el array es [{fila},{columna}].");
                    return;
                }
            }
        }
        Msg.WriteLine($"La posición de {num} no se encuentra en el array");
    }

    // 2D arr random notes
    public static void arrCorrection2D(int[,] arr, int num)
    {
        Msg.WriteLine("hi");
    }

        // MetodosBasicosArray
        public static void MetodosBasicosArray()
    {
        Console.WriteLine("Arrays");
        int[] nums = new int[3]; // declaración de la longitud del array
        float[] decimals = new float[3];

        // asignar valoresint
        int[] array1 = new int[3] { 1, 2, 3 };
        int[] array2 = new int[] { 1, 2, 3 };
        int[] array3 = { 1, 2, 3 };

        // + definiciones
        float[] reales = new float[3] { 1.0f, 2.3f, 5.3f };

        // acceso a datos
        Msg.WriteLine(reales[1]);

        // modificar datos
        reales[1] = 7.5f;
        Msg.WriteLine(reales[1]);

        // length
        Msg.WriteLine(reales.Length);

        // arr iteration
        for (int i = 0; i < reales.Length; i++)
        {
            Msg.WriteLine(reales[i]);
        }
        // foreach
        foreach (float item in reales)
        {
            Msg.WriteLine(item);
        }

        // arrays 2D
        string[,] ciudades = new string[2, 3];
        ciudades[0, 0] = "Barcelona";
        ciudades[0, 1] = "Madrid";
        ciudades[0, 2] = "Pamplona";
        ciudades[1, 0] = "Teruel";
        ciudades[1, 1] = "Bilvao";
        ciudades[1, 2] = "Valencia";

        // printing
        for (int i = 0; i < ciudades.GetLength(0); i++)
        {
            for (int j = 0; j < ciudades.GetLength(1); j++)
            {
                Msg.WriteLine(ciudades[i, j]);
            }
        }
    }

    // II
    public static void MetodosBasicosArrayII()
    {
        Msg.WriteLine("Buscar pos de elemento en array");
        int[] arr = new int[5] { 1, 2, 3, 4, 5, };
        Msg.WriteLine("La posición de 3 es " + Array.IndexOf(arr, 3));

    }

}