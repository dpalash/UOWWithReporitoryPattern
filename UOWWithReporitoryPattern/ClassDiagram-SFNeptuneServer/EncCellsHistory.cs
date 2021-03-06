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
    
    public partial class EncCellsHistory
    {
        public int Id { get; set; }
        public System.DateTime UtcAuditDate { get; set; }
        public int IssuerId { get; set; }
        public string CellName { get; set; }
        public string Description { get; set; }
        public byte NavigationalPurpose { get; set; }
        public decimal BoundarySLat { get; set; }
        public decimal BoundaryWLon { get; set; }
        public decimal BoundaryNLat { get; set; }
        public decimal BoundaryELon { get; set; }
        public string PolygonPoints { get; set; }
        public short BaseEdition { get; set; }
        public System.DateTime BaseIssueDate { get; set; }
        public Nullable<short> LatestUpdateNumber { get; set; }
        public Nullable<System.DateTime> RecordLastUpdated { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public string GeometryData { get; set; }
        public Nullable<System.DateTime> ReleaseDateUtc { get; set; }
        public Nullable<System.DateTime> CancelDateUtc { get; set; }
        public Nullable<System.DateTime> ReplaceDateUtc { get; set; }
        public System.Data.Entity.Spatial.DbGeography Geography { get; set; }
        public Nullable<int> DownloadedBaseEdition { get; set; }
        public Nullable<int> DownloadedUpdateNumber { get; set; }
        public Nullable<System.DateTime> DownloadedUtcDate { get; set; }
        public string Discriminator { get; set; }
    }
}
