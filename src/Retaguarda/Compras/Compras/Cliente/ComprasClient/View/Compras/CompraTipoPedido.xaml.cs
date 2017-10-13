using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ComprasClient.ViewModel.Compras;

namespace ComprasClient.View.Compras
{
    /// <summary>
    /// Interaction logic for CompraTipoPedido.xaml
    /// </summary>
    public partial class CompraTipoPedido : UserControl
    {
        public CompraTipoPedido()
        {
            InitializeComponent();
        }
        private void btSair_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((CompraTipoPedidoViewModel)this.DataContext).IsEditar= false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((CompraTipoPedidoViewModel)this.DataContext).salvarAtualizarCompraTipoPedido();
                MessageBox.Show("Salvo com sucesso!", "Informação do sistema");
                ((CompraTipoPedidoViewModel)this.DataContext).atualizarListaCompraTipoPedido(0);
                ((CompraTipoPedidoViewModel)this.DataContext).IsEditar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }


    }
}
