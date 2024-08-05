using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanJoseZapata.Models
{
    public abstract class Animal
    {
        protected int Id { get; set; }
        public int PublicId { get { return Id; } set { Id = PublicId; } }
        protected string Name { get; set; }
        public string PublicName { get { return Name; } set { Name = PublicName; } }
        protected DateOnly BirthDate { get; set; }
        protected string Breed { get; set; }
        protected string Color { get; set; }
        protected double WeightInKg { get; set; }
        public Animal(int _id, string _name, DateOnly _birthDate, string _breed, string _color, double _weightInKg)
        {
            this.Id = _id;
            this.Name = _name.Trim().ToLower();
            this.BirthDate = _birthDate;
            this.Breed = _breed.Trim().ToLower();
            this.Color = _color.Trim().ToLower();
            this.WeightInKg = _weightInKg;

        }

        public abstract void ShowInformation();

        public void BasicReview()
        {
            Console.WriteLine(@$"ID: {Id}
Nombre: {Name}
Fecha de nacimiento: {BirthDate}
Raza: {Breed}
Color: {Color}
Peso en Kg: {WeightInKg}");
        }

        protected int CalculateAgeInMonths()
        {
            int ageInYears = DateTime.Now.Year - BirthDate.Year;
            return ageInYears * 12;
        }

    }
}