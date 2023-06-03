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
using Punto_Venta.Views;

namespace Punto_Venta.Views
{
    /// <summary>
    /// Lógica de interacción para Providers.xaml
    /// </summary>
    public partial class Providers : Window
    {
        public Providers()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainView venPri = new Views.MainView();
            venPri.Show();
            this.Close();
        }

        private void activar()
        {
            txtCedula.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtEmail.IsEnabled = true;
            comboTipoProv.IsEnabled = true;
            txtTelefono.IsEnabled = true;
        }

        private void desactivar()
        {
            txtCedula.IsEnabled = false;
            txtNombre.IsEnabled = false;
            txtEmail.IsEnabled = false;
            comboTipoProv.IsEnabled = false;
            txtTelefono.IsEnabled = false;

            btnGuardar.IsEnabled = false;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnNuevo.IsEnabled = true;

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            comboTipoProv.SelectedIndex = 0;
        }
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            activar();
            btnGuardar.IsEnabled = true;
            btnNuevo.IsEnabled = false;

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            comboTipoProv.SelectedIndex = 0;
            txtCedula.Focus();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            activar();
            btnActualizar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnGuardar.IsEnabled = false;
            btnNuevo.IsEnabled = false;
            txtCedula.Focus();
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

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
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
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                comboTipoProv.Focus();
                comboTipoProv.SelectedIndex = 1;
            }
        }
    }
}
