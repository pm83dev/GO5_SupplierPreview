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
    
    public partial class SezioniOrdine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SezioniOrdine()
        {
            this.ElementiOrdine = new HashSet<ElementiOrdine>();
            this.OrdiniTotaliSezioni = new HashSet<OrdiniTotaliSezioni>();
            this.ScaglioniSezioneOrdine = new HashSet<ScaglioniSezioneOrdine>();
        }
    
        public int AnnoPratica { get; set; }
        public int NumPratica { get; set; }
        public short NumSezione { get; set; }
        public string DescrizioneSezione { get; set; }
        public Nullable<double> PrezzoVendita { get; set; }
        public bool FlagPrezzoAPacchetto { get; set; }
        public Nullable<short> NumOffertaRif { get; set; }
        public Nullable<short> NumSezioneOffertaRif { get; set; }
        public bool FlagServiziSoloCosto { get; set; }
        public bool FlagAttiva { get; set; }
        public bool FlagFacoltativa { get; set; }
        public bool FlagDayByDay { get; set; }
        public short ProgSezione { get; set; }
        public bool IsNoCommissione { get; set; }
        public bool FlagScaglioni { get; set; }
        public string GratuitaID { get; set; }
        public Nullable<short> NumMinPax { get; set; }
        public Nullable<double> MargineTarget { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementiOrdine> ElementiOrdine { get; set; }
        public virtual Gratuita Gratuita { get; set; }
        public virtual Offerte Offerte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdiniTotaliSezioni> OrdiniTotaliSezioni { get; set; }
        public virtual Pratiche Pratiche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScaglioniSezioneOrdine> ScaglioniSezioneOrdine { get; set; }
    }
}
