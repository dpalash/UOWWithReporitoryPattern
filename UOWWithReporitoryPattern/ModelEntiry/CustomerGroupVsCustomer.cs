namespace UOWWithReporitoryPattern.ModelEntiry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerGroupVsCustomer")]
    public partial class CustomerGroupVsCustomer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? CustomerGroupId { get; set; }

        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
    }
}
