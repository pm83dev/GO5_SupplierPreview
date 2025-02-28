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
    
    public partial class Operatori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operatori()
        {
            this.Clienti = new HashSet<Clienti>();
            this.CollezioniImmagini = new HashSet<CollezioniImmagini>();
            this.Contatti = new HashSet<Contatti>();
            this.Destinazioni = new HashSet<Destinazioni>();
            this.Documenti = new HashSet<Documenti>();
            this.Fornitori = new HashSet<Fornitori>();
            this.Fornitori1 = new HashSet<Fornitori>();
            this.FornitoriValutazioni = new HashSet<FornitoriValutazioni>();
            this.Gratuita = new HashSet<Gratuita>();
            this.Lamentele = new HashSet<Lamentele>();
            this.Lamentele1 = new HashSet<Lamentele>();
            this.Lock = new HashSet<Lock>();
            this.Log = new HashSet<Log>();
            this.Messaggi = new HashSet<Messaggi>();
            this.Note = new HashSet<Note>();
            this.OperatoriAccountEmail = new HashSet<OperatoriAccountEmail>();
            this.OperatoriFunzioni = new HashSet<OperatoriFunzioni>();
            this.Opportunita = new HashSet<Opportunita>();
            this.PagamentiRicevuti = new HashSet<PagamentiRicevuti>();
            this.Parametri = new HashSet<Parametri>();
            this.Pratiche = new HashSet<Pratiche>();
            this.Pratiche1 = new HashSet<Pratiche>();
            this.Pratiche2 = new HashSet<Pratiche>();
            this.Scadenze = new HashSet<Scadenze>();
            this.Servizi = new HashSet<Servizi>();
            this.Servizi2 = new HashSet<Servizi2>();
            this.TasseSoggiorno = new HashSet<TasseSoggiorno>();
            this.TipiServizio = new HashSet<TipiServizio>();
        }
    
        public string OperatoreID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Nullable<short> AreaGadisID { get; set; }
        public Nullable<short> Sede { get; set; }
        public int Livello { get; set; }
        public Nullable<int> AccountEmailEsternoGadisID { get; set; }
        public string Loginfax { get; set; }
        public Nullable<int> AccountEmailInternoGadisID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isAbilitato { get; set; }
        public string NumTelFisso { get; set; }
        public string NumTelMobile { get; set; }
        public string NumFax { get; set; }
        public string TestoFirmaOperatore { get; set; }
        public string AltriContatti { get; set; }
    
        public virtual AccountEmailGadis AccountEmailGadis { get; set; }
        public virtual AccountEmailGadis AccountEmailGadis1 { get; set; }
        public virtual AreeGadis AreeGadis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clienti> Clienti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollezioniImmagini> CollezioniImmagini { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contatti> Contatti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Destinazioni> Destinazioni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documenti> Documenti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fornitori> Fornitori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fornitori> Fornitori1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FornitoriValutazioni> FornitoriValutazioni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gratuita> Gratuita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lamentele> Lamentele { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lamentele> Lamentele1 { get; set; }
        public virtual LivelliUtente LivelliUtente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lock> Lock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log> Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messaggi> Messaggi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Note { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperatoriAccountEmail> OperatoriAccountEmail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperatoriFunzioni> OperatoriFunzioni { get; set; }
        public virtual SediGadis SediGadis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opportunita> Opportunita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagamentiRicevuti> PagamentiRicevuti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parametri> Parametri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pratiche> Pratiche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pratiche> Pratiche1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pratiche> Pratiche2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scadenze> Scadenze { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servizi> Servizi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servizi2> Servizi2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TasseSoggiorno> TasseSoggiorno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipiServizio> TipiServizio { get; set; }
    }
}
