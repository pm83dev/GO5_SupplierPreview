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
    
    public partial class TasseSoggiornoRighe
    {
        public short TassaSoggiornoID { get; set; }
        public short RigaID { get; set; }
        public string ClasseHotel { get; set; }
        public Nullable<double> CameraDa { get; set; }
        public Nullable<double> CameraA { get; set; }
        public Nullable<double> Imposta { get; set; }
        public string Per { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public Nullable<short> MaxNotti { get; set; }
    
        public virtual TasseSoggiorno TasseSoggiorno { get; set; }
    }
}
