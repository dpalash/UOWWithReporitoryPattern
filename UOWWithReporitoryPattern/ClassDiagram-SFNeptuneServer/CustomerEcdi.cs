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
    
    public partial class CustomerEcdi
    {
        public int Id { get; set; }
        public string UserPermit { get; set; }
        public int EcdisTypeId { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime ChangedAt { get; set; }
        public int PermitVersion { get; set; }
        public string Discriminator { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual EcdisType EcdisType { get; set; }
    }
}
