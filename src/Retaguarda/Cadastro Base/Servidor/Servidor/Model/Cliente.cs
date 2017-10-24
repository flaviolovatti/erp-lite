namespace Servidor.Model
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
            fin_cliente_grupo_det = new HashSet<fin_cliente_grupo_det>();
            fin_cobranca = new HashSet<fin_cobranca>();
            fin_lancamento_receber = new HashSet<fin_lancamento_receber>();
            nfe_cabecalho = new HashSet<nfe_cabecalho>();
            venda_cabecalho = new HashSet<venda_cabecalho>();
            venda_orcamento_cabecalho = new HashSet<venda_orcamento_cabecalho>();
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

        public virtual convenio convenio { get; set; }

        public virtual Tribut_OperacaoFiscal tribut_operacao_fiscal { get; set; }

        public virtual Pessoa pessoa { get; set; }

        public virtual regiao regiao { get; set; }

        public virtual situacao_for_cli situacao_for_cli { get; set; }

        public virtual tabela_preco tabela_preco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_cliente_grupo_det> fin_cliente_grupo_det { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_cobranca> fin_cobranca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_lancamento_receber> fin_lancamento_receber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_cabecalho> nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_cabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_orcamento_cabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
