using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanJoseZapata.Models
{
    public class Dog : Animal
    {

        public bool BreedingStatus { get; set; }
        public string Temperament { get; set; }
        public string MicrochipNumber { get; set; }
        public string BarkVolume { get; set; }
        public string CoatType { get; set; } // liso, áspero, suelto y duro
        public Dog(int _id, string _name, DateOnly _birthDate, string _breed, string _color, double _weightInKg, bool _breedingStatus, string _temperament, string _microchipNumber, string _barkVolume, string _coatType) : base(_id, _name, _birthDate, _breed, _color, _weightInKg)
        {
            this.BreedingStatus = _breedingStatus;
            this.Temperament = _temperament.Trim().ToLower();
            this.MicrochipNumber = _microchipNumber.Trim();
            this.BarkVolume = _barkVolume.Trim();
            this.CoatType = _coatType.Trim().ToLower();
        }
        public void CastrateAnimal()
        {
            if (BreedingStatus == true)
            {
                BreedingStatus = false;
                Console.WriteLine("Animal castrado con exito!!");
            }
            else
            {
                Console.WriteLine("El animal ya está castrado!!");
            }
        }
        public void Hairdress()
        {
            if (CoatType == "sin pelo" || CoatType == "pelo corto")
            {
                VisualInterfaces.ShowHairCutError();
            }
            else
            {
                CoatType = "pelo corto";
                VisualInterfaces.ShowHairCutSuccesful();
            }
        }

        public override void ShowInformation()
        {
            Console.WriteLine(@$"ID: {Id}
Nombre: {Name}
Fecha de nacimiento: {BirthDate}
Raza: {Breed}
Color: {Color}
Peso en Kg: {WeightInKg}
Puede criar?: {BreedingStatus}
Temperamento: {Temperament}
Numero del microchip: {MicrochipNumber}
Tono del ladrido: {BarkVolume}
Tipo de pelaje: {CoatType}");

            ManagerApp.ShowSeparator();
        }
    }
}