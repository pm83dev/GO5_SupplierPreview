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
    
    public partial class TipiServizio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipiServizio()
        {
            this.Servizi = new HashSet<Servizi>();
            this.Servizi_TEMP = new HashSet<Servizi_TEMP>();
            this.Servizi2 = new HashSet<Servizi2>();
            this.TipiServizio1 = new HashSet<TipiServizio>();
            this.TipiServizio2 = new HashSet<TipiServizio>();
        }
    
        public int TipoServizioID { get; set; }
        public string TipoServizioCod { get; set; }
        public string NomeTipoServizio { get; set; }
        public long Descrizione { get; set; }
        public Nullable<long> NoteVoucher { get; set; }
        public string NotaInterna { get; set; }
        public short IdCategoria { get; set; }
        public string TipoPrezzoAcquisto { get; set; }
        public string TipoPrezzoVendita { get; set; }
        public bool IsInclusoInRicerche { get; set; }
        public bool IsSupplementare { get; set; }
        public bool IsAttivo { get; set; }
        public bool IsDescServizioInOfferta { get; set; }
        public bool IsImgServizioInOfferta { get; set; }
        public bool IsDescFornInOfferta { get; set; }
        public bool IsImgFornInOfferta { get; set; }
        public bool IsDescDestInOfferta { get; set; }
        public bool IsImgDestInOfferta { get; set; }
        public bool FlagDataOpzioneFornitore { get; set; }
        public bool FlagCheckUnGiornoPrima { get; set; }
        public bool FlagAmmetteValutazione { get; set; }
        public bool FlagStampaVoucher { get; set; }
        public bool FlagAmmetteTassaSoggiorno { get; set; }
        public bool FlagNonSoggettaACommissioni { get; set; }
        public bool FlagNecessariaListaNominativa { get; set; }
        public bool FlagNecessarioNumPax { get; set; }
        public bool FlagSoloPerSingola { get; set; }
        public bool FlagNomeFornInDocs { get; set; }
        public bool FlagIndirFornInDocs { get; set; }
        public bool FlagIndicaFornInDocs { get; set; }
        public bool FlagStampaInDayByDay { get; set; }
        public bool FlagZTL { get; set; }
        public string OperUltAgg { get; set; }
        public System.DateTime DataUltAgg { get; set; }
        public string GratuitaID { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        public virtual Gratuita Gratuita { get; set; }
        public virtual Operatori Operatori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servizi> Servizi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servizi_TEMP> Servizi_TEMP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servizi2> Servizi2 { get; set; }
        public virtual Stringhe Stringhe { get; set; }
        public virtual Stringhe Stringhe1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipiServizio> TipiServizio1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipiServizio> TipiServizio2 { get; set; }
    }
}
