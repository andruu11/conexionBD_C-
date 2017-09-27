using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//referenciamos libreria de mysql

namespace Prueba_Conexion
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection(); //referenciamos el metodo de la libreria para una nueva conexion
        String variableconexion;//declaramos una variable para referenciar los parametros
        public Form1()
        {
            InitializeComponent();
            IniciarConexion();
        }
        private void IniciarConexion()
        {
            try
            {
                variableconexion = ("Server=127.0.0.1; Database=prueba_progra; User=root; Password=;");//almacenamos los parametros de conexion
                conexion.ConnectionString = variableconexion; // igualamos nuestro string a un metodo de conexion en base a nuestra variable
                conexion.Open();//inicializamos la conexion
                MessageBox.Show("La conexion se ha realizado con exito");//mostramos mensaje de conexion exitosa
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("La conexion ha fallado, el error es" + ex);//mostramos el error
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
