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
    
    public partial class CaratteristicheCliente
    {
        public int ClienteID { get; set; }
        public Nullable<short> NumeroBus { get; set; }
        public bool IsTargetLusso { get; set; }
        public bool IsTargetAlto { get; set; }
        public bool IsTargetMedioAlto { get; set; }
        public bool IsTargetMedio { get; set; }
        public bool IsTargetMedioBasso { get; set; }
        public Nullable<short> NumGiorniScadPreArrivoGruppo { get; set; }
        public Nullable<short> NumGiorniScadPostArrivoGruppo { get; set; }
        public Nullable<short> NumGiorniProgrammaPreArrivoGruppo { get; set; }
        public Nullable<short> NumGiorniVoucherPreArrivoGruppo { get; set; }
        public Nullable<short> NumGiorniScadenzaReleaseCliente { get; set; }
        public Nullable<short> NumGiorniScadenzaOpzioneCliente { get; set; }
        public string HaLavoratoCon { get; set; }
        public Nullable<int> AnnoAvvioAttivita { get; set; }
    
        public virtual Clienti Clienti { get; set; }
    }
}
