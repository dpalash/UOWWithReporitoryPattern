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
    
    public partial class PreorderedPublicationInformation
    {
        public long Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string ProductId { get; set; }
        public string Discriminator { get; set; }
    
        public virtual customer customer { get; set; }
    }
}