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
    
    public partial class RequiredEncsForSharedRoute
    {
        public int Id { get; set; }
        public Nullable<int> EncCellId { get; set; }
        public int SharedRouteFileInfoId { get; set; }
        public string EncCellName { get; set; }
        public Nullable<System.DateTime> ChangedDate { get; set; }
        public Nullable<int> ClientsDownloadedIhoBaseEdition { get; set; }
        public Nullable<int> ClientsDownloadedIhoUpdateNumber { get; set; }
        public Nullable<System.DateTime> ClientsDownloadedIhoUtcDate { get; set; }
        public Nullable<bool> IsEncCellMissingInClient { get; set; }
        public Nullable<bool> IsEncCellOutDatedInClient { get; set; }
        public string Discriminator { get; set; }
    
        public virtual EncCell EncCell { get; set; }
        public virtual SharedRouteFileInfo SharedRouteFileInfo { get; set; }
    }
}
