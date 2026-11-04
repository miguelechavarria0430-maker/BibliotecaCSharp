
using System;

class Program
{
    static void Main()
    {
        ShowMainMenu();
    }

    // METODO PARA LEER OPCIONES Y VALIDAR NUMEROS
    static int ReadOption()
    {
        Console.Write("Seleccione una opcion: ");

        if (int.TryParse(Console.ReadLine(), out int option))
        {
            return option;
        }

        Console.WriteLine("Error: debe ingresar un numero.");
        Pause();
        return 0;
    }

    // METODO PARA PAUSAR LA CONSOLA
    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }

    // MENU PRINCIPAL
    static void ShowMainMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("       SISTEMA DE BIBLIOTECA");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Prestamos");
            Console.WriteLine("4. Busquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.WriteLine("====================================");

            option = ReadOption();


            switch (option)
            {
                case 1:
                    ShowBooksMenu();
                    break;
                case 2:
                    ShowUsersMenu();
                    break;
                case 3:
                    ShowLoansMenu();
                    break;
                case 4:
                    ShowSearchReportsMenu();
                    break;
                case 5:
                    ShowPersistenceMenu();
                    break;
                case 6:
                    ConfirmExitAndSave();
                    break;
                default:
                    Console.WriteLine("Opcion no valida. Intente nuevamente.");
                    Pause();
                    break;
            }
        }
    }

    // MODULO 1: LIBROS

    static void ShowBooksMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("             MENU LIBROS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle por ID o ISBN");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("6. Volver al menu principal");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    RegisterBook();
                    Pause();
                    break;
                case 2:
                    ListBooksMenu();
                    break;
                case 3:
                    ViewBookDetail();
                    Pause();
                    break;
                case 4:
                    UpdateBookMenu();
                    break;
                case 5:
                    DeleteBook();
                    Pause();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pause();
                    break;
            }
        }
    }

    static void RegisterBook()
    {
        Console.WriteLine("Funcion: Registrar un nuevo libro.");
        Console.WriteLine("Se solicitarian los datos del libro.");
    }

    static void ListBooksMenu()
    {
        int option = 0;

        while (option != 4)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("          LISTADO DE LIBROS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Listar todos los libros");
            Console.WriteLine("2. Listar libros disponibles");
            Console.WriteLine("3. Listar libros prestados");
            Console.WriteLine("4. Volver al menu de libros");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    ListBooksAll();
                    Pause();
                    break;
                case 2:
                    ListBooksAvailable();
                    Pause();
                    break;
                case 3:
                    ListBooksBorrowed();
                    Pause();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pause();
                    break;
            }
        }
    }

    static void ListBooksAll()
    {
        Console.WriteLine("Funcion: Mostrar todos los libros registrados.");
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("Funcion: Mostrar los libros disponibles.");
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("Funcion: Mostrar los libros prestados.");
    }

    static void ViewBookDetail()
    {
        Console.WriteLine("Funcion: Consultar detalle de un libro por ID o ISBN.");
    }

    static void UpdateBookMenu()
    {
        int option = 0;

        while (option != 4)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("        ACTUALIZAR LIBRO");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Editar titulo");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar anio y categoria");
            Console.WriteLine("4. Volver al menu de libros");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    EditBookTitle();
                    Pause();
                    break;
                case 2:
                    EditBookAuthor();
                    Pause();
                    break;
                case 3:
                    EditBookYearCategory();
                    Pause();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pause();
                    break;
            }
        }
    }

    static void EditBookTitle()
    {
        Console.WriteLine("Funcion: Editar el titulo de un libro.");
    }

    static void EditBookAuthor()
    {
        Console.WriteLine("Funcion: Editar el autor de un libro.");
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine("Funcion: Editar el anio y la categoria de un libro.");
    }

    static void DeleteBook()
    {
        Console.WriteLine("Funcion: Eliminar un libro.");
        Console.WriteLine("Validar que no se permita eliminar si esta prestado.");
    }

    // MODULO 2: USUARIOS

    static void ShowUsersMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("            MENU USUARIOS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle por ID o documento");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("6. Volver al menu principal");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    RegisterUser();
                    Pause();
                    break;
                case 2:
                    ListUsers();
                    Pause();
                    break;
                case 3:
                    ViewUserDetail();
                    Pause();
                    break;
                case 4:
                    UpdateUserMenu();
                    break;
                case 5:
                    DeleteUser();
                    Pause();
                    break;
                case 6:
                    break;
                default:
                   Console.WriteLine("Opcion no valida en el menu de usuarios. Intente nuevamente.");
                    Pause();
                    break;
            }
        }
    }

    static void RegisterUser()
    {
        Console.WriteLine("Funcion: Registrar un nuevo usuario.");
    }

    static void ListUsers()
    {
        Console.WriteLine("Funcion: Mostrar todos los usuarios registrados.");
    }

    static void ViewUserDetail()
    {
        Console.WriteLine("Funcion: Consultar usuario por ID o documento.");
    }

    static void UpdateUserMenu()
    {
        int option = 0;

        while (option != 4)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("       ACTUALIZAR USUARIO");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar o desactivar usuario");
            Console.WriteLine("4. Volver al menu de usuarios");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    EditUserName();
                    Pause();
                    break;
                case 2:
                    EditUserContact();
                    Pause();
                    break;
                case 3:
                    ToggleUserActiveStatus();
                    Pause();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pause();
                    break;
            }
        }
    }

    static void EditUserName()
    {
        Console.WriteLine("Funcion: Editar el nombre del usuario.");
    }

    static void EditUserContact()
    {
        Console.WriteLine("Funcion: Editar los datos de contacto del usuario.");
    }

    static void ToggleUserActiveStatus()
    {
        Console.WriteLine("Funcion: Activar o desactivar un usuario.");
    }

    static void DeleteUser()
    {
        Console.WriteLine("Funcion: Eliminar un usuario.");
        Console.WriteLine("Validar que no se permita eliminar si tiene prestamos activos.");
    }

    // MODULO 3: PRESTAMOS

    static void ShowLoansMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("            MENU PRESTAMOS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Crear prestamo");
            Console.WriteLine("2. Listar prestamos");
            Console.WriteLine("3. Ver detalle por ID");
            Console.WriteLine("4. Registrar devolucion");
            Console.WriteLine("5. Eliminar prestamo");
            Console.WriteLine("6. Volver al menu principal");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    CreateLoan();
                    Pause();
                    break;
                case 2:
                    ListLoansMenu();
                    break;
                case 3:
                    ViewLoanDetail();
                    Pause();
                    break;
                case 4:
                    RegisterReturn();
                    Pause();
                    break;
                case 5:
                    DeleteLoan();
                    Pause();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Opcion no valida en el menu de prestamos. Intente nuevamente.");
                    Pause();
                    break;
            }
        }
    }

    static void CreateLoan()
    {
        Console.WriteLine("Funcion: Crear un nuevo prestamo.");
        Console.WriteLine("Validaciones sugeridas:");
        Console.WriteLine("- Verificar que el usuario este activo.");
        Console.WriteLine("- Verificar que el libro este disponible.");
        Console.WriteLine("- Verificar que el usuario no tenga restricciones.");
        Console.WriteLine("- Registrar fecha de prestamo y fecha de devolucion.");
    }

    static void ListLoansMenu()
    {
        int option = 0;

        while (option != 4)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("         LISTADO DE PRESTAMOS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Listar todos los prestamos");
            Console.WriteLine("2. Listar prestamos activos");
            Console.WriteLine("3. Listar prestamos cerrados");
            Console.WriteLine("4. Volver al menu de prestamos");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    ListLoansAll();
                    Pause();
                    break;
                case 2:
                    ListLoansActive();
                    Pause();
                    break;
                case 3:
                    ListLoansClosed();
                    Pause();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pause();
                    break;
            }
        }
    }

    static void ListLoansAll()
    {
        Console.WriteLine("Funcion: Mostrar todos los prestamos.");
    }

    static void ListLoansActive()
    {
        Console.WriteLine("Funcion: Mostrar los prestamos activos.");
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("Funcion: Mostrar los prestamos cerrados.");
    }

    static void ViewLoanDetail()
    {
        Console.WriteLine("Funcion: Consultar detalle de un prestamo por ID.");
    }

    static void RegisterReturn()
    {
        Console.WriteLine("Funcion: Registrar la devolucion de un libro.");
        Console.WriteLine("Marcar el prestamo como devuelto.");
        Console.WriteLine("Marcar el libro como disponible.");
    }

    static void DeleteLoan()
    {
        Console.WriteLine("Funcion: Eliminar un prestamo.");
        Console.WriteLine("Validar que no se elimine si tiene devoluciones o historial relevante.");
    }

    // MODULO 4: BUSQUEDAS Y REPORTES

    static void ShowSearchReportsMenu()
    {
        int option = 0;

        while (option != 4)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("      BUSQUEDAS Y REPORTES");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Consultar reportes");
            Console.WriteLine("4. Volver al menu principal");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    SearchBook();
                    Pause();
                    break;
                case 2:
                    SearchUser();
                    Pause();
                    break;
                case 3:
                    ReportsMenu();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pause();
                    break;
            }
        }
    }

    static void SearchBook()
    {
        Console.WriteLine("Funcion: Buscar libros por titulo, autor, ID o categoria.");
    }

    static void SearchUser()
    {
        Console.WriteLine("Funcion: Buscar usuarios por nombre o documento.");
    }

    static void ReportsMenu()
    {
        int option = 0;

        while (option != 5)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("          MENU DE REPORTES");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Reporte por usuario");
            Console.WriteLine("2. Reporte por libro");
            Console.WriteLine("3. Reporte de prestamos vencidos");
            Console.WriteLine("4. Reporte general");
            Console.WriteLine("5. Volver al menu anterior");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    ReportByUser();
                    Pause();
                    break;
                case 2:
                    ReportByBook();
                    Pause();
                    break;
                case 3:
                    ReportOverdue();
                    Pause();
                    break;
                case 4:
                    ReportSummary();
                    Pause();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pause();
                    break;
            }
        }
    }

    static void ReportByUser()
    {
        Console.WriteLine("Funcion: Generar reporte de prestamos por usuario.");
    }

    static void ReportByBook()
    {
        Console.WriteLine("Funcion: Generar reporte de prestamos por libro.");
    }

    static void ReportOverdue()
    {
        Console.WriteLine("Funcion: Mostrar prestamos vencidos.");
    }

    static void ReportSummary()
    {
        Console.WriteLine("Funcion: Mostrar resumen general de la biblioteca.");
    }

    // MODULO 5: GUARDAR Y CARGAR DATOS

    static void ShowPersistenceMenu()
    {
        int option = 0;

        while (option != 4)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("       GUARDAR Y CARGAR DATOS");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos");
            Console.WriteLine("4. Volver al menu principal");
            Console.WriteLine("====================================");

            option = ReadOption();

            switch (option)
            {
                case 1:
                    SaveData();
                    Pause();
                    break;
                case 2:
                    LoadData();
                    Pause();
                    break;
                case 3:
                    ConfirmResetData();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    Pause();
                    break;
            }
        }
    }

    static void SaveData()
    {
        Console.WriteLine("Funcion: Guardar los datos de la biblioteca.");
        Console.WriteLine("Se simula el proceso de almacenamiento.");
    }

    static void LoadData()
    {
        Console.WriteLine("Funcion: Cargar los datos de la biblioteca.");
        Console.WriteLine("Se simula el proceso de carga.");
    }

    static void ConfirmResetData()
    {
        Console.Write("¿Esta seguro de reiniciar los datos? (S/N): ");
        string answer = (Console.ReadLine() ?? "").Trim().ToUpper();

        if (answer == "S")
        {
            ResetData();
        }
        else
        {
            Console.WriteLine("Reinicio cancelado.");
        }

        Pause();
    }

    static void ResetData()
    {
        Console.WriteLine("Funcion: Reiniciar los datos de la biblioteca.");
        Console.WriteLine("Se simula el reinicio de los datos.");
    }

    // MODULO 6: SALIDA DEL SISTEMA

    static void ConfirmExitAndSave()
    {
        Console.Write("¿Desea guardar antes de salir? (S/N): ");
        string answer = (Console.ReadLine() ?? "").Trim().ToUpper();

        if (answer == "S")
        {
            SaveData();
        }

        Console.WriteLine("Gracias por utilizar el sistema de biblioteca.");
    }
}
