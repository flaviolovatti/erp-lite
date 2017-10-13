using System;
using System.Collections.Generic;
using System.IO;
using NHibernate;
using Servidor.NHibernate;
using System.Collections;
using Servidor.Util;
using Servidor.Model;
using ComponenteSpedContribuicoes;


namespace Servidor.DAL
{

    public class SpedContribuicoesDAL
    {
        private SpedContribuicoes sped;
        private EmpresaDTO Empresa;
        private int VersaoLeiaute, TipoEscrituracao, IdEmpresa, IdContador;
        private String DataInicial, DataFinal;
        private ISession Session;

        String consultaSql = "";

        public SpedContribuicoesDAL()
        {
            sped  = new SpedContribuicoes();
        }


        #region BLOCO 0: ABERTURA, IDENTIFICA��O E REFER�NCIAS
        public void GerarBloco0()
        {

            Empresa = new EmpresaDAL(Session).SelectId(IdEmpresa);
            ContadorDTO Contador = new NHibernateDAL<ContadorDTO>(Session).SelectId<ContadorDTO>(IdContador);

            consultaSql = "from ViewSpedNfeEmitenteDTO emitente where Id in (Select cab.Fornecedor.Id from NfeCabecalhoDTO as cab where cab.DataHoraEmissao BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal) + ")";
            IList<ViewSpedNfeEmitenteDTO> ListaEmitente = new NHibernateDAL<ViewSpedNfeEmitenteDTO>(Session).SelectListaSql<ViewSpedNfeEmitenteDTO>(consultaSql);

            consultaSql = "from ViewSpedNfeDestinatarioDTO destinatario where Id in (Select cab.Cliente.Id from NfeCabecalhoDTO as cab where cab.DataHoraEmissao BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal) + ")";
            IList<ViewSpedNfeDestinatarioDTO> ListaDestinatario = new NHibernateDAL<ViewSpedNfeDestinatarioDTO>(Session).SelectListaSql<ViewSpedNfeDestinatarioDTO>(consultaSql);

