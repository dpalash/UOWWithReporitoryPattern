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
    
    public partial class VesselPositionsHistory2013
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Data { get; set; }
        public System.DateTime TimestampUtc { get; set; }
        public bool IsWithinCoverage { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int ProviderId { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> LastConfirmedUtc { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> VesselPositionStatusId { get; set; }
        public string Discriminator { get; set; }
    }
}
