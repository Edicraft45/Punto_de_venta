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
    public partial class Form1 : Form
    {
        public static String nombre;
        public static Int32 id;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            label1.Location = new Point(nombreTienda.Location.X - label1.Width / 2, nombreTienda.Location.Y + nombreTienda.Height + 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuariotxb.Text == "") 
            {
                //MessageBox.Show("Captura el usuario");
                erroresL.Text = "Captura el usuario";
                usuariotxb.Focus();
            }
            else if (pswtxb.Text == "")
            {
                //MessageBox.Show("Captura la contraseña");
                erroresL.Text = "Captura la contraseña";
                pswtxb.Focus();
            }
            else
            {
                erroresL.Text = "";
                try
                {


                    MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
                    mySqlConnection.Open();
                    String query = "SELECT * FROM usuarios WHERE numero_de_empleado = " + usuariotxb.Text + " and pass = " + pswtxb.Text;
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.Read())
                    {
                        nombre = mySqlDataReader.GetString(1) + " " + mySqlDataReader.GetString(2) + " " + mySqlDataReader.GetString(3);
                        id = mySqlDataReader.GetInt32(0);
                        //MessageBox.Show("Conexión exitosa");
                        if (mySqlDataReader.GetInt32(11) == 1)
                        {
                            PuntoDeVenta principal = new PuntoDeVenta();
                            principal.Show();
                            this.Hide();
                        }
                        else {
                            Reportes ventana = new Reportes();
                            ventana.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario/Contraseña incorrecto.");
                    }
                    mySqlConnection.Close();
                    usuariotxb.Text = "";
                    pswtxb.Text = "";
                }
                catch (Exception ERROR)
                {
                    MessageBox.Show("Algo salió mal " + ERROR.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void usuariotxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender,e);
            }
        }

        private void pswtxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            erroresL.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
