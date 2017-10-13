using DFe.Classes.Entidades;
using DFe.Classes.Flags;
using DFe.Utils;
using NFe.AppTeste;
using NFe.Classes.Informacoes;
using NFe.Classes.Informacoes.Destinatario;
using NFe.Classes.Informacoes.Detalhe;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Informacoes.Total;
using NFe.Classes.Informacoes.Transporte;
using NFe.Classes.Servicos.Tipos;
using NFe.Servicos;
using NFe.ServidorReference;
using NFe.Util;
using NFe.Utils;
using NFe.Utils.NFe;
using NFe.View;
using SearchWindow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace NFe.ViewModel
{
    public class NFeViewModel : ViewModelBase
    {

        #region Variáveis
        private static ConfiguracaoApp _configuracoes;
        private static string _protocolo;
        private const string ArquivoConfiguracao = @"\configuracao.xml";
        private static NFe.Classes.NFe _nfe;

        public Boolean IsSelectedTabLista { get; set; }
        public Boolean IsSelectedTabDados { get; set; }
        public ContentPresenter ContentPresenterTabDados { get; set; }
        public ObservableCollection<NFE_CABECALHO> ListaNFe { get; set; }
        public NFE_CABECALHO _NFeSelected { get; set; }
        public ProdutoDTO ProdutoSelected { get; set; }
        private EmpresaDTO Empresa { get; set; }
        public NFE_DETALHE DetalheNFe { get; set; }
        #endregion

        #region Construtor
        public NFeViewModel()
        {
            try
            {
                _configuracoes = new ConfiguracaoApp();
                ConfiguraNfe();

                ContentPresenterTabDados = new ContentPresenter();
                ListaNFe = new ObservableCollection<NFE_CABECALHO>();

                using (ServidorClient Servico = new ServidorClient())
                {
                    Empresa = Servico.SelectObjetoEmpresa("Id=1");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Infra
        public NFE_CABECALHO NFeSelected
        {
            get { return _NFeSelected; }
            set
            {
                _NFeSelected = value;
                notifyPropertyChanged("NFeSelected");
            }
        }

        public void CarregarTabLista()
        {
            try
            {
                ContentPresenterTabDados.Content = null;
                AtualizarListaNFe();
                IsSelectedTabLista = true;
                notifyPropertyChanged("IsSelectedTabLista");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CarregarTabDados()
        {
            try
            {
                CarregarNFeSelected();
                ContentPresenterTabDados.Content = new NFeDados();
                IsSelectedTabDados = true;
                notifyPropertyChanged("IsSelectedTabDados");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CarregarNFeSelected()
        {
            try
            {
                if (NFeSelected != null && NFeSelected.ID != 0)
                {
                    using (ServidorClient serv = new ServidorClient())
                    {
                        NFeSelected = serv.SelectNfeCabecalhoId((int)NFeSelected.ID);
                    }
                }

                if (NFeSelected.NFE_DESTINATARIO == null)
                {
                    NFeSelected.NFE_DESTINATARIO = new List<NFE_DESTINATARIO>();
                    NFeSelected.NFE_DESTINATARIO.Add(new NFE_DESTINATARIO());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarListaNFe()
        {
            try
            {
                using (ServidorClient serv = new ServidorClient())
                {
                    List<NFE_CABECALHO> listaNFeServ = serv.SelectNfeCabecalho(new NFE_CABECALHO());

                    ListaNFe.Clear();

                    foreach (NFE_CABECALHO nfe in listaNFeServ)
                    {
                        ListaNFe.Add(nfe);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void AtualizarNumeroItemDetalhe()
        {
            try
            {
                int aux = 0;
                foreach (NFE_DETALHE det in NFeSelected.NFE_DETALHE)
                {
                    det.NUMERO_ITEM = ++aux;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AtualizarValoresNFe()
        {
            try
            {
                NFeSelected.BASE_CALCULO_ICMS = 0;
                NFeSelected.VALOR_ICMS = 0;
                NFeSelected.BASE_CALCULO_ICMS_ST = 0;
                NFeSelected.VALOR_ICMS_ST = 0;
                NFeSelected.VALOR_COFINS = 0;
                NFeSelected.VALOR_TOTAL_PRODUTOS = 0;
                NFeSelected.VALOR_FRETE = 0;
                NFeSelected.VALOR_SEGURO = 0;
                NFeSelected.VALOR_DESPESAS_ACESSORIAS = 0;
                NFeSelected.VALOR_PIS = 0;
                NFeSelected.VALOR_DESCONTO = 0;
                NFeSelected.VALOR_TOTAL = 0;

                foreach(NFE_DETALHE detalhe in NFeSelected.NFE_DETALHE)
                {
                    NFeSelected.VALOR_TOTAL += detalhe.VALOR_TOTAL;
                    NFeSelected.BASE_CALCULO_ICMS += detalhe.NFE_DETALHE_IMPOSTO_ICMS[0].BASE_CALCULO_ICMS;
                    NFeSelected.VALOR_ICMS += detalhe.NFE_DETALHE_IMPOSTO_ICMS[0].VALOR_ICMS;
                    NFeSelected.VALOR_TOTAL_PRODUTOS += detalhe.VALOR_TOTAL;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CRUD
        public void SalvarAtualizarNFe()
        {
            try
            {
                /*if (NFeSelected.TRIBUT_OPERACAO_FISCAL == null)
                    throw new Exception("Selecione a Operação Fiscal.");
                    */
                using (ServidorClient serv = new ServidorClient())
                {
                    NFeSelected.ID_EMPRESA = Empresa.Id;
                    NFeSelected.VERSAO_PROCESSO_EMISSAO = "100";

                    NFeSelected.NFE_DESTINATARIO[0].INSCRICAO_ESTADUAL = "";

                    if (NFeSelected.NFE_DESTINATARIO == null)
                    {
                        NFeSelected.NFE_DESTINATARIO = new List<NFE_DESTINATARIO>();
                        NFeSelected.NFE_DESTINATARIO.Add(new NFE_DESTINATARIO());
                    }
                    /*
                    if (NFeSelected.NFE_EMITENTE == null)
                    {
                        NFeSelected.NFE_EMITENTE = new List<NFE_EMITENTE>();
                        NFeSelected.NFE_EMITENTE.Add(new NFE_EMITENTE());

                        NFeSelected.NFE_EMITENTE[0].CPF_CNPJ = Empresa.Cnpj;
                        NFeSelected.NFE_EMITENTE[0].NOME = Empresa.RazaoSocial;
                        NFeSelected.NFE_EMITENTE[0].FANTASIA = Empresa.NomeFantasia;
                        NFeSelected.NFE_EMITENTE[0].LOGRADOURO = Empresa.EnderecoPrincipal.Logradouro;
                        NFeSelected.NFE_EMITENTE[0].NUMERO = Empresa.EnderecoPrincipal.Numero;
                        NFeSelected.NFE_EMITENTE[0].COMPLEMENTO = Empresa.EnderecoPrincipal.Complemento;
                        NFeSelected.NFE_EMITENTE[0].BAIRRO = Empresa.EnderecoPrincipal.Bairro;
                        NFeSelected.NFE_EMITENTE[0].CODIGO_MUNICIPIO = Empresa.EnderecoPrincipal.MunicipioIbge;
                        NFeSelected.NFE_EMITENTE[0].NOME_MUNICIPIO = Empresa.EnderecoPrincipal.Cidade;
                        NFeSelected.NFE_EMITENTE[0].UF = Empresa.EnderecoPrincipal.Uf;
                        NFeSelected.NFE_EMITENTE[0].CEP = Empresa.EnderecoPrincipal.Cep;
                        NFeSelected.NFE_EMITENTE[0].CRT = Empresa.Crt;
                        NFeSelected.NFE_EMITENTE[0].CODIGO_PAIS = 1058;
                        NFeSelected.NFE_EMITENTE[0].NOME_PAIS = "Brasil";
                        NFeSelected.NFE_EMITENTE[0].TELEFONE = Empresa.EnderecoPrincipal.Fone;
                        NFeSelected.NFE_EMITENTE[0].INSCRICAO_ESTADUAL = Empresa.InscricaoEstadual;
                        NFeSelected.NFE_EMITENTE[0].INSCRICAO_ESTADUAL_ST = Empresa.InscricaoEstadualSt;
                        NFeSelected.NFE_EMITENTE[0].INSCRICAO_MUNICIPAL = Empresa.InscricaoMunicipal;
                    }
                    */
                    serv.SalvarAtualizarNfeCabecalho(NFeSelected);
                    //NFeSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarListaNFe(int pagina)
        {
            try
            {
                using (ServidorClient Servico = new ServidorClient())
                {
                    if (pagina == 0)
                        IndiceNavegacao = 0;
                    else if (pagina > 0 && ListaNFe.Count == QuantidadePagina)
                        IndiceNavegacao += QuantidadePagina;
                    else if (pagina < 0 && IndiceNavegacao != 0)
                        IndiceNavegacao -= QuantidadePagina;

                    NFE_CABECALHO NFe = new NFE_CABECALHO();

                    IList<NFE_CABECALHO> ListaServ = Servico.SelectNfeCabecalhoPagina(IndiceNavegacao, QuantidadePagina, NFe);

                    ListaNFe.Clear();

                    foreach (NFE_CABECALHO objAdd in ListaServ)
                    {
                        ListaNFe.Add(objAdd);
                    }
                    NFeSelected = null;
                }
                QuantidadeCarregada = ListaNFe.Count;
                ControlarNavegacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirNFe()
        {
            try
            {
                using (ServidorClient Servico = new ServidorClient())
                {
                    Servico.DeleteNfeCabecalho(NFeSelected);
                    NFeSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Controle de Ativação dos Botões
        public override void BotaoInserir()
        {
            try
            {
                NFeSelected = new NFE_CABECALHO();
                CarregarTabDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoAlterar()
        {
            try
            {
                if (NFeSelected != null)
                    CarregarTabDados();
                else
                    MessageBox.Show("Selecione um elemento na lista.", "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoExcluir()
        {
            try
            {
                if (NFeSelected != null)
                {
                    if (MessageBox.Show("Tem Certeza Que Deseja Excluir o Registro?", "Pergunta do Sistema", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ExcluirNFe();
                        MessageBox.Show("Exclusão efetuada com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                        AtualizarListaNFe(IndiceNavegacao);
                    }
                }
                else
                    MessageBox.Show("Selecione um elemento na lista.", "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoCancelar()
        {
            try
            {
                CarregarTabLista();
                BotaoLocalizar();
                NFeSelected = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoSalvar()
        {
            try
            {
                SalvarAtualizarNFe();
                MessageBox.Show("Salvo com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                AtualizarListaNFe(IndiceNavegacao);
                CarregarTabLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoLocalizar()
        {
            try
            {
                AtualizarListaNFe(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoExportar()
        {
            DataGridExportacao.ItemsSource = ListaNFe;
        }

        public override void BotaoPaginaSeguinte()
        {
            AtualizarListaNFe(1);
        }

        public override void BotaoPaginaAnterior()
        {
            AtualizarListaNFe(-1);
        }
        #endregion

        #region Pesquisas
        public void PesquisarProduto()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(ProdutoDTO), typeof(NFe.Model.ServicoNFe));
                searchWindow.definirColunas(new string[] { "Gtin", "Nome", "ValorVenda" });
                if (searchWindow.ShowDialog() == true)
                {
                    ProdutoSelected = (ProdutoDTO)searchWindow.itemSelecionado;
                    DetalheNFe = new NFE_DETALHE();
                    notifyPropertyChanged("ProdutoSelected");
                    notifyPropertyChanged("DetalheNFe");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PesquisarOperacaoFiscal()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(TributOperacaoFiscalDTO), typeof(NFe.Model.ServicoNFe));
                searchWindow.definirColunas(new string[] { "Id", "Descricao", "DescricaoNaNf" });
                if (searchWindow.ShowDialog() == true)
                {
                    TributOperacaoFiscalDTO op = new TributOperacaoFiscalDTO();
                    op = (TributOperacaoFiscalDTO)searchWindow.itemSelecionado;
                    NFeSelected.TRIBUT_OPERACAO_FISCAL = new TRIBUT_OPERACAO_FISCAL();
                    NFeSelected.TRIBUT_OPERACAO_FISCAL.CFOP = op.Cfop;
                    NFeSelected.TRIBUT_OPERACAO_FISCAL.DESCRICAO = op.Descricao;
                    NFeSelected.TRIBUT_OPERACAO_FISCAL.DESCRICAO_NA_NF = op.DescricaoNaNf;
                    NFeSelected.TRIBUT_OPERACAO_FISCAL.ID = op.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Exclusões Internas
        public void ExcluirCupomVinculado(int index)
        {
            /*
             * EXERCÍCIO: Analise e corrija o que for necessário.
            try
            {
                if (NFeSelected.ListaNfeCupomFiscalReferenciado.Count > index)
                    NFeSelected.ListaNfeCupomFiscalReferenciado.RemoveAt(index);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            */
        }

        public void ExcluirDuplicata(int index)
        {
            /*
             * EXERCÍCIO: Analise e corrija o que for necessário.
            try
            {
                if (NFeSelected.ListaNfeDuplicata.Count > index)
                    NFeSelected.ListaNfeDuplicata.RemoveAt(index);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            */
        }

        public void ExcluirProduto(int index)
        {
            /*
             * EXERCÍCIO: Analise e corrija o que for necessário.
            try
            {
                if (NFeSelected.NFE_DETALHE.Count > index)
                {
                    NFeSelected.NFE_DETALHE.RemoveAt(index);
                    AtualizarNumeroItemDetalhe();
                    AtualizarValoresNFe();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            */
        }
        #endregion

        #region Inclusões Internas
        public void IncluirCupomVinculado(NFE_CUPOM_FISCAL_REFERENCIADO cupomVinculado)
        {
            try
            {
                /*
                 * EXERCÍCIO: Analise e corrija o que for necessário.
                    if (NFeSelected.ListaNfeCupomFiscalReferenciado == null)
                        NFeSelected.ListaNfeCupomFiscalReferenciado = new List<NfeCupomFiscalReferenciadoDTO>();
*/
                    NFeSelected.NFE_CUPOM_FISCAL_REFERENCIADO.Add(cupomVinculado);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void IncluirDuplicata(NFE_DUPLICATA duplicata)
            {
                try
                {
                /*
               * EXERCÍCIO: Analise e corrija o que for necessário.
                    if (NFeSelected.ListaNfeDuplicata == null)
                          NFeSelected.ListaNfeDuplicata = new List<NfeDuplicataDTO>();
*/
                      NFeSelected.NFE_DUPLICATA.Add(duplicata);
                  }
                  catch (Exception ex)
                  {
                      throw ex;
                  }
              }

              public void IncluirProduto(decimal quantidade)
              {
                  // Exercício: Implemente os cálculos de imposto

                  try
                  {
                      if (ProdutoSelected == null)
                          throw new Exception("Selecione o produto.");

                /*
               * EXERCÍCIO: Analise e corrija o que for necessário.
                      if (NFeSelected.NFE_DETALHE == null)
                          NFeSelected.NFE_DETALHE = new List<NFE_DETALHE>();
*/
                      DetalheNFe.ID_PRODUTO = ProdutoSelected.Id;
                      DetalheNFe.CODIGO_PRODUTO = ProdutoSelected.Gtin;
                      DetalheNFe.GTIN = ProdutoSelected.Gtin;
                      DetalheNFe.VALOR_BRUTO_PRODUTO = quantidade * ProdutoSelected.ValorVenda;
                      DetalheNFe.GTIN_UNIDADE_TRIBUTAVEL = ProdutoSelected.Gtin;
                      DetalheNFe.QUANTIDADE_TRIBUTAVEL = quantidade;
                      DetalheNFe.VALOR_UNITARIO_TRIBUTAVEL = ProdutoSelected.ValorVenda;
                      DetalheNFe.NOME_PRODUTO = ProdutoSelected.Nome;
                      DetalheNFe.QUANTIDADE_COMERCIAL = quantidade;
                      DetalheNFe.VALOR_UNITARIO_COMERCIAL = ProdutoSelected.ValorVenda;
                      DetalheNFe.VALOR_SUBTOTAL = quantidade * ProdutoSelected.ValorVenda;
                      DetalheNFe.VALOR_TOTAL = quantidade * ProdutoSelected.ValorVenda;
                      DetalheNFe.NCM = ProdutoSelected.Ncm;
                      DetalheNFe.UNIDADE_COMERCIAL = ProdutoSelected.UnidadeProduto.Sigla;
                      DetalheNFe.UNIDADE_TRIBUTAVEL = ProdutoSelected.UnidadeProduto.Sigla;

                      // ICMS
                      ViewTributacaoIcmsDTO viewIcms = new ViewTributacaoIcmsDTO();
                      using (ServidorClient serv = new ServidorClient())
                      {
                          viewIcms.IdTributOperacaoFiscal = NFeSelected.TRIBUT_OPERACAO_FISCAL.ID;
                          viewIcms.IdTributGrupoTributario = ProdutoSelected.TributGrupoTributario.Id;
                          viewIcms.UfDestino = NFeSelected.NFE_DESTINATARIO[0].UF;
                          viewIcms = serv.SelectViewTributacaoIcms(viewIcms);

                          if (viewIcms == null)
                              throw new Exception("Não existe tributação definida para o para o produto selecionado.");
                      }
                      DetalheNFe.CFOP = viewIcms.Cfop;
                /*
               * EXERCÍCIO: Analise e corrija o que for necessário.
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0] = new NfeDetalheImpostoIcmsDTO();
                      */
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].ORIGEM_MERCADORIA = int.Parse(viewIcms.OrigemMercadoria);
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].CST_ICMS = viewIcms.CstB;
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].CSOSN = viewIcms.CsosnB;
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].MODALIDADE_BC_ICMS = int.Parse(viewIcms.ModalidadeBc);
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].TAXA_REDUCAO_BC_ICMS = viewIcms.PorcentoBc;
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].ALIQUOTA_ICMS = viewIcms.Aliquota;
                      //DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].ModalidadeBcIcmsSt = int.Parse(viewIcms.ModalidadeBcSt);
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].PERCENTUAL_MVA_ICMS_ST = viewIcms.Mva;
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].PERCENTUAL_REDUCAO_BC_ICMS_ST = viewIcms.PorcentoBcSt;
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].ALIQUOTA_ICMS_ST = viewIcms.AliquotaIcmsSt;
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].BASE_CALCULO_ICMS = ProdutoSelected.ValorVenda;
                      DetalheNFe.NFE_DETALHE_IMPOSTO_ICMS[0].VALOR_ICMS = (ProdutoSelected.ValorVenda * viewIcms.Aliquota) / 100;



                      ViewTributacaoPisDTO viewPis = new ViewTributacaoPisDTO();
                      using (ServidorClient serv = new ServidorClient())
                      {
                          viewPis.IdTributOperacaoFiscal = NFeSelected.TRIBUT_OPERACAO_FISCAL.ID;
                          viewPis.IdTributGrupoTributario = ProdutoSelected.TributGrupoTributario.Id;
                          viewPis = serv.SelectViewTributacaoPis(viewPis);

                    /*
                   * EXERCÍCIO: Analise e corrija o que for necessário.
                              DetalheNFe.NfeDetalheImpostoPis = new NfeDetalheImpostoPisDTO();
*/
                              DetalheNFe.NFE_DETALHE_IMPOSTO_PIS[0].CST_PIS = viewPis.CstPis;
                              DetalheNFe.NFE_DETALHE_IMPOSTO_PIS[0].ALIQUOTA_PIS_PERCENTUAL = viewPis.AliquotaPorcento;
                              DetalheNFe.NFE_DETALHE_IMPOSTO_PIS[0].ALIQUOTA_PIS_REAIS = viewPis.AliquotaUnidade;
                              DetalheNFe.NFE_DETALHE_IMPOSTO_PIS[0].VALOR_BASE_CALCULO_PIS = ProdutoSelected.ValorVenda;
                              DetalheNFe.NFE_DETALHE_IMPOSTO_PIS[0].VALOR_PIS = (ProdutoSelected.ValorVenda * viewPis.AliquotaPorcento) / 100; ;
                          }

                          ViewTributacaoCofinsDTO viewCofins = new ViewTributacaoCofinsDTO();
                          using (ServidorClient serv = new ServidorClient())
                          {
                              viewCofins.IdTributOperacaoFiscal = NFeSelected.TRIBUT_OPERACAO_FISCAL.ID;
                              viewCofins.IdTributGrupoTributario = ProdutoSelected.TributGrupoTributario.Id;
                              viewCofins = serv.SelectViewTributacaoCofins(viewCofins);

                    /*
                   * EXERCÍCIO: Analise e corrija o que for necessário.
                                  DetalheNFe.NfeDetalheImpostoCofins = new NfeDetalheImpostoCofinsDTO();
*/
                                  DetalheNFe.NFE_DETALHE_IMPOSTO_COFINS[0].CST_COFINS = viewCofins.CstCofins;
                                  DetalheNFe.NFE_DETALHE_IMPOSTO_COFINS[0].ALIQUOTA_COFINS_PERCENTUAL = viewCofins.AliquotaPorcento;
                                  DetalheNFe.NFE_DETALHE_IMPOSTO_COFINS[0].ALIQUOTA_COFINS_REAIS = viewCofins.AliquotaUnidade;
                                  DetalheNFe.NFE_DETALHE_IMPOSTO_COFINS[0].BASE_CALCULO_COFINS = ProdutoSelected.ValorVenda;
                                  DetalheNFe.NFE_DETALHE_IMPOSTO_COFINS[0].VALOR_COFINS = (ProdutoSelected.ValorVenda * viewCofins.AliquotaPorcento) / 100; ;
                              }

                              NFeSelected.NFE_DETALHE.Add(DetalheNFe);

                              AtualizarNumeroItemDetalhe();
                              AtualizarValoresNFe();

                              ProdutoSelected = null;
                              DetalheNFe = null;

                              notifyPropertyChanged("ProdutoSelected");
                              notifyPropertyChanged("DetalheNFe");
                          }
                          catch (Exception ex)
                          {
                              throw ex;
                          }

                      }
                      #endregion

                      #region Demais procedimentos para a NF-e
                      public void ConfiguraNfe()
                      {
                          // Exercício: carregue as configurações a partir do banco de dados
                          var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                          try
                          {
                              _configuracoes = !File.Exists(path + ArquivoConfiguracao) ? new ConfiguracaoApp() : FuncoesXml.ArquivoXmlParaClasse<ConfiguracaoApp>(path + ArquivoConfiguracao);
                              if (_configuracoes.CfgServico.TimeOut == 0)
                                  _configuracoes.CfgServico.TimeOut = 100;//mínimo
                          }
                          catch (Exception ex)
                          {
                              if (!String.IsNullOrEmpty(ex.Message))
                                  MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                          }
                      }

                      public void ConsultarStatusServico()
                      {
                          var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
                          var retornoStatus = servicoNFe.NfeStatusServico();

                          string mensagem = "";

                          foreach (var atributos in Funcoes.LerPropriedades(retornoStatus.Retorno))
                          {
                              mensagem += atributos.Key + " = " + atributos.Value + "\r";
                          }
                          MessageBox.Show(mensagem, "Informação do Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                      }


                      /// EXERCICIO: selecione um local apropriado para inutilizar notas.
                      public void Inutilizar()
                      {
                          var ano = Funcoes.InpuBox(null, "Inutilizar Numeração", "Ano");
                          if (string.IsNullOrEmpty(ano)) throw new Exception("O Ano deve ser informado!");
                          if (ano.Length > 2) throw new Exception("O Ano deve ter dois números apenas!");

                          var modelostr = Funcoes.InpuBox(null, "Inutilizar Numeração", "Modelo");
                          if (string.IsNullOrEmpty(modelostr)) throw new Exception("O Modelo deve ser informado!");

                          var modelo = (ModeloDocumento)Convert.ToInt16(modelostr);

                          var serie = Funcoes.InpuBox(null, "Inutilizar Numeração", "Série");
                          if (string.IsNullOrEmpty(serie)) throw new Exception("A série deve ser informada!");

                          var numeroInicial = Funcoes.InpuBox(null, "Inutilizar Numeração", "Número Inicial");
                          if (string.IsNullOrEmpty(numeroInicial)) throw new Exception("O Número Inicial deve ser informado!");

                          var numeroFinal = Funcoes.InpuBox(null, "Inutilizar Numeração", "Número Final");
                          if (string.IsNullOrEmpty(numeroFinal)) throw new Exception("O Número Final deve ser informado!");

                          var justificativa = Funcoes.InpuBox(null, "Inutilizar Numeração", "Justificativa");
                          if (string.IsNullOrEmpty(justificativa)) throw new Exception("A Justificativa deve ser informada!");

                          var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
                          var retornoConsulta = servicoNFe.NfeInutilizacao(_configuracoes.Emitente.CNPJ, Convert.ToInt16(ano),
                              modelo, Convert.ToInt16(serie), Convert.ToInt16(numeroInicial),
                              Convert.ToInt16(numeroFinal), justificativa);

                          string mensagem = "";

                          foreach (var atributos in Funcoes.LerPropriedades(retornoConsulta.Retorno))
                          {
                              mensagem += atributos.Key + " = " + atributos.Value + "\r";
                          }
                          MessageBox.Show(mensagem, "Informação do Sistema", MessageBoxButton.OK, MessageBoxImage.Information);

                      }

                      // EXERCICIO: Faça as devidas adaptações na CC-e de acordo com sua necessidade
                      public void CCe()
                      {
                          var idlote = Funcoes.InpuBox(null, "Carta de correção", "Identificador de controle do Lote de envio:");
                          if (string.IsNullOrEmpty(idlote)) throw new Exception("A Id do Lote deve ser informada!");

                          var sequenciaEvento = Funcoes.InpuBox(null, "Carta de correção", "Número sequencial do evento:");
                          if (string.IsNullOrEmpty(sequenciaEvento))
                              throw new Exception("O número sequencial deve ser informado!");

                          var chave = Funcoes.InpuBox(null, "Carta de correção", "Chave da NFe:");
                          if (string.IsNullOrEmpty(chave)) throw new Exception("A Chave deve ser informada!");
                          if (chave.Length != 44) throw new Exception("Chave deve conter 44 caracteres!");

                          var correcao = Funcoes.InpuBox(null, "Carta de correção", "Correção");
                          if (string.IsNullOrEmpty(correcao)) throw new Exception("A Correção deve ser informada!");

                          var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
                          var cpfcnpj = string.IsNullOrEmpty(_configuracoes.Emitente.CNPJ)
                              ? _configuracoes.Emitente.CPF
                              : _configuracoes.Emitente.CNPJ;
                          var retornoCartaCorrecao = servicoNFe.RecepcaoEventoCartaCorrecao(Convert.ToInt16(idlote),
                              Convert.ToInt16(sequenciaEvento), chave, correcao, cpfcnpj);

                          string mensagem = "";

                          foreach (var atributos in Funcoes.LerPropriedades(retornoCartaCorrecao.Retorno))
                          {
                              mensagem += atributos.Key + " = " + atributos.Value + "\r";
                          }
                          MessageBox.Show(mensagem, "Informação do Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                      }

                      public void GerarXmlNfe()
                      {
                          // EXERCICIO: trate os retornos da Sefaz e armazene o status da nota de acordo
                          NFeSelected.STATUS_NOTA = 4;
                          SalvarAtualizarNFe();

                          infNFe InfNFe = new infNFe();
                          InfNFe.versao = _configuracoes.CfgServico.VersaoNFeAutorizacao.VersaoServicoParaString();//Auxiliar.VersaoServicoParaString(_configuracoes.CfgServico.VersaoNFeAutorizacao),
                          InfNFe.ide = GetIdentificacao();
                          InfNFe.emit = GetEmitente();
                          InfNFe.transp = GetTransporte();

                          if (NFeSelected.NFE_DESTINATARIO[0].CPF_CNPJ != null)
                              InfNFe.dest = GetDestinatario();

                          for (var i = 0; i < 1; i++)
                          {
                              InfNFe.det.Add(GetDetalhe(i, InfNFe.emit.CRT));
                          }

                          InfNFe.total = GetTotal();

                          _nfe = new NFe.Classes.NFe();
                          _nfe.infNFe = InfNFe;

                          _nfe.Assina();
                          string nomeArquivoXml = @"C:\T2Ti\NFe\XML\" + NFeSelected.CHAVE_ACESSO + NFeSelected.DIGITO_CHAVE_ACESSO + ".xml";
                          _nfe.SalvarArquivoXml(nomeArquivoXml);
                          var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
                          var retornoEnvio = servicoNFe.NFeAutorizacao(1, IndicadorSincronizacao.Assincrono, new List<NFe.Classes.NFe> { _nfe });

                          // consultar protocolo
                          var retornoConsulta = servicoNFe.NfeConsultaProtocolo(NFeSelected.CHAVE_ACESSO + NFeSelected.DIGITO_CHAVE_ACESSO);

                          _protocolo = "123";// retornoConsulta.Retorno.protNFe.infProt.nProt; 

                          string mensagem = "";

                          foreach (var atributos in Funcoes.LerPropriedades(retornoEnvio.Retorno))
                          {
                              mensagem += atributos.Key + " = " + atributos.Value + "\r";
                          }
                          MessageBox.Show(mensagem, "Informação do Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                      }

                      protected ide GetIdentificacao()
                      {
                          var ide = new ide();

                          ide.cUF = Estado.DF;
                          ide.natOp = "VENDA";
                          ide.indPag = IndicadorPagamento.ipVista;
                          ide.mod = ModeloDocumento.NFe;
                          ide.serie = 1;
                          ide.nNF = int.Parse(NFeSelected.NUMERO);
                          ide.tpNF = TipoNFe.tnSaida;
                          ide.cMunFG = 5300108;
                          ide.tpEmis = _configuracoes.CfgServico.tpEmis;
                          ide.tpImp = TipoImpressao.tiRetrato;
                          ide.cNF = NFeSelected.CODIGO_NUMERICO;
                          ide.tpAmb = _configuracoes.CfgServico.tpAmb;
                          ide.finNFe = FinalidadeNFe.fnNormal;
                          ide.verProc = "3.000";

                          /// EXERCICIO: implemente a contingência de acordo com sua necessidade
                          if (ide.tpEmis != TipoEmissao.teNormal)
                          {
                              ide.dhCont = DateTime.Now;//DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
                              ide.xJust = "TESTE DE CONTIGÊNCIA PARA NFe/NFCe";
                          }

                          ide.idDest = DestinoOperacao.doInterna;
                          ide.dhEmi = DateTime.Now; //DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"); 
                          ide.procEmi = ProcessoEmissao.peAplicativoContribuinte;
                          ide.indFinal = ConsumidorFinal.cfConsumidorFinal;
                          ide.indPres = PresencaComprador.pcPresencial;

                          return ide;
                      }

                      protected emit GetEmitente()
                      {
                          var emit = _configuracoes.Emitente;
                          emit.enderEmit = GetEnderecoEmitente();
                          return emit;
                      }

                      protected enderEmit GetEnderecoEmitente()
                      {
                          var enderEmit = _configuracoes.EnderecoEmitente;
                          enderEmit.cPais = 1058;
                          enderEmit.xPais = "BRASIL";
                          return enderEmit;
                      }

                      protected dest GetDestinatario()
                      {
                          dest dest = new dest(_configuracoes.CfgServico.VersaoNFeAutorizacao);
                          dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"; //NFeSelected.NFE_DESTINATARIO[0].Nome
                          dest.indIEDest = indIEDest.NaoContribuinte;
                          dest.email = NFeSelected.NFE_DESTINATARIO[0].EMAIL;
                          dest.CPF = NFeSelected.NFE_DESTINATARIO[0].CPF_CNPJ;
                          dest.enderDest = GetEnderecoDestinatario();

                          return dest;
                      }

                      protected enderDest GetEnderecoDestinatario()
                      {
                          var enderDest = new enderDest
                          {
                              xLgr = "RUA ...",
                              nro = "S/N",
                              xBairro = "CENTRO",
                              cMun = 5300108,
                              xMun = "brasilia",
                              UF = "DF",
                              CEP = "71925000",
                              cPais = 1058,
                              xPais = "BRASIL"
                          };
                          /*
                          var enderDest = new enderDest
                          {
                              xLgr = NFeSelected.NFE_DESTINATARIO[0].Logradouro,
                              nro = NFeSelected.NFE_DESTINATARIO[0].Numero,
                              xBairro = NFeSelected.NFE_DESTINATARIO[0].Bairro,
                              cMun = NFeSelected.NFE_DESTINATARIO[0].CodigoMunicipio.Value,
                              xMun = NFeSelected.NFE_DESTINATARIO[0].NomeMunicipio,
                              UF = NFeSelected.NFE_DESTINATARIO[0].Uf,
                              CEP = NFeSelected.NFE_DESTINATARIO[0].Cep,
                              cPais = 1058,
                              xPais = "BRASIL"
                          };
                           */
                    return enderDest;
        }

        protected det GetDetalhe(int i, CRT crt)
        {
            var det = new det
            {
                nItem = NFeSelected.NFE_DETALHE[i].NUMERO_ITEM.Value,
                prod = GetProduto(i),
                imposto = new imposto
                {
                    vTotTrib = decimal.Parse(NFeSelected.NFE_DETALHE[i].NFE_DETALHE_IMPOSTO_ICMS[0].VALOR_ICMS.Value.ToString("N2")),
                    ICMS = new ICMS
                    {
                        TipoICMS = crt == CRT.SimplesNacional ? InformarCSOSN(Csosnicms.Csosn102) : InformarICMS(Csticms.Cst00, i)
                    },
                    COFINS = new COFINS { TipoCOFINS = new COFINSOutr { CST = CSTCOFINS.cofins99, pCOFINS = 0, vBC = 0, vCOFINS = 0 } },
                    PIS = new PIS { TipoPIS = new PISOutr { CST = CSTPIS.pis99, pPIS = 0, vBC = 0, vPIS = 0 } }
                }
            };

            return det;
        }

        protected prod GetProduto(int i)
        {
            var p = new prod
            {
                cProd = NFeSelected.NFE_DETALHE[i].GTIN,
                cEAN = NFeSelected.NFE_DETALHE[i].GTIN,
                xProd = NFeSelected.NFE_DETALHE[i].NOME_PRODUTO,
                NCM = NFeSelected.NFE_DETALHE[i].NCM,
                CFOP = NFeSelected.NFE_DETALHE[i].CFOP.Value,
                uCom = NFeSelected.NFE_DETALHE[i].UNIDADE_COMERCIAL,
                qCom = NFeSelected.NFE_DETALHE[i].QUANTIDADE_COMERCIAL.Value,
                vUnCom = decimal.Parse(NFeSelected.NFE_DETALHE[i].VALOR_UNITARIO_COMERCIAL.Value.ToString("N2")),
                vProd = decimal.Parse(NFeSelected.NFE_DETALHE[i].VALOR_TOTAL.Value.ToString("N2")),
                //vDesc = NFeSelected.NFE_DETALHE[i].ValorDesconto.Value,
                cEANTrib = NFeSelected.NFE_DETALHE[i].GTIN,
                uTrib = NFeSelected.NFE_DETALHE[i].UNIDADE_TRIBUTAVEL,
                qTrib = NFeSelected.NFE_DETALHE[i].QUANTIDADE_TRIBUTAVEL.Value,
                vUnTrib = decimal.Parse(NFeSelected.NFE_DETALHE[i].VALOR_UNITARIO_TRIBUTAVEL.Value.ToString("N2")),
                indTot = IndicadorTotal.ValorDoItemCompoeTotalNF,
            };
            return p;
        }

        protected ICMSBasico InformarICMS(Csticms CST, int i)
        {
            switch (CST)
            {
                case Csticms.Cst00:
                    return new ICMS00
                    {
                        CST = Csticms.Cst00,
                        modBC = DeterminacaoBaseIcms.DbiValorOperacao,
                        orig = OrigemMercadoria.OmNacional,
                        pICMS = decimal.Parse(NFeSelected.NFE_DETALHE[i].NFE_DETALHE_IMPOSTO_ICMS[0].ALIQUOTA_ICMS.Value.ToString("N2")),
                        vBC = decimal.Parse(NFeSelected.NFE_DETALHE[i].NFE_DETALHE_IMPOSTO_ICMS[0].BASE_CALCULO_ICMS.Value.ToString("N2")),
                        vICMS = decimal.Parse(NFeSelected.NFE_DETALHE[i].NFE_DETALHE_IMPOSTO_ICMS[0].VALOR_ICMS.Value.ToString("N2")),
                    };
                //Outros casos aqui
            }

            return new ICMS10();
        }

        protected ICMSBasico InformarCSOSN(Csosnicms CST)
        {
            switch (CST)
            {
                case Csosnicms.Csosn101:
                    return new ICMSSN101
                    {
                        CSOSN = Csosnicms.Csosn101,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn102:
                    return new ICMSSN102
                    {
                        CSOSN = Csosnicms.Csosn102,
                        orig = OrigemMercadoria.OmNacional
                    };
                //Outros casos aqui
                default:
                    return new ICMSSN201();
            }
        }

        protected total GetTotal()
        {
            var icmsTot = new ICMSTot
            {
                vProd = decimal.Parse(NFeSelected.VALOR_TOTAL_PRODUTOS.Value.ToString("N2")),
                vNF = decimal.Parse(NFeSelected.VALOR_TOTAL.Value.ToString("N2")),
                vDesc = decimal.Parse(NFeSelected.VALOR_DESCONTO.Value.ToString("N2")),
                vTotTrib = decimal.Parse(NFeSelected.VALOR_ICMS.Value.ToString("N2")),
                vBC = decimal.Parse(NFeSelected.BASE_CALCULO_ICMS.Value.ToString("N2")),
                vICMS = decimal.Parse(NFeSelected.VALOR_ICMS.Value.ToString("N2")),
                vICMSDeson = 0
            };

            var t = new total { ICMSTot = icmsTot };
            return t;
        }

        protected transp GetTransporte()
        {
            var t = new transp
            {
                modFrete = ModalidadeFrete.mfSemFrete
            };

            return t;
        }

        // Exercício: Implemente os demais métodos para emissão da NF-e

        public void ImprimirDANFE()
        {
            // EXERCICIO: Solicite a justificativa para o usuário
            string Justificativa = "Alguma justificativa";

            // EXERCICIO: Faça com que a justificativa apareça no DANFE reimpresso.
            // EXERCICIO: Implemente um relatório com as estatísticas de reimpressões na sua suite preferida
            // EXERCICIO: Verifique se existem problemas no procedimento a seguir e corrija-os
            NFeSelected.QUANTIDADE_IMPRESSAO_DANFE = NFeSelected.QUANTIDADE_IMPRESSAO_DANFE + 1;
            NFeSelected.INFORMACOES_ADD_CONTRIBUINTE = "DANFE impresso pela " + NFeSelected.QUANTIDADE_IMPRESSAO_DANFE.ToString() + "ª vez. Justificativa: " + Justificativa + ".";
            SalvarAtualizarNFe();

            //Imprime usando Unidanfe
            try
            {
                string nomeArquivoXml = @"C:\T2Ti\NFe\XML\" + NFeSelected.CHAVE_ACESSO + NFeSelected.DIGITO_CHAVE_ACESSO + ".xml";
                Process unidanfe = new Process();
                unidanfe.StartInfo.FileName = @"C:\Unimake\UniNFe\unidanfe.exe";
                unidanfe.StartInfo.Arguments = " arquivo=" + nomeArquivoXml;
                unidanfe.Start();
                unidanfe.WaitForExit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion



    }
}
