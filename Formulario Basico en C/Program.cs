﻿using System;

namespace Formulario_Basico_en_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            String ApellidoPaterno;
            String ApellidoMaterno;
            String Ocupacion;
            String Correo;
            String Mes;
            int Edad;

            Console.WriteLine("REGISTRO EN EL SISTEMA");
            Console.WriteLine("Ingresa Tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine(Nombre);

            Console.WriteLine("Ingrese su apellido Paterno");
            ApellidoPaterno = Console.ReadLine();
            Console.WriteLine(ApellidoPaterno);

            Console.WriteLine("Ingrese su apellido Materno");
            ApellidoMaterno = Console.ReadLine();
            Console.WriteLine(ApellidoMaterno);

            Console.WriteLine("Ingresa su ocupación ");
            Ocupacion = Console.ReadLine();
            Console.WriteLine(Ocupacion);

            Console.WriteLine("Ingresa su correo electronico ");
            Correo = Console.ReadLine();
            Console.WriteLine(Correo);

            Console.WriteLine("Ingresa tu edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            if (Edad <= 18)
            {
                Console.WriteLine("El usuario es menor de edad, Registro Fallido");
            }

        }
    }
}
