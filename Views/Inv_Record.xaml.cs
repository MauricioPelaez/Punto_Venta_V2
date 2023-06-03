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
    /// Lógica de interacción para Inv_Record.xaml
    /// </summary>
    public partial class Inv_Record : Window
    {
        public Inv_Record()
        {
            
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Volver(object sender, RoutedEventArgs e)
        {
            MainView venPri = new Views.MainView();
            venPri.Show();
            this.Close();
        }

        private void activarRP()
        {
            txtCodigo.IsEnabled = true;
            txtDescripcion.IsEnabled = true;
            comboProveedor.IsEnabled = true;
            comboBodega.IsEnabled = true;
            txtCantidad.IsEnabled = true;
            txtValCompra.IsEnabled = true;
            txtValVenta.IsEnabled = true;
            comboDescuento.IsEnabled = true;
        }

        private void desactivarRP()
        {
            txtCodigo.IsEnabled = false;
            txtDescripcion.IsEnabled = false;
            comboProveedor.IsEnabled = false;
            comboBodega.IsEnabled = false;
            txtCantidad.IsEnabled = false;
            txtValCompra.IsEnabled = false;
            txtValVenta.IsEnabled = false;
            comboDescuento.IsEnabled = false;

            btnGuardar.IsEnabled = false;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnNuevo.IsEnabled = true;

            comboBodega.SelectedIndex = 0;
            comboProveedor.SelectedIndex = 0;
            comboDescuento.SelectedIndex = 0;
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtStock.Text = "0";
            txtValCompra.Text = "";
            txtValVenta.Text = "";
            txtGanacia.Text = "0";
        }
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            activarRP();
            btnGuardar.IsEnabled = true;
            btnNuevo.IsEnabled = false;


            comboBodega.SelectedIndex = 0;
            comboProveedor.SelectedIndex = 0;
            comboDescuento.SelectedIndex = 0;
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtStock.Text = "0";
            txtValCompra.Text = "";
            txtValVenta.Text = "";
            txtGanacia.Text = "0";
            txtCodigo.Focus();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            activarRP();

            btnActualizar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnGuardar.IsEnabled = false;
            btnNuevo.IsEnabled = false;
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            desactivarRP();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            desactivarRP();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            desactivarRP();

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            desactivarRP();

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
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
                comboBodega.Focus();
                comboBodega.SelectedIndex = 1;
            }
        }

        private void comboBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtCantidad.Focus();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtValCompra.Focus();
            }
        }

        private void txtValCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtValVenta.Focus();
            }
        }

        private void GananciaTotal()
        {
            try
            {
                float total;
                total = float.Parse(txtValVenta.Text) - float.Parse(txtValCompra.Text);

                string resultado;
                resultado = total.ToString("#,#");
                txtGanacia.Text = $"$ {resultado}";
            }
            catch
            {
                string mensajeText = "El valor de compra o de venta es incorrecto";
                string caption = "Error en los Precios";

                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = MessageBox.Show(mensajeText, caption, button, icon, MessageBoxResult.Yes);
                txtValCompra.Focus();
            }
        }

        private void txtValVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comboDescuento.Focus();
                GananciaTotal(); 
            } 
        }

        private void txtValVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0 || e.Key == Key.NumPad1 || e.Key == Key.NumPad2 || e.Key == Key.NumPad3 || e.Key == Key.NumPad4 ||
            e.Key == Key.NumPad5 || e.Key == Key.NumPad6 || e.Key == Key.NumPad7 || e.Key == Key.NumPad8 || e.Key == Key.NumPad9 ||
            e.Key == Key.D0 || e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4 || e.Key == Key.D5 ||
            e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9)
            {
                GananciaTotal(); 
            }

            if (e.Key == Key.Back)
            {
                txtGanacia.Text = $"$ {0}";
            }
           
        }

        private void txtNomBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtDescBodega.Focus();
            }
            
        }

        private void desactivarBod()
        {
            txtNomBodega.IsEnabled = false;
            txtDescBodega.IsEnabled = false;

            btnGuardarBod.IsEnabled = false;
            btnNuevaBod.IsEnabled = true;
            btnEliminarBod.IsEnabled = false;
            btnActualizarBod.IsEnabled = false;

            txtNomBodega.Text = "";
            txtDescBodega.Text = "";
        }

        private void btnNuevaBod_Click(object sender, RoutedEventArgs e)
        {
            txtNomBodega.IsEnabled = true;
            txtDescBodega.IsEnabled = true;

            btnGuardarBod.IsEnabled = true;
            btnNuevaBod.IsEnabled = false;
            btnEliminarBod.IsEnabled = false;
            btnActualizarBod.IsEnabled = false;

            txtNomBodega.Text = "";
            txtDescBodega.Text = "";
            txtNomBodega.Focus();
        }

        private void btnGuardarBod_Click(object sender, RoutedEventArgs e)
        {
            desactivarBod();
        }

        private void btnActualizarBod_Click(object sender, RoutedEventArgs e)
        {
            desactivarBod();
        }

        private void btnEliminarBod_Click(object sender, RoutedEventArgs e)
        {
            desactivarBod();
        }

        private void btnCancelarBod_Click(object sender, RoutedEventArgs e)
        {
            desactivarBod();
        }

        private void lista_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtNomBodega.IsEnabled = true;
            txtDescBodega.IsEnabled = true;

            btnActualizarBod.IsEnabled = true;
            btnEliminarBod.IsEnabled = true;
            btnGuardarBod.IsEnabled = false;
            btnNuevaBod.IsEnabled = false;
            txtNomBodega.Focus();
        }

        private void SoloNumeros(object sender, TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            if (ascci >= 48 && ascci <= 57) e.Handled = false;

            else e.Handled = true;
        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
