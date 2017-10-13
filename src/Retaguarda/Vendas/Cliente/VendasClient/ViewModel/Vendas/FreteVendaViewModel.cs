using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using VendasClient.VendasReference;
using VendasClient.Command;
using SearchWindow;
using VendasClient.Model;

namespace VendasClient.ViewModel.Vendas
{
	/// 
	/// The MIT License
	///
	/// Copyright: Copyright (C) 2010 T2Ti.COM
	///
	/// Permission is hereby granted, free of charge, to any person
	/// obtaining a copy of this software and associated documentation
	/// files (the "Software"), to deal in the Software without
	/// restriction, including without limitation the rights to use,
	/// copy, modify, merge, publish, distribute, sublicense, and/or sell
	/// copies of the Software, and to permit persons to whom the
	/// Software is furnished to do so, subject to the following
	/// conditions:
	///
	/// The above copyright notice and this permission notice shall be
	/// included in all copies or substantial portions of the Software.
	///
	/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
	/// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
	/// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
	/// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
	/// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
	/// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
	/// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
	/// OTHER DEALINGS IN THE SOFTWARE.
	///
	///        The author may be contacted at:
	///            t2ti.com@gmail.com
	///
	/// Autor: Miguel Kojiio (t2ti.com@gmail.com)
	/// Version: 1.0
    public class FreteVendaViewModel : ERPViewModelBase
    {
        public ObservableCollection<FreteVendaDTO> ListaFreteVenda { get; set; }
        private FreteVendaDTO _FreteVendaSelected;
        private int primeiroResultado;
        protected ICommand seguinteCommand;
        protected ICommand anteriorCommand;
        private bool _isEditar { get; set; }


        public FreteVendaViewModel()
        {
            try
            {
                ListaFreteVenda = new ObservableCollection<FreteVendaDTO>();
                primeiroResultado = 0;
                this.atualizarListaFreteVenda(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FreteVendaDTO FreteVendaSelected
        {
            get { return _FreteVendaSelected; }
            set
            {
                _FreteVendaSelected = value;
                notifyPropertyChanged("FreteVendaSelected");
            }
        }
        public void pesquisarVendaCabecalho()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(VendaCabecalhoDTO),
                    typeof(ServicoVendas));

                if (searchWindow.ShowDialog() == true)
                {
                    FreteVendaSelected.VendaCabecalho = (VendaCabecalhoDTO)searchWindow.itemSelecionado;
                    notifyPropertyChanged("FreteVendaSelected");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void pesquisarTransportadora()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(TransportadoraDTO),
                    typeof(ServicoVendas));

                if (searchWindow.ShowDialog() == true)
                {
                    FreteVendaSelected.Transportadora = (TransportadoraDTO)searchWindow.itemSelecionado;
                    notifyPropertyChanged("FreteVendaSelected");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ICommand paginaSeguinteCommand
        {
            get
            {
                if (seguinteCommand == null)
                {
                    seguinteCommand = new RelayCommand
                    (
                        param =>
                        {
                            this.atualizarListaFreteVenda(1);
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return seguinteCommand;
            }
        }

        public ICommand paginaAnteriorCommand
        {
            get
            {
                if (anteriorCommand == null)
                {
                    anteriorCommand = new RelayCommand
                    (
                        param =>
                        {
                            this.atualizarListaFreteVenda(-1);
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return anteriorCommand;
            }
        }

        public void salvarAtualizarFreteVenda()
        {
            try
            {
                using (ServicoVendasClient serv = new ServicoVendasClient())
                {
                    serv.salvarAtualizarFreteVenda(FreteVendaSelected);
                    FreteVendaSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void atualizarListaFreteVenda(int pagina)
        {
            try
            {
                using (ServicoVendasClient serv = new ServicoVendasClient())
                {
                    if (pagina == 0)
                        primeiroResultado = 0;
                    else if (pagina > 0)
                        primeiroResultado += QUANTIDADE_PAGINA;
                    else if (pagina < 0)
                        primeiroResultado -= QUANTIDADE_PAGINA;

                    List<FreteVendaDTO> listaServ = serv.selectFreteVendaPagina(primeiroResultado, QUANTIDADE_PAGINA, new FreteVendaDTO());

                    ListaFreteVenda.Clear();

                    foreach (FreteVendaDTO objAdd in listaServ)
                    {
                        ListaFreteVenda.Add(objAdd);
                    }
                    FreteVendaSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void excluirFreteVenda()
        {
            try
            {
                using (ServicoVendasClient serv = new ServicoVendasClient())
                {
                    serv.deleteFreteVenda(FreteVendaSelected);
                    FreteVendaSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsEditar
        {
            get { return _isEditar; }
            set
            {
                _isEditar = value;
                notifyPropertyChanged("IsEditar");
                notifyPropertyChanged("IsListar");
            }
        }

        public bool IsListar
        {
            get { return !_isEditar; }
            set
            {
                _isEditar = !value;
                notifyPropertyChanged("IsEditar");
                notifyPropertyChanged("IsListar");
            }
        }
    }
}
