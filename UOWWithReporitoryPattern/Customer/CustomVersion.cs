namespace UOWWithReporitoryPattern.Customer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomVersion
    {
        public int CustomVersionID { get; set; }

        public int CustomerID { get; set; }

        public int Version { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
