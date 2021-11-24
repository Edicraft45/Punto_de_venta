using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoS
{
    public partial class PuntoDeVenta : Form
    {
        private double total = 0.0;
        private double subtotal = 0.0;
        private double iva = 0.0;
        private int renglon;
        private int id;
        public PuntoDeVenta()
        {
            InitializeComponent();
            CalcularSubtotal();
            CalcularIVA();
            CalcularTotal();
        }

        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            cuadro_desc.Location = new Point(40, this.Height / 6);
            nombreTienda.Location = new Point(this.Width / 2 + nombreTienda.Width, cuadro_desc.Location.Y - 80);
            hora_fecha.Location = new Point(this.Width / 2 + hora_fecha.Width, nombreTienda.Location.Y + 50);
            logo.Location = new Point(this.Width / 2 + logo.Width / 2, hora_fecha.Location.Y + 40);

            empleadoL.Text = Form1.nombre;
            cuadro_desc.Width = this.Width / 2;
            cuadro_desc.Height = (this.Height / 4) * 3;
            textBox1.Width = cuadro_desc.Width;

            cuadro_desc.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            cuadro_desc.EnableHeadersVisualStyles = false;

            cuadro_desc.Columns[0].Width = cuadro_desc.Width * 25 / 100;
            cuadro_desc.Columns[1].Width = cuadro_desc.Width * 40 / 100;
            cuadro_desc.Columns[2].Width = cuadro_desc.Width * 20 / 100;
            cuadro_desc.Columns[3].Width = cuadro_desc.Width * 20 / 100;
            cuadro_desc.RowTemplate.Height = 60;
            textBox1.Location = new Point(cuadro_desc.Location.X, cuadro_desc.Location.Y - 80);
            pagoL.Location = new Point(cuadro_desc.Location.X + 50, cuadro_desc.Location.Y + cuadro_desc.Height + 30);
            txtpago.Location = new Point(pagoL.Location.X + pagoL.Width + 50, pagoL.Location.Y);
            btnCerrar.Location = new Point(this.Width/2 - btnCerrar.Width/2, pagoL.Location.Y);


            totalL.Location = new Point(this.Width / 2 + logo.Width / 2, this.Height / 5 * 4);
            ivaL.Location = new Point(totalL.Location.X, totalL.Location.Y - 60);
            subt.Location = new Point(ivaL.Location.X, ivaL.Location.Y - 40);
            eliminarB.Location = new Point(totalL.Location.X , totalL.Location.Y + totalL.Height + 50);
            pagarB.Location = new Point(eliminarB.Location.X + eliminarB.Width + 60, totalL.Location.Y + totalL.Height + 50);



            cuadro_desc.Columns[2].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            cuadro_desc.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora_fecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Me dio problemas al tratar de usar el boton F1 debido a que en keypress no existe el metodo KeyCode
            //Por eso se uso KeyDown en el cual si existe KeyCode
        }

        private void connect(int a)
        {
            String query = "SELECT * FROM productos WHERE producto_codigo =" + textBox1.Text;

            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    mySqlDataReader.Read();
                    renglon = 0;
                    foreach (DataGridViewRow row in cuadro_desc.Rows)
                    {
                        renglon++;
                        if (mySqlDataReader.GetString(1) == Convert.ToString(row.Cells[1].Value) && a == 1)
                        {
                            row.Cells[0].Value = Convert.ToInt32(row.Cells[0].Value) + 1;
                            break;
                        }
                        else
                        {
                            renglon = 0;
                        }
                    }
                    if (renglon == 0 && a == 1)
                    {
                        cuadro_desc.Rows.Add("1", mySqlDataReader.GetString(1), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)));
                    }

                    if (a == 1)
                    {
                        totalP();
                        CalcularSubtotal();
                        CalcularIVA();
                        CalcularTotal();
                    }
                    else
                    {
                        MessageBox.Show("Producto: " + mySqlDataReader.GetString(1) + "\n" +
                                        "Precio: " + mySqlDataReader.GetDouble(3));
                    }
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Codigo erróneo o no se encuentra disponible el producto");
            }
        }

        private void CalcularTotal()
        {
            total = 0;
            total = subtotal + iva;
            totalL.Text = "Total: " + String.Format("{0:0.00}",total);
        }
        private void CalcularSubtotal()
        {
            subtotal = 0;
            for (int i = 0; i < cuadro_desc.Rows.Count; i++)
            {
                subtotal += Double.Parse(cuadro_desc[3, i].Value.ToString());
            }
            subt.Text = "Subtotal: " + String.Format("{0:0.00}", subtotal);
        }

        private void totalP()
        {
            foreach (DataGridViewRow row in cuadro_desc.Rows)
            {
                row.Cells[3].Value = Convert.ToDouble(row.Cells[0].Value) * Convert.ToDouble(row.Cells[2].Value);
            }
        }
        private void CalcularIVA()
        {
            iva = 0; 
            iva = subtotal * 0.16;
            ivaL.Text = "IVA: "+ String.Format("{0:0.00}", iva);
        }

        private void eliminar()
        {
            if (cuadro_desc.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(cuadro_desc.CurrentRow.Cells[0].Value.ToString()) > 1)
                {
                    cuadro_desc.CurrentRow.Cells[0].Value = Convert.ToInt32(cuadro_desc.CurrentRow.Cells[0].Value) - 1;
                    totalP();
                }
                else
                {
                    foreach (DataGridViewRow row in cuadro_desc.SelectedRows)
                    {
                        cuadro_desc.Rows.RemoveAt(row.Index);
                    }
                }
                CalcularSubtotal();
                CalcularIVA();
                CalcularTotal();
            }
            else
            {
                CalcularSubtotal();
                CalcularIVA();
                CalcularTotal();
            }
        }

        private int id_producto(String a)
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
            MySqlCommand buscar = new MySqlCommand($"SELECT producto_codigo FROM productos WHERE producto_nombre = '{a}';", conexion);
            conexion.Open();
            MySqlDataReader mySqlDataReader = buscar.ExecuteReader();
            if (mySqlDataReader.HasRows)
            {
                while (mySqlDataReader.Read())
                {
                    Int32 numero = Convert.ToInt32(mySqlDataReader["producto_codigo"].ToString());
                    return numero;
                }
            }
            else
            {
                MessageBox.Show("A ocurrdo un error inesperado");
            }
            return 0;
        }
        private int id_venta() 
        {
            Int32 numero;
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
            MySqlCommand buscar = new MySqlCommand("SELECT idventa FROM ventas ORDER BY idventa DESC LIMIT 1", conexion);
            conexion.Open();
            MySqlDataReader mySqlDataReader = buscar.ExecuteReader();
            if (mySqlDataReader.HasRows)
            {
                while (mySqlDataReader.Read())
                {
                    //String fecha = Convert.ToDateTime(mySqlDataReader["fechaventa"]).ToString("yyyy-MM-dd");
                    numero = Convert.ToInt32(mySqlDataReader["idventa"].ToString());
                    return numero;
                }
            }
            else
            {
                MessageBox.Show("A ocurrdo un error inesperado");
            }
            return  0;
        }
        private void guardaVentaDetalles() 
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
            MySqlCommand agregar = new MySqlCommand("INSERT INTO ventas_detalle(id_venta, producto_codigo, cantidad, producto_precio) VALUES(?id_venta, ?producto_codigo, ?cantidad, ?producto_precio)", conexion);
            conexion.Open();
            Int32 id = id_venta();
            foreach (DataGridViewRow fila in cuadro_desc.Rows)
            {
                agregar.Parameters.Clear();
                Int32 id_p = id_producto(Convert.ToString(fila.Cells[1].Value));
                agregar.Parameters.Add("?id_venta", MySqlDbType.Int32).Value = id;
                agregar.Parameters.Add("?producto_codigo", MySqlDbType.Int32).Value = id_p;
                agregar.Parameters.Add("?cantidad", MySqlDbType.Int32).Value = Convert.ToString(fila.Cells[0].Value);
                agregar.Parameters.Add("?producto_precio", MySqlDbType.Double).Value = Convert.ToString(fila.Cells[2].Value);
                agregar.ExecuteNonQuery();
            }
        }
        private void guardaVenta() 
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
            MySqlCommand agregar = new MySqlCommand("INSERT INTO ventas(idventa, fechaventa, horaventa, operadorVenta) VALUES(NULL, ?fechaventa, ?horaventa, ?operadorVenta)", conexion);
            conexion.Open();
            agregar.Parameters.Clear();
            DateTime fechaActual = DateTime.Today;
            string horaActual = DateTime.Now.ToString("hh:mm:ss");
            agregar.Parameters.Add("?fechaventa", MySqlDbType.Date).Value = Convert.ToString(fechaActual.Year + "-" + fechaActual.ToString("MM") + "-" + fechaActual.Day);
            agregar.Parameters.Add("?horaventa", MySqlDbType.Time).Value = TimeSpan.Parse(horaActual);
            agregar.Parameters.Add("?operadorVenta", MySqlDbType.Int32).Value = Convert.ToString(Form1.id);
            agregar.ExecuteNonQuery();
            conexion.Close();

        }
        private void iniciarPago()
        {
            try
            {
                String vacio = txtpago.Text;
                if (vacio != "")
                {
                    if (Double.Parse(txtpago.Text) > total)
                    {
                        guardaVenta();
                        guardaVentaDetalles();
                        totalL.Text = $"Cambio: {Math.Round(Convert.ToDouble(txtpago.Text) - total, 2)}";
                        cuadro_desc.Rows.Clear();
                        txtpago.Clear();
                        txtpago.Focus();
                        
                    }
                    else
                    {
                        MessageBox.Show("Dinero insuficiente");
                    }
                }
                else
                {
                    MessageBox.Show("Favor de ingresar la cantidad de pago");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la cantidad de pago");
            }
        }
        private void eliminarB_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void pagarB_Click(object sender, EventArgs e)
        {
            iniciarPago();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Verifica si se agregara al datagrit o solo mostrara los datos del producto (Enter pagar, F1 mostar detalles)
            String vacio = textBox1.Text;
            if (e.KeyCode == Keys.Enter && vacio != "")
            {
                connect(1);
            }
            if (e.KeyCode == Keys.F1 && vacio != "")
            {
                connect(0);
            }
        }

        private void cuadro_desc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cuadro_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                eliminar();
            }
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            String vacio = txtpago.Text;
            if (e.KeyChar == 13 && vacio != "")
            {
                iniciarPago();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void empleadoL_Click(object sender, EventArgs e)
        {

        }
    }
}
