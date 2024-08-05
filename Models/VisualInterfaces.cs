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
            Console.WriteLine("Error: Este paciente no existe en nuestra base de datos!!");
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
            Console.WriteLine($"Tu peludito ya no es tan peludito!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowSaveSuccesful()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El Paciente se ha guardado exitosamente!!");
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
                5. Buscar un perrito
                
                0. Salir");

            return Settings.ValidateString("==> ");
        }
        public static string ShowCatsMenu()
        {
            ManagerApp.ShowHeader("Gatitos 😺");
            Console.WriteLine(@"
                Que deseas hacer?

                1. Agregar paciente
                2. Actualizar paciente
                3. Eliminar paciente
                4. Mostrar todos los gatitos a nuestro cargo
                5. Buscar un gatito
                
                0. Salir");

            return Settings.ValidateString("==> ");
        }

        public static string ShowSearchesMenu()
        {
            ManagerApp.ShowHeader("Busquedas!");
            Console.WriteLine(@"
                Que deseas ver?

                1. Todos los pacientes
                2. Un paciente en especifico
                3. Todos los perros
                4. Todos los gatos

                0. Salir");

            return Settings.ValidateString("==> ");
        }

        public static string ShowPatientMenu(string prompt){
            Console.WriteLine(@$"
            Que deseas hacer con este {prompt}?:

            1. Cortarle el pelo
            2. Castrarlo

            0. Salir");
        
        return Settings.ValidateString("==> ");
        }
    }
}