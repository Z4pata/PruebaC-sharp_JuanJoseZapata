using PruebaC_sharp_JuanJoseZapata.Models;

var veterinary = new VeterinaryClinic("Veterinaria", "Calle 51 #56A-49");
int Id = 0;
while (true)
{
    Console.Clear();
    ManagerApp.ShowHeader("Clinica veterinaria");

    string opc01 = VisualInterfaces.ShowMainMenu();

    switch (opc01)
    {
        case "1":
            bool dogFlag = true;
            while (dogFlag)
            {
                string dogOpc = VisualInterfaces.ShowDogsMenu();

                switch (dogOpc)
                {
                    case "1":
                        Id += 1;
                        veterinary.SaveDog(ManagerApp.CreateDog(Id));
                        VisualInterfaces.ShowSaveSuccesful();
                        ManagerApp.ShowFooter();
                        break;
                    case "2":
                        int updateSearch = Settings.ValidateInt("Ingresa el Id del perrito que deseas actualizar: ");

                        var updatedDog = veterinary.Dogs.Find(d => d.PublicId == updateSearch);

                        veterinary.UpdateDog(updatedDog);

                        ManagerApp.ShowFooter();
                        break;
                    case "3":
                        int deleteSearch = Settings.ValidateInt("Ingresa el Id del perrito que deseas eliminar: ");

                        veterinary.DeleteDog(deleteSearch);
                        ManagerApp.ShowFooter();
                        break;
                    case "4":
                        veterinary.ShowAnimals("perro");
                        ManagerApp.ShowFooter();
                        break;
                    case "0":
                        dogFlag = false;
                        break;
                    default:
                        VisualInterfaces.ShowInputError();
                        ManagerApp.ShowFooter();
                        break;
                }
            }
            break;

        case "2":
            bool catFlag = true;
            while (catFlag)
            {
                Console.Clear();
                string catOpc = VisualInterfaces.ShowCatsMenu();

                switch (catOpc)
                {
                    case "1":
                        Id +=1;
                        veterinary.SaveCat(ManagerApp.CreateCat(Id));
                        VisualInterfaces.ShowSaveSuccesful();
                        ManagerApp.ShowFooter();
                        break;
                    
                    case "2":
                        int updateSearchCat= Settings.ValidateInt("Ingresa el Id del gatito que deseas actualizar: ");

                        var updatedCat = veterinary.Cats.Find(c => c.PublicId == updateSearchCat);

                        veterinary.UpdateCat(updatedCat);

                        ManagerApp.ShowFooter();
                        break;
                    
                    case "3":
                        int deleteSearchCat = Settings.ValidateInt("Ingresa el Id del gatito qur deseas eliminar: ");

                        veterinary.DeleteCat(deleteSearchCat);

                        ManagerApp.ShowFooter();
                        break;
                    
                    case "4":
                        veterinary.ShowAnimals("gato");
                        ManagerApp.ShowFooter();
                        break;
                    
                    case "0":
                        catFlag = false;
                        break;
                    
                    default:
                        VisualInterfaces.ShowInputError();
                        ManagerApp.ShowFooter();
                        break;
                }
            }
            break;

        case "3":
            bool searchesFlag = true;
            while (searchesFlag)
            {
                Console.Clear();

                string searchesOpc = VisualInterfaces.ShowSearchesMenu();

                switch (searchesOpc)
                {
                    case "1":
                    veterinary.ShowAllPatients();
                        ManagerApp.ShowFooter();
                        break;

                    case "2":
                        int idSearch = Settings.ValidateInt("Ingrese el Id del paciente: ");

                        veterinary.ShowPatient(idSearch);
                        ManagerApp.ShowFooter();
                        break;

                    case "3":
                        veterinary.ShowAnimals("perro");
                        ManagerApp.ShowFooter();
                        break;
                    
                    case "4":
                        veterinary.ShowAnimals("gato");
                        ManagerApp.ShowFooter();
                        break;
                }
            }
            break;

        case "0":
            return;

        default:
            VisualInterfaces.ShowInputError();
            ManagerApp.ShowFooter();
            break;

    }
}