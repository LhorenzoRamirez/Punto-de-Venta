using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class Venta
    {
        public int ID { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
        public double IVA { get; set; }
        public double total { get; set; }

        public Venta(int ID, DateTime fecha, int cantidad, 
                    double subtotal, double IVA, double total)
        {
            this.ID = ID;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
            this.IVA = IVA;
            this.total = total;
        }

        public Venta()
        {

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
