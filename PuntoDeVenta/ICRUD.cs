using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    interface ICRUD
    {
        Boolean crear(object o);
        Boolean actualizar(object o);
        Boolean eliminar(object o);
        object leerPorId();
        object leerPorCondicion();
        object leerTodo();
    }
}
