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
    public class CargoViewModel : ViewModelBase
    {

        #region Variáveis
        public ObservableCollection<Cargo> ListaCargo { get; set; }
        private Cargo _CargoSelected;
        #endregion

        #region Construtor
        public CargoViewModel()
        {
            try
            {
                ListaCargo = new ObservableCollection<Cargo>();
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
        public Cargo CargoSelected
        {
            get { return _CargoSelected; }
            set
            {
                _CargoSelected = value;
                notifyPropertyChanged("CargoSelected");
            }
        }
        #endregion

        #region CRUD
        public void SalvarAtualizarCargo()
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    Servico.SalvarAtualizarCargo(CargoSelected);
                    CargoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarListaCargo(int pagina)
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    if (pagina == 0)
                        IndiceNavegacao = 0;
                    else if (pagina > 0 && ListaCargo.Count == QuantidadePagina)
                        IndiceNavegacao += QuantidadePagina;
                    else if (pagina < 0 && IndiceNavegacao != 0)
                        IndiceNavegacao -= QuantidadePagina;

                    Cargo Cargo = new Cargo();
                    if (!Filtro.Trim().Equals(""))
                    {
                        Cargo.nome = Filtro;
                    }

                    IList<Cargo> ListaServ = Servico.SelectCargoPagina(IndiceNavegacao, true, QuantidadePagina, true, Cargo);

                    ListaCargo.Clear();

                    foreach (Cargo objAdd in ListaServ)
                    {
                        ListaCargo.Add(objAdd);
                    }
                    CargoSelected = null;
                }
                QuantidadeCarregada = ListaCargo.Count;
                ControlarNavegacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirCargo()
        {
            try
            {
                using (ServiceServidor Servico = new ServiceServidor())
                {
                    Servico.DeleteCargo(CargoSelected);
                    CargoSelected = null;
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
                CargoSelected = new Cargo();
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
                if (CargoSelected != null)
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
                if (CargoSelected != null)
                {
                    if (MessageBox.Show("Tem Certeza Que Deseja Excluir o Registro?", "Pergunta do Sistema", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ExcluirCargo();
                        MessageBox.Show("Exclusão efetuada com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                        AtualizarListaCargo(IndiceNavegacao);
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
                CargoSelected = null;
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
                SalvarAtualizarCargo();
                MessageBox.Show("Salvo com sucesso!", "Informação do sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                AtualizarListaCargo(IndiceNavegacao);
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
                AtualizarListaCargo(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public override void BotaoExportar()
        {
            DataGridExportacao.ItemsSource = ListaCargo;
        }

        public override void BotaoPaginaSeguinte()
        {
            AtualizarListaCargo(1);
        }

        public override void BotaoPaginaAnterior()
        {
            AtualizarListaCargo(-1);
        }
        #endregion

        #region Pesquisas
        /*
        public void PesquisarCbo()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(CboDTO),
                    typeof(ServicoCadastros));

                if (searchWindow.ShowDialog() == true)
                {
                    CargoSelected.Cbo2002 = ((CboDTO)searchWindow.itemSelecionado).Codigo;
                    CargoSelected.Cbo1994 = ((CboDTO)searchWindow.itemSelecionado).Codigo1994;
                    notifyPropertyChanged("CargoSelected");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
        #endregion       

    }
}
