namespace Ejercicio_Propuesto
{
    public class Producto
    {
        public Producto(string nombre, int precio, string Reviews)
        {
            this.Nombre = nombre;
            this.Precio = precio;
		this.Reviews = reviews;

        }

        public string Nombre { get; set; }

	   public int Precio { get; set; }

	  public Reviews Input { get; set; }
    }
}
