using ModelEF;
using NHibernate;
using Servidor.DAL;
using Servidor.EntityFramework;
using Servidor.Model;
using Servidor.NHibernate;
using Servidor.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace Servidor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please Select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceServidor : IServidor
    {
        
        #region === Comum ===

        #region Empresa

        public EmpresaDTO SelectObjetoEmpresa(string pFiltro)
        {
            try
            {
                EmpresaDTO Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<EmpresaDTO> DAL = new NHibernateDAL<EmpresaDTO>(Session);
                    Resultado = new EmpresaDAL(Session).SelectId(1);

                    if (Resultado != null)
                    {
                        Resultado.ListaEndereco = DAL.Select<EmpresaEnderecoDTO>(new EmpresaEnderecoDTO { IdEmpresa = Resultado.Id });

                        if (Resultado.ListaEndereco == null)
                            Resultado.ListaEndereco = new List<EmpresaEnderecoDTO>();
                        else
                        {
                            for (int i = 0; i <= Resultado.ListaEndereco.Count - 1; i++)
                            {
                                if (Resultado.ListaEndereco[i].Principal == "S")
                                    Resultado.EnderecoPrincipal = Resultado.ListaEndereco[i];
                            }
                        }
                    }
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public IList<EmpresaDTO> SelectEmpresa(EmpresaDTO empresa)
        {
            try
            {
                IList<EmpresaDTO> resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    EmpresaDAL DAL = new EmpresaDAL(Session);
                    resultado = DAL.Select(empresa);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<EmpresaDTO> SelectEmpresaPagina(int primeiroResultado, int quantidadeResultados, EmpresaDTO empresa)
        {
            try
            {
                IList<EmpresaDTO> resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    EmpresaDAL DAL = new EmpresaDAL(Session);
                    resultado = DAL.SelectPagina(primeiroResultado, quantidadeResultados, empresa);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Usuario
        public UsuarioDTO SelectUsuario(String login, String senha)
        {
            try
            {
                UsuarioDTO resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    UsuarioDAL DAL = new UsuarioDAL(Session);
                    resultado = DAL.Select(login, senha);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }
        #endregion

        #endregion

        #region === Cadastros ===

        #region EstadoCivil
        public void DeleteEstadoCivil(EstadoCivilDTO estadoCivil)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<EstadoCivilDTO> DAL = new NHibernateDAL<EstadoCivilDTO>(Session);
                    DAL.Delete(estadoCivil);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public EstadoCivilDTO SalvarAtualizarEstadoCivil(EstadoCivilDTO estadoCivil)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<EstadoCivilDTO> DAL = new NHibernateDAL<EstadoCivilDTO>(Session);
                    DAL.SaveOrUpdate(estadoCivil);
                    Session.Flush();
                }
                return estadoCivil;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<EstadoCivilDTO> SelectEstadoCivil(EstadoCivilDTO estadoCivil)
        {
            try
            {
                IList<EstadoCivilDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<EstadoCivilDTO> DAL = new NHibernateDAL<EstadoCivilDTO>(Session);
                    Resultado = DAL.Select(estadoCivil);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<EstadoCivilDTO> SelectEstadoCivilPagina(int primeiroResultado, int quantidadeResultados, EstadoCivilDTO estadoCivil)
        {
            try
            {
                IList<EstadoCivilDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<EstadoCivilDTO> DAL = new NHibernateDAL<EstadoCivilDTO>(Session);
                    Resultado = DAL.SelectPagina<EstadoCivilDTO>(primeiroResultado, quantidadeResultados, estadoCivil);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        #endregion

        #region AtividadeForCli
        public void DeleteAtividadeForCli(AtividadeForCliDTO atividadeForCli)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<AtividadeForCliDTO> DAL = new NHibernateDAL<AtividadeForCliDTO>(Session);
                    DAL.Delete(atividadeForCli);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public AtividadeForCliDTO SalvarAtualizarAtividadeForCli(AtividadeForCliDTO atividadeForCli)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<AtividadeForCliDTO> DAL = new NHibernateDAL<AtividadeForCliDTO>(Session);
                    DAL.SaveOrUpdate(atividadeForCli);
                    Session.Flush();
                }
                return atividadeForCli;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<AtividadeForCliDTO> SelectAtividadeForCli(AtividadeForCliDTO atividadeForCli)
        {
            try
            {
                IList<AtividadeForCliDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<AtividadeForCliDTO> DAL = new NHibernateDAL<AtividadeForCliDTO>(Session);
                    Resultado = DAL.Select(atividadeForCli);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<AtividadeForCliDTO> SelectAtividadeForCliPagina(int primeiroResultado, int quantidadeResultados, AtividadeForCliDTO atividadeForCli)
        {
            try
            {
                IList<AtividadeForCliDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<AtividadeForCliDTO> DAL = new NHibernateDAL<AtividadeForCliDTO>(Session);
                    Resultado = DAL.SelectPagina<AtividadeForCliDTO>(primeiroResultado, quantidadeResultados, atividadeForCli);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Cargo
        public void DeleteCargo(CargoDTO cargo)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<CargoDTO> DAL = new NHibernateDAL<CargoDTO>(Session);
                    DAL.Delete(cargo);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public CargoDTO SalvarAtualizarCargo(CargoDTO cargo)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<CargoDTO> DAL = new NHibernateDAL<CargoDTO>(Session);
                    DAL.SaveOrUpdate(cargo);
                    Session.Flush();
                }
                return cargo;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<CargoDTO> SelectCargo(CargoDTO cargo)
        {
            try
            {
                IList<CargoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<CargoDTO> DAL = new NHibernateDAL<CargoDTO>(Session);
                    Resultado = DAL.Select(cargo);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<CargoDTO> SelectCargoPagina(int primeiroResultado, int quantidadeResultados, CargoDTO cargo)
        {
            try
            {
                IList<CargoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<CargoDTO> DAL = new NHibernateDAL<CargoDTO>(Session);
                    Resultado = DAL.SelectPagina<CargoDTO>(primeiroResultado, quantidadeResultados, cargo);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Cbo
        public void DeleteCbo(CboDTO cbo)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<CboDTO> DAL = new NHibernateDAL<CboDTO>(Session);
                    DAL.Delete(cbo);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public CboDTO SalvarAtualizarCbo(CboDTO cbo)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<CboDTO> DAL = new NHibernateDAL<CboDTO>(Session);
                    DAL.SaveOrUpdate(cbo);
                    Session.Flush();
                }
                return cbo;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<CboDTO> SelectCbo(CboDTO cbo)
        {
            try
            {
                IList<CboDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<CboDTO> DAL = new NHibernateDAL<CboDTO>(Session);
                    Resultado = DAL.Select(cbo);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<CboDTO> SelectCboPagina(int primeiroResultado, int quantidadeResultados, CboDTO cbo)
        {
            try
            {
                IList<CboDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<CboDTO> DAL = new NHibernateDAL<CboDTO>(Session);
                    Resultado = DAL.SelectPagina<CboDTO>(primeiroResultado, quantidadeResultados, cbo);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region OperadoraPlanoSaude
        public void DeleteOperadoraPlanoSaude(OperadoraPlanoSaudeDTO operadoraPlanoSaude)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<OperadoraPlanoSaudeDTO> DAL = new NHibernateDAL<OperadoraPlanoSaudeDTO>(Session);
                    DAL.Delete(operadoraPlanoSaude);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public OperadoraPlanoSaudeDTO SalvarAtualizarOperadoraPlanoSaude(OperadoraPlanoSaudeDTO operadoraPlanoSaude)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<OperadoraPlanoSaudeDTO> DAL = new NHibernateDAL<OperadoraPlanoSaudeDTO>(Session);
                    DAL.SaveOrUpdate(operadoraPlanoSaude);
                    Session.Flush();
                }
                return operadoraPlanoSaude;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<OperadoraPlanoSaudeDTO> SelectOperadoraPlanoSaude(OperadoraPlanoSaudeDTO operadoraPlanoSaude)
        {
            try
            {
                IList<OperadoraPlanoSaudeDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<OperadoraPlanoSaudeDTO> DAL = new NHibernateDAL<OperadoraPlanoSaudeDTO>(Session);
                    Resultado = DAL.Select(operadoraPlanoSaude);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<OperadoraPlanoSaudeDTO> SelectOperadoraPlanoSaudePagina(int primeiroResultado, int quantidadeResultados, OperadoraPlanoSaudeDTO operadoraPlanoSaude)
        {
            try
            {
                IList<OperadoraPlanoSaudeDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<OperadoraPlanoSaudeDTO> DAL = new NHibernateDAL<OperadoraPlanoSaudeDTO>(Session);
                    Resultado = DAL.SelectPagina<OperadoraPlanoSaudeDTO>(primeiroResultado, quantidadeResultados, operadoraPlanoSaude);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Pais
        public void DeletePais(PaisDTO pais)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<PaisDTO> DAL = new NHibernateDAL<PaisDTO>(Session);
                    DAL.Delete(pais);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public PaisDTO SalvarAtualizarPais(PaisDTO pais)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<PaisDTO> DAL = new NHibernateDAL<PaisDTO>(Session);
                    DAL.SaveOrUpdate(pais);
                    Session.Flush();
                }
                return pais;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<PaisDTO> SelectPais(PaisDTO pais)
        {
            try
            {
                IList<PaisDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<PaisDTO> DAL = new NHibernateDAL<PaisDTO>(Session);
                    Resultado = DAL.Select(pais);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<PaisDTO> SelectPaisPagina(int primeiroResultado, int quantidadeResultados, PaisDTO pais)
        {
            try
            {
                IList<PaisDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<PaisDTO> DAL = new NHibernateDAL<PaisDTO>(Session);
                    Resultado = DAL.SelectPagina<PaisDTO>(primeiroResultado, quantidadeResultados, pais);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Produto
        public void DeleteProduto(ProdutoDTO produto)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoDTO> DAL = new NHibernateDAL<ProdutoDTO>(Session);
                    DAL.Delete(produto);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public ProdutoDTO SalvarAtualizarProduto(ProdutoDTO produto)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoDTO> DAL = new NHibernateDAL<ProdutoDTO>(Session);
                    DAL.SaveOrUpdate(produto);
                    Session.Flush();
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ProdutoDTO> SelectProduto(ProdutoDTO produto)
        {
            try
            {
                IList<ProdutoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoDTO> DAL = new NHibernateDAL<ProdutoDTO>(Session);
                    Resultado = DAL.Select(produto);

                    if (Resultado != null)
                    {
                        foreach (ProdutoDTO prod in Resultado)
                        {
                            prod.ListaFichaTecnica = DAL.Select<FichaTecnicaDTO>(new FichaTecnicaDTO { IdProduto = prod.Id });
                        }
                    }

                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public ProdutoDTO SelectProdutoId(ProdutoDTO produto)
        {
            try
            {
                ProdutoDTO Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoDTO> DAL = new NHibernateDAL<ProdutoDTO>(Session);
                    Resultado = DAL.SelectId<ProdutoDTO>(produto.Id);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public IList<ProdutoDTO> SelectProdutoPagina(int primeiroResultado, int quantidadeResultados, ProdutoDTO produto)
        {
            try
            {
                IList<ProdutoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoDTO> DAL = new NHibernateDAL<ProdutoDTO>(Session);
                    Resultado = DAL.SelectPagina<ProdutoDTO>(primeiroResultado, quantidadeResultados, produto);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region ProdutoSubGrupo
        public void DeleteProdutoSubGrupo(ProdutoSubGrupoDTO produtoSubGrupo)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoSubGrupoDTO> DAL = new NHibernateDAL<ProdutoSubGrupoDTO>(Session);
                    DAL.Delete(produtoSubGrupo);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public ProdutoSubGrupoDTO SalvarAtualizarProdutoSubGrupo(ProdutoSubGrupoDTO produtoSubGrupo)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoSubGrupoDTO> DAL = new NHibernateDAL<ProdutoSubGrupoDTO>(Session);
                    DAL.SaveOrUpdate(produtoSubGrupo);
                    Session.Flush();
                }
                return produtoSubGrupo;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ProdutoSubGrupoDTO> SelectProdutoSubGrupo(ProdutoSubGrupoDTO produtoSubGrupo)
        {
            try
            {
                IList<ProdutoSubGrupoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoSubGrupoDTO> DAL = new NHibernateDAL<ProdutoSubGrupoDTO>(Session);
                    Resultado = DAL.Select(produtoSubGrupo);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ProdutoSubGrupoDTO> SelectProdutoSubGrupoPagina(int primeiroResultado, int quantidadeResultados, ProdutoSubGrupoDTO produtoSubGrupo)
        {
            try
            {
                IList<ProdutoSubGrupoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoSubGrupoDTO> DAL = new NHibernateDAL<ProdutoSubGrupoDTO>(Session);
                    Resultado = DAL.SelectPagina<ProdutoSubGrupoDTO>(primeiroResultado, quantidadeResultados, produtoSubGrupo);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region ProdutoMarca
        public void DeleteProdutoMarca(ProdutoMarcaDTO produtoMarca)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoMarcaDTO> DAL = new NHibernateDAL<ProdutoMarcaDTO>(Session);
                    DAL.Delete(produtoMarca);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public ProdutoMarcaDTO SalvarAtualizarProdutoMarca(ProdutoMarcaDTO produtoMarca)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoMarcaDTO> DAL = new NHibernateDAL<ProdutoMarcaDTO>(Session);
                    DAL.SaveOrUpdate(produtoMarca);
                    Session.Flush();
                }
                return produtoMarca;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ProdutoMarcaDTO> SelectProdutoMarca(ProdutoMarcaDTO produtoMarca)
        {
            try
            {
                IList<ProdutoMarcaDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoMarcaDTO> DAL = new NHibernateDAL<ProdutoMarcaDTO>(Session);
                    Resultado = DAL.Select(produtoMarca);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ProdutoMarcaDTO> SelectProdutoMarcaPagina(int primeiroResultado, int quantidadeResultados, ProdutoMarcaDTO produtoMarca)
        {
            try
            {
                IList<ProdutoMarcaDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ProdutoMarcaDTO> DAL = new NHibernateDAL<ProdutoMarcaDTO>(Session);
                    Resultado = DAL.SelectPagina<ProdutoMarcaDTO>(primeiroResultado, quantidadeResultados, produtoMarca);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Almoxarifado
        public void DeleteAlmoxarifado(AlmoxarifadoDTO almoxarifado)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<AlmoxarifadoDTO> DAL = new NHibernateDAL<AlmoxarifadoDTO>(Session);
                    DAL.Delete(almoxarifado);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public AlmoxarifadoDTO SalvarAtualizarAlmoxarifado(AlmoxarifadoDTO almoxarifado)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<AlmoxarifadoDTO> DAL = new NHibernateDAL<AlmoxarifadoDTO>(Session);
                    DAL.SaveOrUpdate(almoxarifado);
                    Session.Flush();
                }
                return almoxarifado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<AlmoxarifadoDTO> SelectAlmoxarifado(AlmoxarifadoDTO almoxarifado)
        {
            try
            {
                IList<AlmoxarifadoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<AlmoxarifadoDTO> DAL = new NHibernateDAL<AlmoxarifadoDTO>(Session);
                    Resultado = DAL.Select(almoxarifado);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<AlmoxarifadoDTO> SelectAlmoxarifadoPagina(int primeiroResultado, int quantidadeResultados, AlmoxarifadoDTO almoxarifado)
        {
            try
            {
                IList<AlmoxarifadoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<AlmoxarifadoDTO> DAL = new NHibernateDAL<AlmoxarifadoDTO>(Session);
                    Resultado = DAL.SelectPagina<AlmoxarifadoDTO>(primeiroResultado, quantidadeResultados, almoxarifado);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Contador

        public IList<ContadorDTO> SelectContador(ContadorDTO contador)
        {
            try
            {
                IList<ContadorDTO> resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ContadorDTO> DAL = new NHibernateDAL<ContadorDTO>(Session);
                    resultado = DAL.Select(contador);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ContadorDTO> SelectContadorPagina(int primeiroResultado, int quantidadeResultados, ContadorDTO contador)
        {
            try
            {
                IList<ContadorDTO> resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ContadorDTO> DAL = new NHibernateDAL<ContadorDTO>(Session);
                    resultado = DAL.SelectPagina<ContadorDTO>(primeiroResultado, quantidadeResultados, contador);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Pessoa
        public void DeletePessoa(PessoaDTO pessoa)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<PessoaDTO> DAL = new NHibernateDAL<PessoaDTO>(Session);
                    DAL.Delete(pessoa);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public PessoaDTO SalvarAtualizarPessoa(PessoaDTO pessoa)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<PessoaDTO> DAL = new NHibernateDAL<PessoaDTO>(Session);
                    DAL.SaveOrUpdate(pessoa);
                    Session.Flush();
                }
                return pessoa;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<PessoaDTO> SelectPessoa(PessoaDTO pessoa)
        {
            try
            {
                IList<PessoaDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<PessoaDTO> DAL = new NHibernateDAL<PessoaDTO>(Session);
                    Resultado = DAL.Select(pessoa);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<PessoaDTO> SelectPessoaPagina(int primeiroResultado, int quantidadeResultados, PessoaDTO pessoa)
        {
            try
            {
                IList<PessoaDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<PessoaDTO> DAL = new NHibernateDAL<PessoaDTO>(Session);
                    Resultado = DAL.SelectPagina<PessoaDTO>(primeiroResultado, quantidadeResultados, pessoa);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Banco
        public void DeleteBanco(BancoDTO banco)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<BancoDTO> DAL = new NHibernateDAL<BancoDTO>(Session);
                    DAL.Delete(banco);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public BancoDTO SalvarAtualizarBanco(BancoDTO banco)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<BancoDTO> DAL = new NHibernateDAL<BancoDTO>(Session);
                    DAL.SaveOrUpdate(banco);
                    Session.Flush();
                }
                return banco;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<BancoDTO> SelectBanco(BancoDTO banco)
        {
            try
            {
                IList<BancoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<BancoDTO> DAL = new NHibernateDAL<BancoDTO>(Session);
                    Resultado = DAL.Select(banco);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<BancoDTO> SelectBancoPagina(int primeiroResultado, int quantidadeResultados, BancoDTO banco)
        {
            try
            {
                IList<BancoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<BancoDTO> DAL = new NHibernateDAL<BancoDTO>(Session);
                    Resultado = DAL.SelectPagina<BancoDTO>(primeiroResultado, quantidadeResultados, banco);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }
        #endregion

        #region UnidadeProduto
        public void DeleteUnidadeProduto(UnidadeProdutoDTO unidadeProduto)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<UnidadeProdutoDTO> DAL = new NHibernateDAL<UnidadeProdutoDTO>(Session);
                    DAL.Delete(unidadeProduto);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public UnidadeProdutoDTO SalvarAtualizarUnidadeProduto(UnidadeProdutoDTO unidadeProduto)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<UnidadeProdutoDTO> DAL = new NHibernateDAL<UnidadeProdutoDTO>(Session);
                    DAL.SaveOrUpdate(unidadeProduto);
                    Session.Flush();
                }
                return unidadeProduto;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<UnidadeProdutoDTO> SelectUnidadeProduto(UnidadeProdutoDTO unidadeProduto)
        {
            try
            {
                IList<UnidadeProdutoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<UnidadeProdutoDTO> DAL = new NHibernateDAL<UnidadeProdutoDTO>(Session);
                    Resultado = DAL.Select(unidadeProduto);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<UnidadeProdutoDTO> SelectUnidadeProdutoPagina(int primeiroResultado, int quantidadeResultados, UnidadeProdutoDTO unidadeProduto)
        {
            try
            {
                IList<UnidadeProdutoDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<UnidadeProdutoDTO> DAL = new NHibernateDAL<UnidadeProdutoDTO>(Session);
                    Resultado = DAL.SelectPagina<UnidadeProdutoDTO>(primeiroResultado, quantidadeResultados, unidadeProduto);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #region Colaborador
        public int DeleteColaborador(ColaboradorDTO colaborador)
        {
            try
            {
                int Resultado = -1;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ColaboradorDTO> DAL = new NHibernateDAL<ColaboradorDTO>(Session);
                    DAL.Delete(colaborador);
                    Session.Flush();
                    Resultado = 0;
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public ColaboradorDTO SalvarAtualizarColaborador(ColaboradorDTO colaborador)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ColaboradorDTO> DAL = new NHibernateDAL<ColaboradorDTO>(Session);
                    DAL.SaveOrUpdate(colaborador);
                    Session.Flush();
                }
                return colaborador;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ColaboradorDTO> SelectColaborador(ColaboradorDTO colaborador)
        {
            try
            {
                IList<ColaboradorDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ColaboradorDTO> DAL = new NHibernateDAL<ColaboradorDTO>(Session);
                    Resultado = DAL.Select(colaborador);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<ColaboradorDTO> SelectColaboradorPagina(int primeiroResultado, int quantidadeResultados, ColaboradorDTO colaborador)
        {
            try
            {
                IList<ColaboradorDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ColaboradorDTO> DAL = new NHibernateDAL<ColaboradorDTO>(Session);
                    Resultado = DAL.SelectPagina<ColaboradorDTO>(primeiroResultado, quantidadeResultados, colaborador);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion

        #endregion
        
        
        #region === Tributação ===

        #region TributOperacaoFiscal
        public int DeleteTributOperacaoFiscal(TributOperacaoFiscalDTO tributOperacaoFiscal)
        {
            try
            {
                int Resultado = -1;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributOperacaoFiscalDTO> DAL = new NHibernateDAL<TributOperacaoFiscalDTO>(Session);
                    DAL.Delete(tributOperacaoFiscal);
                    Session.Flush();
                    Resultado = 0;
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public TributOperacaoFiscalDTO SalvarAtualizarTributOperacaoFiscal(TributOperacaoFiscalDTO tributOperacaoFiscal)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributOperacaoFiscalDTO> DAL = new NHibernateDAL<TributOperacaoFiscalDTO>(Session);
                    DAL.SaveOrUpdate(tributOperacaoFiscal);
                    Session.Flush();
                }
                return tributOperacaoFiscal;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<TributOperacaoFiscalDTO> SelectTributOperacaoFiscal(TributOperacaoFiscalDTO tributOperacaoFiscal)
        {
            try
            {
                IList<TributOperacaoFiscalDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributOperacaoFiscalDTO> DAL = new NHibernateDAL<TributOperacaoFiscalDTO>(Session);
                    Resultado = DAL.Select(tributOperacaoFiscal);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<TributOperacaoFiscalDTO> SelectTributOperacaoFiscalPagina(int primeiroResultado, int quantidadeResultados, TributOperacaoFiscalDTO tributOperacaoFiscal)
        {
            try
            {
                IList<TributOperacaoFiscalDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributOperacaoFiscalDTO> DAL = new NHibernateDAL<TributOperacaoFiscalDTO>(Session);
                    Resultado = DAL.SelectPagina<TributOperacaoFiscalDTO>(primeiroResultado, quantidadeResultados, tributOperacaoFiscal);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion 

        #region TributGrupoTributario
        public void DeleteTributGrupoTributario(TributGrupoTributarioDTO tributGrupoTributario)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributGrupoTributarioDTO> DAL = new NHibernateDAL<TributGrupoTributarioDTO>(Session);
                    DAL.Delete(tributGrupoTributario);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public TributGrupoTributarioDTO SalvarAtualizarTributGrupoTributario(TributGrupoTributarioDTO tributGrupoTributario)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributGrupoTributarioDTO> DAL = new NHibernateDAL<TributGrupoTributarioDTO>(Session);
                    DAL.SaveOrUpdate(tributGrupoTributario);
                    Session.Flush();
                }
                return tributGrupoTributario;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<TributGrupoTributarioDTO> SelectTributGrupoTributario(TributGrupoTributarioDTO tributGrupoTributario)
        {
            try
            {
                IList<TributGrupoTributarioDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributGrupoTributarioDTO> DAL = new NHibernateDAL<TributGrupoTributarioDTO>(Session);
                    Resultado = DAL.Select(tributGrupoTributario);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<TributGrupoTributarioDTO> SelectTributGrupoTributarioPagina(int primeiroResultado, int quantidadeResultados, TributGrupoTributarioDTO tributGrupoTributario)
        {
            try
            {
                IList<TributGrupoTributarioDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributGrupoTributarioDTO> DAL = new NHibernateDAL<TributGrupoTributarioDTO>(Session);
                    Resultado = DAL.SelectPagina<TributGrupoTributarioDTO>(primeiroResultado, quantidadeResultados, tributGrupoTributario);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion 

        #region TributIcmsCustomCab
        public void DeleteTributIcmsCustomCab(TributIcmsCustomCabDTO tributIcmsCustomCab)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributIcmsCustomCabDTO> DAL = new NHibernateDAL<TributIcmsCustomCabDTO>(Session);
                    DAL.Delete(tributIcmsCustomCab);
                    Session.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public TributIcmsCustomCabDTO SalvarAtualizarTributIcmsCustomCab(TributIcmsCustomCabDTO tributIcmsCustomCab)
        {
            try
            {
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributIcmsCustomCabDTO> DAL = new NHibernateDAL<TributIcmsCustomCabDTO>(Session);
                    DAL.SaveOrUpdate(tributIcmsCustomCab);
                    Session.Flush();
                }
                return tributIcmsCustomCab;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<TributIcmsCustomCabDTO> SelectTributIcmsCustomCab(TributIcmsCustomCabDTO tributIcmsCustomCab)
        {
            try
            {
                IList<TributIcmsCustomCabDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributIcmsCustomCabDTO> DAL = new NHibernateDAL<TributIcmsCustomCabDTO>(Session);
                    Resultado = DAL.Select(tributIcmsCustomCab);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public IList<TributIcmsCustomCabDTO> SelectTributIcmsCustomCabPagina(int primeiroResultado, int quantidadeResultados, TributIcmsCustomCabDTO tributIcmsCustomCab)
        {
            try
            {
                IList<TributIcmsCustomCabDTO> Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<TributIcmsCustomCabDTO> DAL = new NHibernateDAL<TributIcmsCustomCabDTO>(Session);
                    Resultado = DAL.SelectPagina<TributIcmsCustomCabDTO>(primeiroResultado, quantidadeResultados, tributIcmsCustomCab);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        #endregion 
        
        #region ViewTributacaoCofins
        public ViewTributacaoCofinsDTO SelectViewTributacaoCofins(ViewTributacaoCofinsDTO viewTributacaoCofins)
        {
            try
            {
                ViewTributacaoCofinsDTO Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ViewTributacaoCofinsDTO> DAL = new NHibernateDAL<ViewTributacaoCofinsDTO>(Session);
                    Resultado = DAL.SelectObjeto(viewTributacaoCofins);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        #endregion 

        #region ViewTributacaoPis
        public ViewTributacaoPisDTO SelectViewTributacaoPis(ViewTributacaoPisDTO viewTributacaoPis)
        {
            try
            {
                ViewTributacaoPisDTO Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ViewTributacaoPisDTO> DAL = new NHibernateDAL<ViewTributacaoPisDTO>(Session);
                    Resultado = DAL.SelectObjeto(viewTributacaoPis);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        #endregion 

        #region ViewTributacaoIcms
        public ViewTributacaoIcmsDTO SelectViewTributacaoIcms(ViewTributacaoIcmsDTO viewTributacaoIcms)
        {
            try
            {
                ViewTributacaoIcmsDTO Resultado = null;
                using (ISession Session = NHibernateHelper.GetSessionFactory().OpenSession())
                {
                    NHibernateDAL<ViewTributacaoIcmsDTO> DAL = new NHibernateDAL<ViewTributacaoIcmsDTO>(Session);
                    Resultado = DAL.SelectObjeto(viewTributacaoIcms);
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        #endregion 

        #endregion

        #region Banco EF
        public void DeleteBancoEF(BANCO banco)
        {
            try
            {
                var DAL = new EntityFrameworkDAL<BANCO>();
                using (DAL)
                {
                    DAL.Excluir(b => b.ID == banco.ID);
                    DAL.SalvarTodos();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }


        public BANCO SalvarAtualizarBancoEF(BANCO banco)
        {
            try
            {
                var DAL = new EntityFrameworkDAL<BANCO>();
                using (DAL)
                {
                    if (banco.ID == 0)
                    {
                        DAL.Inserir(banco);
                    }
                    else
                    {
                        DAL.Atualizar(banco);
                    }
                    DAL.SalvarTodos();
                }
                return banco;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public IList<BANCO> SelectBancoPaginaEF(int primeiroResultado, int quantidadeResultados, BANCO banco)
        {
            try
            {
                IList<BANCO> Resultado = null;
                var DAL = new EntityFrameworkDAL<BANCO>();
                using (DAL)
                {
                    Resultado = DAL.SelectAll().OrderBy(x => x.ID).Skip(primeiroResultado).Take(quantidadeResultados).ToList();
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public IList<BANCO> SelectBancoEF(BANCO banco)
        {            
            try
            {
                IList<BANCO> Resultado = null;
                var DAL = new EntityFrameworkDAL<BANCO>();
                using (DAL)
                {
                    Resultado = DAL.SelectAll().AsNoTracking().ToList();
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }
        #endregion

        #region Empresa EF
        public EMPRESA SelectObjetoEmpresaEF(string pFiltro)
        {
            try
            {
                EMPRESA Resultado = null;
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public EMPRESA SalvarAtualizarEmpresaEF(EMPRESA empresa)
        {
            try
            {
                var DAL = new EntityFrameworkDAL<EMPRESA>();
                using (DAL)
                {
                    if (empresa.ID == 0)
                    {
                        DAL.Inserir(empresa);
                    }
                    else
                    {
                        DAL.Atualizar(empresa);
                    }
                    DAL.SalvarTodos();

                }
                return empresa;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public IList<EMPRESA> SelectEmpresaEF(EMPRESA empresa)
        {
            try
            {
                IList<EMPRESA> Resultado = null;
                var DAL = new EntityFrameworkDAL<EMPRESA>();
                using (DAL)
                {
                    Resultado = DAL.SelectAll().AsNoTracking().ToList();
                    foreach (var r in Resultado)
                    {
                        var DALEndereco = new EntityFrameworkDAL<EMPRESA_ENDERECO>();
                        r.EMPRESA_ENDERECO = DALEndereco.Select(e => e.ID_EMPRESA.Equals(r.ID)).ToList();
                    }
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }

        }

        public IList<EMPRESA> SelectEmpresaPaginaEF(int primeiroResultado, int quantidadeResultados, EMPRESA empresa)
        {
            try
            {
                IList<EMPRESA> Resultado = null;
                var DAL = new EntityFrameworkDAL<EMPRESA>();
                using (DAL)
                {
                    Resultado = DAL.SelectAll().OrderBy(x => x.ID).Skip(primeiroResultado).Take(quantidadeResultados).ToList();
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }
        #endregion

        
        
        #region === Nfe ===

        #region NfeCabecalho
        public void DeleteNfeCabecalho(NFE_CABECALHO nfeCabecalho)
        {
            try
            {
                var DAL = new EntityFrameworkDAL<NFE_CABECALHO>();
                using (DAL)
                {
                    DAL.Excluir(b => b.ID == nfeCabecalho.ID);
                    DAL.SalvarTodos();
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public NFE_CABECALHO SalvarAtualizarNfeCabecalho(NFE_CABECALHO nfeCabecalho)
        {
            try
            {
                /*
                nfeCabecalho.CHAVE_ACESSO = nfeCabecalho.NFE_EMITENTE.FirstOrDefault().CODIGO_MUNICIPIO.ToString().Substring(0, 2) +
                                                            ((DateTime)nfeCabecalho.DATA_HORA_EMISSAO).ToString("yy") +
                                                            ((DateTime)nfeCabecalho.DATA_HORA_EMISSAO).ToString("MM") +
                                                            nfeCabecalho.NFE_EMITENTE.FirstOrDefault().CPF_CNPJ +
                                                            "55" +
                                                            (int.Parse(nfeCabecalho.SERIE)).ToString("000") +
                                                            (int.Parse(nfeCabecalho.NUMERO)).ToString("000000000") +
                                                            nfeCabecalho.FINALIDADE_EMISSAO +
                                                            (int.Parse(nfeCabecalho.NUMERO)).ToString("00000000");
                nfeCabecalho.DIGITO_CHAVE_ACESSO = Biblioteca.DigitoModulo11(nfeCabecalho.CHAVE_ACESSO);

                //Ambiente, 2 - homologacao
                nfeCabecalho.AMBIENTE = 2;
                */
                var DAL = new EntityFrameworkDAL<NFE_CABECALHO>();
                using (DAL)
                {
                    if (nfeCabecalho.ID == 0)
                    {
                        DAL.Inserir(nfeCabecalho);
                    }
                    else
                    {
                        DAL.Atualizar(nfeCabecalho);
                    }
                    DAL.SalvarTodos();
                }
                return nfeCabecalho;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
            
        }

        public IList<NFE_CABECALHO> SelectNfeCabecalho(NFE_CABECALHO nfeCabecalho)
        {
            try
            {
                IList<NFE_CABECALHO> Resultado = null;
                var DAL = new EntityFrameworkDAL<NFE_CABECALHO>();
                using (DAL)
                {
                    Resultado = DAL.SelectAll().AsNoTracking().ToList();
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public IList<NFE_CABECALHO> SelectNfeCabecalhoPagina(int primeiroResultado, int quantidadeResultados, NFE_CABECALHO nfeCabecalho)
        {
            try
            {
                IList<NFE_CABECALHO> Resultado = null;
                var DAL = new EntityFrameworkDAL<NFE_CABECALHO>();
                using (DAL)
                {
                    Resultado = DAL.SelectAll().OrderBy(x => x.ID).Skip(primeiroResultado).Take(quantidadeResultados).ToList();
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

        public NFE_CABECALHO SelectNfeCabecalhoId(int id)
        {
            try
            {
                NFE_CABECALHO Resultado = null;

                var DAL = new EntityFrameworkDAL<NFE_CABECALHO>();
                using (DAL)
                {
                    Resultado = DAL.Select(nfe => nfe.ID.Equals(id)).First();
                    if (Resultado != null)
                    {
                        var DALDestinatario = new EntityFrameworkDAL<NFE_DESTINATARIO>();
                        Resultado.NFE_DESTINATARIO = DALDestinatario.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        var DALEmitente = new EntityFrameworkDAL<NFE_EMITENTE>();
                        Resultado.NFE_EMITENTE = DALEmitente.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        var DALLocalEntrega = new EntityFrameworkDAL<NFE_LOCAL_ENTREGA>();
                        Resultado.NFE_LOCAL_ENTREGA = DALLocalEntrega.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        var DALLocalRetirada = new EntityFrameworkDAL<NFE_LOCAL_RETIRADA>();
                        Resultado.NFE_LOCAL_RETIRADA = DALLocalRetirada.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        var DALTransporte = new EntityFrameworkDAL<NFE_TRANSPORTE>();
                        Resultado.NFE_TRANSPORTE = DALTransporte.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        var DALFatura = new EntityFrameworkDAL<NFE_FATURA>();
                        Resultado.NFE_FATURA = DALFatura.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        var DALDuplicata = new EntityFrameworkDAL<NFE_DUPLICATA>();
                        Resultado.NFE_DUPLICATA = DALDuplicata.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        var DALCupom = new EntityFrameworkDAL<NFE_CUPOM_FISCAL_REFERENCIADO>();
                        Resultado.NFE_CUPOM_FISCAL_REFERENCIADO = DALCupom.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        var DALDetalhe = new EntityFrameworkDAL<NFE_DETALHE>();
                        Resultado.NFE_DETALHE = DALDetalhe.Select(e => e.ID_NFE_CABECALHO.Equals(Resultado.ID)).ToList();

                        foreach (var r in Resultado.NFE_DETALHE)
                        {
                            var DALCofins = new EntityFrameworkDAL<NFE_DETALHE_IMPOSTO_COFINS>();
                            r.NFE_DETALHE_IMPOSTO_COFINS = DALCofins.Select(e => e.ID_NFE_DETALHE.Equals(r.ID)).ToList();

                            var DALIcms = new EntityFrameworkDAL<NFE_DETALHE_IMPOSTO_ICMS>();
                            r.NFE_DETALHE_IMPOSTO_ICMS = DALIcms.Select(e => e.ID_NFE_DETALHE.Equals(r.ID)).ToList();

                            var DALIss = new EntityFrameworkDAL<NFE_DETALHE_IMPOSTO_ISSQN>();
                            r.NFE_DETALHE_IMPOSTO_ISSQN = DALIss.Select(e => e.ID_NFE_DETALHE.Equals(r.ID)).ToList();

                            var DALPis = new EntityFrameworkDAL<NFE_DETALHE_IMPOSTO_PIS>();
                            r.NFE_DETALHE_IMPOSTO_PIS = DALPis.Select(e => e.ID_NFE_DETALHE.Equals(r.ID)).ToList();

                            var DALIpi = new EntityFrameworkDAL<NFE_DETALHE_IMPOSTO_IPI>();
                            r.NFE_DETALHE_IMPOSTO_IPI = DALIpi.Select(e => e.ID_NFE_DETALHE.Equals(r.ID)).ToList();

                            var DALIi = new EntityFrameworkDAL<NFE_DETALHE_IMPOSTO_II>();
                            r.NFE_DETALHE_IMPOSTO_II = DALIi.Select(e => e.ID_NFE_DETALHE.Equals(r.ID)).ToList();
                        }
                    }

                }
                return Resultado;

            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        #endregion

        #endregion

    }
}
