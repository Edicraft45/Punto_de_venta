using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS
{
    public partial class Reportes : Form
    {

        public Reportes()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private static DataTable GetData(string query)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            MySqlDataAdapter returnVal = new MySqlDataAdapter(query, mySqlConnection);
            DataTable dt = new DataTable();
            returnVal.Fill(dt);
            mySqlConnection.Close();
            return dt;
        }


        private void productoVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String query = "SELECT cantidad.producto_codigo, producto_nombre, Total FROM cantidad INNER JOIN productos WHERE productos.producto_codigo = cantidad.producto_codigo AND Total = (SELECT MAX(Total) FROM cantidad)";
            DataTable tabla = GetData(query);
            dgvReportes.DataSource = tabla;
        }

        private void productoVendidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String query = "SELECT cantidad.producto_codigo, producto_nombre, Total FROM cantidad INNER JOIN productos WHERE productos.producto_codigo = cantidad.producto_codigo AND Total = (SELECT MIN(Total) FROM cantidad);";
            DataTable tabla = GetData(query);
            dgvReportes.DataSource = tabla;
        }

        private void vendedorConVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String query = "SELECT COUNT(ventas.operadorVenta) AS 'Ventas Realizadas', ventas.operadorVenta AS 'ID Usuario', usuarios.nombre AS Nombre, usuarios.apellido1 AS ApellidoP, usuarios.apellido2 AS ApellidoM FROM (usuarios JOIN ventas ON (usuarios.numero_de_empleado = ventas.operadorVenta)) GROUP BY ventas.operadorVenta HAVING COUNT(ventas.operadorVenta) = (SELECT COUNT(ventas.operadorVenta) FROM ventas GROUP BY ventas.operadorVenta ORDER BY COUNT(ventas.operadorVenta) DESC LIMIT 1)";
            DataTable tabla = GetData(query);
            dgvReportes.DataSource = tabla;
        }

        private void vendedorConVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String query = "SELECT COUNT(ventas.operadorVenta) AS 'Ventas Realizadas', ventas.operadorVenta AS 'ID Usuario', usuarios.nombre AS Nombre, usuarios.apellido1 AS ApellidoP, usuarios.apellido2 AS ApellidoM FROM (usuarios JOIN ventas ON (usuarios.numero_de_empleado = ventas.operadorVenta)) GROUP BY ventas.operadorVenta HAVING COUNT(ventas.operadorVenta) = (SELECT COUNT(ventas.operadorVenta) FROM ventas GROUP BY ventas.operadorVenta ORDER BY COUNT(ventas.operadorVenta) ASC LIMIT 1)";
            DataTable tabla = GetData(query);
            dgvReportes.DataSource = tabla;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por:\n" +
                            "   Maldonado Hernández Edi Uriel\n" +
                            "   Luna Valenzuela María José\n" +
                            "   Lugo Cruz José Manuel");
        }

        private void cargarfechas() 
        {
            MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
            mySqlConnection.Open();
            String query = "SELECT DISTINCT fechaventa FROM ventas;;";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            if (mySqlDataReader.HasRows)
            {
                while (mySqlDataReader.Read())
                {
                    String fecha = Convert.ToDateTime(mySqlDataReader["fechaventa"]).ToString("yyyy-MM-dd");
                    cbVD.Items.Add(fecha); 
                }
            }
            else
            {
                MessageBox.Show("NO se encontraron fechas");
            }
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            cargarfechas();
            dgvReportes.Location = new Point(40, this.Height / 6);
            dgvReportes.Width = (this.Width / 100)*43;
            dgvReportes.Height = (this.Height /2);
            dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvReportes.EnableHeadersVisualStyles = false;
            bienvenida.Location = new Point(this.Width / 4 - bienvenida.Width / 2, 80);

            nombreTienda.Location = new Point(this.Width / 2 + nombreTienda.Width, dgvReportes.Location.Y - 80);
            hora_fecha.Location = new Point(nombreTienda.Location.X - hora_fecha.Width/2, nombreTienda.Location.Y + 50);
            logo.Location = new Point(this.Width / 2 + logo.Width / 2, hora_fecha.Location.Y + 40);
        }

        private void cbVD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String fecha = cbVD.SelectedItem.ToString().Replace("/", "-");
            String query = $"SELECT id_venta, operadorVenta, producto_codigo, cantidad, fechaventa, horaventa FROM ventas_detalle INNER JOIN ventas ON ventas.idventa = ventas_detalle.id_venta WHERE fechaventa = '{fecha}';";
            DataTable tabla = GetData(query);
            dgvReportes.DataSource = tabla;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora_fecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }
    }
}
