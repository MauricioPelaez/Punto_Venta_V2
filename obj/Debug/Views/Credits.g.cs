﻿#pragma checksum "..\..\..\Views\Credits.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "117C768C9C85EA14097B5BB9927247CA0E0535EA209928F82E7B5E2DC26F748B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Punto_Venta.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Punto_Venta.Views {
    
    
    /// <summary>
    /// Credits
    /// </summary>
    public partial class Credits : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtFechaCr;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuscarCredito;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAltCredito;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TablaProductos;
        
        #line default
        #line hidden
        
        
        #line 328 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lista;
        
        #line default
        #line hidden
        
        
        #line 347 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel VentanaPagos;
        
        #line default
        #line hidden
        
        
        #line 378 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseVen;
        
        #line default
        #line hidden
        
        
        #line 423 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboTipoPago;
        
        #line default
        #line hidden
        
        
        #line 433 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAceptarTipoPago;
        
        #line default
        #line hidden
        
        
        #line 472 "..\..\..\Views\Credits.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelarTipoPago;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF-LoginForm;component/views/credits.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Credits.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtFechaCr = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Views\Credits.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.btnVolver_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtBuscarCredito = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnAltCredito = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\Views\Credits.xaml"
            this.btnAltCredito.Click += new System.Windows.RoutedEventHandler(this.btnAltCredito_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TablaProductos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.lista = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.VentanaPagos = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.btnCloseVen = ((System.Windows.Controls.Button)(target));
            
            #line 387 "..\..\..\Views\Credits.xaml"
            this.btnCloseVen.Click += new System.Windows.RoutedEventHandler(this.btnCloseVen_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.comboTipoPago = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btnAceptarTipoPago = ((System.Windows.Controls.Button)(target));
            
            #line 442 "..\..\..\Views\Credits.xaml"
            this.btnAceptarTipoPago.Click += new System.Windows.RoutedEventHandler(this.btnAceptarTipoPago_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnCancelarTipoPago = ((System.Windows.Controls.Button)(target));
            
            #line 481 "..\..\..\Views\Credits.xaml"
            this.btnCancelarTipoPago.Click += new System.Windows.RoutedEventHandler(this.btnCancelarTipoPago_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

