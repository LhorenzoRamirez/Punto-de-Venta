using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class Administrador
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }

        public Administrador(int ID,string nombre, string contraseña)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.contraseña = contraseña;
        }
        public Administrador()
        {

        }

        public override bool Equals(object obj)
        {
            var administrador = obj as Administrador;
            return administrador != null &&
                   ID == administrador.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }

        public override string ToString()
        {
            return "\nID: " + ID + "\nNombre: " + nombre + "\nContraseña: " + contraseña;
        }
    }
}
