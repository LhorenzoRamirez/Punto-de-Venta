using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class Administrador
    {
        private int ID;
        private string nombre;
        private string contraseña;

        public Administrador(int ID,string nombre, string contraseña)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.contraseña = contraseña;
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
