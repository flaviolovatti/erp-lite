﻿#pragma checksum "..\..\..\..\..\View\ContasReceber\ViewFinLancamentoReceberPrincipal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "529EFC25684843E9C5C44614D121A9ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using ContasReceberClient.View.ContasReceber;
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


namespace ContasReceberClient.View.ContasReceber {
    
    
    /// <summary>
    /// ViewFinLancamentoReceberPrincipal
    /// </summary>
    public partial class ViewFinLancamentoReceberPrincipal : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\View\ContasReceber\ViewFinLancamentoReceberPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabViewFinLancamentoReceberLista;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\View\ContasReceber\ViewFinLancamentoReceberPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConsultar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\View\ContasReceber\ViewFinLancamentoReceberPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabViewFinLancamentoReceber;
        
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
            System.Uri resourceLocater = new System.Uri("/ContasReceberClient;component/view/contasreceber/viewfinlancamentoreceberprincip" +
                    "al.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\ContasReceber\ViewFinLancamentoReceberPrincipal.xaml"
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
            this.tabViewFinLancamentoReceberLista = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.btConsultar = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\View\ContasReceber\ViewFinLancamentoReceberPrincipal.xaml"
            this.btConsultar.Click += new System.Windows.RoutedEventHandler(this.btConsultar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tabViewFinLancamentoReceber = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

