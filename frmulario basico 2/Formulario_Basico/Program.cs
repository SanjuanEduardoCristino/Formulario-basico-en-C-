using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom, ape, apm, numt, co, ocup;
            int e;

            Console.Write("Ingresa los datos que se solicitan a continuación: \n");
            Console.WriteLine("\nNombre: ");
            nom = Console.ReadLine();


            Console.WriteLine("\nApellido Paterno: ");
            ape = Console.ReadLine();

            Console.WriteLine("\nApellido Materno: ");
            apm = Console.ReadLine();

            Console.WriteLine("\nNumero Telefonico: ");
            numt = Console.ReadLine();

            Console.WriteLine("\nCorreo: ");
            co = Console.ReadLine();

            Console.WriteLine("\nOcupación: ");
            ocup = Console.ReadLine();

            Console.WriteLine("\nEdad: ");
            e = Convert.ToInt32(Console.ReadLine());

           
            if (e >= 18)
            {
                Console.WriteLine("\n\nRegistro Exitoso, sus datos son los siguientes: ");
                Console.WriteLine("\nNombre: " + nom + ape + apm);
                Console.WriteLine("\nEdad: " + e);
                Console.WriteLine("\nNumero de telefono: " + numt);
                Console.WriteLine("\nCorreo: " + co);
                Console.WriteLine("\nOcupacion: " + ocup);

            }
            else if (e < 17)
            {
                Console.WriteLine("\nRegistro Fallido, el usuario es menor de edad");
            }

            Console.Write("\n\nFin del programa");
            Console.ReadLine();
        }
    }
}
