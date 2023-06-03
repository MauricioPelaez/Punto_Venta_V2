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
using System.Windows.Threading;
using Punto_Venta.Datos_Estaticos;
using Punto_Venta.Views;

namespace Punto_Venta.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
           
            InitializeComponent();
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            txtUser_Log.Text = Global.usuarioLog;
            txt_Tipo_User_log.Text = Global.tipoUsuarioLog;

        }


        #region Fecha y Hora
        void timer_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            txtFecha.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region Boton Menu
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (Canva_Menu.Visibility == Visibility.Collapsed)
            {
                Canva_Menu.Visibility = Visibility.Visible;
            }
            else
            {
                Canva_Menu.Visibility = Visibility.Collapsed;
            }
        }
        #endregion

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            Clients venCli = new Views.Clients();
            venCli.Show();
            this.Close();
        }

        private void btnProveedores_Click(object sender, RoutedEventArgs e)
        {
            Providers venProv = new Views.Providers();
            venProv.Show();
            this.Close();
        }

        private void btnRegistroInventario_Click(object sender, RoutedEventArgs e)
        {
            Inv_Record venInv = new Views.Inv_Record();
            venInv.Show();
            this.Close();
        }

        private void btnPuntoVenta_Click(object sender, RoutedEventArgs e)
        {
            PuntoVenta venPV = new Views.PuntoVenta();
            venPV.Show();
            this.Close();
        }

        private void btnCredito_Click(object sender, RoutedEventArgs e)
        {
            Credits VenCred = new Views.Credits();
            VenCred.Show();
            this.Close();
        }

        private void btnConfiguracion_Click(object sender, RoutedEventArgs e)
        {
            Setting VenSet = new Views.Setting();
            VenSet.Show();
            this.Close();
        }

        private void btnTotalVentas_Click(object sender, RoutedEventArgs e)
        {
            TotalSales VenTS = new Views.TotalSales();
            VenTS.Show();
            this.Close();
        }

        private void btnGastos_Click(object sender, RoutedEventArgs e)
        {
            Gastos VenGas = new Views.Gastos();
            VenGas.Show();
            this.Close();
        }

        #region Botones Cabecera
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            string mensajeText = "¿Desea cerrar la sesión?";
            string caption = "Cerrar Sesión";

            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result;

            result = MessageBox.Show(mensajeText, caption, button, icon);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        #endregion
    }
}
