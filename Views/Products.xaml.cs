using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        public Products()
        {
            InitializeComponent();
            txtBuscarProd.Focus();
            txtFechaP.Text = DateTime.Now.ToString("dd/MM/yyyy");

            DataTable tabla = new DataTable();
            DataRow fila = tabla.NewRow();
            tabla.Rows.Add(fila);
            TablaProductos.ItemsSource = tabla.AsDataView();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            PuntoVenta venPV = new Views.PuntoVenta();
            venPV.Show();
            this.Close();
        }
    }
}
