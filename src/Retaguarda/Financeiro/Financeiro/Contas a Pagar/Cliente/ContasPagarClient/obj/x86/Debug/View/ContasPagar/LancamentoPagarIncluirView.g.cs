﻿#pragma checksum "..\..\..\..\..\View\ContasPagar\LancamentoPagarIncluirView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "202DA25D3934FE295BECE8C492920C69"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ContasPagarClient.Util;
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


namespace ContasPagarClient.View.ContasPagar {
    
    
    /// <summary>
    /// LancamentoPagarIncluirView
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class LancamentoPagarIncluirView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\View\ContasPagar\LancamentoPagarIncluirView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConfirmar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\View\ContasPagar\LancamentoPagarIncluirView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCancelar;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\View\ContasPagar\LancamentoPagarIncluirView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btGerarParcelas;
        
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
            System.Uri resourceLocater = new System.Uri("/ContasPagarClient;component/view/contaspagar/lancamentopagarincluirview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\ContasPagar\LancamentoPagarIncluirView.xaml"
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
            this.btConfirmar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\View\ContasPagar\LancamentoPagarIncluirView.xaml"
            this.btConfirmar.Click += new System.Windows.RoutedEventHandler(this.btConfirmar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\View\ContasPagar\LancamentoPagarIncluirView.xaml"
            this.btCancelar.Click += new System.Windows.RoutedEventHandler(this.btCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btGerarParcelas = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\..\..\View\ContasPagar\LancamentoPagarIncluirView.xaml"
            this.btGerarParcelas.Click += new System.Windows.RoutedEventHandler(this.btGerarParcelas_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

