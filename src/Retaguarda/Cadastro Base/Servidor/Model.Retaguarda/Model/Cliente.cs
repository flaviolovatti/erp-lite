namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            fin_cliente_grupo_det = new HashSet<FIN_ClienteGrupoDetalhe>();
            fin_cobranca = new HashSet<FIN_Cobranca>();
            fin_lancamento_receber = new HashSet<FIN_LancamentoReceber>();
            nfe_cabecalho = new HashSet<NFe_Cabecalho>();
            venda_cabecalho = new HashSet<VendaCabecalho>();
            venda_orcamento_cabecalho = new HashSet<VendaOrcamentoCabecalho>();
        }

        public int id { get; set; }

        public int? id_regiao { get; set; }

        public int? id_tabela_preco { get; set; }

        public int? id_convenio { get; set; }

        public int? id_operacao_fiscal { get; set; }

        public int id_pessoa { get; set; }

        public int id_atividade_for_cli { get; set; }

        public int id_situacao_for_cli { get; set; }

        [Column(TypeName = "date")]
        public DateTime? desde { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        public string observacao { get; set; }

        [StringLength(30)]
        public string conta_tomador { get; set; }

        [StringLength(1)]
        public string gera_financeiro { get; set; }

        [StringLength(1)]
        public string indicador_preco { get; set; }

        public decimal? porcento_desconto { get; set; }

        [StringLength(1)]
        public string forma_desconto { get; set; }

        public decimal? limite_credito { get; set; }

        [StringLength(1)]
        public string tipo_frete { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        [StringLength(1)]
        public string bloqueado { get; set; }

        public int? dias_bloqueio { get; set; }

        public virtual AtividadeFornecedorCliente atividade_for_cli { get; set; }

        public virtual Convenio convenio { get; set; }

        public virtual Tribut_OperacaoFiscal tribut_operacao_fiscal { get; set; }

        public virtual Pessoa pessoa { get; set; }

        public virtual Regiao regiao { get; set; }

        public virtual SituacaoFornecedorCliente situacao_for_cli { get; set; }

        public virtual TabelaPreco tabela_preco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ClienteGrupoDetalhe> fin_cliente_grupo_det { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_Cobranca> fin_cobranca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LancamentoReceber> fin_lancamento_receber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Cabecalho> nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaCabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaOrcamentoCabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
