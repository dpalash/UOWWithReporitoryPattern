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
    
    public partial class OrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderHeader()
        {
            this.OrderLines = new HashSet<OrderLine>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime UtcCreatedAt { get; set; }
        public string CustomerServiceTicketId { get; set; }
        public string OrderedByEmail { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceRef { get; set; }
        public string InvoiceComment { get; set; }
        public string InvoiceBy { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public byte OrderStatusId { get; set; }
        public string Discriminator { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual OrderStatu OrderStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
