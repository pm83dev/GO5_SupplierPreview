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
    
    public partial class S_Clienti
    {
        public int ClienteID { get; set; }
        public int AnnoRilevazione { get; set; }
        public short MeseRilevazione { get; set; }
        public int AnnoPratiche { get; set; }
        public Nullable<double> CostiPraticheFatturate { get; set; }
        public Nullable<double> Fatturato { get; set; }
        public Nullable<double> StimaCostiOfferte { get; set; }
        public Nullable<double> StimaRicaviOfferte { get; set; }
        public Nullable<double> StimaCostiOrdinate { get; set; }
        public Nullable<double> StimaRicaviOrdinate { get; set; }
        public Nullable<short> PraticheRegistrate { get; set; }
        public Nullable<short> PraticheOfferte { get; set; }
        public Nullable<short> PraticheOrdinate { get; set; }
        public Nullable<short> PraticheFatturate { get; set; }
        public Nullable<short> PraticheAnnullate { get; set; }
        public Nullable<short> NumTotViaggianti { get; set; }
        public Nullable<double> NumMedioViaggianti { get; set; }
        public Nullable<double> NumMedioGiorni { get; set; }
    }
}
