﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Punto_Venta.Views;

namespace Punto_Venta
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var loginView = new LoginView();
            loginView.Show();
            loginView.IsVisibleChanged += (s, ev) =>
              {
                  try
                  {
                      if (loginView.IsVisible == false && loginView.IsLoaded)
                      {
                          var mainView = new MainView();
                          mainView.Show();
                          loginView.Close();

                      }

                  }
                  catch
                  {
                      Application.Current.Shutdown();
                  }
                  
              };
        }
    }
}
