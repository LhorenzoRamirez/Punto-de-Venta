using PuntoDeVenta.Clases_DAO;
using PuntoDeVenta.Conexion_MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Form1 : Form
    {
        public static ProductosDAO productosDAO = new ProductosDAO();
        ConectorMySQL conector = new ConectorMySQL();
        private Producto producto;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConectorMySQL.Conectar();
            tablaProductos.DataSource = productosDAO.leerTodo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConectorMySQL.Desconectar())
            {
                MessageBox.Show("Desconexión exitosa");
            }
            else
            {
                MessageBox.Show("Fallo en la desconexión");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int prodCreado;
            try
            {
                producto = new Producto(descripcion.Text, Convert.ToInt32(stock.Text), Convert.ToDouble(precio.Text));
                prodCreado = productosDAO.crear(producto);
                tablaProductos.DataSource = productosDAO.leerTodo();
                if (prodCreado <= 0)
                {
                    MessageBox.Show("No se completó el registro del producto","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Uno o más campos tienen un formato inválido"); //Provisional, después se validarán
            }                                                                   //los textbox para no permitir 
                                                                                //escribir otros formatos        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count == 1) //Si hay una fila seleccionada
            {
                int id = Convert.ToInt32(tablaProductos.CurrentRow.Cells[0].Value); //Se obtiene el id de la fila seleccionada
                producto = new Producto();
                producto = productosDAO.leerPorId(id); //Se iguala el nuevo producto al que se seleccionó en la tabla

                if (producto != null)
                {
                    descripcion.Text = producto.descripcion;
                    precio.Text = Convert.ToString(producto.precio);
                    stock.Text = Convert.ToString(producto.numStock);
                }
            }
            else
            {
                MessageBox.Show("Se debe de seleccionar una fila de productos");
            }
        }
    }
}
