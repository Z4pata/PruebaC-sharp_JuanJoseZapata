using PruebaC_sharp_JuanJoseZapata.Models;

// Se instancia la veterinaria ----------

var veterinary = new VeterinaryClinic("Veterinaria", "Calle 51 #56A-49");

// ------------------------------------------- QUEMO DATOS --------------------------------------------------------------

veterinary.Dogs.Add(new Dog(0, "Juan", new DateOnly(2014, 9, 06), "pinscher", "verde", 12.5, true, "timido", "122349", "mucho", "pelo corto"));
veterinary.Dogs.Add(new Dog(1, "Carlos", new DateOnly(2010, 12, 06), "Pinscher", "cafe", 8, true, "normal", "122349", "mucho", "pelo largo"));
veterinary.Dogs.Add(new Dog(2, "Andres", new DateOnly(2014, 3, 06), "doberman", "negro", 30, true, "agresivo", "5675", "poco", "pelo largo"));


veterinary.Cats.Add(new Cat(3, "Black", new DateOnly(2000, 5, 17), "egipcio", "rosado", 5, true, "pelo largo"));
veterinary.Cats.Add(new Cat(4, "Blue", new DateOnly(2000, 6, 20), "otro", "cafe", 8, true, "sin pelo"));
veterinary.Cats.Add(new Cat(5, "pelusa", new DateOnly(2000, 7, 8), "otro", "gris", 3, true, "pelo largo"));

// ----------------------------------------------------------------------------------------------------------------------

// En esta ocasion el contador de Id empezara en 5 ya que ya he quemado datos con los Ids del 0 al 5

int Id = 5;

// ------


