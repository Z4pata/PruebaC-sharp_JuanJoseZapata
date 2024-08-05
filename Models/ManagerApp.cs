using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanJoseZapata.Models
{
    public class ManagerApp
    {
        public static Dog CreateDog(int _id)
        {
            int Id = _id;
            string name = Settings.ValidateString("Cual es el nombre del perro?: ");

            
            
            Console.WriteLine(" -- Fecha de nacimiento -- ");

            int year = Settings.ValidateInt("Año: ");
            int month = Settings.ValidateInt("Mes: ");
            int day = Settings.ValidateInt("Dia: ");

            DateOnly birthDate = new DateOnly(year, month, day);

            string breed = Settings.ValidateString("Que raza es?: ");

            string color = Settings.ValidateString("Cual es el color de su pelaje?: ");

            double weightInKg = Settings.ValidateDouble("Cuanto pesa?: ");

            // --------------------- Dog properties -----------------

            bool breedingStatus = Settings.ValidateBool("Ya ha sido castrado?(si/no): ");

            string temperament = Settings.ValidateString("Que temperamento tiene?: ");

            string microchipNumber = Settings.ValidateString("Numero del microchip: ");

            string barkVolume = Settings.ValidateString("Que tan fuerte ladra?: ");

            string coatType = Settings.ValidateCoatType();

            return new Dog(Id, name, birthDate, breed, color, weightInKg, breedingStatus, temperament, microchipNumber, barkVolume, coatType);

        }
    }
}