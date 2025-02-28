//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GO5_SupplierPreview.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class PagamentiRicevuti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PagamentiRicevuti()
        {
            this.PagamentiRicevutiRighe = new HashSet<PagamentiRicevutiRighe>();
        }
    
        public int PagamentoID { get; set; }
        public Nullable<System.DateTime> DataDistinta { get; set; }
        public string Banca { get; set; }
        public string FileOrigine { get; set; }
        public string Testo { get; set; }
        public string OperUltAgg { get; set; }
        public System.DateTime DataUltAgg { get; set; }
    
        public virtual Banche Banche { get; set; }
        public virtual Operatori Operatori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagamentiRicevutiRighe> PagamentiRicevutiRighe { get; set; }
    }
}
