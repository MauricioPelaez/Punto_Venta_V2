using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Punto_Venta.Views
{
    /// <summary>
    /// Lógica de interacción para Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
            txtFechaConf.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnVolverConf_Click(object sender, RoutedEventArgs e)
        {
            MainView venPri = new Views.MainView();
            venPri.Show();
            this.Close();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtTelefono.Focus();
            }
        }

        private void activar()
        {
            txtUsuario.IsEnabled = true;
            txtContraseña.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtApellido.IsEnabled = true;
            txtTelefono.IsEnabled = true;
        }
        private void desactivar()
        {
            txtUsuario.IsEnabled = false;
            txtContraseña.IsEnabled = false;
            txtNombre.IsEnabled = false;
            txtApellido.IsEnabled = false;
            txtTelefono.IsEnabled = false;

            btnGuardar.IsEnabled = false;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnNuevo.IsEnabled = true;

            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            activar();
            btnGuardar.IsEnabled = true;
            btnNuevo.IsEnabled = false;

            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Focus();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            desactivar();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            desactivar();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            desactivar();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            desactivar();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            activar();
            btnActualizar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnGuardar.IsEnabled =false;
            btnNuevo.IsEnabled = false;
        }


        private void activarEmp()
        {
            txtNit.IsEnabled = true;
            txtNombreEmp.IsEnabled = true;
            txtDireccionEmp.IsEnabled = true;
            txtCiudad.IsEnabled = true;
            txtDepartamento.IsEnabled = true;
            btnActualizarEmp.IsEnabled = true;
        }

        private void desactivarEmp()
        {
            txtNit.IsEnabled = false;
            txtNombreEmp.IsEnabled = false;
            txtDireccionEmp.IsEnabled = false;
            txtCiudad.IsEnabled = false;
            txtDepartamento.IsEnabled = false;
            btnActualizarEmp.IsEnabled = false;

            txtNit.Text = "";
            txtNombreEmp.Text = "";
            txtDireccionEmp.Text = "";
            txtCiudad.Text = "";
            txtDireccionEmp.Text = "";
        }

        private void btnActualizarEmp_Click(object sender, RoutedEventArgs e)
        {
            desactivarEmp();
        }

        private void btnCancelarEmp_Click(object sender, RoutedEventArgs e)
        {
            desactivarEmp();
        }

        private void txtNit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtNombreEmp.Focus();
            }
        }

        private void txtNombreEmp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtDireccionEmp.Focus();
            }
        }

        private void txtDireccionEmp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtCiudad.Focus();
            }
        }

        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtDepartamento.Focus();
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            activarEmp();
        }

        private void lista_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            txtDefDescuento.IsEnabled = true;
            btnActualizarDes.IsEnabled = true;
            btnCancelarDes.IsEnabled = true;

            txtDefDescuento.Focus();
        }

        private void btnCancelarDes_Click(object sender, RoutedEventArgs e)
        {
            txtDefDescuento.IsEnabled = false;
            btnActualizarDes.IsEnabled = false;
            btnCancelarDes.IsEnabled = false;

            txtDefDescuento.Text = "";
        }

        private void btnActualizarDes_Click(object sender, RoutedEventArgs e)
        {
            txtDefDescuento.IsEnabled = false;
            btnActualizarDes.IsEnabled = false;
            btnCancelarDes.IsEnabled = false;

            txtDefDescuento.Text = "";
        }

        private void SoloNumeros(object sender, TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            if (ascci >= 48 && ascci <= 57) e.Handled = false;

            else e.Handled = true;
        }
    }
}
