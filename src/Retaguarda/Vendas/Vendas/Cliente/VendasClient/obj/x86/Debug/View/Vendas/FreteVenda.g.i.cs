﻿#pragma checksum "..\..\..\..\..\View\Vendas\FreteVenda.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B651BBBE8DE7627D024D1602AB089741"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
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


namespace VendasClient.View.Vendas {
    
    
    /// <summary>
    /// FreteVenda
    /// </summary>
    public partial class FreteVenda : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSalvar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSair;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarTransportadora;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPesquisarVendaCabecalho;
        
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
            System.Uri resourceLocater = new System.Uri("/VendasClient;component/view/vendas/fretevenda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
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
            this.btSalvar = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
            this.btSalvar.Click += new System.Windows.RoutedEventHandler(this.btSalvar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btSair = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
            this.btSair.Click += new System.Windows.RoutedEventHandler(this.btSair_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btPesquisarTransportadora = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
            this.btPesquisarTransportadora.Click += new System.Windows.RoutedEventHandler(this.btPesquisarTransportadora_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btPesquisarVendaCabecalho = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\View\Vendas\FreteVenda.xaml"
            this.btPesquisarVendaCabecalho.Click += new System.Windows.RoutedEventHandler(this.btPesquisarVendaCabecalho_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

