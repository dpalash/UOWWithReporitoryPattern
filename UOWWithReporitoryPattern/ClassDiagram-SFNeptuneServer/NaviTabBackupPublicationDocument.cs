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
    
    public partial class NaviTabBackupPublicationDocument
    {
        public int Id { get; set; }
        public int CustomerInfoId { get; set; }
        public int BackupId { get; set; }
        public string NauProdId { get; set; }
        public string ProdId { get; set; }
        public Nullable<int> PublicationId { get; set; }
        public Nullable<int> MaxPrintCount { get; set; }
        public Nullable<int> MaxPercentagePrintAllowed { get; set; }
        public string FileName { get; set; }
        public Nullable<int> ParentDocId { get; set; }
        public Nullable<System.DateTime> PublicationDownloadDate { get; set; }
        public string Discriminator { get; set; }
    
        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
