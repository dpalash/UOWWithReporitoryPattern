namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomersPositionProvider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomersPositionProvider()
        {
            CustomersInmarsatProviders = new HashSet<CustomersInmarsatProvider>();
        }

        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int ProviderId { get; set; }

        public DateTime? LastReceivedUtc { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersInmarsatProvider> CustomersInmarsatProviders { get; set; }

        public virtual PositionProvider PositionProvider { get; set; }
    }
}
