using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanJoseZapata.Models
{
    public static class VisualInterfaces
    {
        public static void ShowNumberError(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Debes ingresar un numero!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowInputError(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: No has ingresado una opcion valida!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowFindError(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Este elemento no existe dentro de la lista!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowHairCutError(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pelo ya esta corto!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowDeleteSuccesful(string prompt){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El {prompt} se ha eliminado correctamente!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowHairCutSuccesful(string prompt){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El tu peludito ya no es tan peludito!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}