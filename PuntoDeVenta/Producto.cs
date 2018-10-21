using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class Producto
    {
        private int ID;
        private string descripcion;
        private int numStock;
        private double precio;

        public Producto(int ID, string descripcion, int numStock, double precio)
        {
            this.ID = ID;
            this.descripcion = descripcion;
            this.numStock = numStock;
            this.precio = precio;
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
