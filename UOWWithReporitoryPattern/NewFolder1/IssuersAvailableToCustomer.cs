namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IssuersAvailableToCustomer")]
    public partial class IssuersAvailableToCustomer
    {
        public int? IssuerId { get; set; }

        public int? CustomerGroupId { get; set; }

        public int Id { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual issuer issuer { get; set; }
    }
}
