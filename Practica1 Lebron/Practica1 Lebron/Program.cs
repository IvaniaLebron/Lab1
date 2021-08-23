using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_Lebron
{
    class Program
    {
        static void Raiz()
        {
            Console.WriteLine("Calculando Raices");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n La raiz cuadrada del numero " + i + " es:" + Math.Round(Math.Sqrt(i), 2));
            }
        }
        static void Main(string[] args)
        {
            DateTime fechaNacimiento = new DateTime(200, 01, 01);
            DateTime now = DateTime.Today;
            int edad= DateTime.Today.Year - fechaNacimiento.Year;
            if(DateTime.Today < fechaNacimiento.AddYears(edad))
            {
            edad--;
            }
            Console.WriteLine("Para" + fechaNacimiento.ToString("d"));
            Console.WriteLine("La edad es: " + edad);

           // Double edad;
           // Console.WriteLine("Ingrese el año de su nacimiento: ");
          //  edad = Convert.ToDouble(Console.ReadLine());
          //  Console.WriteLine("Su edad es: "+Edad(edad));


            Console.ReadKey();
        }
        static Double Edad(Double e)
        {
            return 2021 - e;
        }
        static void Faren()
        {
            Double cel, far;
            Console.WriteLine("Escribe los grados Celsius");
            cel = Convert.ToDouble(Console.ReadLine());
            far = cel * 9.0 / 5.0 + 32;
            Console.WriteLine($"{cel} grados Celsius son {Math.Round(far, 2)} grados Fahrenheit");
        }
        static void Celsius()
        {
            Double cel, far;
            Console.WriteLine("Escribe los grados Fahrenheit: ");
            far = Convert.ToDouble(Console.ReadLine());
            cel = (far - 32) * 5.0 / 9.0;
            Console.WriteLine($"{far} grados Fahrenheit son {Math.Round(cel, 2)} grados Celsius");
        }
        static void Kelvin()
        {
            Double cel, kel;
            Console.WriteLine("Escribe los grados Celsius");
            cel = Convert.ToDouble(Console.ReadLine());
            kel = cel + 273;
            Console.WriteLine($"{cel} grados Celsius son {kel} grados Kelvin");

        }
        static void ej3()
        {
            string opc;
            Console.WriteLine("\t\t PROGRAMA PARA CONVERTIR TEMPERATURAS");
            Console.WriteLine("\nElige el tipo de conversión");
            Console.WriteLine("\n\nPresiona F si quieres convertir Celsius a Fahrenheit");
            Console.WriteLine("Presiona C si quieres convertir Fahrenheit a Celsius");
            Console.WriteLine("\nElige F, C o K:");

            opc = Console.ReadLine();
            switch (opc)
            {
                case "F":
                case "f":
                    Console.WriteLine("\nConversión a F");
                    Faren();
                    break;
                case "C":
                case "c":
                    Console.WriteLine("\nConversión a C");
                    Celsius();
                    break;
                case "k":
                case "K":
                    Console.WriteLine("\nConversión a K");
                    Kelvin();
                    break;
                default:
                    Console.WriteLine("No válido");
                    break;
            }
        }
    }
}

