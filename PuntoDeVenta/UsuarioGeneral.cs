using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    class UsuarioGeneral : Administrador
    {
        public UsuarioGeneral(int ID, string nombre, string contraseña) : base(ID,nombre, contraseña) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
