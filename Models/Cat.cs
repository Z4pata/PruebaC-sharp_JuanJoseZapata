using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanJoseZapata.Models
{
    public class Cat : Animal
    {

        public bool BreedingStatus { get; set; }
        public string FurLength { get; set; }
        public Cat(int _id, string _name, DateOnly _birthDate, string _breed, string _color, double _weightInKg, bool _breedingStatus, string _furLength) : base(_id, _name, _birthDate, _breed, _color, _weightInKg)
        {
            this.BreedingStatus = _breedingStatus;
            this.FurLength = _furLength;
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
            if (FurLength == "sin pelo" || FurLength == "pelo corto")
            {
                VisualInterfaces.ShowHairCutError();
            }
            else
            {
                FurLength = "pelo corto";
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
Longitud del cabello: {FurLength}");
        }
    
    }
}