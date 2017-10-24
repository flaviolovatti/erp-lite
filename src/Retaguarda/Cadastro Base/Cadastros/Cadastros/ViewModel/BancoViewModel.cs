using Cadastros.Command;
using Cadastros.Model;
using Cadastros.ServidorReference;
using SearchWindow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Cadastros.ViewModel
{
    public class BancoViewModel : ViewModelBase
    {

        #region Variáveis
        public ObservableCollection<Banco> ListaBanco { get; set; }
        private Banco _BancoSelected;
        #endregion

        #region Construtor
        public BancoViewModel()
        {
            try
            {
                ListaBanco = new ObservableCollection<Banco>();
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
        public Banco BancoSelected
        {
            get { return _BancoSelected; }
            set
            {
                _BancoSelected = value;
                notifyPropertyChanged("BancoSelected");
            }
        }
        #endregion

        #region CRUD
        public void SalvarAtualizarBanco()
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    Servico.SalvarAtualizarBanco(BancoSelected);
                    BancoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarListaBanco(int pagina)
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    if (pagina == 0)
                        IndiceNavegacao = 0;
                    else if (pagina > 0 && ListaBanco.Count == QuantidadePagina)
                        IndiceNavegacao += QuantidadePagina;
                    else if (pagina < 0 && IndiceNavegacao != 0)
                        IndiceNavegacao -= QuantidadePagina;

                    Banco Banco = new Banco();
                    if (!Filtro.Trim().Equals(""))
                    {
                        Banco.nome = Filtro;
                    }

                    IList<Banco> ListaServ = Servico.SelectBancoPagina(IndiceNavegacao, true, QuantidadePagina, true, Banco);

                    ListaBanco.Clear();

                    foreach (Banco objAdd in ListaServ)
                    {
                        ListaBanco.Add(objAdd);
                    }
                    BancoSelected = null;
                }
                QuantidadeCarregada = ListaBanco.Count;
                ControlarNavegacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirBanco()
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    Servico.DeleteBanco(BancoSelected);
                    BancoSelected = null;
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
                BancoSelected = new Banco();
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
                if (BancoSelected != null)
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
                if (BancoSelected != null)
                {
                    if (MessageBox.Show("Tem Certeza Que Deseja Excluir o Registro?", "Pergunta do Sistema", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ExcluirBanco();
                        MessageBox.Show("Exclusão efetuada com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                        AtualizarListaBanco(IndiceNavegacao);
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
                BancoSelected = null;
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
                SalvarAtualizarBanco();
                MessageBox.Show("Salvo com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                AtualizarListaBanco(IndiceNavegacao);
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
                AtualizarListaBanco(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoExportar()
        {
            DataGridExportacao.ItemsSource = ListaBanco;
        }

        public override void BotaoPaginaSeguinte()
        {
            AtualizarListaBanco(1);
        }

        public override void BotaoPaginaAnterior()
        {
            AtualizarListaBanco(-1);
        }
        #endregion


    }
}
