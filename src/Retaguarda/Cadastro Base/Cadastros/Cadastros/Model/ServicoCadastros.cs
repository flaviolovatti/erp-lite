using Cadastros.ServidorReference;
using SearchWindow.Attributes;
using System.Collections.Generic;

namespace Cadastros.Model
{
    public class ServicoCadastros : ServiceServidor
    {

        [SearchWindowDataSource(typeof(Produto), new string[] { "Id", "Nome" }, new string[] { "Id", "Nome" })]
        public new IList<Produto> SelectProduto(Produto dtoPesquisa)
        {
            return base.SelectProduto(dtoPesquisa);
        }

        /*
        [SearchWindowDataSource(typeof(CboDTO), new string[] { "Id", "Nome", "Codigo", "Codigo1994" }, new string[] { "Id", "Nome", "Codigo", "Codigo1994" })]
        public new IList<CboDTO> SelectCbo(CboDTO dtoPesquisa)
        {
            return base.SelectCbo(dtoPesquisa);
        }
        */
        [SearchWindowDataSource(typeof(AtividadeFornecedorCliente))]
        public new IList<AtividadeFornecedorCliente> SelectAtividadeFornecedorCliente(AtividadeFornecedorCliente atividadeforcli)
        {
            return base.SelectAtividadeFornecedorCliente(atividadeforcli);
        }

        /*
        [SearchWindowDataSource(typeof(SituacaoForCliDTO))]
        public new IList<SituacaoForCliDTO> SelectSituacaoForCli(SituacaoForCliDTO situacaoforcli)
        {
            return base.SelectSituacaoForCli(situacaoforcli);
        }
        */

        [SearchWindowDataSource(typeof(EstadoCivil))]
        public new IList<EstadoCivil> SelectEstadoCivil(EstadoCivil estadocivil)
        {
            return base.SelectEstadoCivil(estadocivil);
        }

        /*
        [SearchWindowDataSource(typeof(ContabilContaDTO))]
        public new IList<ContabilContaDTO> SelectContabilConta(ContabilContaDTO ContabilConta)
        {
            return base.SelectContabilConta(ContabilConta);
        }
        */

        /*
        [SearchWindowDataSource(typeof(TributOperacaoFiscalDTO))]
        public new IList<TributOperacaoFiscalDTO> SelectTributOperacaoFiscal(TributOperacaoFiscalDTO TributOperacaoFiscal)
        {
            return base.SelectTributOperacaoFiscal(TributOperacaoFiscal);
        }
        */

        /*
        [SearchWindowDataSource(typeof(SetorDTO))]
        public new IList<SetorDTO> SelectSetor(SetorDTO Setor)
        {
            return base.SelectSetor(Setor);
        }
        */

        [SearchWindowDataSource(typeof(Cargo))]
        public new IList<Cargo> SelectCargo(Cargo Cargo)
        {
            return base.SelectCargo(Cargo);
        }

        /*
        [SearchWindowDataSource(typeof(NivelFormacaoDTO))]
        public new IList<NivelFormacaoDTO> SelectNivelFormacao(NivelFormacaoDTO NivelFormacao)
        {
            return base.SelectNivelFormacao(NivelFormacao);
        }


        [SearchWindowDataSource(typeof(TipoColaboradorDTO))]
        public new IList<TipoColaboradorDTO> SelectTipoColaborador(TipoColaboradorDTO TipoColaborador)
        {
            return base.SelectTipoColaborador(TipoColaborador);
        }

        [SearchWindowDataSource(typeof(SituacaoColaboradorDTO))]
        public new IList<SituacaoColaboradorDTO> SelectSituacaoColaborador(SituacaoColaboradorDTO SituacaoColaborador)
        {
            return base.SelectSituacaoColaborador(SituacaoColaborador);
        }

        [SearchWindowDataSource(typeof(SindicatoDTO))]
        public new IList<SindicatoDTO> SelectSindicato(SindicatoDTO Sindicato)
        {
            return base.SelectSindicato(Sindicato);
        }

        [SearchWindowDataSource(typeof(ProdutoGrupoDTO))]
        public new IList<ProdutoGrupoDTO> SelectProdutoGrupo(ProdutoGrupoDTO ProdutoGrupo)
        {
            return base.SelectProdutoGrupo(ProdutoGrupo);
        }
        */

        [SearchWindowDataSource(typeof(ProdutoSubGrupo))]
        public new IList<ProdutoSubGrupo> SelectProdutoSubGrupo(ProdutoSubGrupo ProdutoSubGrupo)
        {
            return base.SelectProdutoSubGrupo(ProdutoSubGrupo);
        }

        [SearchWindowDataSource(typeof(ProdutoMarca))]
        public new IList<ProdutoMarca> SelectProdutoMarca(ProdutoMarca ProdutoMarca)
        {
            return base.SelectProdutoMarca(ProdutoMarca);
        }

        [SearchWindowDataSource(typeof(Tribut_GrupoTributario))]
        public new IList<Tribut_GrupoTributario> SelectTribut_GrupoTributario(Tribut_GrupoTributario Tribut_GrupoTributario)
        {
            return base.SelectTribut_GrupoTributario(Tribut_GrupoTributario);
        }

        [SearchWindowDataSource(typeof(Almoxarifado))]
        public new IList<Almoxarifado> SelectAlmoxarifado(Almoxarifado Almoxarifado)
        {
            return base.SelectAlmoxarifado(Almoxarifado);
        }

        [SearchWindowDataSource(typeof(UnidadeProduto))]
        public new IList<UnidadeProduto> SelectUnidadeProduto(UnidadeProduto UnidadeProduto)
        {
            return base.SelectUnidadeProduto(UnidadeProduto);
        }

        [SearchWindowDataSource(typeof(Tribut_ICMSCustomCabecalho))]
        public new IList<Tribut_ICMSCustomCabecalho> SelectTribut_ICMSCustomCabecalho(Tribut_ICMSCustomCabecalho Tribut_ICMSCustomCabecalho)
        {
            return base.SelectTribut_ICMSCustomCabecalho(Tribut_ICMSCustomCabecalho);
        }
    }
}
