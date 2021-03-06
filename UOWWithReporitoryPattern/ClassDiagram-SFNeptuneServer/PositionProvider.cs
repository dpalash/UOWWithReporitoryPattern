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
    
    public partial class PositionProvider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PositionProvider()
        {
            this.CustomersPositionProviders = new HashSet<CustomersPositionProvider>();
            this.VesselPositions_Dummy = new HashSet<VesselPositions_Dummy>();
            this.VesselPositions = new HashSet<VesselPosition>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> NormalPollInterval { get; set; }
        public Nullable<int> ActivePollInterval { get; set; }
        public Nullable<int> HighPollInterval { get; set; }
        public string Discriminator { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersPositionProvider> CustomersPositionProviders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselPositions_Dummy> VesselPositions_Dummy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselPosition> VesselPositions { get; set; }
    }
}
