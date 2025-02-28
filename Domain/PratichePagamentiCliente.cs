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
    
    public partial class PratichePagamentiCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PratichePagamentiCliente()
        {
            this.Scadenze = new HashSet<Scadenze>();
        }
    
        public int AnnoPratica { get; set; }
        public int NumPratica { get; set; }
        public short PraticaPagamentoPrevistoID { get; set; }
        public Nullable<System.DateTime> DataPrevista { get; set; }
        public Nullable<double> ImportoPrevisto { get; set; }
        public bool FlagImportoFissato { get; set; }
        public Nullable<double> PercentualePrevista { get; set; }
        public string Note { get; set; }
        public string IdFatturaAdhoc { get; set; }
        public Nullable<System.DateTime> DataEffettiva { get; set; }
        public Nullable<double> ImportoEffettivo { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<int> PagamentoID { get; set; }
        public Nullable<short> PagamentoRigaID { get; set; }
        public Nullable<short> TipoPagamentoID { get; set; }
        public Nullable<short> CodEvento { get; set; }
        public bool FlagAcconto { get; set; }
        public Nullable<short> Giorni { get; set; }
        public bool FlagGiorniPrima { get; set; }
        public Nullable<short> CodMezzoPagamento { get; set; }
        public string CodPagamentoOld { get; set; }
    
        public virtual Clienti Clienti { get; set; }
        public virtual CondizioniPagamento CondizioniPagamento { get; set; }
        public virtual Eventi Eventi { get; set; }
        public virtual MezziPagamento MezziPagamento { get; set; }
        public virtual PagamentiRicevutiRighe PagamentiRicevutiRighe { get; set; }
        public virtual Pratiche Pratiche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scadenze> Scadenze { get; set; }
    }
}
