using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Punto_Venta.ConexionMySQL;
using Punto_Venta.Views;
using Punto_Venta.Datos_Estaticos;

namespace Punto_Venta.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            txtUser.Focus();
            conexion.ConnectionString = conexionSQL.Conectar();

        }

        #region Cabecera

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region saltos de linea
        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_Validacion.Visibility = Visibility.Hidden;
            if (e.Key == Key.Enter)
            {
                txt_Pass.Focus();
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin.Focus();
            }
        }

        #endregion

        #region Base de datos
        MySqlConnection conexion = new MySqlConnection();
        ConexionSQL conexionSQL = new ConexionSQL();

        #region Iniciar Sesión
        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            IniciarSesion();
        }
        private void btnLogin_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                IniciarSesion();
            }
        }

        private void IniciarSesion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                string cadena = "SELECT `Usuario`, `Contraseña` FROM `login` WHERE `Usuario` = @user AND `Contraseña` = @pass";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUser.Text;
                comando.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txt_Pass.Password;
                comando.CommandTimeout = 60;

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count == 0)
                {
                    lbl_Validacion.Visibility = Visibility.Visible;
                    txtUser.Text = "";
                    txt_Pass.Password = "";
                    txtUser.Focus();
                    lbl_TipoUserIng.Visibility = Visibility.Hidden;
                    lbl_UserIng.Visibility = Visibility.Hidden;
                }
                else
                {

                    MainView ventana = new MainView();
                    ventana.Show();
                    this.Close();

                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }

                }
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                conexion.Close();
                txtUser.Text = "";
                txt_Pass.Password = "";
                txtUser.Focus();
                lbl_TipoUserIng.Visibility = Visibility.Hidden;
                lbl_UserIng.Visibility = Visibility.Hidden;
            }

        }


        #endregion

        #region Ver nombre y tipo de User ingresado
        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            //Mostrar nombre del usuario ingresado
            string cadena = "SELECT `Nombre` FROM `login` WHERE `Usuario` = @user";
            MySqlCommand command = new MySqlCommand(cadena, conexion);
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUser.Text;
            command.CommandTimeout = 60;
            lbl_UserIng.Text = Convert.ToString(command.ExecuteScalar());
            lbl_UserIng.Visibility = Visibility.Visible;

            //Mostrar el tipo de usuario ingresado
            MySqlCommand cmd = new MySqlCommand("SELECT `Tipo` FROM `login` WHERE `Usuario` = @user", conexion);
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUser.Text;
            cmd.CommandTimeout = 60;
            lbl_TipoUserIng.Text = Convert.ToString(cmd.ExecuteScalar());
            lbl_TipoUserIng.Visibility = Visibility.Visible;

            Global.usuarioLog = lbl_UserIng.Text;
            Global.tipoUsuarioLog = lbl_TipoUserIng.Text;

            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }


        #endregion

        #endregion

        private void btnCamara_Click(object sender, RoutedEventArgs e)
        {
            Camara cam = new Camara();
            cam.Show();

            this.Close();

        }
    }
}
