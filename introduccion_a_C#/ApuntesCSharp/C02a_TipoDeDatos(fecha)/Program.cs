using System;
using Msg = System.Console;

public class Plantilla
{
    public static void Main()
    {
        // Creamos una fecha inicial, el valor minimo
        DateTime dt = new DateTime();
        Msg.WriteLine(dt);
        //fecha actual
        dt = DateTime.Now;
        Msg.WriteLine(dt);
        // fecha concreta
        DateTime FechaCumple = new DateTime(1986, 08, 17); // yyyy, mm, dd
        // con hora
        DateTime CumpleHora = new DateTime(1986, 08, 17, 05,15, 00); // yyyy, mm, dd, hh, mm,  ss
        Msg.WriteLine(CumpleHora);
        // solo fecha
        DateTime FechaCumpleSoloHora = CumpleHora;
        Msg.WriteLine(FechaCumpleSoloHora.ToShortDateString());
        // solo hora
        Msg.WriteLine(FechaCumpleSoloHora.ToShortTimeString());
        // fecha larga 
        Msg.WriteLine(FechaCumpleSoloHora.ToLongDateString());
        // formato mm/dd/yyyy
        var FechaEng = new System.Globalization.CultureInfo("en-US");
        Msg.WriteLine(DateTime.Now.ToString(FechaEng.DateTimeFormat));
        // ES
        var FechaES = new System.Globalization.CultureInfo("es-Es");
        Msg.WriteLine(DateTime.Now.ToString(FechaES.DateTimeFormat));
        // MODO DE VISUALIZACIÓN
        DateTime NuevaFecha = new DateTime(2025, 12, 05, 11, 00, 00);
        Msg.WriteLine(NuevaFecha.ToString("d")); //  d/m/y                  05/12/2025
        Msg.WriteLine(NuevaFecha.ToString("D")); // d mL, yyyy              viernes, 5 de diciembre de 2025
        Msg.WriteLine(NuevaFecha.ToString("f")); // d mL, yyyy, hh:mm       viernes, 5 de diciembre de 2025 11:00    
        Msg.WriteLine(NuevaFecha.ToString("F")); // d mL, yyyy, hh:mm:ss    viernes, 5 de diciembre de 2025 11:00:00
        Msg.WriteLine(NuevaFecha.ToString("y")); // mL- yL -                diciembre de 2025
        Msg.WriteLine(NuevaFecha.ToString("M")); // d - mL                  5 de diciembre
        Msg.WriteLine(NuevaFecha.ToString("dd'/'MM'/'yyyy")); //            05/12/2025
        Msg.WriteLine(NuevaFecha.ToString("ddd'/'MM'/'yyyy")); //           vie./12/2025
        Msg.WriteLine(NuevaFecha.ToString("ddd dd/MM/yyyy")); //        vie. 05/12/2025
        Msg.WriteLine(NuevaFecha.ToString("ddd'/'MM'/'yyyy", System.Globalization.CultureInfo.InvariantCulture)); //Fri / 12 / 2025
        //
        // calculos
        // numero de dias entre dos fechas 
        // fecha de hoy
        DateTime d1 = DateTime.Now;
        // mostramos
        Msg.WriteLine(d1);
        // establecemos una fecha cualquiera
        DateTime d2 = new DateTime(2053, 08, 17);
        Msg.WriteLine(d2);
        // calculamos tiempo entre fechas
        // Calculate the interval between the two dates.
        TimeSpan interval = d2 - d1;
        Msg.WriteLine(interval.ToString()); // formato to raro
        Msg.WriteLine("Diferencia en dias: ");
        // Calculate the interval between the two dates.
        Msg.WriteLine(interval.Days);
        Msg.WriteLine(interval.TotalDays);
        // otra forma de obtener timespan
        Msg.WriteLine(d2.Subtract(d1).Days);
        // shothand
        Msg.WriteLine(new DateTime(2023, 1, 1).Subtract(DateTime.Now).Days);





    }

}