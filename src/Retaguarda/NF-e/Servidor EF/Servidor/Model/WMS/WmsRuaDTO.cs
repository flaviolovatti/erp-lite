using System;
using System.Text;
using System.Collections.Generic;


namespace Servidor.Model {
    
    public class WmsRuaDTO {
        public WmsRuaDTO() { }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public System.Nullable<int> QuantidadeEstante { get; set; }
    }
}
