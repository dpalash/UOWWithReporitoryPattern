//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UOWWithReporitoryPattern.ClassDiagram_SFNeptuneServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CancelledNotice
    {
        public long C_Id { get; set; }
        public int C_NMNumber { get; set; }
        public int C_Year { get; set; }
        public int C_GeographicalArea { get; set; }
        public string C_ChartNumber { get; set; }
        public int C_IssuerID { get; set; }
        public Nullable<long> C_NTMId { get; set; }
        public int C_CancelledYear { get; set; }
        public int C_CancelledWeek { get; set; }
        public System.DateTime C_Added { get; set; }
        public string Discriminator { get; set; }
    }
}
