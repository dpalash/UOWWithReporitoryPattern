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
    
    public partial class EncVersion
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string CustomerEncVersionId { get; set; }
        public Nullable<int> EncId { get; set; }
        public string Discriminator { get; set; }
    
        public virtual CustomerEncVersion CustomerEncVersion { get; set; }
        public virtual EncCell EncCell { get; set; }
    }
}
