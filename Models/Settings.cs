using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanJoseZapata.Models
{
    public static class Settings
    {
        public static string ValidateString(string prompt)
        {
            string aValidar;

            do
            {
                Console.Write(prompt);
                aValidar = Console.ReadLine() ?? " "; // esto "??" me valida si es nulo, y si lo es me devuelve lo de la derecha

            } while (string.IsNullOrWhiteSpace(aValidar));

            return aValidar;
        }
        public static int ValidateInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string sAvalidar = Console.ReadLine() ?? " ";

                int result;
                if (int.TryParse(sAvalidar, out result))
                {
                    return result;
                }
                else
                {
                    VisualInterfaces.ShowNumberError();
                }

            }
        }

        public static double ValidateDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string sAvalidar = Console.ReadLine() ?? " ";

                double result;
                if (double.TryParse(sAvalidar, out result))
                {
                    return result;
                }
                else
                {
                    VisualInterfaces.ShowNumberError();
                }
            }
        }
    }
}