namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COLABORADOR")]
    public partial class COLABORADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COLABORADOR()
        {
            COLABORADOR_RELACIONAMENTO = new HashSet<COLABORADOR_RELACIONAMENTO>();
            COMPRA_REQUISICAO = new HashSet<COMPRA_REQUISICAO>();
            ESTOQUE_REAJUSTE_CABECALHO = new HashSet<ESTOQUE_REAJUSTE_CABECALHO>();
            REQUISICAO_INTERNA_CABECALHO = new HashSet<REQUISICAO_INTERNA_CABECALHO>();
            USUARIO = new HashSet<USUARIO>();
            VENDA_ROMANEIO_ENTREGA = new HashSet<VENDA_ROMANEIO_ENTREGA>();
            VENDEDOR = new HashSet<VENDEDOR>();
        }

        public int ID { get; set; }

        public int? ID_SINDICATO { get; set; }

        public int? ID_TIPO_ADMISSAO { get; set; }

        public int ID_SITUACAO_COLABORADOR { get; set; }

        public int ID_PESSOA { get; set; }

        public int ID_TIPO_COLABORADOR { get; set; }

        public int ID_NIVEL_FORMACAO { get; set; }

        public int ID_CARGO { get; set; }

        public int ID_SETOR { get; set; }

        [StringLength(10)]
        public string MATRICULA { get; set; }

        [Column(TypeName = "text")]
        public string FOTO_34 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ADMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENCIMENTO_FERIAS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_TRANSFERENCIA { get; set; }

        [StringLength(1)]
        public string FGTS_OPTANTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FGTS_DATA_OPCAO { get; set; }

        public int? FGTS_CONTA { get; set; }

        [StringLength(1)]
        public string PAGAMENTO_FORMA { get; set; }

        [StringLength(10)]
        public string PAGAMENTO_BANCO { get; set; }

        [StringLength(10)]
        public string PAGAMENTO_AGENCIA { get; set; }

        [StringLength(1)]
        public string PAGAMENTO_AGENCIA_DIGITO { get; set; }

        [StringLength(10)]
        public string PAGAMENTO_CONTA { get; set; }

        [StringLength(1)]
        public string PAGAMENTO_CONTA_DIGITO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EXAME_MEDICO_ULTIMO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EXAME_MEDICO_VENCIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PIS_DATA_CADASTRO { get; set; }

        [StringLength(12)]
        public string PIS_NUMERO { get; set; }

        [StringLength(10)]
        public string PIS_BANCO { get; set; }

        [StringLength(10)]
        public string PIS_AGENCIA { get; set; }

        [StringLength(1)]
        public string PIS_AGENCIA_DIGITO { get; set; }

        [StringLength(10)]
        public string CTPS_NUMERO { get; set; }

        [StringLength(10)]
        public string CTPS_SERIE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CTPS_DATA_EXPEDICAO { get; set; }

        [StringLength(2)]
        public string CTPS_UF { get; set; }

        [StringLength(1)]
        public string DESCONTO_PLANO_SAUDE { get; set; }

        [StringLength(1)]
        public string SAI_NA_RAIS { get; set; }

        [StringLength(2)]
        public string CATEGORIA_SEFIP { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public int? OCORRENCIA_SEFIP { get; set; }

        public int? CODIGO_ADMISSAO_CAGED { get; set; }

        public int? CODIGO_DEMISSAO_CAGED { get; set; }

        public int? CODIGO_DEMISSAO_SEFIP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_DEMISSAO { get; set; }

        [StringLength(5)]
        public string CODIGO_TURMA_PONTO { get; set; }

        [StringLength(1)]
        public string CAGED_APRENDIZ { get; set; }

        [StringLength(1)]
        public string CAGED_DEFICIENCIA { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO_CONTABIL_CONTA { get; set; }

        public virtual CARGO CARGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLABORADOR_RELACIONAMENTO> COLABORADOR_RELACIONAMENTO { get; set; }

        public virtual NIVEL_FORMACAO NIVEL_FORMACAO { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual SETOR SETOR { get; set; }

        public virtual SITUACAO_COLABORADOR SITUACAO_COLABORADOR { get; set; }

        public virtual SINDICATO SINDICATO { get; set; }

        public virtual TIPO_COLABORADOR TIPO_COLABORADOR { get; set; }

        public virtual TIPO_ADMISSAO TIPO_ADMISSAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_REQUISICAO> COMPRA_REQUISICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTOQUE_REAJUSTE_CABECALHO> ESTOQUE_REAJUSTE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICAO_INTERNA_CABECALHO> REQUISICAO_INTERNA_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_ROMANEIO_ENTREGA> VENDA_ROMANEIO_ENTREGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDEDOR> VENDEDOR { get; set; }
    }
}
