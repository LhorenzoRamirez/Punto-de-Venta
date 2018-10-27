using MySql.Data.MySqlClient;
using PuntoDeVenta.Conexion_MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases_DAO
{
    public class ProductosDAO : ICRUD<Producto>
    {
        public int crear(Producto prod)
        {
            int retorno = 0;

            //Validar
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into productos(id_prod,descripcion," +
            "numStock,precio) values ('{0}','{1}','{2}','{3}')",prod.ID,prod.descripcion,prod.numStock,prod.precio), 
            ConectorMySQL.conexion);

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public bool eliminar(object o)
        {
            throw new NotImplementedException();
        }

        public bool actualizar(object o)
        {
            throw new NotImplementedException();
        }

        public object leerPorCondicion()
        {
            throw new NotImplementedException();
        }

        public Producto leerPorId(int id)
        {
            Producto prod = new Producto();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT descripcion, numStock, precio FROM productos WHERE id_prod = {0}",id),ConectorMySQL.conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                prod.descripcion = reader.GetString(0);
                prod.precio = reader.GetDouble(3);
                prod.numStock = reader.GetInt32(2);
            }
            return prod;
        }

        public List<Producto> leerTodo()
        {
            List<Producto> listaProductos = new List<Producto>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM productos"),ConectorMySQL.conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                Producto prod = new Producto();
                prod.ID = reader.GetInt32(0);
                prod.descripcion = reader.GetString(1);
                prod.numStock = reader.GetInt32(2);
                prod.precio = reader.GetDouble(3);

                listaProductos.Add(prod);
            }
            return listaProductos;
        }
    }
}
