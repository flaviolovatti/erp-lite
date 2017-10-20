namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fornecedor")]
    public partial class Fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedor()
        {
            compra_fornecedor_cotacao = new HashSet<CompraFornecedorCotacao>();
            compra_pedido = new HashSet<CompraPedido>();
            fin_lancamento_pagar = new HashSet<FIN_LancamentoPagar>();
            fin_pagamento_fixo = new HashSet<FIN_PagamentoFixo>();
            fornecedor_produto = new HashSet<FornecedorProduto>();
            nfe_cabecalho = new HashSet<NFe_Cabecalho>();
        }

        public int id { get; set; }

        public int id_pessoa { get; set; }

        public int id_atividade_for_cli { get; set; }

        public int id_situacao_for_cli { get; set; }

        [Column(TypeName = "date")]
        public DateTime? desde { get; set; }

        [StringLength(1)]
        public string optante_simples_nacional { get; set; }

        [StringLength(1)]
        public string localizacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [StringLength(1)]
        public string sofre_retencao { get; set; }

        [StringLength(100)]
        public string cheque_nominal_a { get; set; }

        public string observacao { get; set; }

        [StringLength(30)]
        public string conta_remetente { get; set; }

        public int? prazo_medio_entrega { get; set; }

        [StringLength(1)]
        public string gera_faturamento { get; set; }

        public int? num_dias_primeiro_vencimento { get; set; }

        public int? num_dias_intervalo { get; set; }

        public int? quantidade_parcelas { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        public virtual AtividadeFornecedorCliente atividade_for_cli { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraFornecedorCotacao> compra_fornecedor_cotacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraPedido> compra_pedido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LancamentoPagar> fin_lancamento_pagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PagamentoFixo> fin_pagamento_fixo { get; set; }

        public virtual Pessoa pessoa { get; set; }

        public virtual SituacaoFornecedorCliente situacao_for_cli { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FornecedorProduto> fornecedor_produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Cabecalho> nfe_cabecalho { get; set; }
    }
}
