﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using ContasPagarClient.View.ContasPagar;
using CloseableTabItemDemo;

namespace ContasPagarClient.ViewModel.ContasPagar
{
    public class ContasPagarViewModel
    {

        public ContasPagarViewModel()
        {
        }

        public void novaPagina(UserControl janela, String cabecalho)
        {
            Boolean achou = false;

            CloseableTabItem tabItem = new CloseableTabItem();
            tabItem.Header = cabecalho;
            tabItem.Content = janela;

            foreach (TabItem tab in ContasPagarPrincipal.TabPrincipal.Items)
            {
                if (tab.Header == tabItem.Header)
                {
                    achou = true;
                    tab.Focus();
                }
            }

            if (!achou)
            {
                ContasPagarPrincipal.TabPrincipal.Items.Add(tabItem);
                tabItem.Focus();
            }
        }


    }
}
