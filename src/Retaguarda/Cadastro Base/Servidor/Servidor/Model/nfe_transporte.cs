namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_transporte")]
    public partial class nfe_transporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfe_transporte()
        {
            nfe_transporte_reboque = new HashSet<nfe_transporte_reboque>();
            nfe_transporte_volume = new HashSet<nfe_transporte_volume>();
        }

        public int id { get; set; }

        public int? id_transportadora { get; set; }

        public int id_nfe_cabecalho { get; set; }

        public int? modalidade_frete { get; set; }

        [StringLength(14)]
        public string cpf_cnpj { get; set; }

        [StringLength(60)]
        public string nome { get; set; }

        [StringLength(14)]
        public string inscricao_estadual { get; set; }

        [StringLength(60)]
        public string empresa_endereco { get; set; }

        [StringLength(60)]
        public string nome_municipio { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        public decimal? valor_servico { get; set; }

        public decimal? valor_bc_retencao_icms { get; set; }

        public decimal? aliquota_retencao_icms { get; set; }

        public decimal? valor_icms_retido { get; set; }

        public int? cfop { get; set; }

        public int? municipio { get; set; }

        [StringLength(7)]
        public string placa_veiculo { get; set; }

        [StringLength(2)]
        public string uf_veiculo { get; set; }

        [StringLength(20)]
        public string rntc_veiculo { get; set; }

        [StringLength(20)]
        public string vagao { get; set; }

        [StringLength(20)]
        public string balsa { get; set; }

        public virtual nfe_cabecalho nfe_cabecalho { get; set; }

        public virtual transportadora transportadora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_transporte_reboque> nfe_transporte_reboque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_transporte_volume> nfe_transporte_volume { get; set; }
    }
}
