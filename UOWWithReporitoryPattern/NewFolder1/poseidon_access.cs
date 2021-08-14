namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poseidon_access
    {
        public int id { get; set; }

        public int? groupid { get; set; }

        public int? customerid { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
