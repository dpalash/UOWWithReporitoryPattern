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
    
    public partial class Neptune_Logons
    {
        public long id { get; set; }
        public System.DateTime date { get; set; }
        public string ip { get; set; }
        public string customer { get; set; }
        public string parameters { get; set; }
        public string Discriminator { get; set; }
    }
}