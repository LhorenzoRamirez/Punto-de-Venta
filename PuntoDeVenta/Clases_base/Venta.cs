using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class Venta
    {
        private int ID;
        private DateTime fecha;
        private List<Producto> productos;
        private int cantidad;
        private double subtotal;
        private double IVA;
        private double total;

        public Venta(int ID, DateTime fecha, List<Producto> productos, int cantidad, 
                    double subtotal, double IVA, double total)
        {
            this.ID = ID;
            this.fecha = fecha;
            this.productos = productos;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
            this.IVA = IVA;
            this.total = total;
        }

        public override bool Equals(object obj)
        {
            var venta = obj as Venta;
            return venta != null &&
                   ID == venta.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }

        public override string ToString()
        {
            return "\nID: " + ID + "\nFecha: " + fecha + "\nProductos: " + productos + 
                    "\nCantidad: " + cantidad + "\nSubtotal: " + subtotal + "\nIVA: " +
                    IVA + "\nTotal: " + total;
        }
    }
}