            consultaSql = "from ViewSpedNfeItemDTO item where Id in (Select det.Produto.Id from NfeDetalheDTO as det inner join det.NfeCabecalho as cab where cab.DataHoraEmissao BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal) + ")";
            IList<ViewSpedNfeItemDTO> ListaProduto = new NHibernateDAL<ViewSpedNfeItemDTO>(Session).SelectListaSql<ViewSpedNfeItemDTO>(consultaSql);

            IList<TributOperacaoFiscalDTO> ListaOperacaoFiscal = new NHibernateDAL<TributOperacaoFiscalDTO>(Session).Select(new TributOperacaoFiscalDTO());

            var bloco0 = sped.getBloco0();

            // Registro 0000: ABERTURA DO ARQUIVO DIGITAL E IDENTIFICA��O DA ENTIDADE
            sped.getBloco0().getRegistro0000().setDtIni(System.DateTime.Parse(DataInicial));
            sped.getBloco0().getRegistro0000().setDtFin(System.DateTime.Parse(DataFinal));
            sped.getBloco0().getRegistro0000().setCodVer(VersaoLeiaute.ToString());
            //sped.getBloco0().getRegistro0000().setCodFin(FinalidadeArquivo.ToString());
            //sped.getBloco0().getRegistro0000().setIndPerfil(PerfilApresentacao.ToString());
            sped.getBloco0().getRegistro0000().setNome(Empresa.RazaoSocial);
            sped.getBloco0().getRegistro0000().setCnpj(Empresa.Cnpj);
            sped.getBloco0().getRegistro0000().setCpf("");
            sped.getBloco0().getRegistro0000().setIe(Empresa.InscricaoEstadual);
            sped.getBloco0().getRegistro0000().setCodMun(Empresa.CodigoIbgeCidade.Value);
            sped.getBloco0().getRegistro0000().setIm(Empresa.InscricaoMunicipal);
            sped.getBloco0().getRegistro0000().setSuframa(Empresa.Suframa);
            sped.getBloco0().getRegistro0000().setIndAtiv("1");
            sped.getBloco0().getRegistro0000().setUf(Empresa.EnderecoPrincipal.Uf);

            // REGISTRO 0001: ABERTURA DO BLOCO 0
            sped.getBloco0().getRegistro0001().setIndMov(0);

            // REGISTRO 0035: IDENTIFICA��O DE SOCIEDADE EM CONTA DE PARTICIPA��O � SCP
            //{ N�o Implementado }

            // REGISTRO 0100: DADOS DO CONTABILISTA
            sped.getBloco0().getRegistro0100().setNome(Contador.Nome);
            sped.getBloco0().getRegistro0100().setCpf(Contador.Cpf);
            sped.getBloco0().getRegistro0100().setCpf(Contador.Cnpj);
            sped.getBloco0().getRegistro0100().setCrc(Contador.InscricaoCrc);
            sped.getBloco0().getRegistro0100().setCep(Contador.Cep);
            sped.getBloco0().getRegistro0100().setEndereco(Contador.Logradouro);
            sped.getBloco0().getRegistro0100().setNum(Contador.Numero);
            sped.getBloco0().getRegistro0100().setCompl(Contador.Complemento);
            sped.getBloco0().getRegistro0100().setBairro(Contador.Bairro);
            sped.getBloco0().getRegistro0100().setFone(Contador.Fone);
            sped.getBloco0().getRegistro0100().setFax(Contador.Fax);
            sped.getBloco0().getRegistro0100().setEmail(Contador.Email);
            sped.getBloco0().getRegistro0100().setCodMun(Contador.MunicipioIbge.Value);

            // REGISTRO  0110:  REGIMES  DE  APURA��O  DA  CONTRIBUI��O  SOCIAL  E  DE APROPRIA��O DE CR�DITO
            sped.getBloco0().getRegistro0110().setCodIncTrib("1");
            sped.getBloco0().getRegistro0110().setIndAproCred("1");
            sped.getBloco0().getRegistro0110().setCodTipoCont("1");

            // REGISTRO  0111:  TABELA  DE  RECEITA  BRUTA  MENSAL  PARA  FINS  DE  RATEIO  DE CR�DITOS COMUNS
            // REGISTRO  0120:  IDENTIFICA��O  DE  PER�ODOS  DISPENSADOS  DA  ESCRITURA��O FISCAL DIGITAL DAS CONTRIBUI��ES � EFD-CONTRIBUI��ES
            // { N�o Implementados }

            // REGISTRO 0140: TABELA DE CADASTRO DE ESTABELECIMENTO
            sped.getBloco0().getRegistro0140().setCodEst("MATRIZ");
            sped.getBloco0().getRegistro0140().setNome(Empresa.RazaoSocial);
            sped.getBloco0().getRegistro0140().setCnpj(Empresa.Cnpj);
            sped.getBloco0().getRegistro0140().setUf(Empresa.EnderecoPrincipal.Uf);
            sped.getBloco0().getRegistro0140().setIe(Empresa.InscricaoEstadual);
            sped.getBloco0().getRegistro0140().setCodMun(Empresa.CodigoIbgeCidade.Value);
            sped.getBloco0().getRegistro0140().setIm(Empresa.InscricaoMunicipal);
            sped.getBloco0().getRegistro0140().setSuframa(Empresa.Suframa);

            // REGISTRO 0145: REGIME DE APURA��O DA CONTRIBUI��O PREVIDENCI�RIA SOBRE A RECEITA BRUTA
            // { N�o Implementado }

            // REGISTRO 0150: TABELA DE CADASTRO DO PARTICIPANTE
            Registro0150 registro0150;
            foreach (ViewSpedNfeEmitenteDTO Emitente in ListaEmitente)
            {
                registro0150 = new Registro0150();

                registro0150.setCodPart("F" + Emitente.Id);
                registro0150.setNome(Emitente.RazaoSocial);
                registro0150.setCodPais("01058");
                if (Emitente.CpfCnpj.Length == 11)
                {
                    registro0150.setCpf(Emitente.CpfCnpj);
                }
                else if (Emitente.CpfCnpj.Length == 14)
                {
                    registro0150.setCnpj(Emitente.CpfCnpj);
                }
                registro0150.setIe(Emitente.InscricaoEstadual);
                registro0150.setCodMun(Emitente.CodigoMunicipio);
                registro0150.setSuframa(Emitente.Suframa);
                registro0150.setEndereco(Emitente.Logradouro);
                registro0150.setNum(Emitente.Numero);
                registro0150.setCompl(Emitente.Complemento);
                registro0150.setBairro(Emitente.Bairro);

                sped.getBloco0().getRegistro0140().getRegistro0150List().Add(registro0150);
            }

            foreach (ViewSpedNfeDestinatarioDTO Destinatario in ListaDestinatario)
            {
                registro0150 = new Registro0150();

                registro0150.setCodPart("F" + Destinatario.Id);
                registro0150.setNome(Destinatario.RazaoSocial);
                registro0150.setCodPais("01058");
                if (Destinatario.CpfCnpj.Length == 11)
                {
                    registro0150.setCpf(Destinatario.CpfCnpj);
                }
                else if (Destinatario.CpfCnpj.Length == 14)
                {
                    registro0150.setCnpj(Destinatario.CpfCnpj);
                }
                registro0150.setIe(Destinatario.InscricaoEstadual);
                registro0150.setCodMun(Destinatario.CodigoMunicipio);
                registro0150.setSuframa(Destinatario.Suframa);
                registro0150.setEndereco(Destinatario.Logradouro);
                registro0150.setNum(Destinatario.Numero);
                registro0150.setCompl(Destinatario.Complemento);
                registro0150.setBairro(Destinatario.Bairro);

                sped.getBloco0().getRegistro0140().getRegistro0150List().Add(registro0150);
            }


            //REGISTRO 0200: TABELA DE IDENTIFICA��O DO ITEM (PRODUTO E SERVI�OS)
            Registro0200 registro0200;
            ArrayList ListaSiglaUnidade = new ArrayList();
            List<UnidadeProdutoDTO> ListaUnidade = new List<UnidadeProdutoDTO>();
            foreach (ViewSpedNfeItemDTO Produto in ListaProduto)
            {
                registro0200 = new Registro0200();

                registro0200.setCodItem(Produto.Id.ToString());
                registro0200.setDescrItem(Produto.Nome);
                registro0200.setCodBarra(Produto.Gtin);
                //TEM QUE PREENCHER PARA INFORMAR NO 0205
                registro0200.setCodAntItem("");
                registro0200.setUnidInv(Produto.IdUnidadeProduto.ToString());
                registro0200.setTipoItem(Produto.TipoItemSped);
                registro0200.setCodNcm(Produto.Ncm);
                registro0200.setExIpi(Produto.ExTipi);
                registro0200.setCodGen(Produto.Ncm.Substring(0, 2));
                registro0200.setCodLst(Produto.CodigoLst);
                registro0200.setAliqIcms(Produto.AliquotaIcmsPaf);
                
                if (ListaSiglaUnidade.IndexOf(Produto.IdUnidadeProduto) == -1)
                {
                    ListaSiglaUnidade.Add(Convert.ToString(Produto.IdUnidadeProduto));
                    UnidadeProdutoDTO Unidade = new UnidadeProdutoDTO();
                    Unidade.Id = Produto.IdUnidadeProduto;
                    Unidade.Sigla = Produto.Sigla;
                    ListaUnidade.Add(Unidade);
                }

                consultaSql = "from ProdutoAlteracaoItemDTO item where item.DataInicial BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal);
                IList<ProdutoAlteracaoItemDTO> ListaProdutoAlterado = new NHibernateDAL<ProdutoAlteracaoItemDTO>(Session).SelectListaSql<ProdutoAlteracaoItemDTO>(consultaSql);

                // REGISTRO 0205: ALTERA��O DO ITEM
                Registro0205 registro0205;
                foreach (ProdutoAlteracaoItemDTO ProdutoAlterado in ListaProdutoAlterado)
                {
                    registro0205 = new Registro0205();

                    registro0205.setDescrAntItem(ProdutoAlterado.Nome);
                    registro0205.setDtIni(ProdutoAlterado.DataInicial.Value);
                    registro0205.setDtFin(ProdutoAlterado.DataFinal.Value);
                    registro0205.setCodAntItem(ProdutoAlterado.Codigo);

                    registro0200.getRegistro0205List().Add(registro0205);
                }

                sped.getBloco0().getRegistro0140().getRegistro0200List().Add(registro0200);
            }


            // REGISTRO 0190: IDENTIFICA��O DAS UNIDADES DE MEDIDA
            Registro0190 registro0190;
            foreach (UnidadeProdutoDTO Unidade in ListaUnidade)
            {
                registro0190 = new Registro0190();

                registro0190.setUnid(Unidade.Id.ToString());
                registro0190.setDescr(Unidade.Sigla);

                sped.getBloco0().getRegistro0140().getRegistro0190List().Add(registro0190);
            }


            // REGISTRO 0206: C�DIGO DE PRODUTO CONFORME TABELA PUBLICADA PELA ANP (COMBUST�VEIS)
            // { N�o Implementado }

            // REGISTRO 0208: C�DIGO DE GRUPOS POR MARCA COMERCIAL� REFRI (BEBIDAS FRIAS).
            // { N�o Implementado }


            // REGISTRO 0400: TABELA DE NATUREZA DA OPERA��O/PRESTA��O
            Registro0400 registro0400;
            foreach (TributOperacaoFiscalDTO OperacaoFiscal in ListaOperacaoFiscal)
            {
                registro0400 = new Registro0400();
            
                registro0400.setCodNat(OperacaoFiscal.Id.ToString());
                registro0400.setDescrNat(OperacaoFiscal.DescricaoNaNf);
            }

            // REGISTRO 0450: TABELA DE INFORMA��O COMPLEMENTAR DO DOCUMENTO FISCAL
            //{ N�o Implementado }

            // REGISTRO 0500: PLANO DE CONTAS CONT�BEIS
            //{ N�o Implementado }

            // REGISTRO 0600: CENTRO DE CUSTOS
            //{ N�o Implementado }
        }
        #endregion

        #region BLOCO A: DOCUMENTOS FISCAIS - SERVI�OS (N�O SUJEITOS AO ICMS)
        public void GerarBlocoA()
        {
            sped.getBlocoA().getRegistroA001().setIndMov(1); //sem dados
        }
        #endregion

        #region BLOCO C: DOCUMENTOS FISCAIS I - MERCADORIAS (ICMS/IPI)
        public void GerarBlocoC()
        {
            consultaSql = "from EcfNotaFiscalCabecalhoDTO where DataEmissao BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal);
            IList<EcfNotaFiscalCabecalhoDTO> ListaNF2Cabecalho = new NHibernateDAL<EcfNotaFiscalCabecalhoDTO>(Session).SelectListaSql<EcfNotaFiscalCabecalhoDTO>(consultaSql);

            consultaSql = "from EcfNotaFiscalCabecalhoDTO where Cancelada='S' and DataEmissao BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal);
            IList<EcfNotaFiscalCabecalhoDTO> ListaNF2CabecalhoCanceladas = new NHibernateDAL<EcfNotaFiscalCabecalhoDTO>(Session).SelectListaSql<EcfNotaFiscalCabecalhoDTO>(consultaSql);

            consultaSql = "from NfeCabecalhoDTO where DataHoraEmissao BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal);
            IList<NfeCabecalhoDTO> ListaNFeCabecalho = new NHibernateDAL<NfeCabecalhoDTO>(Session).SelectListaSql<NfeCabecalhoDTO>(consultaSql);

            var BlocoC = sped.getBlocoC();

            // REGISTRO C001: ABERTURA DO BLOCO C
            sped.getBlocoC().getRegistroC001().setIndMov(0);

            // REGISTRO C010: IDENTIFICA��O DO ESTABELECIMENTO
            sped.getBlocoC().getRegistroC010().setCnpj(Empresa.Cnpj);
            sped.getBlocoC().getRegistroC010().setIndEscri("2");       // 1 � Apura��o com base nos registros de consolida��odas opera��es por NF-e (C180 e C190) e por ECF (C490);
                                                                       // 2 � Apura��o com base no registro individualizado de NF-e (C100 e C170) e de ECF (C400)

            if (ListaNFeCabecalho != null)
            {
                RegistroC100 registroC100;
                foreach (NfeCabecalhoDTO NFeCabecalho in ListaNFeCabecalho)
                {
                    registroC100 = new RegistroC100();

                    registroC100.setIndOper(NFeCabecalho.TipoOperacao.Value.ToString());
                    registroC100.setIndEmit("0"); // 0 - Emissao Propria
                    if (NFeCabecalho.Cliente != null) {
                        registroC100.setCodPart("C" + NFeCabecalho.Cliente.Id.ToString());
                    } else if (NFeCabecalho.Fornecedor != null) {
                        registroC100.setCodPart("F" + NFeCabecalho.Fornecedor.Id.ToString());
                    }
                    registroC100.setCodMod(NFeCabecalho.CodigoModelo);
                
                    /*
                      4.1.2- Tabela Situa��o do Documento
                      C�digo Descri��o
                      00 Documento regular
                      01 Documento regular extempor�neo
                      02 Documento cancelado
                      03 Documento cancelado extempor�neo
                      04 NFe denegada
                      05 Nfe � Numera��o inutilizada
                      06 Documento Fiscal Complementar
                      07 Documento Fiscal Complementar extempor�neo.
                      08 Documento Fiscal emitido com base em Regime Especial ou Norma Espec�fica
                    */
                    if (NFeCabecalho.StatusNota.Equals("5")) {
                        registroC100.setCodSit("00");
                    } else if (NFeCabecalho.StatusNota.Equals("6")) {
                        registroC100.setCodSit("02");
                    }
                    registroC100.setSer(NFeCabecalho.Serie);
                    registroC100.setNumDoc(NFeCabecalho.Numero);
                    registroC100.setChvNfe(NFeCabecalho.ChaveAcesso);
                    registroC100.setDtDoc(NFeCabecalho.DataHoraEmissao.Value);
                    registroC100.setDtES(NFeCabecalho.DataHoraEntradaSaida.Value);
                    registroC100.setVlDoc(NFeCabecalho.ValorTotal.Value);
                    registroC100.setIndPgto(NFeCabecalho.IndicadorFormaPagamento.Value.ToString());
                    registroC100.setVlDesc(NFeCabecalho.ValorDesconto.Value);
                    registroC100.setVlAbatNt(0);
                    registroC100.setVlMerc(NFeCabecalho.ValorTotalProdutos.Value);

                    NfeTransporteDTO Transporte = new NHibernateDAL<NfeTransporteDTO>(Session).SelectId<NfeTransporteDTO>(1);

                    if (Transporte != null) {
                        registroC100.setIndFrt(Transporte.ModalidadeFrete.Value.ToString());
                    }

                    registroC100.setVlFrt(NFeCabecalho.ValorFrete.Value);
                    registroC100.setVlSeg(NFeCabecalho.ValorSeguro.Value);
                    registroC100.setVlOutDa(NFeCabecalho.ValorDespesasAcessorias.Value);
                    registroC100.setVlBcIcms(NFeCabecalho.BaseCalculoIcms.Value);
                    registroC100.setVlIcms(NFeCabecalho.ValorIcms.Value);
                    registroC100.setVlBcIcmsSt(NFeCabecalho.BaseCalculoIcmsSt.Value);
                    registroC100.setVlIcmsSt(NFeCabecalho.ValorIcmsSt.Value);
                    registroC100.setVlIpi(NFeCabecalho.ValorIpi.Value);
                    registroC100.setVlPis(NFeCabecalho.ValorPis.Value);
                    registroC100.setVlPisSt(0);
                    registroC100.setVlCofins(NFeCabecalho.ValorCofins.Value);
                    registroC100.setVlCofinsSt(0);

                    // REGISTRO C110: COMPLEMENTO  DO  DOCUMENTO  -  INFORMA��O  COMPLEMENTAR  DA NOTA FISCAL (C�DIGOS 01, 1B, 04 e 55)
                    //{ N�o Implementado }

                    // REGISTRO C111: PROCESSO REFERENCIADO
                    //{ N�o Implementado }

                    // REGISTRO  C120:  COMPLEMENTO  DO  DOCUMENTO  -  OPERA��ES DE  IMPORTA��O (C�DIGO 01)
                    //{ N�o Implementado }

                    
                    // REGISTRO  C170:  COMPLEMENTO  DO  DOCUMENTO  -  ITENS  DO  DOCUMENTO (C�DIGOS 01, 1B, 04 e 55)
                    consultaSql = "from ViewSpedNfeDetalheDTO where IdNfeCabecalho = " + NFeCabecalho.Id;
                    IList<ViewSpedNfeDetalheDTO> ListaNFeDetalhe = new NHibernateDAL<ViewSpedNfeDetalheDTO>(Session).SelectListaSql<ViewSpedNfeDetalheDTO>(consultaSql);
                    RegistroC170 registroC170;
                    if (ListaNFeDetalhe != null)
                    {
                        foreach (ViewSpedNfeDetalheDTO NFeDetalhe in ListaNFeDetalhe)
                        {
                            registroC170 = new RegistroC170();

                            registroC170.setNumItem(NFeDetalhe.NumeroItem.ToString());
                            registroC170.setCodItem(NFeDetalhe.Gtin);
                            registroC170.setDescrCompl(NFeDetalhe.NomeProduto);
                            registroC170.setQtd(NFeDetalhe.QuantidadeComercial);
                            registroC170.setUnid(Convert.ToString(NFeDetalhe.IdUnidadeProduto));
                            registroC170.setVlItem(NFeDetalhe.ValorTotal);
                            registroC170.setVlDesc(NFeDetalhe.ValorDesconto);
                            registroC170.setIndMov(0);
                            registroC170.setCstIcms(NFeDetalhe.CstIcms);
                            registroC170.setCfop(Convert.ToString(NFeDetalhe.Cfop));
                            registroC170.setCodNat(Convert.ToString(NFeDetalhe.IdTributOperacaoFiscal));
                            registroC170.setVlBcIcms(NFeDetalhe.BaseCalculoIcms);
                            registroC170.setAliqIcms(NFeDetalhe.AliquotaIcms);
                            registroC170.setVlIcms(NFeDetalhe.ValorIcms);
                            registroC170.setVlBcIcmsSt(NFeDetalhe.ValorBaseCalculoIcmsSt);
                            registroC170.setAliqSt(NFeDetalhe.AliquotaIcmsSt);
                            registroC170.setVlIcmsSt(NFeDetalhe.ValorIcmsSt);
                            registroC170.setIndApur(0);
                            registroC170.setCstIpi(NFeDetalhe.CstIpi);
                            registroC170.setCodEnq(NFeDetalhe.EnquadramentoIpi);
                            registroC170.setVlBcIpi(NFeDetalhe.ValorBaseCalculoIpi);
                            registroC170.setAliqIpi(NFeDetalhe.AliquotaIpi);
                            registroC170.setVlIpi(NFeDetalhe.ValorIpi);
                            registroC170.setCstPis(NFeDetalhe.CstPis);
                            registroC170.setVlBcPis(NFeDetalhe.ValorBaseCalculoPis);
                            registroC170.setAliqPisPerc(NFeDetalhe.AliquotaPisPercentual);
                            registroC170.setQuantBcPis(NFeDetalhe.QuantidadeVendidaPis);
                            registroC170.setAliqPisR(NFeDetalhe.AliquotaPisReais);
                            registroC170.setVlPis(NFeDetalhe.ValorPis);
                            registroC170.setCstCofins(NFeDetalhe.CstCofins);
                            registroC170.setVlBcCofins(NFeDetalhe.BaseCalculoCofins);
                            registroC170.setAliqCofinsPerc(NFeDetalhe.AliquotaCofinsPercentual);
                            registroC170.setQuantBcCofins(NFeDetalhe.QuantidadeVendidaCofins);
                            registroC170.setAliqCofinsR(NFeDetalhe.AliquotaCofinsReais);
                            registroC170.setVlCofins(NFeDetalhe.ValorCofins);
                            registroC170.setCodCta("");

                            registroC100.getRegistroC170List().Add(registroC170);
                        }
                    }

                    // REGISTRO C175: REGISTRO ANAL�TICO DO DOCUMENTO (C�DIGO 65)
                    // { Ser� analisado ap�s a implementa��o da NFC-e }

                    // REGISTRO C180: CONSOLIDA��O  DE  NOTAS  FISCAIS  ELETR�NICAS  EMITIDAS PELA PESSOA JUR�DICA (C�DIGOS 55 e 65) � OPERA��ES DE VENDAS
                    // REGISTRO C181: DETALHAMENTO DA CONSOLIDA��O � OPERA��ES DE VENDAS � PIS/PASEP
                    // REGISTRO C185: DETALHAMENTO DA CONSOLIDA��O � OPERA��ES DE VENDAS � COFINS
                    // REGISTRO C188: PROCESSO REFERENCIADO
                    // { N�o Implementados }

                    // REGISTRO C190: CONSOLIDA��O DE NOTAS FISCAIS ELETR�NICAS (C�DIGO 55) � OPERA��ES  DE  AQUISI��O  COM  DIREITO  A  CR�DITO,  E  OPERA��ES  DE DEVOLU��O DE COMPRAS E VENDAS.
                    // REGISTRO C191:  DETALHAMENTO  DA  CONSOLIDA��O  �  OPERA��ES  DE AQUISI��O  COM  DIREITO  A  CR�DITO,  E  OPERA��ES  DE  DEVOLU��O  DE COMPRAS E VENDAS � PIS/PASEP
                    // REGISTRO C195:  DETALHAMENTO  DA  CONSOLIDA��O  -  OPERA��ES  DE AQUISI��O  COM  DIREITO  A  CR�DITO,  E  OPERA��ES  DE  DEVOLU��O  DE COMPRAS E VENDAS � COFINS
                    // REGISTRO C198: PROCESSO REFERENCIADO
                    // REGISTRO C199: COMPLEMENTO DO DOCUMENTO - OPERA��ESDE IMPORTA��O (C�DIGO 55)
                    // { N�o Implementados }
                }
               
            }


            // REGISTRO  C380:  NOTA  FISCAL  DE  VENDA  A  CONSUMIDOR  (C�DIGO  02)  - CONSOLIDA��O DE DOCUMENTOS EMITIDOS.
            consultaSql = "from ViewSpedC300DTO where DataEmissao BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal);
            IList<ViewSpedC300DTO> ListaC300 = new NHibernateDAL<ViewSpedC300DTO>(Session).SelectListaSql<ViewSpedC300DTO>(consultaSql);
            if (ListaC300 != null)
            {
                RegistroC380 registroC380;
                foreach (ViewSpedC300DTO C380 in ListaC300)
                {
                    registroC380 = new RegistroC380();
                    registroC380.setCodMod("2");
                    registroC380.setNumDocIni(C380.Id.ToString()); // Como pegar o n�mero inicial?
                    registroC380.setNumDocFin(C380.Id.ToString()); // Como pegar o n�mero Final?
                    registroC380.setDtDocIni(C380.DataEmissao); // Como pegar a data inicial?
                    registroC380.setDtDocFin(C380.DataEmissao); // Como pegar a data Final?
                    registroC380.setVlDoc(C380.SomaTotalNf);
                    registroC380.setvlDocCanc(C380.SomaTotalNf); // Como pegar os valores cancelados?

                    // REGISTRO C381: DETALHAMENTO DA CONSOLIDA��O � PIS/P ASEP
                    // REGISTRO C385: DETALHAMENTO DA CONSOLIDA��O � COFINS
                    // { Exerc�cio: implementar }

                    // REGISTRO C395: NOTAS FISCAIS DE VENDA A CONSUMIDOR(C�DIGOS 02, 2D, 2E e 59) � AQUISI��ES/ENTRADAS COM CR�DITO.
                    // REGISTRO C396:  ITENS  DO  DOCUMENTO  (C�DIGOS  02,  2D,  2E  e  59)  � AQUISI��ES/ENTRADAS COM CR�DITO
                    // { N�o Implementados }

                }
            }


            IList<EcfImpressoraDTO> ListaImpressora = new NHibernateDAL<EcfImpressoraDTO>(Session).Select(new EcfImpressoraDTO());
            if (ListaImpressora != null)
            {
                RegistroC400 registroC400;
                foreach (EcfImpressoraDTO Impressora in ListaImpressora)
                {
                    // REGISTRO C400: EQUIPAMENTO ECF (C�DIGO 02, 2D e 60).
                    registroC400 = new RegistroC400();

                    registroC400.setCodMod(Impressora.ModeloDocumentoFiscal);
                    registroC400.setEcfMod(Impressora.Modelo);
                    registroC400.setEcfFab(Impressora.Serie);
                    registroC400.setEcfCx(Impressora.Numero.ToString());

                    // verifica se existe movimento no periodo para aquele ECF
                    consultaSql = "from EcfR02DTO where IdImpressora=" + Impressora.Id + " and DataEmissao BETWEEN " + Biblioteca.QuotedStr(DataInicial) + " and " + Biblioteca.QuotedStr(DataFinal);
                    IList<EcfR02DTO> ListaR02 = new NHibernateDAL<EcfR02DTO>(Session).SelectListaSql<EcfR02DTO>(consultaSql);
                    if (ListaR02 != null)
                    {
                        // REGISTRO C405: REDU��O Z (C�DIGO 02, 2D e 60).
                        RegistroC405 registroC405;
                        foreach (EcfR02DTO R02 in ListaR02)
                        {
                            registroC405 = new RegistroC405();

                            registroC405.setDtDoc(R02.DataMovimento.Value);
                            registroC405.setCro(R02.Cro.Value);
                            registroC405.setCrz(R02.Crz.Value);
                            registroC405.setNumCooFin(R02.Coo.Value);
                            registroC405.setGtFin(R02.GrandeTotal.Value);
                            registroC405.setVlBrt(R02.VendaBruta.Value);

                            // REGISTRO C481: RESUMO DI�RIO DE DOCUMENTOS EMITIDOSPOR ECF � PIS/PASEP (C�DIGOS 02 e 2D).
                            // REGISTRO C485: RESUMO DI�RIO DE DOCUMENTOS EMITIDOSPOR ECF � COFINS (C�DIGOS 02 e 2D)
                            // {Exerc�cio: Implementar}                           

                            
                            registroC400.getRegistroC405List().Add(registroC405);
                        }

                        // REGISTRO C489: PROCESSO REFERENCIADO
                        // { N�o Implementado }

                        // REGISTRO C490: CONSOLIDA��O DE DOCUMENTOS EMITIDOS  POR ECF (C�DIGOS 02, 2D, 59 e 60)
                        // REGISTRO C491:  DETALHAMENTO  DA CONSOLIDA��O DE DOCUMENTOS EMITIDOS POR ECF (C�DIGOS 02, 2D e 59) � PIS/PASEP
                        // REGISTRO C495:  DETALHAMENTO  DA CONSOLIDA��O DE DOCUMENTOS EMITIDOS POR ECF (C�DIGOS 02, 2D e 59) � COFINS
                        // REGISTRO C499: PROCESSO REFERENCIADO
                        // { N�o Implementados }
                    }

                    // REGISTRO C495: RESUMO MENSAL DE ITENS DO ECF POR ESTABELECIMENTO (C�DIGO 02 e 2D).
                    // Implementado a crit�rio do Participante do T2Ti ERP
                }
            }

            // REGISTRO C500:  NOTA  FISCAL/CONTA  DE  ENERGIA  EL�TRICA  (C�DIGO  06),  NOTA FISCAL/CONTA  DE  FORNECIMENTO  D'�GUA  CANALIZADA  (C�DIGO  29)  E  NOTA  FISCAL CONSUMO  FORNECIMENTO  DE  G�S  (C�DIGO  28)  E  NF-e  (C�DIGO  55)�  DOCUMENTOS  DE ENTRADA/AQUISI��O COM CR�DITO
            // REGISTRO C501: COMPLEMENTO DA OPERA��O (C�DIGOS 06,28 e 29) � PIS/PASEP
            // REGISTRO C505: COMPLEMENTO DA OPERA��O (C�DIGOS 06,28 e 29) � COFINS
            // REGISTRO C509: PROCESSO REFERENCIADO
            // REGISTRO C600:  CONSOLIDA��O  DI�RIA  DE  NOTAS  FISCAIS/CONTAS  EMITIDAS  DE ENERGIA  EL�TRICA  (C�DIGO  06),  NOTA  FISCAL/CONTA  DE  FORNECIMENTO  D'�GUA CANALIZADA (C�DIGO 29) E NOTA FISCAL/CONTA DE FORNECIMENTO DE G�S (C�DIGO 28) (EMPRESAS OBRIGADAS OU N�O OBRIGADAS AO CONVENIO ICMS 115/03) � DOCUMENTOS DE SA�DA
            // REGISTRO C601: COMPLEMENTO DA CONSOLIDA��O DI�RIA (C�DIGOS 06, 28 e 29) � DOCUMENTOS DE SA�DAS - PIS/PASEP
            // REGISTRO C605: COMPLEMENTO DA CONSOLIDA��O DI�RIA (C�DIGOS 06, 28 e 29) � DOCUMENTOS DE SA�DAS � COFINS
            // REGISTRO C609: PROCESSO REFERENCIADO
            // { N�o Implementados }

            // REGISTRO C800: CUPOM FISCAL ELETR�NICO (C�DIGO 59)
            // REGISTRO C810:  DETALHAMENTO  DO  CUPOM  FISCAL  ELETR�NICO  (C�DIGO  59)  � PIS/PASEP E COFINS
            // REGISTRO C820:  DETALHAMENTO  DO  CUPOM  FISCAL  ELETR�NICO  (C�DIGO  59)  � PIS/PASEP E COFINS APURADO POR UNIDADE DE MEDIDA DEPRODUTO
            // REGISTRO C830: PROCESSO RERENCIADO
            // REGISTRO C860: IDENTIFICA��O DO EQUIPAMENTO SAT-CF-E
            // REGISTRO C870:  RESUMO  DI�RIO  DE  DOCUMENTOS  EMITIDOS POR  EQUIPAMENTO SAT-CF-E (C�DIGO 59) � PIS/PASEP E COFINS
            // REGISTRO C880:  RESUMO  DI�RIO  DE  DOCUMENTOS  EMITIDOS POR  EQUIPAMENTO SAT-CF-E (C�DIGO 59) � PIS/PASEP E COFINS APURADO POR UNIDADE DE MEDIDA DE PRODUTO
            // REGISTRO C890: PROCESSO REFERENCIADO
            // (* Ser�o analisados ap�s implementa��o do SAT *)

        }
        #endregion

        #region BLOCO D: DOCUMENTOS FISCAIS II - SERVI�OS (ICMS)
        public void GerarBlocoD()
        {
            sped.getBlocoD().getRegistroD001().setIndMov(1); //sem dados
        }
        #endregion

        #region BLOCO F: DEMAIS DOCUMENTOS E OPERA��ES
        public void GerarBlocoF()
        {
            sped.getBlocoF().getRegistroF001().setIndMov(1); //sem dados
        }
        #endregion

        #region BLOCO I: OPERA��ES DAS INSTITUI��ES FINANCEIRAS, SEGURADORAS, ENTIDADES DE  PREVIDENCIA  PRIVADA,  OPERADORAS  DE  PLANOS  DE  ASSIST�NCIA  � SA�DE E DEMAIS PESSOAS JUR�DICAS REFERIDAS NOS �� 6�, 8�E 9�DO ART. 3�DA LEI n�9.718/98'}
        public void GerarBlocoI()
        {
            sped.getBlocoI().getRegistroI001().setIndMov(1); //sem dados
        }
        #endregion

        #region BLOCO M: APURA��O  DA  CONTRIBUI��O  E  CR�DITO  DO  PIS/PASEP  E DA COFINS'}
        public void GerarBlocoM()
        {
            sped.getBlocoM().getRegistroM001().setIndMov(1); //sem dados
        }
        #endregion

        #region BLOCO 1: OUTRAS INFORMA��ES
        public void GerarBloco1()
        {
            sped.getBloco1().getRegistro1001().setIndMov(1); //sem dados
        }
        #endregion

        #region Gerar Arquivo
        public bool GerarArquivoSpedContribuicoes(string pDataIni, string pDataFim, int pVersao, int pTipoEscrituracao, int pIdEmpresa, int pIdContador)
        {
            VersaoLeiaute = pVersao;
            TipoEscrituracao = pTipoEscrituracao;
            DataInicial = System.DateTime.Parse(pDataIni).ToString("yyyy-MM-dd");
            DataFinal = System.DateTime.Parse(pDataFim).ToString("yyyy-MM-dd");
            IdEmpresa = pIdEmpresa;
            IdContador = pIdContador;

            using (Session = NHibernateHelper.GetSessionFactory().OpenSession())
            {
                // BLOCO 0: ABERTURA, IDENTIFICA��O E REFER�NCIAS
                GerarBloco0();

                // BLOCO A: DOCUMENTOS FISCAIS - SERVI�OS (N�O SUJEITOS AO ICMS)
                /*
                  Ser� analisado ap�s a implementa��o da NFS-e
                  Exerc�cio:
                    Analisar como implementar com dados de um NF-e de servi�o.
                */
                GerarBlocoA();

                // BLOCO C: DOCUMENTOS FISCAIS I - MERCADORIAS (ICMS/IPI
                GerarBlocoC();

                // BLOCO D: DOCUMENTOS FISCAIS II - SERVI�OS (ICMS).
                // Estabelecimentos  que  efetivamente  tenham realizado as opera��es especificadas no Bloco D (presta��o ou contrata��o), relativas a servi�os de transporte de cargas e/ou de passageiros, servi�os de comunica��o e de telecomunica��o, mediante emiss�o de documento fiscal definido pela legisla��o do ICMS e do IPI, que devam ser escrituradas no Bloco D.
                // N�o Implementado 
                GerarBlocoD();

                // BLOCO F: DEMAIS DOCUMENTOS E OPERA��ES
                // Neste  bloco  ser�o  informadas  pela  pessoa  jur�dica,  as  demais  opera��es  geradoras  de  contribui��o  ou  de cr�dito,  n�o informadas nos Blocos A, C e D
                // N�o Implementado 
                GerarBlocoF();

                // BLOCO I: OPERA��ES DAS INSTITUI��ES FINANCEIRAS, SEGURADORAS, ENTIDADES DE  PREVIDENCIA  PRIVADA,  OPERADORAS  DE  PLANOS  DE  ASSIST�NCIA  � SA�DE E DEMAIS PESSOAS JUR�DICAS REFERIDAS NOS �� 6�, 8�E 9�DO ART. 3�DA LEI n�9.718/98.
                // N�o Implementado 
                GerarBlocoI();

                // BLOCO  M: APURA��O  DA  CONTRIBUI��O  E  CR�DITO  DO  PIS/PASEP  E DA COFINS
                // Gerado pelo PVA 
                GerarBlocoM();

                // BLOCO P: APURA��O DA CONTRIBUI��O PREVIDENCI�RIA SOBRE A RECEITA BRUTA (CPRB)
                // N�o Implementado 

                // BLOCO 1: COMPLEMENTO DA ESCRITURA��O � CONTROLE DE  SALDOS DE  CR�DITOS  E  DE  RETEN��ES,  OPERA��ES  EXTEMPOR�NEAS E OUTRAS INFORMA��ES
                // N�o Implementado 
                GerarBloco1();
            }

            sped.geraArquivoTxt("SpedContribuicoes.txt");
            return true;
        }
        #endregion

    }

}
