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
    
    public partial class EncCellReplacement
    {
        public int OriginalCellId { get; set; }
        public int ReplacementCellId { get; set; }
        public Nullable<System.DateTime> ReplacedDate { get; set; }
        public string Discriminator { get; set; }
    
        public virtual EncCell EncCell { get; set; }
        public virtual EncCell EncCell1 { get; set; }
    }
}