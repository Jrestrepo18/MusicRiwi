using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Listas para almacenar los objetos
    static List<Concierto> listaConciertos = new List<Concierto>();
    static List<Cliente> listaClientes = new List<Cliente>();
    static List<Tiquete> listaTiquetes = new List<Tiquete>();

    // Contadores para IDs automáticos
    static int proximoIdConcierto = 1;
    static int proximoIdCliente = 1;
    static int proximoIdTiquete = 1;

    static void Main(string[] args)
    {
        bool continuar = true;
        Console.WriteLine("👋 ¡Bienvenido al sistema RiwiMusic!");

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Menú Principal ===");
            Console.WriteLine("1. Gestión de Conciertos");
            Console.WriteLine("2. Gestión de Clientes");
            Console.WriteLine("3. Gestión de Tiquetes");
            Console.WriteLine("4. Historial de Compras por Cliente");
            Console.WriteLine("5. Consultas Avanzadas (LINQ)");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MenuConciertos();
                    break;
                case "2":
                    MenuClientes();
                    break;
                case "3":
                    MenuTiquetes();
                    break;
                case "4":
                    MostrarHistorialComprasPorCliente();
                    break;
                case "5":
                    MenuConsultasAvanzadas();
                    break;
                case "6":
                    continuar = false;
                    Console.WriteLine("¡Gracias por usar RiwiMusic!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // --- MÉTODOS DE MENÚ ---

    static void MenuConciertos()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Conciertos ===");
            Console.WriteLine("1. Registrar concierto");
            Console.WriteLine("2. Listar conciertos");
            Console.WriteLine("3. Editar concierto");
            Console.WriteLine("4. Eliminar concierto");
            Console.WriteLine("5. Volver al menú principal");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": RegistrarConcierto(); break;
                case "2": ListarConciertos(); break;
                case "3": EditarConcierto(); break;
                case "4": EliminarConcierto(); break;
                case "5": continuar = false; break;
                default: Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar."); Console.ReadKey(); break;
            }
        }
    }

    static void MenuClientes()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Clientes ===");
            Console.WriteLine("1. Registrar cliente");
            Console.WriteLine("2. Listar clientes");
            Console.WriteLine("3. Editar cliente");
            Console.WriteLine("4. Eliminar cliente");
            Console.WriteLine("5. Volver al menú principal");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": RegistrarCliente(); break;
                case "2": ListarClientes(); break;
                case "3": EditarCliente(); break;
                case "4": EliminarCliente(); break;
                case "5": continuar = false; break;
                default: Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar."); Console.ReadKey(); break;
            }
        }
    }

    static void MenuTiquetes()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Tiquetes ===");
            Console.WriteLine("1. Registrar compra de tiquete");
            Console.WriteLine("2. Listar tiquetes vendidos");
            Console.WriteLine("3. Editar compra (no implementado en este ejemplo)");
            Console.WriteLine("4. Eliminar compra (no implementado en este ejemplo)");
            Console.WriteLine("5. Volver al menú principal");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": RegistrarCompraTiquete(); break;
                case "2": ListarTiquetesVendidos(); break;
                case "3": Console.WriteLine("Funcionalidad no implementada. Presione cualquier tecla para continuar."); Console.ReadKey(); break;
                case "4": Console.WriteLine("Funcionalidad no implementada. Presione cualquier tecla para continuar."); Console.ReadKey(); break;
                case "5": continuar = false; break;
                default: Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar."); Console.ReadKey(); break;
            }
        }
    }

    static void MenuConsultasAvanzadas()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Consultas Avanzadas (LINQ) ===");
            Console.WriteLine("1. Consultar conciertos por ciudad");
            Console.WriteLine("2. Consultar conciertos por rango de fechas");
            Console.WriteLine("3. Consultar el concierto con más tiquetes vendidos");
            Console.WriteLine("4. Consultar ingresos totales de un concierto");
            Console.WriteLine("5. Consultar cliente con más compras realizadas");
            Console.WriteLine("6. Volver al menú principal");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": ConsultarConciertosPorCiudad(); break;
                case "2": ConsultarConciertosPorFechas(); break;
                case "3": ConsultarConciertoMasVendido(); break;
                case "4": ConsultarIngresosTotalesConcierto(); break;
                case "5": ConsultarClienteMasCompras(); break;
                case "6": continuar = false; break;
                default: Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar."); Console.ReadKey(); break;
            }
        }
    }

    // --- MÉTODOS DE GESTIÓN DE CONCIERTOS ---

    static void RegistrarConcierto()
    {
        Console.Clear();
        Console.WriteLine("--- Registrar Nuevo Concierto ---");
        Console.Write("Nombre del concierto: ");
        string nombre = Console.ReadLine();
        Console.Write("Artista: ");
        string artista = Console.ReadLine();
        Console.Write("Ciudad: ");
        string ciudad = Console.ReadLine();
        Console.Write("Fecha (yyyy-MM-dd): ");
        DateTime fecha;
        while (!DateTime.TryParse(Console.ReadLine(), out fecha))
        {
            Console.WriteLine("Formato de fecha incorrecto. Intente de nuevo (yyyy-MM-dd): ");
        }
        Console.Write("Capacidad total: ");
        int capacidad;
        while (!int.TryParse(Console.ReadLine(), out capacidad))
        {
            Console.WriteLine("Entrada no válida. Ingrese un número para la capacidad: ");
        }
        Console.Write("Precio base: ");
        double precio;
        while (!double.TryParse(Console.ReadLine(), out precio))
        {
            Console.WriteLine("Entrada no válida. Ingrese un número para el precio: ");
        }

        Concierto nuevoConcierto = new Concierto(proximoIdConcierto, nombre, artista, ciudad, fecha, capacidad, precio);
        listaConciertos.Add(nuevoConcierto);
        proximoIdConcierto++;
        Console.WriteLine("\n🎉 Concierto registrado con éxito. ID: " + nuevoConcierto.IdConcierto);
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void ListarConciertos()
    {
        Console.Clear();
        Console.WriteLine("--- Lista de Conciertos ---");
        if (listaConciertos.Count == 0)
        {
            Console.WriteLine("No hay conciertos registrados.");
        }
        else
        {
            foreach (var concierto in listaConciertos)
            {
                MostrarDetalleConcierto(concierto);
            }
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void EditarConcierto()
    {
        Console.Clear();
        Console.WriteLine("--- Editar Concierto ---");
        Console.Write("Ingrese el ID del concierto a editar: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID no válido.");
            Console.ReadKey();
            return;
        }

        var concierto = listaConciertos.FirstOrDefault(c => c.IdConcierto == id);
        if (concierto == null)
        {
            Console.WriteLine("Concierto no encontrado.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"Concierto actual: {concierto.Nombre}");
        Console.WriteLine("Ingrese nuevos datos (deje en blanco para no cambiar):");
        Console.Write($"Nombre ({concierto.Nombre}): ");
        string nombre = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nombre)) concierto.Nombre = nombre;

        Console.Write($"Artista ({concierto.Artista}): ");
        string artista = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(artista)) concierto.Artista = artista;

        Console.Write($"Ciudad ({concierto.Ciudad}): ");
        string ciudad = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(ciudad)) concierto.Ciudad = ciudad;

        Console.Write($"Fecha ({concierto.Fecha.ToShortDateString()}): ");
        string fechaStr = Console.ReadLine();
        if (DateTime.TryParse(fechaStr, out DateTime fecha)) concierto.Fecha = fecha;

        Console.WriteLine("\nConcierto editado con éxito.");
        Console.ReadKey();
    }

    static void EliminarConcierto()
    {
        Console.Clear();
        Console.WriteLine("--- Eliminar Concierto ---");
        Console.Write("Ingrese el ID del concierto a eliminar: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID no válido.");
            Console.ReadKey();
            return;
        }

        var concierto = listaConciertos.FirstOrDefault(c => c.IdConcierto == id);
        if (concierto == null)
        {
            Console.WriteLine("Concierto no encontrado.");
            Console.ReadKey();
            return;
        }

        listaConciertos.Remove(concierto);
        Console.WriteLine($"Concierto '{concierto.Nombre}' eliminado con éxito.");
        Console.ReadKey();
    }

    // --- MÉTODOS DE GESTIÓN DE CLIENTES ---

    static void RegistrarCliente()
    {
        Console.Clear();
        Console.WriteLine("--- Registrar Nuevo Cliente ---");
        Console.Write("Nombre del cliente: ");
        string nombre = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Teléfono: ");
        string telefono = Console.ReadLine();

        Cliente nuevoCliente = new Cliente(proximoIdCliente, nombre, email, telefono);
        listaClientes.Add(nuevoCliente);
        proximoIdCliente++;
        Console.WriteLine("\n🎉 Cliente registrado con éxito. ID: " + nuevoCliente.IdCliente);
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("--- Lista de Clientes ---");
        if (listaClientes.Count == 0)
        {
            Console.WriteLine("No hay clientes registrados.");
        }
        else
        {
            foreach (var cliente in listaClientes)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"ID: {cliente.IdCliente}");
                Console.WriteLine($"Nombre: {cliente.Nombre}");
                Console.WriteLine($"Email: {cliente.Email}");
                Console.WriteLine($"Teléfono: {cliente.Telefono}");
                Console.WriteLine("----------------------------------");
            }
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void EditarCliente()
    {
        Console.Clear();
        Console.WriteLine("--- Editar Cliente ---");
        Console.Write("Ingrese el ID del cliente a editar: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID no válido.");
            Console.ReadKey();
            return;
        }

        var cliente = listaClientes.FirstOrDefault(c => c.IdCliente == id);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"Cliente actual: {cliente.Nombre}");
        Console.WriteLine("Ingrese nuevos datos (deje en blanco para no cambiar):");
        Console.Write($"Nombre ({cliente.Nombre}): ");
        string nombre = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nombre)) cliente.Nombre = nombre;

        Console.Write($"Email ({cliente.Email}): ");
        string email = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(email)) cliente.Email = email;

        Console.Write($"Teléfono ({cliente.Telefono}): ");
        string telefono = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(telefono)) cliente.Telefono = telefono;

        Console.WriteLine("\nCliente editado con éxito.");
        Console.ReadKey();
    }

    static void EliminarCliente()
    {
        Console.Clear();
        Console.WriteLine("--- Eliminar Cliente ---");
        Console.Write("Ingrese el ID del cliente a eliminar: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID no válido.");
            Console.ReadKey();
            return;
        }

        var cliente = listaClientes.FirstOrDefault(c => c.IdCliente == id);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado.");
            Console.ReadKey();
            return;
        }

        listaClientes.Remove(cliente);
        Console.WriteLine($"Cliente '{cliente.Nombre}' eliminado con éxito.");
        Console.ReadKey();
    }

    // --- MÉTODOS DE GESTIÓN DE TIQUETES ---

    static void RegistrarCompraTiquete()
    {
        Console.Clear();
        Console.WriteLine("--- Registrar Compra de Tiquete ---");
        Console.Write("Ingrese el ID del cliente: ");
        if (!int.TryParse(Console.ReadLine(), out int idCliente))
        {
            Console.WriteLine("ID de cliente no válido.");
            Console.ReadKey();
            return;
        }
        var cliente = listaClientes.FirstOrDefault(c => c.IdCliente == idCliente);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado.");
            Console.ReadKey();
            return;
        }

        Console.Write("Ingrese el ID del concierto: ");
        if (!int.TryParse(Console.ReadLine(), out int idConcierto))
        {
            Console.WriteLine("ID de concierto no válido.");
            Console.ReadKey();
            return;
        }
        var concierto = listaConciertos.FirstOrDefault(c => c.IdConcierto == idConcierto);
        if (concierto == null)
        {
            Console.WriteLine("Concierto no encontrado.");
            Console.ReadKey();
            return;
        }

        if (concierto.TiquetesVendidos >= concierto.CapacidadTotal)
        {
            Console.WriteLine("Lo sentimos, no hay tiquetes disponibles para este concierto.");
            Console.ReadKey();
            return;
        }

        Tiquete nuevoTiquete = new Tiquete(proximoIdTiquete, idCliente, idConcierto, concierto.PrecioBase);
        listaTiquetes.Add(nuevoTiquete);
        concierto.TiquetesVendidos++;
        proximoIdTiquete++;

        Console.WriteLine("\n🎉 Compra registrada con éxito.");
        Console.WriteLine($"Detalles: Tiquete #{nuevoTiquete.IdTiquete} para el concierto '{concierto.Nombre}' comprado por '{cliente.Nombre}'.");
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void ListarTiquetesVendidos()
    {
        Console.Clear();
        Console.WriteLine("--- Lista de Tiquetes Vendidos ---");
        if (listaTiquetes.Count == 0)
        {
            Console.WriteLine("No se han vendido tiquetes.");
        }
        else
        {
            foreach (var tiquete in listaTiquetes)
            {
                var cliente = listaClientes.FirstOrDefault(c => c.IdCliente == tiquete.IdCliente);
                var concierto = listaConciertos.FirstOrDefault(c => c.IdConcierto == tiquete.IdConcierto);

                Console.WriteLine("----------------------------------");
                Console.WriteLine($"ID Tiquete: {tiquete.IdTiquete}");
                Console.WriteLine($"Cliente: {(cliente != null ? cliente.Nombre : "Desconocido")}");
                Console.WriteLine($"Concierto: {(concierto != null ? concierto.Nombre : "Desconocido")}");
                Console.WriteLine($"Precio Pagado: ${tiquete.PrecioPagado}");
                Console.WriteLine($"Fecha de Compra: {tiquete.FechaCompra.ToShortDateString()}");
                Console.WriteLine("----------------------------------");
            }
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    // --- MÉTODOS DE HISTORIAL Y CONSULTAS AVANZADAS ---

    static void MostrarHistorialComprasPorCliente()
    {
        Console.Clear();
        Console.WriteLine("--- Historial de Compras por Cliente ---");
        Console.Write("Ingrese el ID del cliente: ");
        if (!int.TryParse(Console.ReadLine(), out int idCliente))
        {
            Console.WriteLine("ID de cliente no válido.");
            Console.ReadKey();
            return;
        }

        var comprasCliente = listaTiquetes.Where(t => t.IdCliente == idCliente).ToList();

        if (comprasCliente.Count == 0)
        {
            Console.WriteLine("No se encontraron compras para este cliente.");
        }
        else
        {
            var cliente = listaClientes.FirstOrDefault(c => c.IdCliente == idCliente);
            Console.WriteLine($"Historial de compras para: {(cliente != null ? cliente.Nombre : "Cliente Desconocido")}");
            foreach (var tiquete in comprasCliente)
            {
                var concierto = listaConciertos.FirstOrDefault(c => c.IdConcierto == tiquete.IdConcierto);
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Tiquete #{tiquete.IdTiquete}");
                Console.WriteLine($"Concierto: {(concierto != null ? concierto.Nombre : "Desconocido")}");
                Console.WriteLine($"Fecha Concierto: {(concierto != null ? concierto.Fecha.ToShortDateString() : "N/A")}");
                Console.WriteLine($"Precio: ${tiquete.PrecioPagado}");
                Console.WriteLine("----------------------------------");
            }
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }
    
    // --- CONSULTAS AVANZADAS CON LINQ ---

    static void ConsultarConciertosPorCiudad()
    {
        Console.Clear();
        Console.WriteLine("--- Consultar Conciertos por Ciudad ---");
        Console.Write("Ingrese el nombre de la ciudad: ");
        string ciudadBuscada = Console.ReadLine();

        var conciertosEnCiudad = listaConciertos.Where(c => c.Ciudad.Equals(ciudadBuscada, StringComparison.OrdinalIgnoreCase)).ToList();

        if (conciertosEnCiudad.Count == 0)
        {
            Console.WriteLine($"No se encontraron conciertos en la ciudad de '{ciudadBuscada}'.");
        }
        else
        {
            Console.WriteLine($"Conciertos en '{ciudadBuscada}':");
            foreach (var concierto in conciertosEnCiudad)
            {
                MostrarDetalleConcierto(concierto);
            }
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void ConsultarConciertosPorFechas()
    {
        Console.Clear();
        Console.WriteLine("--- Consultar Conciertos por Rango de Fechas ---");
        Console.Write("Fecha de inicio (yyyy-MM-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime fechaInicio))
        {
            Console.WriteLine("Fecha de inicio no válida.");
            Console.ReadKey();
            return;
        }

        Console.Write("Fecha de fin (yyyy-MM-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime fechaFin))
        {
            Console.WriteLine("Fecha de fin no válida.");
            Console.ReadKey();
            return;
        }

        var conciertosEnRango = listaConciertos.Where(c => c.Fecha >= fechaInicio && c.Fecha <= fechaFin).ToList();

        if (conciertosEnRango.Count == 0)
        {
            Console.WriteLine("No se encontraron conciertos en ese rango de fechas.");
        }
        else
        {
            Console.WriteLine($"Conciertos entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()}:");
            foreach (var concierto in conciertosEnRango)
            {
                MostrarDetalleConcierto(concierto);
            }
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void ConsultarConciertoMasVendido()
    {
        Console.Clear();
        Console.WriteLine("--- Concierto con Más Tiquetes Vendidos ---");
        var conciertoMasVendido = listaConciertos.OrderByDescending(c => c.TiquetesVendidos).FirstOrDefault();

        if (conciertoMasVendido == null || conciertoMasVendido.TiquetesVendidos == 0)
        {
            Console.WriteLine("Aún no se han vendido tiquetes para ningún concierto.");
        }
        else
        {
            Console.WriteLine("El concierto con más tiquetes vendidos es:");
            MostrarDetalleConcierto(conciertoMasVendido);
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void ConsultarIngresosTotalesConcierto()
    {
        Console.Clear();
        Console.WriteLine("--- Consultar Ingresos Totales de un Concierto ---");
        Console.Write("Ingrese el ID del concierto: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID no válido.");
            Console.ReadKey();
            return;
        }

        var concierto = listaConciertos.FirstOrDefault(c => c.IdConcierto == id);
        if (concierto == null)
        {
            Console.WriteLine("Concierto no encontrado.");
        }
        else
        {
            Console.WriteLine($"Ingresos totales para el concierto '{concierto.Nombre}': ${concierto.CalcularIngresosTotales():N2}");
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    static void ConsultarClienteMasCompras()
    {
        Console.Clear();
        Console.WriteLine("--- Cliente con Más Compras Realizadas ---");

        var clienteMasCompras = listaTiquetes
            .GroupBy(t => t.IdCliente)
            .OrderByDescending(g => g.Count())
            .FirstOrDefault();

        if (clienteMasCompras == null)
        {
            Console.WriteLine("Aún no se han registrado compras.");
        }
        else
        {
            var cliente = listaClientes.FirstOrDefault(c => c.IdCliente == clienteMasCompras.Key);
            Console.WriteLine("El cliente con más compras es:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"ID: {cliente.IdCliente}");
            Console.WriteLine($"Nombre: {cliente.Nombre}");
            Console.WriteLine($"Total de compras: {clienteMasCompras.Count()}");
            Console.WriteLine("----------------------------------");
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }

    // --- MÉTODOS DE AYUDA ---

    static void MostrarDetalleConcierto(Concierto concierto)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"ID: {concierto.IdConcierto}");
        Console.WriteLine($"Nombre: {concierto.Nombre}");
        Console.WriteLine($"Artista: {concierto.Artista}");
        Console.WriteLine($"Ciudad: {concierto.Ciudad}");
        Console.WriteLine($"Fecha: {concierto.Fecha.ToShortDateString()}");
        Console.WriteLine($"Capacidad: {concierto.CapacidadTotal}");
        Console.WriteLine($"Tiquetes Vendidos: {concierto.TiquetesVendidos}");
        Console.WriteLine($"Ingresos Totales: ${concierto.CalcularIngresosTotales():N2}");
        Console.WriteLine("----------------------------------");
    }
}