using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PuntoDeVenta.Conexion_MySQL
{
    class ConectorMySQL
    {
        public static MySqlConnection conexion = new MySqlConnection("server = localhost; database = punto_venta; " +
                                                            "Uid = root; pwd = ;");
        public static MySqlConnection Conectar()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión exitosa");
                return conexion;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return conexion;
            }
        }

        public static Boolean Desconectar()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Dispose();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }  
        }
    }
}
