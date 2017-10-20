namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.colaborador")]
    public partial class Colaborador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colaborador()
        {
            colaborador_relacionamento = new HashSet<ColaboradorRelacionamento>();
            compra_requisicao = new HashSet<CompraRequisicao>();
            estoque_reajuste_cabecalho = new HashSet<EstoqueReajusteCabecalho>();
            requisicao_interna_cabecalho = new HashSet<RequisicaoInternaCabecalho>();
            usuarios = new HashSet<Usuario>();
            venda_romaneio_entrega = new HashSet<VendaRomaneioEntrega>();
            vendedors = new HashSet<Vendedor>();
        }

        public int id { get; set; }

        public int? id_sindicato { get; set; }

        public int? id_tipo_admissao { get; set; }

        public int id_situacao_colaborador { get; set; }

        public int id_pessoa { get; set; }

        public int id_tipo_colaborador { get; set; }

        public int id_nivel_formacao { get; set; }

        public int id_cargo { get; set; }

        public int id_setor { get; set; }

        [StringLength(10)]
        public string matricula { get; set; }

        public string foto_34 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_admissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? vencimento_ferias { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_transferencia { get; set; }

        [StringLength(1)]
        public string fgts_optante { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fgts_data_opcao { get; set; }

        public int? fgts_conta { get; set; }

        [StringLength(1)]
        public string pagamento_forma { get; set; }

        [StringLength(10)]
        public string pagamento_banco { get; set; }

        [StringLength(10)]
        public string pagamento_agencia { get; set; }

        [StringLength(1)]
        public string pagamento_agencia_digito { get; set; }

        [StringLength(10)]
        public string pagamento_conta { get; set; }

        [StringLength(1)]
        public string pagamento_conta_digito { get; set; }

        [Column(TypeName = "date")]
        public DateTime? exame_medico_ultimo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? exame_medico_vencimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? pis_data_cadastro { get; set; }

        [StringLength(12)]
        public string pis_numero { get; set; }

        [StringLength(10)]
        public string pis_banco { get; set; }

        [StringLength(10)]
        public string pis_agencia { get; set; }

        [StringLength(1)]
        public string pis_agencia_digito { get; set; }

        [StringLength(10)]
        public string ctps_numero { get; set; }

        [StringLength(10)]
        public string ctps_serie { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ctps_data_expedicao { get; set; }

        [StringLength(2)]
        public string ctps_uf { get; set; }

        [StringLength(1)]
        public string desconto_plano_saude { get; set; }

        [StringLength(1)]
        public string sai_na_rais { get; set; }

        [StringLength(2)]
        public string categoria_sefip { get; set; }

        public string observacao { get; set; }

        public int? ocorrencia_sefip { get; set; }

        public int? codigo_admissao_caged { get; set; }

        public int? codigo_demissao_caged { get; set; }

        public int? codigo_demissao_sefip { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_demissao { get; set; }

        [StringLength(5)]
        public string codigo_turma_ponto { get; set; }

        [StringLength(1)]
        public string caged_aprendiz { get; set; }

        [StringLength(1)]
        public string caged_deficiencia { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        public virtual Cargo cargo { get; set; }

        public virtual NivelFormacao nivel_formacao { get; set; }

        public virtual Pessoa pessoa { get; set; }

        public virtual Setor setor { get; set; }

        public virtual Sindicato sindicato { get; set; }

        public virtual SituacaoColaborador situacao_colaborador { get; set; }

        public virtual TipoAdmissao tipo_admissao { get; set; }

        public virtual TipoColaborador tipo_colaborador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ColaboradorRelacionamento> colaborador_relacionamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraRequisicao> compra_requisicao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstoqueReajusteCabecalho> estoque_reajuste_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequisicaoInternaCabecalho> requisicao_interna_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> usuarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaRomaneioEntrega> venda_romaneio_entrega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendedor> vendedors { get; set; }
    }
}
