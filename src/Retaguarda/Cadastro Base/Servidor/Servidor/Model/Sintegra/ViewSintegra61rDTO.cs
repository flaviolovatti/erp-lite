using System;
using System.Text;
using System.Collections.Generic;


namespace Servidor.Model {
    
    public class ViewSintegra61rDTO {
        public ViewSintegra61rDTO() { }
        public int Id { get; set; }
        public string Gtin { get; set; }
        public System.Nullable<System.DateTime> DataEmissao { get; set; }
        public System.Nullable<int> MesEmissao { get; set; }
        public System.Nullable<int> AnoEmissao { get; set; }
        public string EcfIcmsSt { get; set; }
        public System.Nullable<decimal> SomaQuantidade { get; set; }
        public System.Nullable<decimal> SomaItem { get; set; }
        public System.Nullable<decimal> SomaBaseIcms { get; set; }
    }
}
