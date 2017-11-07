using Cadastros.ServidorReference;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Cadastros.ViewModel
{
    public class ClienteViewModel : ViewModelBase
    {

        #region Variáveis
        public ObservableCollection<Cliente> ListaCliente { get; set; }
        private Cliente _ClienteSelected;
        
        #endregion

        #region Construtor
        public ClienteViewModel()
        {
            
            try
            {
                ListaCliente = new ObservableCollection<Cliente>();
                IndiceNavegacao = 0;
                QuantidadeCarregada = 0;
                Filtro = "";
                ControlarNavegacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Infra
        public Cliente ClienteSelected
        {
            get { return _ClienteSelected; }
            set
            {
                _ClienteSelected = value;
                notifyPropertyChanged("ClienteSelected");
            }
        }
        #endregion

        #region CRUD
        public void SalvarAtualizarCliente()
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    ClienteSelected.pessoa.tipo = "F";

                    Servico.SalvarAtualizarCliente(ClienteSelected);
                    ClienteSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarListaCliente(int pagina)
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    if (pagina == 0)
                        IndiceNavegacao = 0;
                    else if (pagina > 0 && ListaCliente.Count == QuantidadePagina)
                        IndiceNavegacao += QuantidadePagina;
                    else if (pagina < 0 && IndiceNavegacao != 0)
                        IndiceNavegacao -= QuantidadePagina;

                    Cliente Cli = new Cliente();
                    Cli.pessoa = new Pessoa();

                    if (!Filtro.Trim().Equals(""))
                    {
                        Cli.pessoa.nome = Filtro;
                    }

                    IList<Cliente> ListaServ = Servico.SelectClientePagina(IndiceNavegacao, true, QuantidadePagina, true, Cli);

                    ListaCliente.Clear();

                    foreach (Cliente objAdd in ListaServ)
                    {
                        ListaCliente.Add(objAdd);
                    }

                    ClienteSelected = null;
                }
                QuantidadeCarregada = ListaCliente.Count;
                ControlarNavegacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirCliente()
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    Servico.DeleteCliente(ClienteSelected);
                    ClienteSelected = null;
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
                ClienteSelected = new Cliente();
                ClienteSelected.pessoa = new Pessoa();
                IsEditar = true;
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
                if (ClienteSelected != null)
                    IsEditar = true;
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
                if (ClienteSelected != null)
                {
                    if (MessageBox.Show("Tem Certeza Que Deseja Excluir o Registro?", "Pergunta do Sistema", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ExcluirCliente();
                        MessageBox.Show("Exclusão efetuada com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                        AtualizarListaCliente(IndiceNavegacao);
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
                BotaoLocalizar();
                IsEditar = false;
                ClienteSelected = null;
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
                SalvarAtualizarCliente();
                MessageBox.Show("Salvo com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                AtualizarListaCliente(IndiceNavegacao);
                IsEditar = false;
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
                AtualizarListaCliente(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoExportar()
        {
            DataGridExportacao.ItemsSource = ListaCliente;
        }

        public override void BotaoPaginaSeguinte()
        {
            AtualizarListaCliente(1);
        }

        public override void BotaoPaginaAnterior()
        {
            AtualizarListaCliente(-1);
        }
        #endregion

    }
}
