using NFe.ServidorReference;
using NFe.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace NFe.View
{
    /// <summary>
    /// Interaction logic for NFeDestinatario.xaml
    /// </summary>
    public partial class NFeCupomVinculado : UserControl
    {
        public NFeCupomVinculado()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NFE_CUPOM_FISCAL_REFERENCIADO CupomVinculado = new NFE_CUPOM_FISCAL_REFERENCIADO();

                CupomVinculado.MODELO_DOCUMENTO_FISCAL = tbModeloDocumentoFiscal.Text;
                CupomVinculado.DATA_EMISSAO_CUPOM = dpDataEmissao.DateTime;
                int aux;
                if(int.TryParse(tbNrOrdemECF.Text, out aux))
                    CupomVinculado.NUMERO_ORDEM_ECF = aux;
                else
                    CupomVinculado.NUMERO_ORDEM_ECF = null;

                if(int.TryParse(tbNrCaixa.Text, out aux))
                    CupomVinculado.NUMERO_CAIXA = aux;
                else
                    CupomVinculado.NUMERO_CAIXA = null;

                if (int.TryParse(tbCOO.Text, out aux))
                    CupomVinculado.COO = aux;
                else
                    CupomVinculado.COO = null;

                CupomVinculado.NUMERO_SERIE_ECF = tbNrSerieECF.Text;

                ((NFeViewModel)DataContext).IncluirCupomVinculado(CupomVinculado);

                tbModeloDocumentoFiscal.Clear();
                //dpDataEmissao.DateTime = null;
                tbNrOrdemECF.Clear();
                tbNrCaixa.Clear();
                tbCOO.Clear();
                tbNrSerieECF.Clear();

                dataGrid.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");    
            }
        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataGrid.SelectedItem != null)
                {
                    ((NFeViewModel)DataContext).ExcluirCupomVinculado(dataGrid.SelectedIndex);
                    dataGrid.Items.Refresh();
                }
                else
                    MessageBox.Show("Selecione um cupom fiscal a ser excluído.", "Alerta do sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }
    }
}
