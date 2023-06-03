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

namespace Punto_Venta.Views
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            txtUser_Log.Text = Global.usuarioLog;
            txt_Tipo_User_log.Text = Global.tipoUsuarioLog;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            txtFecha.Text = DateTime.Now.ToLongDateString();
        }


        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if(Canva_Menu.Visibility == Visibility.Collapsed)
            {
                Canva_Menu.Visibility = Visibility.Visible;
            }
            else
            {
                Canva_Menu.Visibility = Visibility.Collapsed;
            }
        }


        #region Abrir formularios

        private Window ventana = null;
        private void AbrirFormulario(Window formulario)
        {
            if (Global.pestaña == false)
            {
                Global.pestaña = true;
                if (ventana != null)
                {
                    ventana.Close();
                }

                ventana = formulario;
                formulario.Show();
            }

        }


        #endregion

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


        private void btnMaximizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
            btnMaximizar.Visibility = Visibility.Hidden;
            btnRestaurar.Visibility = Visibility.Visible;
        }

        private void btnRestaurar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            btnMaximizar.Visibility = Visibility.Visible;
            btnRestaurar.Visibility = Visibility.Hidden;

        }

        #endregion
    }
}