while (true)
{
    Console.Clear();
    ManagerApp.ShowHeader("Clinica veterinaria");

    string opc01 = VisualInterfaces.ShowMainMenu();

    switch (opc01)
    {
        // Caso para todo lo relacionado con perros -----------------------------------------------------
        case "1":
            bool dogFlag = true;
            while (dogFlag)
            {
                Console.Clear();
                string dogOpc = VisualInterfaces.ShowDogsMenu();

                switch (dogOpc)
                {
                    // Caso para agregar perro ---------------------------------------------------------
                    case "1":
                        // cada que alguien quiera ingresar un paciente se le suma uno a la variable Id
                        Id += 1;
                        // El metodo CreateDog me recibe ese id y me instancia un paciente con ese Id
                        veterinary.SaveDog(ManagerApp.CreateDog(Id));
                        VisualInterfaces.ShowSaveSuccesful();
                        ManagerApp.ShowFooter();
                        break;

                    // Caso para actualizar gato ----------------------------------------------------------
                    case "2":
                        // Se pide un id para poder actualizar
                        int updateSearch = Settings.ValidateInt("Ingresa el Id del perrito que deseas actualizar: ");

                        // Encuentra un perro en la lista con ese Id
                        var updatedDog = veterinary.Dogs.Find(d => d.PublicId == updateSearch);

                        // Llama al metodo UpdateDog dandole como argumento a ese perro que se encontro
                        veterinary.UpdateDog(updatedDog);

                        ManagerApp.ShowFooter();
                        break;

                    // Caso para eliminar gato ------------------------------------------------------------
                    case "3":
                        int deleteSearch = Settings.ValidateInt("Ingresa el Id del perrito que deseas eliminar: ");

                        veterinary.DeleteDog(deleteSearch);
                        ManagerApp.ShowFooter();
                        break;

                    // Caso para mostrar todos los perros ----------------------------------------------
                    case "4":
                        veterinary.ShowAnimals("perro");
                        ManagerApp.ShowFooter();
                        break;

                    // Caso para mostrar un perro en especifico ---------------------------------------
                    case "5":
                    // Buscamos el perro por el Id
                        int idSearch = Settings.ValidateInt("Ingrese el Id del perrito: ");

                        // Si lo encuentra se muestra y se guarda en la bandera un 'true'
                        bool pFlag = veterinary.ShowPatient(idSearch);

                        // Se muestra el footer
                        ManagerApp.ShowFooter();

                        // Entramos a un bucle para Motilar o castrar ese perro
                        while (pFlag)
                        {

                            Console.Clear();

                            // Traemos el perro que se encuentre con el id dado anteriormente
                            var patient = veterinary.Dogs.Find(d => d.PublicId == idSearch);

                            // Mostramos en consola el menu y recibimos una opcion
                            string pOpc = VisualInterfaces.ShowPatientMenu("perro");

                            
                            switch (pOpc)
                            {
                                // Caso para cortar el cabello ---------
                                case "1":
                                    patient.Hairdress();
                                    ManagerApp.ShowFooter();
                                    break;

                                // Caso para castrar ---------------------
                                case "2":
                                    patient.CastrateAnimal();
                                    ManagerApp.ShowFooter();
                                    break;

                                // Caso Para Salir ----------------
                                case "0":
                                    pFlag = false;
                                    ManagerApp.ShowFooter();
                                    break;

                                // Manejo de excepcion ----------------
                                default:
                                    VisualInterfaces.ShowInputError();
                                    ManagerApp.ShowFooter();
                                    break;
                            }


                        }
                        break;

                    // Caso para salir del menu de los perros ------------------------------------
                    case "0":
                        dogFlag = false;
                        ManagerApp.ShowFooter();
                        break;
                    
                    // Manejo de excepcion -------------------------------------------
                    default:
                        VisualInterfaces.ShowInputError();
                        ManagerApp.ShowFooter();
                        break;
                }
            }

            break;


        // Caso para todo lo relacionado con gatos --------------------------------------------------------
        case "2":
            bool catFlag = true;
            while (catFlag)
            {
                Console.Clear();

                // Entramos al menu de los gatos y sacamos la opcion que nos de el usuario -----
                string catOpc = VisualInterfaces.ShowCatsMenu();

                switch (catOpc)
                {
                    // Caso para agregar gato --------------------------------------------------------------------------
                    case "1":
                        // cada que alguien quiera ingresar un paciente se le suma uno a la variable Id
                        Id += 1;
                        veterinary.SaveCat(ManagerApp.CreateCat(Id));
                        VisualInterfaces.ShowSaveSuccesful();
                        ManagerApp.ShowFooter();
                        break;

                    // Caso para actualizar gato ------------------------------------------------------------------------------
                    case "2":
                        int updateSearchCat = Settings.ValidateInt("Ingresa el Id del gatito que deseas actualizar: ");

                        var updatedCat = veterinary.Cats.Find(c => c.PublicId == updateSearchCat);

                        veterinary.UpdateCat(updatedCat);

                        ManagerApp.ShowFooter();
                        break;

                    // Caso para eliminar gato -----------------------------------------------------------------------------------
                    case "3":
                        int deleteSearchCat = Settings.ValidateInt("Ingresa el Id del gatito qur deseas eliminar: ");

                        veterinary.DeleteCat(deleteSearchCat);

                        ManagerApp.ShowFooter();
                        break;
                
                    // Caso para mostrar todos los gatos ---------------------------------------------------------------------------
                    case "4":
                        veterinary.ShowAnimals("gato");
                        ManagerApp.ShowFooter();
                        break;

                    // Caso para mostrar un unico gato -------------------------------------------------------------------
                    case "5":

                    // Repetimos el proceso realizado en los perros -----------------------
                        int idSearch = Settings.ValidateInt("Ingrese el Id del gatito: ");

                        bool pFlag = veterinary.ShowPatient(idSearch);
                        ManagerApp.ShowFooter();
                        while (pFlag)
                        {

                            Console.Clear();
                            var patient = veterinary.Cats.Find(d => d.PublicId == idSearch);

                            string pOpc = VisualInterfaces.ShowPatientMenu("gato");

                            switch (pOpc)
                            {
                                case "1":
                                    patient.Hairdress();
                                    ManagerApp.ShowFooter();
                                    break;

                                case "2":
                                    patient.CastrateAnimal();
                                    ManagerApp.ShowFooter();
                                    break;

                                // Caso para salir del menu de corte o castracion ------
                                case "0":
                                    pFlag = false;
                                    ManagerApp.ShowFooter();
                                    break;

                                default:
                                    VisualInterfaces.ShowInputError();
                                    ManagerApp.ShowFooter();
                                    break;
                            }


                        }
                        break;
                    
                    // Caso para salir del menu de los gatos ---------------------------------------------------------
                    case "0":
                        catFlag = false;
                        ManagerApp.ShowFooter();
                        break;

                    default:
                        VisualInterfaces.ShowInputError();
                        ManagerApp.ShowFooter();
                        break;
                }
            }
            break;
        // Caso para busquedas en conjunto entre gatos y perros -----------------------------------------------------
        case "3":
            bool searchesFlag = true;
            while (searchesFlag)
            {
                Console.Clear();

                string searchesOpc = VisualInterfaces.ShowSearchesMenu();

                switch (searchesOpc)
                {
                    // Buscar todos los pacientes, gatos y perros unidos ---------
                    case "1":
                        veterinary.ShowAllPatients();
                        ManagerApp.ShowFooter();
                        break;

                    // Buscar por ID ------
                    case "2":
                        int idSearch = Settings.ValidateInt("Ingrese el Id del paciente: ");

                        veterinary.ShowPatient(idSearch);
                        ManagerApp.ShowFooter();
                        break;

                    // Mostrar todos los perros -----
                    case "3":
                        veterinary.ShowAnimals("perro");
                        ManagerApp.ShowFooter();
                        break;

                    // Mostrar todos los gatos ---------
                    case "4":
                        veterinary.ShowAnimals("gato");
                        ManagerApp.ShowFooter();
                        break;

                    // Salir del menu de busquedas -------
                    case "0":
                        searchesFlag = false;
                        ManagerApp.ShowFooter();
                        break;

                    default:
                        VisualInterfaces.ShowInputError();
                        break;
                }
            }
            break;

            
        // Caso de exit
        case "0":
            ManagerApp.ShowFooter();
            return;


        // Manejo de exepcion
        default:
            VisualInterfaces.ShowInputError();
            ManagerApp.ShowFooter();
            break;

    }
}