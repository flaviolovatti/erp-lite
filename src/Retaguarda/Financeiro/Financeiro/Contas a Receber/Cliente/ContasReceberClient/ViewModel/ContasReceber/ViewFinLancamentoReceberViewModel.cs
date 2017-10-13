using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ContasReceberClient.ContasReceberService;
using ContasReceberClient.Command;
using SearchWindow;
using ContasReceberClient.Model;

namespace ContasReceberClient.ViewModel.ContasReceber
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
	/// Autor: Albert Eije (t2ti.com@gmail.com)
	/// Version: 1.0
    public class ViewFinLancamentoReceberViewModel : ERPViewModelBase
    {
        public ObservableCollection<ViewFinLancamentoReceberDTO> ListaViewFinLancamentoReceber { get; set; }
        private ViewFinLancamentoReceberDTO _ViewFinLancamentoReceberSelected;
        private int primeiroResultado;
        protected ICommand seguinteCommand;
        protected ICommand anteriorCommand;
        private bool _isEditar { get; set; }
        public FinParcelaRecebimentoDTO FinParcelaRecebimentoSelected { get; set; }


        public ViewFinLancamentoReceberViewModel()
        {
            try
            {
                ListaViewFinLancamentoReceber = new ObservableCollection<ViewFinLancamentoReceberDTO>();
                primeiroResultado = 0;
                this.atualizarListaViewFinLancamentoReceber(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ViewFinLancamentoReceberDTO ViewFinLancamentoReceberSelected
        {
            get { return _ViewFinLancamentoReceberSelected; }
            set
            {
                _ViewFinLancamentoReceberSelected = value;
                notifyPropertyChanged("ViewFinLancamentoReceberSelected");
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
                            this.atualizarListaViewFinLancamentoReceber(1);
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
                            this.atualizarListaViewFinLancamentoReceber(-1);
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

        public void salvarAtualizarViewFinLancamentoReceber()
        {
            try
            {
                using (ContasReceberServiceClient serv = new ContasReceberServiceClient())
                {
                    serv.salvarAtualizarViewFinLancamentoReceber(ViewFinLancamentoReceberSelected);
                    ViewFinLancamentoReceberSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void atualizarListaViewFinLancamentoReceber(int pagina)
        {
            try
            {
                using (ContasReceberServiceClient serv = new ContasReceberServiceClient())
                {
                    if (pagina == 0)
                        primeiroResultado = 0;
                    else if (pagina > 0)
                        primeiroResultado += QUANTIDADE_PAGINA;
                    else if (pagina < 0)
                        primeiroResultado -= QUANTIDADE_PAGINA;

                    List<ViewFinLancamentoReceberDTO> listaServ = serv.selectViewFinLancamentoReceberPagina(primeiroResultado, QUANTIDADE_PAGINA, new ViewFinLancamentoReceberDTO());

                    ListaViewFinLancamentoReceber.Clear();

                    foreach (ViewFinLancamentoReceberDTO objAdd in listaServ)
                    {
                        ListaViewFinLancamentoReceber.Add(objAdd);
                    }
                    ViewFinLancamentoReceberSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void pesquisarContaCaixa()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(ContaCaixaDTO),
                    typeof(ServicoContasReceber));

                if (searchWindow.ShowDialog() == true)
                {
                    FinParcelaRecebimentoSelected.ContaCaixa = (ContaCaixaDTO)searchWindow.itemSelecionado;
                    notifyPropertyChanged("FinParcelaRecebimentoSelected");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void pesquisarFinTipoRecebimento()
        {
            try
            {
                SearchWindowApp searchWindow = new SearchWindowApp(typeof(FinTipoRecebimentoDTO),
                    typeof(ServicoContasReceber));

                if (searchWindow.ShowDialog() == true)
                {
                    FinParcelaRecebimentoSelected.FinTipoRecebimento = (FinTipoRecebimentoDTO)searchWindow.itemSelecionado;
                    notifyPropertyChanged("FinParcelaRecebimentoSelected");
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
