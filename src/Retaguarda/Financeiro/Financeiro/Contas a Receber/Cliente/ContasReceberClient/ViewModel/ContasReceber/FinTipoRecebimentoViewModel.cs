using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ContasReceberClient.ContasReceberService;
using ContasReceberClient.Command;

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
    public class FinTipoRecebimentoViewModel : ERPViewModelBase
    {
        public ObservableCollection<FinTipoRecebimentoDTO> ListaFinTipoRecebimento { get; set; }
        private FinTipoRecebimentoDTO _FinTipoRecebimentoSelected;
        private int primeiroResultado;
        protected ICommand seguinteCommand;
        protected ICommand anteriorCommand;
        private bool _isEditar { get; set; }


        public FinTipoRecebimentoViewModel()
        {
            try
            {
                ListaFinTipoRecebimento = new ObservableCollection<FinTipoRecebimentoDTO>();
                primeiroResultado = 0;
                this.atualizarListaFinTipoRecebimento(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FinTipoRecebimentoDTO FinTipoRecebimentoSelected
        {
            get { return _FinTipoRecebimentoSelected; }
            set
            {
                _FinTipoRecebimentoSelected = value;
                notifyPropertyChanged("FinTipoRecebimentoSelected");
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
                            this.atualizarListaFinTipoRecebimento(1);
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
                            this.atualizarListaFinTipoRecebimento(-1);
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

        public void salvarAtualizarFinTipoRecebimento()
        {
            try
            {
                using (ContasReceberServiceClient serv = new ContasReceberServiceClient())
                {
                    FinTipoRecebimentoSelected.Empresa = Empresa;
                    serv.salvarAtualizarFinTipoRecebimento(FinTipoRecebimentoSelected);
                    FinTipoRecebimentoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void atualizarListaFinTipoRecebimento(int pagina)
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

                    List<FinTipoRecebimentoDTO> listaServ = serv.selectFinTipoRecebimentoPagina(primeiroResultado, QUANTIDADE_PAGINA, new FinTipoRecebimentoDTO());

                    ListaFinTipoRecebimento.Clear();

                    foreach (FinTipoRecebimentoDTO objAdd in listaServ)
                    {
                        ListaFinTipoRecebimento.Add(objAdd);
                    }
                    FinTipoRecebimentoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void excluirFinTipoRecebimento()
        {
            try
            {
                using (ContasReceberServiceClient serv = new ContasReceberServiceClient())
                {
                    serv.deleteFinTipoRecebimento(FinTipoRecebimentoSelected);
                    FinTipoRecebimentoSelected = null;
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
