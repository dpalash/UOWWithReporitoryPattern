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
    
    public partial class EcdisType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EcdisType()
        {
            this.CustomerEcdis = new HashSet<CustomerEcdi>();
            this.CustomerPermitsExtraLines = new HashSet<CustomerPermitsExtraLine>();
            this.CustomerPermitsPriorToPays = new HashSet<CustomerPermitsPriorToPay>();
            this.EncCellCustomerPermits = new HashSet<EncCellCustomerPermit>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discriminator { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEcdi> CustomerEcdis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPermitsExtraLine> CustomerPermitsExtraLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPermitsPriorToPay> CustomerPermitsPriorToPays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellCustomerPermit> EncCellCustomerPermits { get; set; }
    }
}
