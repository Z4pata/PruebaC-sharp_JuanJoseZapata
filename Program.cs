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

                        var updateDog = veterinary.Dogs.Find(d => d.PublicId == updateSearch);

                        veterinary.UpdateDog(updateDog);

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
            break;

        case "3":
            break;

        case "0":
            return;

        default:
            VisualInterfaces.ShowInputError();
            ManagerApp.ShowFooter();

            break;

    }
}