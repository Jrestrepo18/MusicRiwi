public class Tiquete
{
    public int IdTiquete { get; set; }
    public int IdCliente { get; set; }
    public int IdConcierto { get; set; }
    public double PrecioPagado { get; set; }
    public DateTime FechaCompra { get; set; }

    public Tiquete(int idTiquete, int idCliente, int idConcierto, double precio)
    {
        IdTiquete = idTiquete;
        IdCliente = idCliente;
        IdConcierto = idConcierto;
        PrecioPagado = precio;
        FechaCompra = DateTime.Now;
    }
}