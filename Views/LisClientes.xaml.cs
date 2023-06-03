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

namespace Punto_Venta.Views
{
    /// <summary>
    /// Lógica de interacción para LisClientes.xaml
    /// </summary>
    public partial class LisClientes : Window
    {
        public LisClientes()
        {
            InitializeComponent();
            txtBuscarCli.Focus();
            txtFechaC.Text = DateTime.Now.ToString("dd/MM/yyyy");

            DataTable tabla = new DataTable();
            DataRow fila = tabla.NewRow();
            tabla.Rows.Add(fila);
            TablaClientes.ItemsSource = tabla.AsDataView();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            PuntoVenta venPV = new Views.PuntoVenta();
            venPV.Show();
            this.Close();
        }
        
        private void TablaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PuntoVenta punto = new Views.PuntoVenta();
            punto.txtNomCliente.Text = "CAMILA LOPEZ";
            this.Close();
            punto.Show();
        }
    }
}
