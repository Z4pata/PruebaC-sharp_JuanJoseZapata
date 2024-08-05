using System;
using System.Collections.Generic;
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
    }
}