class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    public Contacto(string nombre, string telefono, string correo)
    {
        Nombre = nombre;
        Telefono = telefono;
        Correo = correo;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Teléfono: {Telefono}, Correo: {Correo}";
    }
}

class Agenda
{
    private List<Contacto> contactos;

    public Agenda()
    {
        contactos = new List<Contacto>();
    }

    public void AgregarContacto(string nombre, string telefono, string correo)
    {
        Contacto nuevoContacto = new Contacto(nombre, telefono, correo);
        contactos.Add(nuevoContacto);
        Console.WriteLine("Contacto agregado exitosamente.");
    }

    public void MostrarContactos()
    {
        if (contactos.Count == 0)
        {
            Console.WriteLine("La agenda está vacía.");
        }
        else
        {
            Console.WriteLine("\nContactos en la agenda:");
            for (int i = 0; i < contactos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {contactos[i]}");
            }
        }
    }

    public void BuscarContacto(string nombre)
    {
        var resultados = contactos.Where(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        if (resultados.Any())
        {
            Console.WriteLine("\nContactos encontrados:");
            foreach (var contacto in resultados)
            {
                Console.WriteLine(contacto);
            }
        }
        else
        {
            Console.WriteLine("No se encontraron contactos con ese nombre.");
        }
    }

    public void EliminarContacto(string nombre)
    {
        int eliminados = contactos.RemoveAll(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (eliminados > 0)
        {
            Console.WriteLine($"Se eliminaron {eliminados} contacto(s) con el nombre: {nombre}.");
        }
        else
        {
            Console.WriteLine("No se encontraron contactos con ese nombre para eliminar.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();

        // Menú de opciones
        while (true)
        {
            Console.WriteLine("\n--- Agenda Telefónica ---");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Eliminar contacto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el teléfono: ");
                    string telefono = Console.ReadLine();
                    Console.Write("Ingrese el correo: ");
                    string correo = Console.ReadLine();
                    agenda.AgregarContacto(nombre, telefono, correo);
                    break;

                case "2":
                    agenda.MostrarContactos();
                    break;

                case "3":
                    Console.Write("Ingrese el nombre a buscar: ");
                    string nombreBuscar = Console.ReadLine();
                    agenda.BuscarContacto(nombreBuscar);
                    break;

                case "4":
                    Console.Write("Ingrese el nombre a eliminar: ");
                    string nombreEliminar = Console.ReadLine();
                    agenda.EliminarContacto(nombreEliminar);
                    break;

                case "5":
                    Console.WriteLine("Saliendo de la agenda...");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}

