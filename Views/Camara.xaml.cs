using System.Diagnostics;
using System.IO;
using System.Threading;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Punto_Venta.Views;
using System.Drawing;

namespace Punto_Venta.Views
{
    /// <summary>
    /// Lógica de interacción para Camara.xaml
    /// </summary>
    public partial class Camara : Window
    {

        public Camara()
        {
            InitializeComponent();

        }

        #region Salir
       
        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            this.Close();
        }
        #endregion

 
    }
}
