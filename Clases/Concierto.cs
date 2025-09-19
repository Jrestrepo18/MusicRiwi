public class Concierto
{
    public int IdConcierto { get; set; }
    public string Nombre { get; set; }
    public string Artista { get; set; }
    public string Ciudad { get; set; }
    public DateTime Fecha { get; set; }
    public int CapacidadTotal { get; set; }
    public int TiquetesVendidos { get; set; }
    public double PrecioBase { get; set; }

    public Concierto(int idConcierto, string nombre, string artista, string ciudad, DateTime fecha, int capacidad, double precio)
    {
        IdConcierto = idConcierto;
        Nombre = nombre;
        Artista = artista;
        Ciudad = ciudad;
        Fecha = fecha;
        CapacidadTotal = capacidad;
        PrecioBase = precio;
        TiquetesVendidos = 0;
    }

    public double CalcularIngresosTotales()
    {
        return TiquetesVendidos * PrecioBase;
    }
}