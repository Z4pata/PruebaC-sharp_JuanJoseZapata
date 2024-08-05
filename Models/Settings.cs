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

        public static bool ValidateBool(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string opc = Console.ReadLine() ?? " ";

                switch (opc.Trim().ToLower())
                {
                    case "si":
                        return true;

                    case "no":
                        return false;

                    default:
                        VisualInterfaces.ShowInputError();
                        break;
                }
            }
        }

        public static string ValidateHair()
        {
            string[] coatTypes = ["sin pelo", "pelo corto", "pelo mediano", "pelo largo"];

            while (true)
            {
                Console.WriteLine(@"Que tipo de pelaje tiene?
    - Sin pelo
    - Pelo corto
    - Pelo mediano
    - Pelo largo");
                string coatType = ValidateString("==> ").ToLower();

                if (coatTypes.Contains(coatType))
                {
                    return coatType;
                }
                else
                {
                    VisualInterfaces.ShowInputError();
                }
            }
        }

        public static string ValidateTemperament()
        {
            string[] temperaments = ["timido", "normal", "agresivo"];

            while (true)
            {
                Console.WriteLine(@"Que temperamento tiene?
    - Timido
    - Normal
    - Agresivo");

                string temperament = ValidateString("==> ").ToLower();

                if (temperaments.Contains(temperament))
                {
                    return temperament;
                }
                else
                {
                    VisualInterfaces.ShowInputError();
                }
            }
        }

        public static int ValidateYear(string prompt)
        {
            while (true)
            {
                int year = ValidateInt(prompt);
                if (year < DateTime.Now.Year)
                {
                    return year;
                }
                else
                {
                    VisualInterfaces.ShowYearError();
                }
            }
        }

        public static int ValidateMonth(string prompt)
        {
            while (true)
            {
                int month = ValidateInt(prompt);
                if (month < 12)
                {
                    return month;
                }
                else
                {
                    VisualInterfaces.ShowMonthError();
                }
            }
        }
    }
}