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
    /// Lógica de interacción para Facturas.xaml
    /// </summary>
    public partial class Gastos : Window
    {
        public Gastos()
        {
            InitializeComponent();
            CalendarioVencimiento.SelectedDate = DateTime.Now;
            txtFechaG.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainView VenPri = new MainView();
            VenPri.Show();
            this.Close();
        }

        private void txtNumFact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtDescripcionFact.Focus();
            }
        }

        private void txtDescripcionFact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                comboProveedor.Focus();
                comboProveedor.SelectedIndex = 1;
            }

        }

        private void comboProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtValorFact.Focus();
            }
        }

        private void txtValorFact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                CalendarioVencimiento.Focus();
            }
        }

        private void activar()
        {
            txtNumFact.IsEnabled = true;
            txtDescripcionFact.IsEnabled = true;
            comboProveedor.IsEnabled = true;
            txtValorFact.IsEnabled = true;
            CalendarioVencimiento.IsEnabled = true;
        }

        private void desactivar()
        {
            txtNumFact.IsEnabled = false;
            txtDescripcionFact.IsEnabled = false;
            comboProveedor.IsEnabled = false;
            txtValorFact.IsEnabled = false;
            CalendarioVencimiento.IsEnabled = false;

            btnGuardar.IsEnabled = false;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnNuevo.IsEnabled = true;

            txtNumFact.Text = "";
            txtDescripcionFact.Text = "";
            comboProveedor.SelectedIndex = 0;
            txtValorFact.Text = "";
            CalendarioVencimiento.SelectedDate = DateTime.Now;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            btnGuardar.IsEnabled = true;
            btnNuevo.IsEnabled = false;

            activar();
            txtNumFact.Text = "";
            txtDescripcionFact.Text = "";
            comboProveedor.SelectedIndex = 0;
            txtValorFact.Text = "";
            CalendarioVencimiento.SelectedDate = DateTime.Now;
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
            btnNuevo.IsEnabled = false;
        }
    }
}
