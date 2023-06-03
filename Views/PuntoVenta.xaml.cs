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
using Punto_Venta.ConexionMySQL;

namespace Punto_Venta.Views
{
    /// <summary>
    /// Lógica de interacción para PuntoVenta.xaml
    /// </summary>
    public partial class PuntoVenta : Window
    {
        public PuntoVenta()
        {
            InitializeComponent();
            txtFechaPV.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainView venPri = new Views.MainView();
            venPri.Show();
            this.Close();
        }

        private void btnProducto_Click(object sender, RoutedEventArgs e)
        {
            Products venProd = new Views.Products();
            venProd.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, RoutedEventArgs e)
        {
            VentanaPagos.Visibility = Visibility.Visible;

            btnClientes.IsEnabled = false;
            btnProducto.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnCredito.IsEnabled = false;
            btnFacturar.IsEnabled = false;
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnCredito_Click(object sender, RoutedEventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            conexion.Conectar();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            LisClientes venLisC = new Views.LisClientes();
            venLisC.Show();
            this.Close();
        }

        private void CerrarVenPago()
        {
            VentanaPagos.Visibility = Visibility.Hidden;
            comboTipoPago.SelectedIndex = 0;

            btnClientes.IsEnabled = true;
            btnProducto.IsEnabled = true;
            btnLimpiar.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            btnCredito.IsEnabled = true;
            btnFacturar.IsEnabled = true;
        }

        private void btnCloseVen_Click(object sender, RoutedEventArgs e)
        {
            CerrarVenPago();
        }

        private void btnCancelarTipoPago_Click(object sender, RoutedEventArgs e)
        {
            CerrarVenPago();
        }

        private void btnAceptarTipoPago_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
