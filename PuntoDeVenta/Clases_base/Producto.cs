using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public class Producto
    {
        public int ID { get; set; }
        public string descripcion { get; set; }
        public int numStock { get; set; }
        public double precio { get; set; }

        public Producto(string descripcion, int numStock, double precio)
        {
            this.descripcion = descripcion;
            this.numStock = numStock;
            this.precio = precio;
        }

        public Producto()
        {

        }

        public override bool Equals(object obj)
        {
            var producto = obj as Producto;
            return producto != null &&
                   ID == producto.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }

        public override string ToString()
        {
            return "\nID: " + ID + "\nDescripción: " + descripcion + "\n#Stock: " + numStock
                + "\nPrecio: " + precio;
        }
    }
}
