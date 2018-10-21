using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class Administrador
    {
        private string nombre;
        private string contraseña;

        public Administrador(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

        public override bool Equals(object obj)
        {
            var administrador = obj as Administrador;
            return administrador != null &&
                   nombre == administrador.nombre;
        }

        public override int GetHashCode()
        {
            return -1597784800 + EqualityComparer<string>.Default.GetHashCode(nombre);
        }

        public override string ToString()
        {
            return "\nNombre: " + nombre + "\nContraseña: " + contraseña;
        }
    }
}
