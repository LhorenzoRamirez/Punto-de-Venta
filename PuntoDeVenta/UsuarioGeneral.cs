using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class UsuarioGeneral : Administrador
    {
        private string e_mail;
        private string direccion;
        public UsuarioGeneral(string nombre, string contraseña, string e_mail, string direccion)
            : base(nombre,contraseña)
        {
            this.e_mail = e_mail;
            this.direccion = direccion;
        }

        public override string ToString()
        {
            return base.ToString() + "\nE-mail: " + e_mail + "\nDirección: " + direccion;
        }
    }
}
