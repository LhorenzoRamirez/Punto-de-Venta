using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public interface ICRUD<T>
    {
        int crear(T t);
        Boolean actualizar(object o);
        Boolean eliminar(object o);
        T leerPorId(int id);
        object leerPorCondicion();
        List<T> leerTodo();
    }
}
