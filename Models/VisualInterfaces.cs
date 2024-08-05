using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanJoseZapata.Models
{
    public static class VisualInterfaces
    {
        public static void ShowNumberError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Debes ingresar un numero!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowInputError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: No has ingresado una opcion valida!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowFindError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Este elemento no existe dentro de la lista!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowHairCutError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pelo ya esta corto!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowDeleteSuccesful(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El {prompt} se ha eliminado correctamente!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowHairCutSuccesful()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El tu peludito ya no es tan peludito!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string ShowMainMenu()
        {
            Console.WriteLine(@"
                Tipo de paciente

                1. Perro

                2. Gato

                3. Busquedas

                0. Salir");

            return Settings.ValidateString("==> ");
        }

        public static string ShowDogsMenu()
        {
            ManagerApp.ShowHeader("Perritos 🐕");
            Console.WriteLine(@"
                Que deseas hacer?

                1. Agregar paciente
                2. Actualizar paciente
                3. Eliminar paciente
                4. Mostrar todos los perritos a nuestro cargo
                
                0. Salir");

                return Settings.ValidateString("==> ");
        }
    }
}