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
    
    public partial class FattureClienti
    {
        public string ClienteAdHocID { get; set; }
        public string FatturaAdhocID { get; set; }
        public short RigaFattura { get; set; }
        public int AnnoPratica { get; set; }
        public int NumPratica { get; set; }
        public string NomeClienteAdHoc { get; set; }
        public int ClienteID { get; set; }
        public System.DateTime DataFattura { get; set; }
        public double Importo { get; set; }
        public string PercorsoFile { get; set; }
        public string NumFattura { get; set; }
        public System.DateTime DataUltimaModifica { get; set; }
        public string Note { get; set; }
        public Nullable<short> Stato { get; set; }
    
        public virtual Clienti Clienti { get; set; }
        public virtual Pratiche Pratiche { get; set; }
    }
}
