﻿#pragma checksum "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "421F4C7E113AE526543A932AE0101C8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExportarParaArquivo;
using ExportarParaArquivo.Control;
using FluxoCaixaClient.Util;
using FluxoCaixaClient.ViewModel.FluxoCaixa;
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


namespace FluxoCaixaClient.View.FluxoCaixa {
    
    
    /// <summary>
    /// FCDetalhe
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class FCDetalhe : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarPeriodo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpData;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDataBase;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btGerarFluxo;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCarregaOrcado;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConfirmar;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSair;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FluxoCaixaClient;component/view/fluxocaixa/fcdetalhe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btPesquisarPeriodo = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
            this.btPesquisarPeriodo.Click += new System.Windows.RoutedEventHandler(this.btPesquisarPeriodo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dpData = ((System.Windows.Controls.DatePicker)(target));
            
            #line 33 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
            this.dpData.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpData_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dpDataBase = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.btGerarFluxo = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
            this.btGerarFluxo.Click += new System.Windows.RoutedEventHandler(this.btGerarFluxo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btCarregaOrcado = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
            this.btCarregaOrcado.Click += new System.Windows.RoutedEventHandler(this.btCarregaOrcado_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btConfirmar = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
            this.btConfirmar.Click += new System.Windows.RoutedEventHandler(this.btConfirmar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btSair = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\View\FluxoCaixa\FCDetalhe.xaml"
            this.btSair.Click += new System.Windows.RoutedEventHandler(this.btSair_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

