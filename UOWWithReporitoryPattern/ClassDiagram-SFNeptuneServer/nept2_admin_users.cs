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
    
    public partial class nept2_admin_users
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string displayname { get; set; }
        public string email { get; set; }
        public byte admin { get; set; }
        public Nullable<System.DateTime> lastlogin { get; set; }
        public string Discriminator { get; set; }
    }
}
