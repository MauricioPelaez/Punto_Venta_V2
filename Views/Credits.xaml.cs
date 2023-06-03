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
    /// Lógica de interacción para Credits.xaml
    /// </summary>
    public partial class Credits : Window
    {
        public Credits()
        {
            InitializeComponent();
            txtFechaCr.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtBuscarCredito.Focus();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainView venPri = new Views.MainView();
            venPri.Show();
            this.Close();
        }

        private void btnAltCredito_Click(object sender, RoutedEventArgs e)
        {
            VentanaPagos.Visibility = Visibility.Visible;
            btnAltCredito.IsEnabled = false;
        }
        private void CerrarVenPago()
        {
            VentanaPagos.Visibility = Visibility.Hidden;
            comboTipoPago.SelectedIndex = 0;

            btnAltCredito.IsEnabled = true;
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
