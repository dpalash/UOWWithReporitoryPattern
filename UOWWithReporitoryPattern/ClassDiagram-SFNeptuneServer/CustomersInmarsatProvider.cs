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
    
    public partial class CustomersInmarsatProvider
    {
        public int Id { get; set; }
        public int CustPosProvId { get; set; }
        public short Region { get; set; }
        public string DNID { get; set; }
        public string MemberNumber { get; set; }
        public string TerminalId { get; set; }
        public int PollInterval { get; set; }
        public bool IsActivated { get; set; }
        public bool IsProgramming { get; set; }
        public System.DateTime LastModifiedUtc { get; set; }
        public string Discriminator { get; set; }
    
        public virtual CustomersPositionProvider CustomersPositionProvider { get; set; }
    }
}
