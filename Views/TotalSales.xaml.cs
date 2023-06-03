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
    /// Lógica de interacción para TotalSales.xaml
    /// </summary>
    public partial class TotalSales : Window
    {
        public TotalSales()
        {
            InitializeComponent();
            CalendarioInicio.SelectedDate = DateTime.Now;
            CalendarioFinal.SelectedDate = DateTime.Now;
            txtFechaTV.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelUser.Visibility = Visibility.Hidden;
            comboUser.Visibility = Visibility.Hidden;
        }

        private void btnVolverTS_Click(object sender, RoutedEventArgs e)
        {
            MainView venPri = new Views.MainView();
            venPri.Show();
            this.Close();
        }

        private void btnBuscarVenta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdoTodosUser_Checked(object sender, RoutedEventArgs e)
        {
            labelUser.Visibility = Visibility.Hidden;
            comboUser.Visibility = Visibility.Hidden;
            comboUser.SelectedIndex = 0;
        }

        private void rdoSelectUser_Checked(object sender, RoutedEventArgs e)
        {
            labelUser.Visibility = Visibility.Visible;
            comboUser.Visibility = Visibility.Visible;
        }
    }
}
