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
    
    public partial class poseidon_user
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string displayname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<short> displaytype { get; set; }
        public Nullable<bool> superuser { get; set; }
        public Nullable<int> groupid { get; set; }
        public string Discriminator { get; set; }
    }
}
