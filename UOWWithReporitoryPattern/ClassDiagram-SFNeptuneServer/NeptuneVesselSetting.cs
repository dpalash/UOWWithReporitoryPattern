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
    
    public partial class NeptuneVesselSetting
    {
        public long Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> CustomerGroupId { get; set; }
        public string SettingsXml { get; set; }
        public string Discriminator { get; set; }
    }
}
