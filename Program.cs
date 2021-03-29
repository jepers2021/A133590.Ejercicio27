using System;

namespace A133590.Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 27");
            Console.WriteLine("Programa que muestra las fechas 30, 60, 90 y 180 días posterioes a una fecha válida.");

            Console.Write("Por favor, ingrese una fecha: ");
            DateTime fecha;
            if (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.WriteLine("La fecha ingresada no es válida.");
                return;
            }

            Console.WriteLine($"30 días: {fecha.AddDays(30).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"60 días: {fecha.AddDays(60).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"90 días: {fecha.AddDays(90).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"180 días: {fecha.AddDays(180).ToString("dd/MM/yyyy")}");
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
