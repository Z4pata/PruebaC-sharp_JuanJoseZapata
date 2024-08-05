using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JuanJoseZapata.Models
{
    public class VeterinaryClinic
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }
        public VeterinaryClinic()
        {
            this.Dogs = new List<Dog>();
            this.Cats = new List<Cat>();

        }
        public VeterinaryClinic(string _name, string _address)
        {
            this.Name = _name;
            this.Address = _address;
            this.Dogs = new List<Dog>();
            this.Cats = new List<Cat>();
        }

        public void SaveDog(Dog newDog)
        {
            Dogs.Add(newDog);
        }
        public void SaveCat(Cat newCat)
        {
            Cats.Add(newCat);
        }
        public void UpdateDog(Dog dog)
        {
            if (Dogs.Any(d => d == dog))
            {
                var index = Dogs.IndexOf(dog);

                Dogs[index] = ManagerApp.CreateDog(Dogs[index].PublicId);
            }
            else
            {
                VisualInterfaces.ShowFindError();
            }

        }
        public void UpdateCat(Cat cat)
        {
            if (Cats.Any(c => c == cat))
            {
                var index = Cats.IndexOf(cat);

                Cats[index] = ManagerApp.CreateCat(Cats[index].PublicId);
            }
            else
            {
                VisualInterfaces.ShowFindError();
            }
        }
        public void DeleteDog(int _id)
        {
            if (Dogs.Any(d => d.PublicId == _id))
            {
                var dog = Dogs.First(d => d.PublicId == _id);

                Dogs.Remove(dog);
                VisualInterfaces.ShowDeleteSuccesful("perro");
            }
            else
            {
                VisualInterfaces.ShowFindError();
            }
        }
        public void DeleteCat(int _id)
        {
            if (Cats.Any(c => c.PublicId == _id))
            {
                var cat = Cats.First(c => c.PublicId == _id);

                Cats.Remove(cat);
                VisualInterfaces.ShowDeleteSuccesful("gato");
            }
            else
            {
                VisualInterfaces.ShowFindError();
            }
        }
        public void ShowAllPatients()
        {
            Dogs.ForEach(d => d.ShowInformation());
            Cats.ForEach(c => c.ShowInformation());
        }
        public void ShowAnimals(string type)
        {
            if (type == "perro")
            {
                Dogs.ForEach(d => d.ShowInformation());
            }
            else if (type == "gato")
            {
                Cats.ForEach(c => c.ShowInformation());
            }
            else
            {
                VisualInterfaces.ShowInputError();
            }
        }
        public bool ShowPatient(int idPatient)
        {
            if (Dogs.Any(d => d.PublicId == idPatient))
            {
                var patient = Dogs.First(d => d.PublicId == idPatient);

                patient.ShowInformation();
                return true;
            } 
            else if (Cats.Any(c => c.PublicId == idPatient))
            {
                var patient = Cats.First(c=>c.PublicId == idPatient);

                patient.ShowInformation();
                return true;
            }
            else
            {
                VisualInterfaces.ShowFindError();
                return false;
            }
        }
    }
}