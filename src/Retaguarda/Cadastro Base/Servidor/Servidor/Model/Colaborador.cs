namespace Servidor.Model
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
            colaborador_relacionamento = new HashSet<colaborador_relacionamento>();
            compra_requisicao = new HashSet<compra_requisicao>();
            estoque_reajuste_cabecalho = new HashSet<estoque_reajuste_cabecalho>();
            requisicao_interna_cabecalho = new HashSet<requisicao_interna_cabecalho>();
            usuarios = new HashSet<Usuario>();
            venda_romaneio_entrega = new HashSet<venda_romaneio_entrega>();
            vendedors = new HashSet<vendedor>();
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

        public virtual nivel_formacao nivel_formacao { get; set; }

        public virtual Pessoa pessoa { get; set; }

        public virtual setor setor { get; set; }

        public virtual sindicato sindicato { get; set; }

        public virtual situacao_colaborador situacao_colaborador { get; set; }

        public virtual tipo_admissao tipo_admissao { get; set; }

        public virtual tipo_colaborador tipo_colaborador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<colaborador_relacionamento> colaborador_relacionamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_requisicao> compra_requisicao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estoque_reajuste_cabecalho> estoque_reajuste_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<requisicao_interna_cabecalho> requisicao_interna_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> usuarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_romaneio_entrega> venda_romaneio_entrega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vendedor> vendedors { get; set; }
    }
}
