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
    
    public partial class NaviLogPublicationDocumentDetail
    {
        public long PublicationDocumentId { get; set; }
        public int SectionId { get; set; }
        public string Discriminator { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string TemplateName { get; set; }
        public string Name { get; set; }
    
        public virtual PublicationDocument PublicationDocument { get; set; }
    }
}
