namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_TRANSPORTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFE_TRANSPORTE()
        {
            NFE_TRANSPORTE_REBOQUE = new HashSet<NFE_TRANSPORTE_REBOQUE>();
            NFE_TRANSPORTE_VOLUME = new HashSet<NFE_TRANSPORTE_VOLUME>();
        }

        public int ID { get; set; }

        public int? ID_TRANSPORTADORA { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        public int? MODALIDADE_FRETE { get; set; }

        [StringLength(14)]
        public string CPF_CNPJ { get; set; }

        [StringLength(60)]
        public string NOME { get; set; }

        [StringLength(14)]
        public string INSCRICAO_ESTADUAL { get; set; }

        [StringLength(60)]
        public string EMPRESA_ENDERECO { get; set; }

        [StringLength(60)]
        public string NOME_MUNICIPIO { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        public decimal? VALOR_SERVICO { get; set; }

        public decimal? VALOR_BC_RETENCAO_ICMS { get; set; }

        public decimal? ALIQUOTA_RETENCAO_ICMS { get; set; }

        public decimal? VALOR_ICMS_RETIDO { get; set; }

        public int? CFOP { get; set; }

        public int? MUNICIPIO { get; set; }

        [StringLength(7)]
        public string PLACA_VEICULO { get; set; }

        [StringLength(2)]
        public string UF_VEICULO { get; set; }

        [StringLength(20)]
        public string RNTC_VEICULO { get; set; }

        [StringLength(20)]
        public string VAGAO { get; set; }

        [StringLength(20)]
        public string BALSA { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_TRANSPORTE_REBOQUE> NFE_TRANSPORTE_REBOQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_TRANSPORTE_VOLUME> NFE_TRANSPORTE_VOLUME { get; set; }

        public virtual TRANSPORTADORA TRANSPORTADORA { get; set; }
    }
}
